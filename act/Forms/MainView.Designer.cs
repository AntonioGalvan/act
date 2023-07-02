namespace act.Forms.Roles
{
    partial class MainView
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
            pnlMenu = new Panel();
            lblHome = new Label();
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
            // lblHome
            // 
            lblHome.Font = new Font("HoloLens MDL2 Assets", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblHome.Location = new Point(354, 0);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(197, 64);
            lblHome.TabIndex = 1;
            lblHome.Text = "Inicio";
            lblHome.TextAlign = ContentAlignment.TopCenter;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 1024);
            Controls.Add(lblHome);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainView";
            Text = "RoleIndex";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Label lblHome;
    }
}