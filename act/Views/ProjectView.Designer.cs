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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            contextMenuStrip1 = new ContextMenuStrip(components);
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            btnOut = new PictureBox();
            tbcProjects = new TabControl();
            tbpList = new TabPage();
            btnOpen = new Button();
            panel1 = new Panel();
            tbxSearch = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSearch = new Button();
            dgbProjects = new DataGridView();
            btnAdd = new Button();
            tbpAdd = new TabPage();
            panel5 = new Panel();
            label1 = new Label();
            dtpEnd = new DateTimePicker();
            dtpStart = new DateTimePicker();
            lblName = new Label();
            panel4 = new Panel();
            tbxDesc = new TextBox();
            lblType = new Label();
            lblDesc = new Label();
            panel2 = new Panel();
            tbxName = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            tbxId = new TextBox();
            lblId = new Label();
            lblProjects = new Label();
            pnlSideBar = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox6 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnOut).BeginInit();
            tbcProjects.SuspendLayout();
            tbpList.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgbProjects).BeginInit();
            tbpAdd.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // btnOut
            // 
            btnOut.Cursor = Cursors.Hand;
            btnOut.Image = Properties.Resources.close;
            btnOut.Location = new Point(1143, 30);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(31, 28);
            btnOut.SizeMode = PictureBoxSizeMode.Zoom;
            btnOut.TabIndex = 19;
            btnOut.TabStop = false;
            btnOut.Click += btnOut_Click;
            // 
            // tbcProjects
            // 
            tbcProjects.Controls.Add(tbpList);
            tbcProjects.Controls.Add(tbpAdd);
            tbcProjects.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbcProjects.ItemSize = new Size(66, 26);
            tbcProjects.Location = new Point(354, 78);
            tbcProjects.Margin = new Padding(5);
            tbcProjects.Multiline = true;
            tbcProjects.Name = "tbcProjects";
            tbcProjects.SelectedIndex = 0;
            tbcProjects.Size = new Size(838, 706);
            tbcProjects.SizeMode = TabSizeMode.FillToRight;
            tbcProjects.TabIndex = 18;
            // 
            // tbpList
            // 
            tbpList.BackColor = Color.WhiteSmoke;
            tbpList.Controls.Add(btnOpen);
            tbpList.Controls.Add(panel1);
            tbpList.Controls.Add(btnDelete);
            tbpList.Controls.Add(btnEdit);
            tbpList.Controls.Add(btnSearch);
            tbpList.Controls.Add(dgbProjects);
            tbpList.Controls.Add(btnAdd);
            tbpList.Location = new Point(4, 30);
            tbpList.Name = "tbpList";
            tbpList.Padding = new Padding(3);
            tbpList.Size = new Size(830, 672);
            tbpList.TabIndex = 0;
            tbpList.Text = "Listado";
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.FromArgb(27, 43, 57);
            btnOpen.Cursor = Cursors.Hand;
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpen.ForeColor = SystemColors.Control;
            btnOpen.Image = Properties.Resources._2open2;
            btnOpen.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpen.Location = new Point(489, 623);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(105, 33);
            btnOpen.TabIndex = 16;
            btnOpen.Text = "Abrir";
            btnOpen.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(tbxSearch);
            panel1.Location = new Point(16, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 31);
            panel1.TabIndex = 15;
            // 
            // tbxSearch
            // 
            tbxSearch.BackColor = Color.Gainsboro;
            tbxSearch.BorderStyle = BorderStyle.None;
            tbxSearch.Location = new Point(12, 3);
            tbxSearch.Multiline = true;
            tbxSearch.Name = "tbxSearch";
            tbxSearch.PlaceholderText = "Id o nombre";
            tbxSearch.Size = new Size(227, 25);
            tbxSearch.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(711, 623);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 33);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Eliminar";
            btnDelete.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(27, 43, 57);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = SystemColors.Control;
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(600, 623);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(105, 33);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Editar";
            btnEdit.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(27, 43, 57);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Image = Properties.Resources.search;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(272, 17);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(105, 33);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Buscar";
            btnSearch.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgbProjects
            // 
            dgbProjects.AllowUserToAddRows = false;
            dgbProjects.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dgbProjects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgbProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgbProjects.BackgroundColor = Color.WhiteSmoke;
            dgbProjects.BorderStyle = BorderStyle.None;
            dgbProjects.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgbProjects.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle2.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgbProjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgbProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dataGridViewCellStyle3.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgbProjects.DefaultCellStyle = dataGridViewCellStyle3;
            dgbProjects.EnableHeadersVisualStyles = false;
            dgbProjects.GridColor = Color.White;
            dgbProjects.Location = new Point(16, 75);
            dgbProjects.MultiSelect = false;
            dgbProjects.Name = "dgbProjects";
            dgbProjects.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgbProjects.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgbProjects.RowHeadersVisible = false;
            dgbProjects.RowHeadersWidth = 20;
            dgbProjects.RowTemplate.Height = 35;
            dgbProjects.RowTemplate.ReadOnly = true;
            dgbProjects.Size = new Size(800, 530);
            dgbProjects.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(27, 43, 57);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Image = Properties.Resources.add;
            btnAdd.Location = new Point(711, 21);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 33);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Agregar";
            btnAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnAdd.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // tbpAdd
            // 
            tbpAdd.BackColor = Color.WhiteSmoke;
            tbpAdd.Controls.Add(panel5);
            tbpAdd.Controls.Add(btnCancel);
            tbpAdd.Controls.Add(btnSave);
            tbpAdd.Controls.Add(tbxId);
            tbpAdd.Controls.Add(lblId);
            tbpAdd.Location = new Point(4, 30);
            tbpAdd.Name = "tbpAdd";
            tbpAdd.Padding = new Padding(3);
            tbpAdd.Size = new Size(1053, 739);
            tbpAdd.TabIndex = 1;
            tbpAdd.Text = "Agregar";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(label1);
            panel5.Controls.Add(dtpEnd);
            panel5.Controls.Add(dtpStart);
            panel5.Controls.Add(lblName);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(lblType);
            panel5.Controls.Add(lblDesc);
            panel5.Controls.Add(panel2);
            panel5.Location = new Point(16, 16);
            panel5.Name = "panel5";
            panel5.Size = new Size(1023, 246);
            panel5.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 90);
            label1.Name = "label1";
            label1.Size = new Size(166, 21);
            label1.TabIndex = 24;
            label1.Text = "Fecha de finalización";
            // 
            // dtpEnd
            // 
            dtpEnd.CalendarForeColor = SystemColors.Desktop;
            dtpEnd.CalendarMonthBackground = SystemColors.ScrollBar;
            dtpEnd.CalendarTitleBackColor = SystemColors.Desktop;
            dtpEnd.CalendarTitleForeColor = SystemColors.Control;
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(155, 114);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(132, 26);
            dtpEnd.TabIndex = 23;
            // 
            // dtpStart
            // 
            dtpStart.CalendarForeColor = SystemColors.Desktop;
            dtpStart.CalendarMonthBackground = SystemColors.ScrollBar;
            dtpStart.CalendarTitleBackColor = SystemColors.Desktop;
            dtpStart.CalendarTitleForeColor = SystemColors.Control;
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(14, 114);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(132, 26);
            dtpStart.TabIndex = 22;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(14, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(72, 21);
            lblName.TabIndex = 12;
            lblName.Text = "Nombre";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(tbxDesc);
            panel4.Location = new Point(14, 187);
            panel4.Name = "panel4";
            panel4.Size = new Size(273, 31);
            panel4.TabIndex = 21;
            // 
            // tbxDesc
            // 
            tbxDesc.BackColor = Color.Gainsboro;
            tbxDesc.BorderStyle = BorderStyle.None;
            tbxDesc.Location = new Point(8, 3);
            tbxDesc.Multiline = true;
            tbxDesc.Name = "tbxDesc";
            tbxDesc.Size = new Size(256, 28);
            tbxDesc.TabIndex = 15;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(14, 90);
            lblType.Name = "lblType";
            lblType.Size = new Size(121, 21);
            lblType.TabIndex = 14;
            lblType.Text = "Fecha de inicio";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(14, 163);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(97, 21);
            lblDesc.TabIndex = 15;
            lblDesc.Text = "Descripción";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(tbxName);
            panel2.Location = new Point(14, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 31);
            panel2.TabIndex = 19;
            // 
            // tbxName
            // 
            tbxName.BackColor = Color.Gainsboro;
            tbxName.BorderStyle = BorderStyle.None;
            tbxName.Location = new Point(8, 3);
            tbxName.Multiline = true;
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(256, 25);
            tbxName.TabIndex = 13;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Firebrick;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.Image = Properties.Resources.cancelar;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(934, 689);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 33);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancelar";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(27, 43, 57);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(823, 689);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 33);
            btnSave.TabIndex = 17;
            btnSave.Text = "Guardar";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // tbxId
            // 
            tbxId.Location = new Point(915, 297);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(125, 26);
            tbxId.TabIndex = 11;
            tbxId.Visible = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(1018, 276);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 21);
            lblId.TabIndex = 10;
            lblId.Text = "Id";
            lblId.Visible = false;
            // 
            // lblProjects
            // 
            lblProjects.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblProjects.Location = new Point(354, 9);
            lblProjects.Name = "lblProjects";
            lblProjects.Size = new Size(197, 64);
            lblProjects.TabIndex = 17;
            lblProjects.Text = "Proyectos";
            lblProjects.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.FromArgb(24, 40, 54);
            pnlSideBar.Controls.Add(label2);
            pnlSideBar.Controls.Add(pictureBox1);
            pnlSideBar.Controls.Add(pictureBox6);
            pnlSideBar.Controls.Add(label3);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(0, 0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(348, 793);
            pnlSideBar.TabIndex = 27;
            pnlSideBar.Paint += pnlSideBar_Paint;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(24, 40, 54);
            label2.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(123, 307);
            label2.Name = "label2";
            label2.Size = new Size(82, 42);
            label2.TabIndex = 19;
            label2.Text = "ACT";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.correcto2;
            pictureBox1.Location = new Point(152, 267);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 62);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.correcto;
            pictureBox6.Location = new Point(112, 325);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(72, 62);
            pictureBox6.TabIndex = 42;
            pictureBox6.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Montserrat", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(68, 377);
            label3.Name = "label3";
            label3.Size = new Size(197, 110);
            label3.TabIndex = 43;
            label3.Text = "Nombre de aplicación";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // ProjectView
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1200, 793);
            Controls.Add(pnlSideBar);
            Controls.Add(btnOut);
            Controls.Add(tbcProjects);
            Controls.Add(lblProjects);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProjectView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProjectView";
            ((System.ComponentModel.ISupportInitialize)btnOut).EndInit();
            tbcProjects.ResumeLayout(false);
            tbpList.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgbProjects).EndInit();
            tbpAdd.ResumeLayout(false);
            tbpAdd.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private PictureBox btnOut;
        private TabControl tbcProjects;
        private TabPage tbpList;
        private Button btnOpen;
        private Panel panel1;
        private TextBox tbxSearch;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSearch;
        private DataGridView dgbProjects;
        private Button btnAdd;
        private TabPage tbpAdd;
        private Panel panel5;
        private Label lblName;
        private Panel panel4;
        private TextBox tbxDesc;
        private Label lblType;
        private Label lblDesc;
        private Panel panel2;
        private TextBox tbxName;
        private Button btnCancel;
        private Button btnSave;
        private TextBox tbxId;
        private Label lblId;
        private Label lblProjects;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Label label1;
        private Panel pnlSideBar;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox6;
        private Label label3;
    }
}