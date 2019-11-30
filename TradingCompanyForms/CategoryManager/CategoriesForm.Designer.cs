﻿namespace TradingCompanyForms.CategoryManager
{
    partial class CategoriesForm
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
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.LoginLbl = new System.Windows.Forms.Label();
            this.AddCategoryGroupBtn = new System.Windows.Forms.Button();
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(728, 3);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(67, 28);
            this.LogOutBtn.TabIndex = 0;
            this.LogOutBtn.Text = "Log out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // LoginLbl
            // 
            this.LoginLbl.AutoSize = true;
            this.LoginLbl.Location = new System.Drawing.Point(663, 10);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(37, 15);
            this.LoginLbl.TabIndex = 1;
            this.LoginLbl.Text = "Login";
            // 
            // AddCategoryGroupBtn
            // 
            this.AddCategoryGroupBtn.Location = new System.Drawing.Point(15, 89);
            this.AddCategoryGroupBtn.Name = "AddCategoryGroupBtn";
            this.AddCategoryGroupBtn.Size = new System.Drawing.Size(128, 30);
            this.AddCategoryGroupBtn.TabIndex = 2;
            this.AddCategoryGroupBtn.Text = "Add category group";
            this.AddCategoryGroupBtn.UseVisualStyleBackColor = true;
            this.AddCategoryGroupBtn.Click += new System.EventHandler(this.AddCategoryGroupBtn_Click);
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddCategoryGroupBtn);
            this.Controls.Add(this.LoginLbl);
            this.Controls.Add(this.LogOutBtn);
            this.Name = "CategoriesForm";
            this.Text = "CategoriesForm";
            InitializeNotGeneratedComponents();
        }
        #endregion


        private void InitializeNotGeneratedComponents()
        {
            System.Windows.Forms.DataGridViewCellStyle FirstCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle SecondCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle ThirdCellStyle = new System.Windows.Forms.DataGridViewCellStyle();


            this.CategoriesGV = new System.Windows.Forms.DataGridView();
            this.CNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIsActiveColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();

            this.GroupsGV = new System.Windows.Forms.DataGridView();
            this.GNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIsActiveColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            //
            // Styles
            //
            FirstCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            SecondCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            SecondCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            SecondCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            SecondCellStyle.ForeColor = System.Drawing.Color.White;
            SecondCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            SecondCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            SecondCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            ThirdCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            ThirdCellStyle.BackColor = System.Drawing.SystemColors.Window;
            ThirdCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ThirdCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            ThirdCellStyle.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            ThirdCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            ThirdCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CategoriesGV
            // 
            this.CategoriesGV.AllowUserToOrderColumns = true;
            this.CategoriesGV.AlternatingRowsDefaultCellStyle = FirstCellStyle;
            this.CategoriesGV.BackgroundColor = System.Drawing.Color.White;
            this.CategoriesGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoriesGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoriesGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CategoriesGV.ColumnHeadersDefaultCellStyle = SecondCellStyle;
            this.CategoriesGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNameColumn,
            this.CIsActiveColumn});
            this.CategoriesGV.DefaultCellStyle = ThirdCellStyle;
            this.CategoriesGV.EnableHeadersVisualStyles = false;
            this.CategoriesGV.Location = new System.Drawing.Point(414, 12);
            this.CategoriesGV.Name = "CategoriesGV";
            this.CategoriesGV.Size = new System.Drawing.Size(187, 389);
            this.CategoriesGV.TabIndex = 2;
            //this.CategoriesGV.SelectionChanged += new System.EventHandler(this.GroupsGV_SelectionChanged);
            // 
            // CNameColumn
            // 
            this.CNameColumn.DataPropertyName = "Name";
            this.CNameColumn.HeaderText = "Name";
            this.CNameColumn.MaxInputLength = 50;
            this.CNameColumn.Name = "NameColumn";
            this.CNameColumn.ReadOnly = true;
            // 
            // CIsActiveColumn
            // 
            this.CIsActiveColumn.DataPropertyName = "IsActive";
            this.CIsActiveColumn.HeaderText = "Active";
            this.CIsActiveColumn.Name = "IsActiveColumn";
            this.CIsActiveColumn.ReadOnly = true;
            this.CIsActiveColumn.Width = 45;
            // 
            // GroupsGV
            // 
            this.GroupsGV.AllowUserToOrderColumns = true;
            this.GroupsGV.AlternatingRowsDefaultCellStyle = FirstCellStyle;
            this.GroupsGV.BackgroundColor = System.Drawing.Color.White;
            this.GroupsGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GroupsGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GroupsGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GroupsGV.ColumnHeadersDefaultCellStyle = SecondCellStyle;
            this.GroupsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GNameColumn,
            this.GIsActiveColumn});
            this.GroupsGV.DefaultCellStyle = ThirdCellStyle;
            this.GroupsGV.EnableHeadersVisualStyles = false;
            this.GroupsGV.Location = new System.Drawing.Point(212, 12);
            this.GroupsGV.Name = "GroupsGV";
            this.GroupsGV.Size = new System.Drawing.Size(187, 389);
            this.GroupsGV.TabIndex = 3;
            this.GroupsGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupsGV_CellClick);

            // 
            // CNameColumn
            // 
            this.GNameColumn.DataPropertyName = "Name";
            this.GNameColumn.HeaderText = "Name";
            this.GNameColumn.MaxInputLength = 50;
            this.GNameColumn.Name = "NameColumn";
            this.GNameColumn.ReadOnly = true;
            // 
            // CIsActiveColumn
            // 
            this.GIsActiveColumn.DataPropertyName = "IsActive";
            this.GIsActiveColumn.HeaderText = "Active";
            this.GIsActiveColumn.Name = "IsActiveColumn";
            this.GIsActiveColumn.ReadOnly = true;
            this.GIsActiveColumn.Width = 45;


            this.Controls.Add(this.CategoriesGV);
            this.Controls.Add(this.GroupsGV);
        }

        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Label LoginLbl;
        private System.Windows.Forms.DataGridView CategoriesGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNameColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CIsActiveColumn;
        private System.Windows.Forms.DataGridView GroupsGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GNameColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GIsActiveColumn;
        private System.Windows.Forms.Button AddCategoryGroupBtn;
    }
}