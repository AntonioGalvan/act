namespace act.Views
{
    partial class ProjectView
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            pnlHeader = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tbpAdd = new TabPage();
            dtpEnd = new DateTimePicker();
            dtpStart = new DateTimePicker();
            btnCancel = new Button();
            btnSave = new Button();
            tbxDesc = new TextBox();
            tbxName = new TextBox();
            tbxId = new TextBox();
            lblDesc = new Label();
            lblType = new Label();
            lblName = new Label();
            lblId = new Label();
            tbpList = new TabPage();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgbProjects = new DataGridView();
            btnSearch = new Button();
            tbxSearch = new TextBox();
            lblSearch = new Label();
            tbcProjects = new TabControl();
            pnlHeader.SuspendLayout();
            tbpAdd.SuspendLayout();
            tbpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgbProjects).BeginInit();
            tbcProjects.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.Window;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(177, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Proyectos";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 0, 64);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 68);
            pnlHeader.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tbpAdd
            // 
            tbpAdd.Controls.Add(dtpEnd);
            tbpAdd.Controls.Add(dtpStart);
            tbpAdd.Controls.Add(btnCancel);
            tbpAdd.Controls.Add(btnSave);
            tbpAdd.Controls.Add(tbxDesc);
            tbpAdd.Controls.Add(tbxName);
            tbpAdd.Controls.Add(tbxId);
            tbpAdd.Controls.Add(lblDesc);
            tbpAdd.Controls.Add(lblType);
            tbpAdd.Controls.Add(lblName);
            tbpAdd.Controls.Add(lblId);
            tbpAdd.Location = new Point(4, 29);
            tbpAdd.Name = "tbpAdd";
            tbpAdd.Padding = new Padding(3);
            tbpAdd.Size = new Size(792, 349);
            tbpAdd.TabIndex = 1;
            tbpAdd.Text = "Agregar";
            tbpAdd.UseVisualStyleBackColor = true;
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(152, 181);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(125, 27);
            dtpEnd.TabIndex = 12;
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(21, 181);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(125, 27);
            dtpStart.TabIndex = 11;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(169, 292);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(21, 292);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // tbxDesc
            // 
            tbxDesc.Location = new Point(21, 246);
            tbxDesc.Name = "tbxDesc";
            tbxDesc.Size = new Size(273, 27);
            tbxDesc.TabIndex = 7;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(21, 112);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(125, 27);
            tbxName.TabIndex = 3;
            // 
            // tbxId
            // 
            tbxId.Location = new Point(21, 47);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(125, 27);
            tbxId.TabIndex = 1;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(24, 226);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(87, 20);
            lblDesc.TabIndex = 6;
            lblDesc.Text = "Descripción";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(21, 158);
            lblType.Name = "lblType";
            lblType.Size = new Size(199, 20);
            lblType.TabIndex = 4;
            lblType.Text = "Fecha de inicio y finalización";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(24, 92);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Nombre";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(24, 27);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // tbpList
            // 
            tbpList.Controls.Add(btnDelete);
            tbpList.Controls.Add(btnEdit);
            tbpList.Controls.Add(btnAdd);
            tbpList.Controls.Add(dgbProjects);
            tbpList.Controls.Add(btnSearch);
            tbpList.Controls.Add(tbxSearch);
            tbpList.Controls.Add(lblSearch);
            tbpList.Location = new Point(4, 29);
            tbpList.Name = "tbpList";
            tbpList.Padding = new Padding(3);
            tbpList.Size = new Size(792, 349);
            tbpList.TabIndex = 0;
            tbpList.Text = "Listado";
            tbpList.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(690, 129);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(690, 94);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(690, 59);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgbProjects
            // 
            dgbProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbProjects.Location = new Point(8, 59);
            dgbProjects.Name = "dgbProjects";
            dgbProjects.RowHeadersWidth = 51;
            dgbProjects.RowTemplate.Height = 29;
            dgbProjects.Size = new Size(676, 282);
            dgbProjects.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(236, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbxSearch
            // 
            tbxSearch.Location = new Point(8, 26);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(222, 27);
            tbxSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(6, 6);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // tbcProjects
            // 
            tbcProjects.Controls.Add(tbpList);
            tbcProjects.Controls.Add(tbpAdd);
            tbcProjects.Dock = DockStyle.Fill;
            tbcProjects.Location = new Point(0, 68);
            tbcProjects.Name = "tbcProjects";
            tbcProjects.SelectedIndex = 0;
            tbcProjects.Size = new Size(800, 382);
            tbcProjects.TabIndex = 4;
            // 
            // ProjectView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbcProjects);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProjectView";
            Text = "ProjectView";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tbpAdd.ResumeLayout(false);
            tbpAdd.PerformLayout();
            tbpList.ResumeLayout(false);
            tbpList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgbProjects).EndInit();
            tbcProjects.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Panel pnlHeader;
        private ContextMenuStrip contextMenuStrip1;
        private TabPage tbpAdd;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpStart;
        private Button btnCancel;
        private Button btnSave;
        private TextBox tbxDesc;
        private TextBox tbxName;
        private TextBox tbxId;
        private Label lblDesc;
        private Label lblType;
        private Label lblName;
        private Label lblId;
        private TabPage tbpList;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dgbProjects;
        private Button btnSearch;
        private TextBox tbxSearch;
        private Label lblSearch;
        private TabControl tbcProjects;
    }
}