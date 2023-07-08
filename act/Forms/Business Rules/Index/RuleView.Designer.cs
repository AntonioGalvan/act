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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel5 = new Panel();
            panel4 = new Panel();
            tbxDescription = new TextBox();
            lblType = new Label();
            panel3 = new Panel();
            tbxKey = new TextBox();
            lblDesc = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            tbxId = new TextBox();
            lblId = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSearch = new Button();
            dgvRules = new DataGridView();
            btnAdd = new Button();
            tbxSearch = new TextBox();
            panel1 = new Panel();
            tbpList = new TabPage();
            btnOut = new PictureBox();
            lblBusinessRules = new Label();
            tbpAdd = new TabPage();
            tbcRules = new TabControl();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRules).BeginInit();
            panel1.SuspendLayout();
            tbpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnOut).BeginInit();
            tbpAdd.SuspendLayout();
            tbcRules.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(lblType);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(lblDesc);
            panel5.Location = new Point(16, 16);
            panel5.Name = "panel5";
            panel5.Size = new Size(1023, 249);
            panel5.TabIndex = 22;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(tbxDescription);
            panel4.Location = new Point(20, 113);
            panel4.Name = "panel4";
            panel4.Size = new Size(273, 31);
            panel4.TabIndex = 21;
            // 
            // tbxDescription
            // 
            tbxDescription.BackColor = Color.Gainsboro;
            tbxDescription.BorderStyle = BorderStyle.None;
            tbxDescription.Location = new Point(8, 3);
            tbxDescription.Multiline = true;
            tbxDescription.Name = "tbxDescription";
            tbxDescription.Size = new Size(256, 28);
            tbxDescription.TabIndex = 15;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(20, 16);
            lblType.Name = "lblType";
            lblType.Size = new Size(51, 21);
            lblType.TabIndex = 14;
            lblType.Text = "Clave";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(tbxKey);
            panel3.Location = new Point(20, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(112, 31);
            panel3.TabIndex = 20;
            // 
            // tbxKey
            // 
            tbxKey.BackColor = Color.Gainsboro;
            tbxKey.BorderStyle = BorderStyle.None;
            tbxKey.Location = new Point(12, 3);
            tbxKey.Multiline = true;
            tbxKey.Name = "tbxKey";
            tbxKey.Size = new Size(90, 25);
            tbxKey.TabIndex = 14;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(20, 89);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(97, 21);
            lblDesc.TabIndex = 15;
            lblDesc.Text = "Descripción";
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
            tbxId.Location = new Point(914, 298);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(125, 26);
            tbxId.TabIndex = 11;
            tbxId.Visible = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(1017, 277);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 21);
            lblId.TabIndex = 10;
            lblId.Text = "Id";
            lblId.Visible = false;
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
            btnDelete.Location = new Point(934, 689);
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
            btnEdit.Location = new Point(823, 689);
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
            // dgvRules
            // 
            dgvRules.AllowUserToAddRows = false;
            dgvRules.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.Padding = new Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Control;
            dgvRules.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvRules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRules.BackgroundColor = Color.WhiteSmoke;
            dgvRules.BorderStyle = BorderStyle.None;
            dgvRules.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvRules.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle6.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.Control;
            dataGridViewCellStyle6.Padding = new Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvRules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvRules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.Gainsboro;
            dataGridViewCellStyle7.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvRules.DefaultCellStyle = dataGridViewCellStyle7;
            dgvRules.EnableHeadersVisualStyles = false;
            dgvRules.GridColor = Color.White;
            dgvRules.Location = new Point(16, 65);
            dgvRules.MultiSelect = false;
            dgvRules.Name = "dgvRules";
            dgvRules.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvRules.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvRules.RowHeadersVisible = false;
            dgvRules.RowHeadersWidth = 20;
            dgvRules.RowTemplate.Height = 35;
            dgvRules.RowTemplate.ReadOnly = true;
            dgvRules.Size = new Size(1023, 609);
            dgvRules.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(27, 43, 57);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Image = Properties.Resources.add;
            btnAdd.Location = new Point(934, 18);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 33);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Agregar";
            btnAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnAdd.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // tbxSearch
            // 
            tbxSearch.BackColor = Color.Gainsboro;
            tbxSearch.BorderStyle = BorderStyle.None;
            tbxSearch.Location = new Point(12, 3);
            tbxSearch.Multiline = true;
            tbxSearch.Name = "tbxSearch";
            tbxSearch.PlaceholderText = "Clave o nombre";
            tbxSearch.Size = new Size(227, 25);
            tbxSearch.TabIndex = 7;
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
            // tbpList
            // 
            tbpList.BackColor = Color.WhiteSmoke;
            tbpList.Controls.Add(panel1);
            tbpList.Controls.Add(btnDelete);
            tbpList.Controls.Add(btnEdit);
            tbpList.Controls.Add(btnSearch);
            tbpList.Controls.Add(dgvRules);
            tbpList.Controls.Add(btnAdd);
            tbpList.Location = new Point(4, 30);
            tbpList.Name = "tbpList";
            tbpList.Padding = new Padding(3);
            tbpList.Size = new Size(1053, 739);
            tbpList.TabIndex = 0;
            tbpList.Text = "Listado";
            // 
            // btnOut
            // 
            btnOut.Cursor = Cursors.Hand;
            btnOut.Image = Properties.Resources.close;
            btnOut.Location = new Point(1017, 21);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(31, 28);
            btnOut.SizeMode = PictureBoxSizeMode.Zoom;
            btnOut.TabIndex = 19;
            btnOut.TabStop = false;
            // 
            // lblBusinessRules
            // 
            lblBusinessRules.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblBusinessRules.Location = new Point(4, 5);
            lblBusinessRules.Name = "lblBusinessRules";
            lblBusinessRules.Size = new Size(322, 64);
            lblBusinessRules.TabIndex = 17;
            lblBusinessRules.Text = "Reglas de Negocio";
            lblBusinessRules.TextAlign = ContentAlignment.MiddleLeft;
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
            // tbcRules
            // 
            tbcRules.Controls.Add(tbpList);
            tbcRules.Controls.Add(tbpAdd);
            tbcRules.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbcRules.ItemSize = new Size(66, 26);
            tbcRules.Location = new Point(4, 74);
            tbcRules.Margin = new Padding(5);
            tbcRules.Multiline = true;
            tbcRules.Name = "tbcRules";
            tbcRules.SelectedIndex = 0;
            tbcRules.Size = new Size(1061, 773);
            tbcRules.SizeMode = TabSizeMode.FillToRight;
            tbcRules.TabIndex = 18;
            // 
            // RuleView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 853);
            Controls.Add(btnOut);
            Controls.Add(lblBusinessRules);
            Controls.Add(tbcRules);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RuleView";
            Text = "RuleIndex";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRules).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tbpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnOut).EndInit();
            tbpAdd.ResumeLayout(false);
            tbpAdd.PerformLayout();
            tbcRules.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Panel panel4;
        private TextBox tbxDescription;
        private Label lblType;
        private Panel panel3;
        private TextBox tbxKey;
        private Label lblDesc;
        private Button btnCancel;
        private Button btnSave;
        private TextBox tbxId;
        private Label lblId;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSearch;
        private DataGridView dgvRules;
        private Button btnAdd;
        private TextBox tbxSearch;
        private Panel panel1;
        private TabPage tbpList;
        private PictureBox btnOut;
        private Label lblBusinessRules;
        private TabPage tbpAdd;
        private TabControl tbcRules;
    }
}