namespace act.Forms.Roles
{
    partial class RoleIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleIndex));
            pnlMenu = new Panel();
            lblRoles = new Label();
            txtSearch = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(348, 1024);
            pnlMenu.TabIndex = 0;
            // 
            // lblRoles
            // 
            lblRoles.Font = new Font("HoloLens MDL2 Assets", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoles.Location = new Point(354, 0);
            lblRoles.Name = "lblRoles";
            lblRoles.Size = new Size(197, 64);
            lblRoles.TabIndex = 1;
            lblRoles.Text = "Roles";
            lblRoles.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(388, 84);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Buscar";
            txtSearch.Size = new Size(227, 27);
            txtSearch.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("HoloLens MDL2 Assets", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1283, 79);
            button1.Name = "button1";
            button1.Size = new Size(102, 38);
            button1.TabIndex = 3;
            button1.Text = "Nuevo";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(621, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 26);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_add_24;
            pictureBox2.Location = new Point(1391, 87);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(388, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1027, 868);
            dataGridView1.TabIndex = 6;
            // 
            // RoleIndex
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 1024);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(txtSearch);
            Controls.Add(lblRoles);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RoleIndex";
            Text = "RoleIndex";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMenu;
        private Label lblRoles;
        private TextBox txtSearch;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
    }
}