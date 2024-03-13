namespace act.Forms.AlternativeFlows.Index
{
    partial class AlternativeFlow
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblUseCases = new Label();
            tbcAlternativeFlows = new TabControl();
            tbpList = new TabPage();
            btnAlternatingFlow = new Button();
            panel1 = new Panel();
            tbxSearch = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSearch = new Button();
            dgvAlternativeFlows = new DataGridView();
            btnAdd = new Button();
            tbpAdd = new TabPage();
            panel5 = new Panel();
            panel6 = new Panel();
            textBox1 = new TextBox();
            panel4 = new Panel();
            tbxFlowChartPath = new TextBox();
            lblUseCaseP = new Label();
            lblName = new Label();
            lblType = new Label();
            panel3 = new Panel();
            tbxKey = new TextBox();
            panel2 = new Panel();
            tbxName = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            tbxId = new TextBox();
            lblId = new Label();
            btnOut = new PictureBox();
            tbcAlternativeFlows.SuspendLayout();
            tbpList.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlternativeFlows).BeginInit();
            tbpAdd.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnOut).BeginInit();
            SuspendLayout();
            // 
            // lblUseCases
            // 
            lblUseCases.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblUseCases.Location = new Point(3, 11);
            lblUseCases.Margin = new Padding(5, 0, 5, 0);
            lblUseCases.Name = "lblUseCases";
            lblUseCases.Size = new Size(619, 102);
            lblUseCases.TabIndex = 23;
            lblUseCases.Text = "Flujos alternos";
            lblUseCases.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbcAlternativeFlows
            // 
            tbcAlternativeFlows.Controls.Add(tbpList);
            tbcAlternativeFlows.Controls.Add(tbpAdd);
            tbcAlternativeFlows.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbcAlternativeFlows.ItemSize = new Size(66, 26);
            tbcAlternativeFlows.Location = new Point(3, 117);
            tbcAlternativeFlows.Margin = new Padding(8);
            tbcAlternativeFlows.Multiline = true;
            tbcAlternativeFlows.Name = "tbcAlternativeFlows";
            tbcAlternativeFlows.SelectedIndex = 0;
            tbcAlternativeFlows.Size = new Size(1724, 1237);
            tbcAlternativeFlows.SizeMode = TabSizeMode.FillToRight;
            tbcAlternativeFlows.TabIndex = 24;
            // 
            // tbpList
            // 
            tbpList.BackColor = Color.WhiteSmoke;
            tbpList.Controls.Add(btnAlternatingFlow);
            tbpList.Controls.Add(panel1);
            tbpList.Controls.Add(btnDelete);
            tbpList.Controls.Add(btnEdit);
            tbpList.Controls.Add(btnSearch);
            tbpList.Controls.Add(dgvAlternativeFlows);
            tbpList.Controls.Add(btnAdd);
            tbpList.Location = new Point(8, 34);
            tbpList.Margin = new Padding(5);
            tbpList.Name = "tbpList";
            tbpList.Padding = new Padding(5);
            tbpList.Size = new Size(1708, 1195);
            tbpList.TabIndex = 0;
            tbpList.Text = "Listado";
            // 
            // btnAlternatingFlow
            // 
            btnAlternatingFlow.BackColor = Color.FromArgb(27, 43, 57);
            btnAlternatingFlow.Cursor = Cursors.Hand;
            btnAlternatingFlow.FlatStyle = FlatStyle.Flat;
            btnAlternatingFlow.Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlternatingFlow.ForeColor = SystemColors.Control;
            btnAlternatingFlow.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlternatingFlow.Location = new Point(1095, 1019);
            btnAlternatingFlow.Margin = new Padding(5);
            btnAlternatingFlow.Name = "btnAlternatingFlow";
            btnAlternatingFlow.Size = new Size(231, 53);
            btnAlternatingFlow.TabIndex = 16;
            btnAlternatingFlow.Text = "Flujos";
            btnAlternatingFlow.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAlternatingFlow.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(tbxSearch);
            panel1.Location = new Point(26, 30);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 50);
            panel1.TabIndex = 15;
            // 
            // tbxSearch
            // 
            tbxSearch.BackColor = Color.Gainsboro;
            tbxSearch.BorderStyle = BorderStyle.None;
            tbxSearch.Location = new Point(18, 5);
            tbxSearch.Margin = new Padding(5);
            tbxSearch.Multiline = true;
            tbxSearch.Name = "tbxSearch";
            tbxSearch.PlaceholderText = "Clave o nombre";
            tbxSearch.Size = new Size(369, 40);
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
            btnDelete.Location = new Point(1518, 1019);
            btnDelete.Margin = new Padding(5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(171, 53);
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
            btnEdit.Location = new Point(1337, 1019);
            btnEdit.Margin = new Padding(5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(171, 53);
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
            btnSearch.Location = new Point(442, 27);
            btnSearch.Margin = new Padding(5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(171, 53);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Buscar";
            btnSearch.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvAlternativeFlows
            // 
            dgvAlternativeFlows.AllowUserToAddRows = false;
            dgvAlternativeFlows.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dgvAlternativeFlows.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAlternativeFlows.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlternativeFlows.BackgroundColor = Color.WhiteSmoke;
            dgvAlternativeFlows.BorderStyle = BorderStyle.None;
            dgvAlternativeFlows.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvAlternativeFlows.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Desktop;
            dataGridViewCellStyle2.Font = new Font("Montserrat SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAlternativeFlows.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAlternativeFlows.ColumnHeadersHeight = 40;
            dgvAlternativeFlows.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dataGridViewCellStyle3.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAlternativeFlows.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAlternativeFlows.EnableHeadersVisualStyles = false;
            dgvAlternativeFlows.GridColor = Color.White;
            dgvAlternativeFlows.Location = new Point(26, 104);
            dgvAlternativeFlows.Margin = new Padding(5);
            dgvAlternativeFlows.MultiSelect = false;
            dgvAlternativeFlows.Name = "dgvAlternativeFlows";
            dgvAlternativeFlows.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvAlternativeFlows.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvAlternativeFlows.RowHeadersVisible = false;
            dgvAlternativeFlows.RowHeadersWidth = 20;
            dgvAlternativeFlows.RowTemplate.Height = 40;
            dgvAlternativeFlows.RowTemplate.ReadOnly = true;
            dgvAlternativeFlows.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlternativeFlows.Size = new Size(1662, 974);
            dgvAlternativeFlows.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(27, 43, 57);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Image = Properties.Resources.add;
            btnAdd.Location = new Point(1518, 30);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(171, 53);
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
            tbpAdd.Location = new Point(8, 34);
            tbpAdd.Margin = new Padding(5);
            tbpAdd.Name = "tbpAdd";
            tbpAdd.Padding = new Padding(5);
            tbpAdd.Size = new Size(1708, 1195);
            tbpAdd.TabIndex = 1;
            tbpAdd.Text = "Agregar";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(lblUseCaseP);
            panel5.Controls.Add(lblName);
            panel5.Controls.Add(lblType);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(panel2);
            panel5.Location = new Point(26, 26);
            panel5.Margin = new Padding(5);
            panel5.Name = "panel5";
            panel5.Size = new Size(1662, 398);
            panel5.TabIndex = 22;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gainsboro;
            panel6.Controls.Add(textBox1);
            panel6.Location = new Point(23, 184);
            panel6.Margin = new Padding(5);
            panel6.Name = "panel6";
            panel6.Size = new Size(94, 50);
            panel6.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Location = new Point(13, 5);
            textBox1.Margin = new Padding(5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(81, 40);
            textBox1.TabIndex = 14;
            textBox1.Text = "FA -";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(tbxFlowChartPath);
            panel4.Location = new Point(23, 302);
            panel4.Margin = new Padding(5);
            panel4.Name = "panel4";
            panel4.Size = new Size(444, 50);
            panel4.TabIndex = 20;
            // 
            // tbxFlowChartPath
            // 
            tbxFlowChartPath.BackColor = Color.Gainsboro;
            tbxFlowChartPath.BorderStyle = BorderStyle.None;
            tbxFlowChartPath.Location = new Point(13, 5);
            tbxFlowChartPath.Margin = new Padding(5);
            tbxFlowChartPath.Multiline = true;
            tbxFlowChartPath.Name = "tbxFlowChartPath";
            tbxFlowChartPath.Size = new Size(416, 40);
            tbxFlowChartPath.TabIndex = 13;
            // 
            // lblUseCaseP
            // 
            lblUseCaseP.AutoSize = true;
            lblUseCaseP.Location = new Point(23, 251);
            lblUseCaseP.Margin = new Padding(5, 0, 5, 0);
            lblUseCaseP.Name = "lblUseCaseP";
            lblUseCaseP.Size = new Size(108, 33);
            lblUseCaseP.TabIndex = 21;
            lblUseCaseP.Text = "Imagen";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(23, 24);
            lblName.Margin = new Padding(5, 0, 5, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(116, 33);
            lblName.TabIndex = 12;
            lblName.Text = "Nombre";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(23, 146);
            lblType.Margin = new Padding(5, 0, 5, 0);
            lblType.Name = "lblType";
            lblType.Size = new Size(80, 33);
            lblType.TabIndex = 14;
            lblType.Text = "Clave";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(tbxKey);
            panel3.Location = new Point(127, 184);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(182, 50);
            panel3.TabIndex = 20;
            // 
            // tbxKey
            // 
            tbxKey.BackColor = Color.Gainsboro;
            tbxKey.BorderStyle = BorderStyle.None;
            tbxKey.Location = new Point(18, 5);
            tbxKey.Margin = new Padding(5);
            tbxKey.Multiline = true;
            tbxKey.Name = "tbxKey";
            tbxKey.Size = new Size(146, 40);
            tbxKey.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(tbxName);
            panel2.Location = new Point(23, 70);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 50);
            panel2.TabIndex = 19;
            // 
            // tbxName
            // 
            tbxName.BackColor = Color.Gainsboro;
            tbxName.BorderStyle = BorderStyle.None;
            tbxName.Location = new Point(13, 5);
            tbxName.Margin = new Padding(5);
            tbxName.Multiline = true;
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(416, 40);
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
            btnCancel.Location = new Point(1518, 1019);
            btnCancel.Margin = new Padding(5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(171, 53);
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
            btnSave.Location = new Point(1337, 1019);
            btnSave.Margin = new Padding(5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(171, 53);
            btnSave.TabIndex = 17;
            btnSave.Text = "Guardar";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // tbxId
            // 
            tbxId.Location = new Point(1485, 478);
            tbxId.Margin = new Padding(5);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(201, 37);
            tbxId.TabIndex = 11;
            tbxId.Visible = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(1648, 440);
            lblId.Margin = new Padding(5, 0, 5, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(38, 33);
            lblId.TabIndex = 10;
            lblId.Text = "Id";
            lblId.Visible = false;
            // 
            // btnOut
            // 
            btnOut.Cursor = Cursors.Hand;
            btnOut.Image = Properties.Resources.close;
            btnOut.Location = new Point(1648, 37);
            btnOut.Margin = new Padding(5);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(50, 45);
            btnOut.SizeMode = PictureBoxSizeMode.Zoom;
            btnOut.TabIndex = 25;
            btnOut.TabStop = false;
            // 
            // AlternativeFlow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1729, 1280);
            Controls.Add(lblUseCases);
            Controls.Add(tbcAlternativeFlows);
            Controls.Add(btnOut);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "AlternativeFlow";
            Text = "BaseFlow";
            Load += AlternativeFlow_Load;
            tbcAlternativeFlows.ResumeLayout(false);
            tbpList.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlternativeFlows).EndInit();
            tbpAdd.ResumeLayout(false);
            tbpAdd.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUseCases;
        private TabControl tbcAlternativeFlows;
        private TabPage tbpList;
        private Button btnAlternatingFlow;
        private Panel panel1;
        private TextBox tbxSearch;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSearch;
        private DataGridView dgvAlternativeFlows;
        private Button btnAdd;
        private TabPage tbpAdd;
        private Panel panel5;
        private Panel panel4;
        private TextBox tbxFlowChartPath;
        private Label lblUseCaseP;
        private Label lblName;
        private Label lblType;
        private Panel panel3;
        private TextBox tbxKey;
        private Panel panel2;
        private TextBox tbxName;
        private Button btnCancel;
        private Button btnSave;
        private TextBox tbxId;
        private Label lblId;
        private PictureBox btnOut;
        private Panel panel6;
        private TextBox textBox1;
    }
}