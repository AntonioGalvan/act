namespace act.Forms.Business_Rules.Index
{
    partial class RuleView
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
            btnOut = new Button();
            tbpList = new TabPage();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSearch = new Button();
            lblSearch = new Label();
            dgvRules = new DataGridView();
            btnAdd = new Button();
            tbxSearch = new TextBox();
            tbxKey = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            tbxDescription = new TextBox();
            tbxId = new TextBox();
            lblDesc = new Label();
            lblType = new Label();
            tbpAdd = new TabPage();
            lblId = new Label();
            tbcRules = new TabControl();
            lblRules = new Label();
            tbpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRules).BeginInit();
            tbpAdd.SuspendLayout();
            tbcRules.SuspendLayout();
            SuspendLayout();
            // 
            // btnOut
            // 
            btnOut.Font = new Font("HoloLens MDL2 Assets", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnOut.Location = new Point(952, 11);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(102, 38);
            btnOut.TabIndex = 12;
            btnOut.Text = "Cerrar";
            btnOut.TextAlign = ContentAlignment.TopCenter;
            btnOut.UseVisualStyleBackColor = true;
            // 
            // tbpList
            // 
            tbpList.Controls.Add(btnDelete);
            tbpList.Controls.Add(btnEdit);
            tbpList.Controls.Add(btnSearch);
            tbpList.Controls.Add(lblSearch);
            tbpList.Controls.Add(dgvRules);
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
            lblSearch.Location = new Point(19, 10);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 20);
            lblSearch.TabIndex = 11;
            lblSearch.Text = "Search";
            // 
            // dgvRules
            // 
            dgvRules.AllowUserToAddRows = false;
            dgvRules.AllowUserToDeleteRows = false;
            dgvRules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRules.Location = new Point(16, 63);
            dgvRules.Name = "dgvRules";
            dgvRules.RowHeadersWidth = 51;
            dgvRules.RowTemplate.Height = 29;
            dgvRules.Size = new Size(922, 670);
            dgvRules.TabIndex = 10;
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
            // tbxKey
            // 
            tbxKey.Location = new Point(9, 39);
            tbxKey.Name = "tbxKey";
            tbxKey.Size = new Size(90, 27);
            tbxKey.TabIndex = 14;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(140, 186);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 29);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(9, 186);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 29);
            btnSave.TabIndex = 17;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // tbxDescription
            // 
            tbxDescription.Location = new Point(9, 112);
            tbxDescription.Name = "tbxDescription";
            tbxDescription.Size = new Size(256, 27);
            tbxDescription.TabIndex = 15;
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
            lblDesc.Location = new Point(15, 92);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(87, 20);
            lblDesc.TabIndex = 15;
            lblDesc.Text = "Descripción";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(15, 19);
            lblType.Name = "lblType";
            lblType.Size = new Size(45, 20);
            lblType.TabIndex = 14;
            lblType.Text = "Clave";
            // 
            // tbpAdd
            // 
            tbpAdd.Controls.Add(tbxKey);
            tbpAdd.Controls.Add(btnCancel);
            tbpAdd.Controls.Add(btnSave);
            tbpAdd.Controls.Add(tbxDescription);
            tbpAdd.Controls.Add(tbxId);
            tbpAdd.Controls.Add(lblDesc);
            tbpAdd.Controls.Add(lblType);
            tbpAdd.Controls.Add(lblId);
            tbpAdd.Location = new Point(4, 29);
            tbpAdd.Name = "tbpAdd";
            tbpAdd.Padding = new Padding(3);
            tbpAdd.Size = new Size(1053, 740);
            tbpAdd.TabIndex = 1;
            tbpAdd.Text = "Agregar";
            tbpAdd.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(660, 19);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 10;
            lblId.Text = "Id";
            lblId.Visible = false;
            // 
            // tbcRules
            // 
            tbcRules.Controls.Add(tbpList);
            tbcRules.Controls.Add(tbpAdd);
            tbcRules.Location = new Point(4, 78);
            tbcRules.Name = "tbcRules";
            tbcRules.SelectedIndex = 0;
            tbcRules.Size = new Size(1061, 773);
            tbcRules.TabIndex = 11;
            // 
            // lblRules
            // 
            lblRules.Font = new Font("HoloLens MDL2 Assets", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblRules.Location = new Point(4, 2);
            lblRules.Name = "lblRules";
            lblRules.Size = new Size(457, 73);
            lblRules.TabIndex = 10;
            lblRules.Text = "Reglas de negocio";
            lblRules.TextAlign = ContentAlignment.TopCenter;
            // 
            // RuleView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 853);
            Controls.Add(btnOut);
            Controls.Add(tbcRules);
            Controls.Add(lblRules);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RuleView";
            Text = "RuleIndex";
            tbpList.ResumeLayout(false);
            tbpList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRules).EndInit();
            tbpAdd.ResumeLayout(false);
            tbpAdd.PerformLayout();
            tbcRules.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnOut;
        private Label lblName;
        private TabPage tbpList;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSearch;
        private Label lblSearch;
        private DataGridView dgvRules;
        private Button btnAdd;
        private TextBox tbxSearch;
        private TextBox tbxKey;
        private Button btnCancel;
        private Button btnSave;
        private TextBox tbxDescription;
        private TextBox tbxName;
        private TextBox tbxId;
        private Label lblDesc;
        private Label lblType;
        private TabPage tbpAdd;
        private Label lblId;
        private TabControl tbcRules;
        private Label lblRules;
    }
}