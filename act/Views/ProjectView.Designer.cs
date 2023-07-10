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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
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
            btnOut.Location = new Point(914, 24);
            btnOut.Margin = new Padding(2, 2, 2, 2);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(25, 22);
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
            tbcProjects.Location = new Point(283, 62);
            tbcProjects.Margin = new Padding(4, 4, 4, 4);
            tbcProjects.Multiline = true;
            tbcProjects.Name = "tbcProjects";
            tbcProjects.SelectedIndex = 0;
            tbcProjects.Size = new Size(670, 548);
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
            tbpList.Margin = new Padding(2, 2, 2, 2);
            tbpList.Name = "tbpList";
            tbpList.Padding = new Padding(2, 2, 2, 2);
            tbpList.Size = new Size(662, 514);
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
            btnOpen.Location = new Point(364, 480);
            btnOpen.Margin = new Padding(2, 2, 2, 2);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(94, 26);
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
            panel1.Location = new Point(13, 14);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 25);
            panel1.TabIndex = 15;
            // 
            // tbxSearch
            // 
            tbxSearch.BackColor = Color.Gainsboro;
            tbxSearch.BorderStyle = BorderStyle.None;
            tbxSearch.Location = new Point(10, 2);
            tbxSearch.Margin = new Padding(2, 2, 2, 2);
            tbxSearch.Multiline = true;
            tbxSearch.Name = "tbxSearch";
            tbxSearch.PlaceholderText = "Id o nombre";
            tbxSearch.Size = new Size(182, 20);
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
            btnDelete.Location = new Point(560, 480);
            btnDelete.Margin = new Padding(2, 2, 2, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 26);
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
            btnEdit.Location = new Point(462, 480);
            btnEdit.Margin = new Padding(2, 2, 2, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 26);
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
            btnSearch.Location = new Point(218, 14);
            btnSearch.Margin = new Padding(2, 2, 2, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 26);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Buscar";
            btnSearch.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgbProjects
            // 
            dgbProjects.AllowUserToAddRows = false;
            dgbProjects.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.Padding = new Padding(2);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.Control;
            dgbProjects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dgbProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgbProjects.BackgroundColor = Color.WhiteSmoke;
            dgbProjects.BorderStyle = BorderStyle.None;
            dgbProjects.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgbProjects.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle10.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.Control;
            dataGridViewCellStyle10.Padding = new Padding(2);
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgbProjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgbProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.Gainsboro;
            dataGridViewCellStyle11.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgbProjects.DefaultCellStyle = dataGridViewCellStyle11;
            dgbProjects.EnableHeadersVisualStyles = false;
            dgbProjects.GridColor = Color.White;
            dgbProjects.Location = new Point(13, 57);
            dgbProjects.Margin = new Padding(2, 2, 2, 2);
            dgbProjects.MultiSelect = false;
            dgbProjects.Name = "dgbProjects";
            dgbProjects.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle12.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgbProjects.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgbProjects.RowHeadersVisible = false;
            dgbProjects.RowHeadersWidth = 20;
            dgbProjects.RowTemplate.Height = 35;
            dgbProjects.RowTemplate.ReadOnly = true;
            dgbProjects.Size = new Size(640, 410);
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
            btnAdd.Location = new Point(560, 16);
            btnAdd.Margin = new Padding(2, 2, 2, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 26);
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
            tbpAdd.Margin = new Padding(2, 2, 2, 2);
            tbpAdd.Name = "tbpAdd";
            tbpAdd.Padding = new Padding(2, 2, 2, 2);
            tbpAdd.Size = new Size(662, 514);
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
            panel5.Location = new Point(13, 13);
            panel5.Margin = new Padding(2, 2, 2, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(640, 197);
            panel5.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 72);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 16);
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
            dtpEnd.Location = new Point(124, 91);
            dtpEnd.Margin = new Padding(2, 2, 2, 2);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(106, 22);
            dtpEnd.TabIndex = 23;
            // 
            // dtpStart
            // 
            dtpStart.CalendarForeColor = SystemColors.Desktop;
            dtpStart.CalendarMonthBackground = SystemColors.ScrollBar;
            dtpStart.CalendarTitleBackColor = SystemColors.Desktop;
            dtpStart.CalendarTitleForeColor = SystemColors.Control;
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(11, 91);
            dtpStart.Margin = new Padding(2, 2, 2, 2);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(106, 22);
            dtpStart.TabIndex = 22;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(11, 12);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(58, 16);
            lblName.TabIndex = 12;
            lblName.Text = "Nombre";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(tbxDesc);
            panel4.Location = new Point(11, 150);
            panel4.Margin = new Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(218, 25);
            panel4.TabIndex = 21;
            // 
            // tbxDesc
            // 
            tbxDesc.BackColor = Color.Gainsboro;
            tbxDesc.BorderStyle = BorderStyle.None;
            tbxDesc.Location = new Point(6, 2);
            tbxDesc.Margin = new Padding(2, 2, 2, 2);
            tbxDesc.Multiline = true;
            tbxDesc.Name = "tbxDesc";
            tbxDesc.Size = new Size(205, 22);
            tbxDesc.TabIndex = 15;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(11, 72);
            lblType.Margin = new Padding(2, 0, 2, 0);
            lblType.Name = "lblType";
            lblType.Size = new Size(97, 16);
            lblType.TabIndex = 14;
            lblType.Text = "Fecha de inicio";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(11, 130);
            lblDesc.Margin = new Padding(2, 0, 2, 0);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(79, 16);
            lblDesc.TabIndex = 15;
            lblDesc.Text = "Descripción";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(tbxName);
            panel2.Location = new Point(11, 35);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(218, 25);
            panel2.TabIndex = 19;
            // 
            // tbxName
            // 
            tbxName.BackColor = Color.Gainsboro;
            tbxName.BorderStyle = BorderStyle.None;
            tbxName.Location = new Point(6, 2);
            tbxName.Margin = new Padding(2, 2, 2, 2);
            tbxName.Multiline = true;
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(205, 20);
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
            btnCancel.Location = new Point(559, 481);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 26);
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
            btnSave.Location = new Point(461, 481);
            btnSave.Margin = new Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 26);
            btnSave.TabIndex = 17;
            btnSave.Text = "Guardar";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // tbxId
            // 
            tbxId.Location = new Point(732, 238);
            tbxId.Margin = new Padding(2, 2, 2, 2);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(101, 22);
            tbxId.TabIndex = 11;
            tbxId.Visible = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(814, 221);
            lblId.Margin = new Padding(2, 0, 2, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(19, 16);
            lblId.TabIndex = 10;
            lblId.Text = "Id";
            lblId.Visible = false;
            // 
            // lblProjects
            // 
            lblProjects.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblProjects.Location = new Point(283, 7);
            lblProjects.Margin = new Padding(2, 0, 2, 0);
            lblProjects.Name = "lblProjects";
            lblProjects.Size = new Size(158, 51);
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
            pnlSideBar.Margin = new Padding(2, 2, 2, 2);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(278, 618);
            pnlSideBar.TabIndex = 27;
            pnlSideBar.Paint += pnlSideBar_Paint;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(24, 40, 54);
            label2.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(98, 246);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 34);
            label2.TabIndex = 19;
            label2.Text = "ACT";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.correcto2;
            pictureBox1.Location = new Point(122, 214);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 50);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.correcto;
            pictureBox6.Location = new Point(90, 260);
            pictureBox6.Margin = new Padding(2, 2, 2, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(58, 50);
            pictureBox6.TabIndex = 42;
            pictureBox6.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Montserrat", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(54, 302);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(158, 88);
            label3.TabIndex = 43;
            label3.Text = "Nombre de aplicación";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // ProjectView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(960, 618);
            Controls.Add(pnlSideBar);
            Controls.Add(btnOut);
            Controls.Add(tbcProjects);
            Controls.Add(lblProjects);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
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