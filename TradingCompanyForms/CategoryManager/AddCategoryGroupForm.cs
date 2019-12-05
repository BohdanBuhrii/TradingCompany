using BLL;
using BLL.Services.Interfaces;
using DTO;
using System;
using System.Windows.Forms;

namespace TradingCompanyForms.CategoryManager
{
    public partial class AddCategoryGroupForm : Form
    {
        private readonly ICategoryService _categoryService;

        public AddCategoryGroupForm()
        {
            _categoryService = DependencyInjectorBLL.Resolve<ICategoryService>();

            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveBtn.Enabled = false;

            _categoryService.AddCategoryGroup(new CategoryGroupDTO {
                Name = NameTB.Text,
                IsActive = IsActiveCB.Checked
            });

            this.Close();
        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            if (_categoryService.CategoryGroupExist(NameTB.Text))
            {
                SaveBtn.Enabled = false;
                AlertLable.Visible = true;
            }
            else
            {
                SaveBtn.Enabled = true;
                AlertLable.Visible = false;
            }
        }
    }
}
