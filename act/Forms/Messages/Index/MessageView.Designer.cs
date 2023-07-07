namespace act.Forms.Messages.Index
{
    partial class MessageView
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
            tbcMessages = new TabControl();
            tbpList = new TabPage();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSearch = new Button();
            lblSearch = new Label();
            dgvMessages = new DataGridView();
            btnAdd = new Button();
            tbxSearch = new TextBox();
            tbpAdd = new TabPage();
            tbxKey = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            tbxDescription = new TextBox();
            tbxId = new TextBox();
            lblDesc = new Label();
            lblType = new Label();
            lblId = new Label();
            lblMessages = new Label();
            tbcMessages.SuspendLayout();
            tbpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMessages).BeginInit();
            tbpAdd.SuspendLayout();
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
            // tbcMessages
            // 
            tbcMessages.Controls.Add(tbpList);
            tbcMessages.Controls.Add(tbpAdd);
            tbcMessages.Location = new Point(4, 78);
            tbcMessages.Name = "tbcMessages";
            tbcMessages.SelectedIndex = 0;
            tbcMessages.Size = new Size(1061, 773);
            tbcMessages.TabIndex = 11;
            // 
            // tbpList
            // 
            tbpList.Controls.Add(btnDelete);
            tbpList.Controls.Add(btnEdit);
            tbpList.Controls.Add(btnSearch);
            tbpList.Controls.Add(lblSearch);
            tbpList.Controls.Add(dgvMessages);
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
            // dgvMessages
            // 
            dgvMessages.AllowUserToAddRows = false;
            dgvMessages.AllowUserToDeleteRows = false;
            dgvMessages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMessages.Location = new Point(16, 63);
            dgvMessages.Name = "dgvMessages";
            dgvMessages.RowHeadersWidth = 51;
            dgvMessages.RowTemplate.Height = 29;
            dgvMessages.Size = new Size(922, 670);
            dgvMessages.TabIndex = 10;
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
            // tbxKey
            // 
            tbxKey.Location = new Point(12, 39);
            tbxKey.Name = "tbxKey";
            tbxKey.Size = new Size(90, 27);
            tbxKey.TabIndex = 14;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(143, 186);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 29);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 186);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 29);
            btnSave.TabIndex = 17;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // tbxDescription
            // 
            tbxDescription.Location = new Point(12, 112);
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
            lblDesc.Location = new Point(18, 92);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(87, 20);
            lblDesc.TabIndex = 15;
            lblDesc.Text = "Descripción";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(18, 19);
            lblType.Name = "lblType";
            lblType.Size = new Size(45, 20);
            lblType.TabIndex = 14;
            lblType.Text = "Clave";
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
            // lblMessages
            // 
            lblMessages.Font = new Font("HoloLens MDL2 Assets", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblMessages.Location = new Point(4, 2);
            lblMessages.Name = "lblMessages";
            lblMessages.Size = new Size(229, 64);
            lblMessages.TabIndex = 10;
            lblMessages.Text = "Mensajes";
            lblMessages.TextAlign = ContentAlignment.TopCenter;
            // 
            // MessageView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 853);
            Controls.Add(btnOut);
            Controls.Add(tbcMessages);
            Controls.Add(lblMessages);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MessageView";
            Text = "MessagesIndex";
            tbcMessages.ResumeLayout(false);
            tbpList.ResumeLayout(false);
            tbpList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMessages).EndInit();
            tbpAdd.ResumeLayout(false);
            tbpAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnOut;
        private TabControl tbcMessages;
        private TabPage tbpList;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSearch;
        private Label lblSearch;
        private DataGridView dgvMessages;
        private Button btnAdd;
        private TextBox tbxSearch;
        private TabPage tbpAdd;
        private TextBox tbxKey;
        private Button btnCancel;
        private Button btnSave;
        private TextBox tbxDescription;
        private TextBox tbxId;
        private Label lblDesc;
        private Label lblType;
        private Label lblId;
        private Label lblMessages;
    }
}