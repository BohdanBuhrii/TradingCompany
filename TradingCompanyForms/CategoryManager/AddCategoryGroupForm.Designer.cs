namespace TradingCompanyForms.CategoryManager
{
    partial class AddCategoryGroupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AlertLable = new System.Windows.Forms.Label();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Enabled = false;
            this.SaveBtn.Location = new System.Drawing.Point(155, 119);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(101, 30);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(26, 120);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(101, 29);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(26, 36);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(129, 23);
            this.NameTB.TabIndex = 2;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // IsActiveCB
            // 
            this.IsActiveCB.AutoSize = true;
            this.IsActiveCB.Location = new System.Drawing.Point(207, 40);
            this.IsActiveCB.Name = "IsActiveCB";
            this.IsActiveCB.Size = new System.Drawing.Size(15, 14);
            this.IsActiveCB.TabIndex = 3;
            this.IsActiveCB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Active";
            // 
            // AlertLable
            // 
            this.AlertLable.AutoSize = true;
            this.AlertLable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AlertLable.ForeColor = System.Drawing.Color.Red;
            this.AlertLable.Location = new System.Drawing.Point(26, 62);
            this.AlertLable.Name = "AlertLable";
            this.AlertLable.Size = new System.Drawing.Size(209, 15);
            this.AlertLable.TabIndex = 5;
            this.AlertLable.Text = "Group with this name already exists!";
            this.AlertLable.Visible = false;
            // 
            // AddCategoryGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 162);
            this.Controls.Add(this.AlertLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsActiveCB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "AddCategoryGroupForm";
            this.Text = "Creating new category group";

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.CheckBox IsActiveCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AlertLable;
    }
}