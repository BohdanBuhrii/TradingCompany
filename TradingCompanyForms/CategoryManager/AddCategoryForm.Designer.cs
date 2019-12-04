namespace TradingCompanyForms.CategoryManager
{
    partial class AddCategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.IsActiveCB = new System.Windows.Forms.CheckBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.ActiveLbl = new System.Windows.Forms.Label();
            this.AlertLable = new System.Windows.Forms.Label();
            this.CategoryGroupLbl = new System.Windows.Forms.Label();
            this.GroupCB = new System.Windows.Forms.ComboBox();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Enabled = false;
            this.SaveBtn.Location = new System.Drawing.Point(157, 167);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(101, 30);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(28, 168);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(101, 29);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(28, 84);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(129, 23);
            this.NameTB.TabIndex = 2;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // IsActiveCB
            // 
            this.IsActiveCB.AutoSize = true;
            this.IsActiveCB.Location = new System.Drawing.Point(209, 88);
            this.IsActiveCB.Name = "IsActiveCB";
            this.IsActiveCB.Size = new System.Drawing.Size(15, 14);
            this.IsActiveCB.TabIndex = 3;
            this.IsActiveCB.UseVisualStyleBackColor = true;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(28, 61);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(42, 15);
            this.NameLbl.TabIndex = 4;
            this.NameLbl.Text = "Name:";
            // 
            // ActiveLbl
            // 
            this.ActiveLbl.AutoSize = true;
            this.ActiveLbl.Location = new System.Drawing.Point(196, 61);
            this.ActiveLbl.Name = "ActiveLbl";
            this.ActiveLbl.Size = new System.Drawing.Size(43, 15);
            this.ActiveLbl.TabIndex = 4;
            this.ActiveLbl.Text = "Active:";
            // 
            // AlertLable
            // 
            this.AlertLable.AutoSize = true;
            this.AlertLable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AlertLable.ForeColor = System.Drawing.Color.Red;
            this.AlertLable.Location = new System.Drawing.Point(28, 110);
            this.AlertLable.Name = "AlertLable";
            this.AlertLable.Size = new System.Drawing.Size(224, 15);
            this.AlertLable.TabIndex = 5;
            this.AlertLable.Text = "Category with this name already exists!";
            this.AlertLable.Visible = false;
            // 
            // CategoryGroupLbl
            // 
            this.CategoryGroupLbl.AutoSize = true;
            this.CategoryGroupLbl.Location = new System.Drawing.Point(28, 14);
            this.CategoryGroupLbl.Name = "CategoryGroupLbl";
            this.CategoryGroupLbl.Size = new System.Drawing.Size(93, 15);
            this.CategoryGroupLbl.TabIndex = 6;
            this.CategoryGroupLbl.Text = "Category group:";
            // 
            // GroupCB
            // 
            this.GroupCB.FormattingEnabled = true;
            this.GroupCB.Location = new System.Drawing.Point(134, 13);
            this.GroupCB.Name = "GroupCB";
            this.GroupCB.Size = new System.Drawing.Size(124, 23);
            this.GroupCB.TabIndex = 7;
            this.GroupCB.SelectedIndexChanged += new System.EventHandler(this.GroupCB_SelectedIndexChanged);
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 215);
            this.Controls.Add(this.GroupCB);
            this.Controls.Add(this.CategoryGroupLbl);
            this.Controls.Add(this.AlertLable);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.IsActiveCB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ActiveLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "AddCategoryForm";
            this.Text = "Creating new category group";

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.CheckBox IsActiveCB;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label ActiveLbl;
        private System.Windows.Forms.Label AlertLable;
        private System.Windows.Forms.Label CategoryGroupLbl;
        private System.Windows.Forms.ComboBox GroupCB;
    }
}