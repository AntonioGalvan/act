﻿namespace act.Forms.Business_Rules.Index
{
    partial class RuleIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuleIndex));
            dataGridView1 = new DataGridView();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnNew = new Button();
            txtSearch = new TextBox();
            lblRules = new Label();
            pnlMenu = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(401, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1027, 868);
            dataGridView1.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_add_24;
            pictureBox2.Location = new Point(1404, 87);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(634, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 26);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("HoloLens MDL2 Assets", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.Location = new Point(1296, 79);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(102, 38);
            btnNew.TabIndex = 10;
            btnNew.Text = "Nuevo";
            btnNew.TextAlign = ContentAlignment.TopCenter;
            btnNew.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(401, 84);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Buscar";
            txtSearch.Size = new Size(227, 27);
            txtSearch.TabIndex = 9;
            // 
            // lblRules
            // 
            lblRules.Font = new Font("HoloLens MDL2 Assets", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblRules.Location = new Point(367, 0);
            lblRules.Name = "lblRules";
            lblRules.Size = new Size(455, 81);
            lblRules.TabIndex = 8;
            lblRules.Text = "Reglas de negocio";
            lblRules.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlMenu
            // 
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(348, 1024);
            pnlMenu.TabIndex = 7;
            // 
            // RuleIndex
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 1024);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnNew);
            Controls.Add(txtSearch);
            Controls.Add(lblRules);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RuleIndex";
            Text = "RuleIndex";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnNew;
        private TextBox txtSearch;
        private Label lblRules;
        private Panel pnlMenu;
    }
}