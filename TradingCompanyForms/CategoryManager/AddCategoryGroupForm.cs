using BLL;
using DAL.Models;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingCompanyForms.CategoryManager
{
    public partial class AddCategoryGroupForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddCategoryGroupForm()
        {
            _unitOfWork = DependencyInjectorBLL.Resolve<IUnitOfWork>();

            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveBtn.Enabled = false;

            _unitOfWork.CategoryGroupRepository.Add(new CategoryGroup {
                Name = NameTB.Text,
                IsActive = IsActiveCB.Checked
            });

            _unitOfWork.SaveChanges();

            this.Close();
        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            if (_unitOfWork.CategoryGroupRepository.Get(g => g.Name == NameTB.Text).Count() > 0)
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
