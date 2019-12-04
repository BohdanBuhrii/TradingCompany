using BLL;
using BLL.Services.Interfaces;
using DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace TradingCompanyForms.CategoryManager
{
    public partial class AddCategoryForm : Form
    {
        private readonly ICategoryService _categoryService;

        public AddCategoryForm()
        {
            _categoryService = DependencyInjectorBLL.Resolve<ICategoryService>();
            
            InitializeComponent();

            GroupCB.Items.AddRange(
                _categoryService.GetAllCategoryGroups()
                .Select(g => g.Name).ToArray()
            );
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveBtn.Enabled = false;

            _categoryService.AddCategory(new CategoryDTO
            {
                Name = NameTB.Text,
                IsActive = IsActiveCB.Checked,
                CategoryGroup = _categoryService.GetGroupByName(GroupCB.SelectedItem.ToString())
            });


            this.Close();
        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            if (_categoryService.CategoryExist(NameTB.Text))
            {
                SaveBtn.Enabled = false;
                AlertLable.Visible = true;
            }
            else
            {
                if (GroupCB.SelectedItem?.ToString().Length > 0)
                {
                    SaveBtn.Enabled = true;
                }

                AlertLable.Visible = false;
            }
        }

        private void GroupCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NameTB.Text.Length > 0)
            { 
                SaveBtn.Enabled = true;
            }
        }
    }
}

