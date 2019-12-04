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

        public CategoriesForm(UserDTO user)
        {
            _user = user;
            _categoryService = DependencyInjectorBLL.Resolve<ICategoryService>();

            InitializeComponent();

            this.GroupsGV.DataSource = _categoryService.GetAllCategoryGroups();
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

        private void AddCategoryGroupBtn_Click(object sender, System.EventArgs e)
        {
            var form = new AddCategoryGroupForm();
            form.FormClosing += new FormClosingEventHandler(this.UpdateData);
            
            form.Show();
        }

        public void UpdateData(object sender, FormClosingEventArgs e) 
        {
            this.GroupsGV.DataSource = _categoryService.GetAllCategoryGroups();
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
    }
}
