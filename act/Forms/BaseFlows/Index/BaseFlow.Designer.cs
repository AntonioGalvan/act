namespace act.Forms.BaseFlows.Index
{
    partial class BaseFlow
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
            tbcBaseFlows = new TabControl();
            tbpList = new TabPage();
            btnAlternatingFlow = new Button();
            panel1 = new Panel();
            tbxSearch = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSearch = new Button();
            dgvBaseFlows = new DataGridView();
            btnAdd = new Button();
            tbpAdd = new TabPage();
            panel5 = new Panel();
            cmbUseCases = new ComboBox();
            label1 = new Label();
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
            panel6 = new Panel();
            textBox1 = new TextBox();
            tbcBaseFlows.SuspendLayout();
            tbpList.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBaseFlows).BeginInit();
            tbpAdd.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnOut).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // lblUseCases
            // 
            lblUseCases.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblUseCases.Location = new Point(2, 7);
            lblUseCases.Name = "lblUseCases";
            lblUseCases.Size = new Size(381, 64);
            lblUseCases.TabIndex = 23;
            lblUseCases.Text = "Flujos base";
            lblUseCases.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbcBaseFlows
            // 
            tbcBaseFlows.Controls.Add(tbpList);
            tbcBaseFlows.Controls.Add(tbpAdd);
            tbcBaseFlows.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbcBaseFlows.ItemSize = new Size(66, 26);
            tbcBaseFlows.Location = new Point(2, 73);
            tbcBaseFlows.Margin = new Padding(5);
            tbcBaseFlows.Multiline = true;
            tbcBaseFlows.Name = "tbcBaseFlows";
            tbcBaseFlows.SelectedIndex = 0;
            tbcBaseFlows.Size = new Size(1061, 773);
            tbcBaseFlows.SizeMode = TabSizeMode.FillToRight;
            tbcBaseFlows.TabIndex = 24;
            // 
            // tbpList
            // 
            tbpList.BackColor = Color.WhiteSmoke;
            tbpList.Controls.Add(btnAlternatingFlow);
            tbpList.Controls.Add(panel1);
            tbpList.Controls.Add(btnDelete);
            tbpList.Controls.Add(btnEdit);
            tbpList.Controls.Add(btnSearch);
            tbpList.Controls.Add(dgvBaseFlows);
            tbpList.Controls.Add(btnAdd);
            tbpList.Location = new Point(4, 30);
            tbpList.Name = "tbpList";
            tbpList.Padding = new Padding(3);
            tbpList.Size = new Size(1053, 739);
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
            btnAlternatingFlow.Location = new Point(674, 637);
            btnAlternatingFlow.Name = "btnAlternatingFlow";
            btnAlternatingFlow.Size = new Size(142, 33);
            btnAlternatingFlow.TabIndex = 16;
            btnAlternatingFlow.Text = "Flujos Alternos";
            btnAlternatingFlow.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAlternatingFlow.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(tbxSearch);
            panel1.Location = new Point(16, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 31);
            panel1.TabIndex = 15;
            // 
            // tbxSearch
            // 
            tbxSearch.BackColor = Color.Gainsboro;
            tbxSearch.BorderStyle = BorderStyle.None;
            tbxSearch.Location = new Point(11, 3);
            tbxSearch.Multiline = true;
            tbxSearch.Name = "tbxSearch";
            tbxSearch.PlaceholderText = "Clave o nombre";
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
            btnDelete.Location = new Point(934, 637);
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
            btnEdit.Location = new Point(823, 637);
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
            // dgvBaseFlows
            // 
            dgvBaseFlows.AllowUserToAddRows = false;
            dgvBaseFlows.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dgvBaseFlows.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBaseFlows.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBaseFlows.BackgroundColor = Color.WhiteSmoke;
            dgvBaseFlows.BorderStyle = BorderStyle.None;
            dgvBaseFlows.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBaseFlows.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Desktop;
            dataGridViewCellStyle2.Font = new Font("Montserrat SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBaseFlows.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBaseFlows.ColumnHeadersHeight = 40;
            dgvBaseFlows.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dataGridViewCellStyle3.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBaseFlows.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBaseFlows.EnableHeadersVisualStyles = false;
            dgvBaseFlows.GridColor = Color.White;
            dgvBaseFlows.Location = new Point(16, 65);
            dgvBaseFlows.MultiSelect = false;
            dgvBaseFlows.Name = "dgvBaseFlows";
            dgvBaseFlows.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvBaseFlows.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvBaseFlows.RowHeadersVisible = false;
            dgvBaseFlows.RowHeadersWidth = 20;
            dgvBaseFlows.RowTemplate.Height = 40;
            dgvBaseFlows.RowTemplate.ReadOnly = true;
            dgvBaseFlows.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBaseFlows.Size = new Size(1023, 609);
            dgvBaseFlows.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(27, 43, 57);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Image = Properties.Resources.add;
            btnAdd.Location = new Point(934, 19);
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
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(cmbUseCases);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(lblUseCaseP);
            panel5.Controls.Add(lblName);
            panel5.Controls.Add(lblType);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(panel2);
            panel5.Location = new Point(16, 16);
            panel5.Name = "panel5";
            panel5.Size = new Size(1023, 249);
            panel5.TabIndex = 22;
            // 
            // cmbUseCases
            // 
            cmbUseCases.BackColor = Color.Gainsboro;
            cmbUseCases.FormattingEnabled = true;
            cmbUseCases.Location = new Point(319, 45);
            cmbUseCases.Name = "cmbUseCases";
            cmbUseCases.Size = new Size(273, 29);
            cmbUseCases.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 15);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 22;
            label1.Text = "Caso de uso";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(tbxFlowChartPath);
            panel4.Location = new Point(14, 189);
            panel4.Name = "panel4";
            panel4.Size = new Size(273, 31);
            panel4.TabIndex = 20;
            // 
            // tbxFlowChartPath
            // 
            tbxFlowChartPath.BackColor = Color.Gainsboro;
            tbxFlowChartPath.BorderStyle = BorderStyle.None;
            tbxFlowChartPath.Location = new Point(8, 3);
            tbxFlowChartPath.Multiline = true;
            tbxFlowChartPath.Name = "tbxFlowChartPath";
            tbxFlowChartPath.Size = new Size(256, 25);
            tbxFlowChartPath.TabIndex = 13;
            // 
            // lblUseCaseP
            // 
            lblUseCaseP.AutoSize = true;
            lblUseCaseP.Location = new Point(14, 157);
            lblUseCaseP.Name = "lblUseCaseP";
            lblUseCaseP.Size = new Size(69, 21);
            lblUseCaseP.TabIndex = 21;
            lblUseCaseP.Text = "Imagen";
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
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(14, 91);
            lblType.Name = "lblType";
            lblType.Size = new Size(51, 21);
            lblType.TabIndex = 14;
            lblType.Text = "Clave";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(tbxKey);
            panel3.Location = new Point(78, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(112, 31);
            panel3.TabIndex = 20;
            // 
            // tbxKey
            // 
            tbxKey.BackColor = Color.Gainsboro;
            tbxKey.BorderStyle = BorderStyle.None;
            tbxKey.Location = new Point(11, 3);
            tbxKey.Multiline = true;
            tbxKey.Name = "tbxKey";
            tbxKey.Size = new Size(90, 25);
            tbxKey.TabIndex = 14;
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
            btnCancel.Location = new Point(934, 637);
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
            btnSave.Location = new Point(823, 637);
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
            tbxId.Location = new Point(914, 299);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(125, 26);
            tbxId.TabIndex = 11;
            tbxId.Visible = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(1014, 275);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 21);
            lblId.TabIndex = 10;
            lblId.Text = "Id";
            lblId.Visible = false;
            // 
            // btnOut
            // 
            btnOut.Cursor = Cursors.Hand;
            btnOut.Image = Properties.Resources.close;
            btnOut.Location = new Point(1014, 23);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(31, 28);
            btnOut.SizeMode = PictureBoxSizeMode.Zoom;
            btnOut.TabIndex = 25;
            btnOut.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gainsboro;
            panel6.Controls.Add(textBox1);
            panel6.Location = new Point(14, 115);
            panel6.Name = "panel6";
            panel6.Size = new Size(58, 31);
            panel6.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Location = new Point(8, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(50, 25);
            textBox1.TabIndex = 14;
            textBox1.Text = "FB -";
            // 
            // BaseFlow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 800);
            Controls.Add(lblUseCases);
            Controls.Add(tbcBaseFlows);
            Controls.Add(btnOut);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BaseFlow";
            Text = "BaseFlow";
            Load += BaseFlow_Load;
            tbcBaseFlows.ResumeLayout(false);
            tbpList.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBaseFlows).EndInit();
            tbpAdd.ResumeLayout(false);
            tbpAdd.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnOut).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUseCases;
        private TabControl tbcBaseFlows;
        private TabPage tbpList;
        private Button btnAlternatingFlow;
        private Panel panel1;
        private TextBox tbxSearch;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSearch;
        private DataGridView dgvBaseFlows;
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
        private ComboBox cmbUseCases;
        private Label label1;
        private Panel panel6;
        private TextBox textBox1;
    }
}