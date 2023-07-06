namespace act.Forms.Roles
{
    partial class RoleView
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
            lblRoles = new Label();
            tbcRoles = new TabControl();
            tbpList = new TabPage();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSearch = new Button();
            lblSearch = new Label();
            dgvRoles = new DataGridView();
            btnAdd = new Button();
            tbxSearch = new TextBox();
            tbpAdd = new TabPage();
            tbxKey = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            tbxPurpose = new TextBox();
            tbxName = new TextBox();
            tbxId = new TextBox();
            lblDesc = new Label();
            lblType = new Label();
            lblName = new Label();
            lblId = new Label();
            btnOut = new Button();
            tbcRoles.SuspendLayout();
            tbpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            tbpAdd.SuspendLayout();
            SuspendLayout();
            // 
            // lblRoles
            // 
            lblRoles.Font = new Font("HoloLens MDL2 Assets", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoles.Location = new Point(6, 3);
            lblRoles.Name = "lblRoles";
            lblRoles.Size = new Size(197, 64);
            lblRoles.TabIndex = 1;
            lblRoles.Text = "Roles";
            lblRoles.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbcRoles
            // 
            tbcRoles.Controls.Add(tbpList);
            tbcRoles.Controls.Add(tbpAdd);
            tbcRoles.Location = new Point(6, 79);
            tbcRoles.Name = "tbcRoles";
            tbcRoles.SelectedIndex = 0;
            tbcRoles.Size = new Size(1061, 773);
            tbcRoles.TabIndex = 7;
            // 
            // tbpList
            // 
            tbpList.Controls.Add(btnDelete);
            tbpList.Controls.Add(btnEdit);
            tbpList.Controls.Add(btnSearch);
            tbpList.Controls.Add(lblSearch);
            tbpList.Controls.Add(dgvRoles);
            tbpList.Controls.Add(btnAdd);
            tbpList.Controls.Add(tbxSearch);
            tbpList.Location = new Point(4, 29);
            tbpList.Name = "tbpList";
            tbpList.Padding = new Padding(3);
            tbpList.Size = new Size(1053, 740);
            tbpList.TabIndex = 0;
            tbpList.Text = "Listado";
            tbpList.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("HoloLens MDL2 Assets", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(944, 151);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 38);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Eliminar";
            btnDelete.TextAlign = ContentAlignment.TopCenter;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("HoloLens MDL2 Assets", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(944, 107);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(102, 38);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Editar";
            btnEdit.TextAlign = ContentAlignment.TopCenter;
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(249, 27);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(16, 7);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 20);
            lblSearch.TabIndex = 11;
            lblSearch.Text = "Search";
            // 
            // dgvRoles
            // 
            dgvRoles.AllowUserToAddRows = false;
            dgvRoles.AllowUserToDeleteRows = false;
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Location = new Point(16, 63);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.RowHeadersWidth = 51;
            dgvRoles.RowTemplate.Height = 29;
            dgvRoles.Size = new Size(922, 670);
            dgvRoles.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("HoloLens MDL2 Assets", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(944, 63);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 38);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Agregar";
            btnAdd.TextAlign = ContentAlignment.TopCenter;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // tbxSearch
            // 
            tbxSearch.Location = new Point(16, 30);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.PlaceholderText = "Buscar";
            tbxSearch.Size = new Size(227, 27);
            tbxSearch.TabIndex = 7;
            // 
            // tbpAdd
            // 
            tbpAdd.Controls.Add(tbxKey);
            tbpAdd.Controls.Add(btnCancel);
            tbpAdd.Controls.Add(btnSave);
            tbpAdd.Controls.Add(tbxPurpose);
            tbpAdd.Controls.Add(tbxName);
            tbpAdd.Controls.Add(tbxId);
            tbpAdd.Controls.Add(lblDesc);
            tbpAdd.Controls.Add(lblType);
            tbpAdd.Controls.Add(lblName);
            tbpAdd.Controls.Add(lblId);
            tbpAdd.Location = new Point(4, 29);
            tbpAdd.Name = "tbpAdd";
            tbpAdd.Padding = new Padding(3);
            tbpAdd.Size = new Size(1053, 740);
            tbpAdd.TabIndex = 1;
            tbpAdd.Text = "Agregar";
            tbpAdd.UseVisualStyleBackColor = true;
            // 
            // tbxKey
            // 
            tbxKey.Location = new Point(13, 107);
            tbxKey.Name = "tbxKey";
            tbxKey.Size = new Size(90, 27);
            tbxKey.TabIndex = 19;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(144, 254);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 29);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(13, 254);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 29);
            btnSave.TabIndex = 17;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // tbxPurpose
            // 
            tbxPurpose.Location = new Point(13, 180);
            tbxPurpose.Name = "tbxPurpose";
            tbxPurpose.Size = new Size(256, 27);
            tbxPurpose.TabIndex = 16;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(16, 44);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(256, 27);
            tbxName.TabIndex = 13;
            // 
            // tbxId
            // 
            tbxId.Location = new Point(654, 36);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(125, 27);
            tbxId.TabIndex = 11;
            tbxId.Visible = false;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(16, 157);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(73, 20);
            lblDesc.TabIndex = 15;
            lblDesc.Text = "Propósito";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(16, 84);
            lblType.Name = "lblType";
            lblType.Size = new Size(45, 20);
            lblType.TabIndex = 14;
            lblType.Text = "Clave";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(16, 21);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 20);
            lblName.TabIndex = 12;
            lblName.Text = "Nombre";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(657, 16);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 10;
            lblId.Text = "Id";
            lblId.Visible = false;
            // 
            // btnOut
            // 
            btnOut.Font = new Font("HoloLens MDL2 Assets", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnOut.Location = new Point(954, 12);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(102, 38);
            btnOut.TabIndex = 9;
            btnOut.Text = "Cerrar";
            btnOut.TextAlign = ContentAlignment.TopCenter;
            btnOut.UseVisualStyleBackColor = true;
            // 
            // RoleView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1068, 853);
            Controls.Add(btnOut);
            Controls.Add(tbcRoles);
            Controls.Add(lblRoles);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RoleView";
            Text = "RoleIndex";
            tbcRoles.ResumeLayout(false);
            tbpList.ResumeLayout(false);
            tbpList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            tbpAdd.ResumeLayout(false);
            tbpAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblRoles;
        private TabControl tbcRoles;
        private TabPage tbpList;
        private DataGridView dgvRoles;
        private Button btnAdd;
        private TextBox tbxSearch;
        private TabPage tbpAdd;
        private Label lblSearch;
        private Button btnSearch;
        private Button btnEdit;
        private Button btnCancel;
        private Button btnSave;
        private TextBox tbxPurpose;
        private TextBox tbxName;
        private TextBox tbxId;
        private Label lblDesc;
        private Label lblType;
        private Label lblName;
        private Label lblId;
        private Button btnDelete;
        private TextBox tbxKey;
        private Button btnOut;
    }
}