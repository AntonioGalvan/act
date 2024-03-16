namespace act.Forms.BaseAlternativeFlows.Index
{
    partial class BaseAlternativeFlow
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            lblUseCases = new Label();
            tbcBaseAlternativeFlows = new TabControl();
            tbpList = new TabPage();
            btnAlternatingFlow = new Button();
            panel1 = new Panel();
            tbxSearch = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSearch = new Button();
            dgvBaseAlternativeFlows = new DataGridView();
            btnAdd = new Button();
            tbpAdd = new TabPage();
            panel5 = new Panel();
            cmbAlternativeFlow = new ComboBox();
            label1 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            tbxId = new TextBox();
            lblId = new Label();
            btnOut = new PictureBox();
            tbcBaseAlternativeFlows.SuspendLayout();
            tbpList.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBaseAlternativeFlows).BeginInit();
            tbpAdd.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnOut).BeginInit();
            SuspendLayout();
            // 
            // lblUseCases
            // 
            lblUseCases.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblUseCases.Location = new Point(3, 11);
            lblUseCases.Margin = new Padding(5, 0, 5, 0);
            lblUseCases.Name = "lblUseCases";
            lblUseCases.Size = new Size(817, 102);
            lblUseCases.TabIndex = 23;
            lblUseCases.Text = "Flujos alternos vinculados";
            lblUseCases.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbcBaseAlternativeFlows
            // 
            tbcBaseAlternativeFlows.Controls.Add(tbpList);
            tbcBaseAlternativeFlows.Controls.Add(tbpAdd);
            tbcBaseAlternativeFlows.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbcBaseAlternativeFlows.ItemSize = new Size(66, 26);
            tbcBaseAlternativeFlows.Location = new Point(3, 117);
            tbcBaseAlternativeFlows.Margin = new Padding(8, 8, 8, 8);
            tbcBaseAlternativeFlows.Multiline = true;
            tbcBaseAlternativeFlows.Name = "tbcBaseAlternativeFlows";
            tbcBaseAlternativeFlows.SelectedIndex = 0;
            tbcBaseAlternativeFlows.Size = new Size(1724, 1237);
            tbcBaseAlternativeFlows.SizeMode = TabSizeMode.FillToRight;
            tbcBaseAlternativeFlows.TabIndex = 24;
            // 
            // tbpList
            // 
            tbpList.BackColor = Color.WhiteSmoke;
            tbpList.Controls.Add(btnAlternatingFlow);
            tbpList.Controls.Add(panel1);
            tbpList.Controls.Add(btnDelete);
            tbpList.Controls.Add(btnEdit);
            tbpList.Controls.Add(btnSearch);
            tbpList.Controls.Add(dgvBaseAlternativeFlows);
            tbpList.Controls.Add(btnAdd);
            tbpList.Location = new Point(8, 34);
            tbpList.Margin = new Padding(5, 5, 5, 5);
            tbpList.Name = "tbpList";
            tbpList.Padding = new Padding(5, 5, 5, 5);
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
            btnAlternatingFlow.Margin = new Padding(5, 5, 5, 5);
            btnAlternatingFlow.Name = "btnAlternatingFlow";
            btnAlternatingFlow.Size = new Size(231, 53);
            btnAlternatingFlow.TabIndex = 16;
            btnAlternatingFlow.Text = "Flujos Alternos";
            btnAlternatingFlow.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAlternatingFlow.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(tbxSearch);
            panel1.Location = new Point(26, 30);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 50);
            panel1.TabIndex = 15;
            // 
            // tbxSearch
            // 
            tbxSearch.BackColor = Color.Gainsboro;
            tbxSearch.BorderStyle = BorderStyle.None;
            tbxSearch.Location = new Point(18, 5);
            tbxSearch.Margin = new Padding(5, 5, 5, 5);
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
            btnDelete.Margin = new Padding(5, 5, 5, 5);
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
            btnEdit.Margin = new Padding(5, 5, 5, 5);
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
            btnSearch.Margin = new Padding(5, 5, 5, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(171, 53);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Buscar";
            btnSearch.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvBaseAlternativeFlows
            // 
            dgvBaseAlternativeFlows.AllowUserToAddRows = false;
            dgvBaseAlternativeFlows.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.Padding = new Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Control;
            dgvBaseAlternativeFlows.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvBaseAlternativeFlows.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBaseAlternativeFlows.BackgroundColor = Color.WhiteSmoke;
            dgvBaseAlternativeFlows.BorderStyle = BorderStyle.None;
            dgvBaseAlternativeFlows.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBaseAlternativeFlows.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Desktop;
            dataGridViewCellStyle6.Font = new Font("Montserrat SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.Control;
            dataGridViewCellStyle6.Padding = new Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvBaseAlternativeFlows.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvBaseAlternativeFlows.ColumnHeadersHeight = 40;
            dgvBaseAlternativeFlows.Cursor = Cursors.Hand;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.Gainsboro;
            dataGridViewCellStyle7.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvBaseAlternativeFlows.DefaultCellStyle = dataGridViewCellStyle7;
            dgvBaseAlternativeFlows.EnableHeadersVisualStyles = false;
            dgvBaseAlternativeFlows.GridColor = Color.White;
            dgvBaseAlternativeFlows.Location = new Point(26, 104);
            dgvBaseAlternativeFlows.Margin = new Padding(5, 5, 5, 5);
            dgvBaseAlternativeFlows.MultiSelect = false;
            dgvBaseAlternativeFlows.Name = "dgvBaseAlternativeFlows";
            dgvBaseAlternativeFlows.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvBaseAlternativeFlows.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvBaseAlternativeFlows.RowHeadersVisible = false;
            dgvBaseAlternativeFlows.RowHeadersWidth = 20;
            dgvBaseAlternativeFlows.RowTemplate.Height = 40;
            dgvBaseAlternativeFlows.RowTemplate.ReadOnly = true;
            dgvBaseAlternativeFlows.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBaseAlternativeFlows.Size = new Size(1662, 974);
            dgvBaseAlternativeFlows.TabIndex = 10;
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
            btnAdd.Margin = new Padding(5, 5, 5, 5);
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
            tbpAdd.Margin = new Padding(5, 5, 5, 5);
            tbpAdd.Name = "tbpAdd";
            tbpAdd.Padding = new Padding(5, 5, 5, 5);
            tbpAdd.Size = new Size(1708, 1195);
            tbpAdd.TabIndex = 1;
            tbpAdd.Text = "Agregar";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(cmbAlternativeFlow);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(26, 26);
            panel5.Margin = new Padding(5, 5, 5, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(1662, 398);
            panel5.TabIndex = 22;
            // 
            // cmbAlternativeFlow
            // 
            cmbAlternativeFlow.BackColor = Color.Gainsboro;
            cmbAlternativeFlow.FormattingEnabled = true;
            cmbAlternativeFlow.Location = new Point(30, 76);
            cmbAlternativeFlow.Margin = new Padding(5, 5, 5, 5);
            cmbAlternativeFlow.Name = "cmbAlternativeFlow";
            cmbAlternativeFlow.Size = new Size(441, 41);
            cmbAlternativeFlow.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 28);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 33);
            label1.TabIndex = 22;
            label1.Text = "Flujo Alterno";
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
            btnCancel.Margin = new Padding(5, 5, 5, 5);
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
            btnSave.Margin = new Padding(5, 5, 5, 5);
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
            tbxId.Margin = new Padding(5, 5, 5, 5);
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
            btnOut.Margin = new Padding(5, 5, 5, 5);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(50, 45);
            btnOut.SizeMode = PictureBoxSizeMode.Zoom;
            btnOut.TabIndex = 25;
            btnOut.TabStop = false;
            // 
            // BaseAlternativeFlow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1729, 1280);
            Controls.Add(lblUseCases);
            Controls.Add(tbcBaseAlternativeFlows);
            Controls.Add(btnOut);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 5, 5, 5);
            Name = "BaseAlternativeFlow";
            Text = "BaseFlow";
            Load += BaseFlow_Load;
            tbcBaseAlternativeFlows.ResumeLayout(false);
            tbpList.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBaseAlternativeFlows).EndInit();
            tbpAdd.ResumeLayout(false);
            tbpAdd.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUseCases;
        private TabControl tbcBaseAlternativeFlows;
        private TabPage tbpList;
        private Button btnAlternatingFlow;
        private Panel panel1;
        private TextBox tbxSearch;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSearch;
        private DataGridView dgvBaseAlternativeFlows;
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
        private ComboBox cmbAlternativeFlow;
        private Label label1;
        private Panel panel6;
        private TextBox textBox1;
    }
}