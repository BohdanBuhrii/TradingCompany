using BLL;
using BLL.Services.Interfaces;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TradingCompanyForms.Shared;

namespace TradingCompanyForms.CategoryManager
{
    public partial class CategoriesForm : Form
    {
        private readonly UserDTO _user;
        private readonly ICategoryService _categoryService;
        private SortOrder CategoriesSortOrder = SortOrder.None;
        private SortOrder GroupsSortOrder = SortOrder.None;

        public CategoriesForm(UserDTO user)
        {
            _user = user;
            _categoryService = DependencyInjectorBLL.Resolve<ICategoryService>();

            InitializeComponent();

            this.GroupsGV.DataSource = _categoryService.GetAllCategoryGroups();
            this.CategoriesGV.DataSource = _categoryService.GetCategoriesByGroupId(
                ((IEnumerable<CategoryGroupDTO>)GroupsGV.DataSource).FirstOrDefault().Id
            );
            this.LoginLbl.Text = _user.Login;
            this.Refresh();
        }

        private void LogOutBtn_Click(object sender, System.EventArgs e)
        {
            var form = DependencyInjectorBLL.Resolve<AuthenticationForm>();
            form.Show();
            this.Dispose();
        }

        private void GroupsGV_CellClick(object sender, System.EventArgs e)
        {
            this.CategoriesGV.DataSource =
                _categoryService.GetCategoriesByGroupId(
                    (int)this.GroupsGV.CurrentRow.Cells["Id"].Value
                );
        }

        private void GroupsGV_HeaderClick(object sender, System.EventArgs e)
        {
            //var a = this.GroupsGV.CurrentCellAddress;
            /*this.GroupsGV.Sort(GroupsGV.Columns["Name"],
                GroupsGV.SortOrder == SortOrder.Ascending ?
                    ListSortDirection.Descending : ListSortDirection.Ascending);*/
            if (GroupsSortOrder == SortOrder.Ascending)
            {
                this.GroupsGV.DataSource = 
                    ((IList<CategoryGroupDTO>)this.GroupsGV.DataSource)
                        .OrderByDescending(x => x.Name).ToList();
                GroupsSortOrder = SortOrder.Descending;
            }
            else
            {
                this.GroupsGV.DataSource = 
                    ((IList<CategoryGroupDTO>)this.GroupsGV.DataSource)
                        .OrderBy(x => x.Name).ToList();
                GroupsSortOrder = SortOrder.Ascending;
            }
            this.Refresh();
        }

        private void CategoriesGV_HeaderClick(object sender, System.EventArgs e)
        {
            if (CategoriesSortOrder == SortOrder.Ascending)
            {
                this.CategoriesGV.DataSource =
                    ((IList<CategoryGroupDTO>)this.CategoriesGV.DataSource)
                        .OrderByDescending(x => x.Name).ToList();
                CategoriesSortOrder = SortOrder.Descending;
            }
            else
            {
                this.CategoriesGV.DataSource =
                    ((IList<CategoryGroupDTO>)this.CategoriesGV.DataSource)
                        .OrderBy(x => x.Name).ToList();
                CategoriesSortOrder = SortOrder.Ascending;
            }
            this.Refresh();
        }

        private void CategoriesGV_DataChanged(object sender, System.EventArgs e)
        {
            if (!((IEnumerable<CategoryDTO>)CategoriesGV.DataSource).Any())
            {
                this.NoCategoriesLbl.Visible = true;
            }
            else 
            {
                this.NoCategoriesLbl.Visible = false;
            }
        }

        private void AddCategoryGroupBtn_Click(object sender, System.EventArgs e)
        {
            var form = new AddCategoryGroupForm();
            form.FormClosing += new FormClosingEventHandler(this.UpdateData);
            
            form.Show();
        }

        public void UpdateData(object sender, FormClosingEventArgs e) 
        {
            this.GroupsGV.DataSource = _categoryService.GetAllCategoryGroups();
            this.CategoriesGV.DataSource = _categoryService.GetCategoriesByGroupId(
                    (int)this.GroupsGV.CurrentRow.Cells["Id"].Value
            );

            this.Refresh();
        }

        private void AddCategoryBtn_Click(object sender, System.EventArgs e)
        {
            var form = new AddCategoryForm();
            form.FormClosing += new FormClosingEventHandler(this.UpdateData);

            form.Show();
        }

        private void SaveChangesBtn_Click(object sender, System.EventArgs e)
        {
            _categoryService.UpdateCategories(
                (IEnumerable<CategoryDTO>)this.CategoriesGV.DataSource);
            _categoryService.UpdateCategoryGroups(
                (IEnumerable<CategoryGroupDTO>)this.GroupsGV.DataSource);
        }

        private void GroupSearchTB_TextChanged(object sender, System.EventArgs e)
        {
            var buff = _categoryService.FilterGroups(GroupSearchTB.Text).ToList();
            GroupsGV.DataSource = buff;
            Refresh();
        }
    }
}
