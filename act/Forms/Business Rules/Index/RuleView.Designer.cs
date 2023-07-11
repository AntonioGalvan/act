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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            panel5.Location = new Point(14, 12);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(895, 187);
            panel5.TabIndex = 22;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(tbxDescription);
            panel4.Location = new Point(18, 85);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(239, 23);
            panel4.TabIndex = 21;
            // 
            // tbxDescription
            // 
            tbxDescription.BackColor = Color.Gainsboro;
            tbxDescription.BorderStyle = BorderStyle.None;
            tbxDescription.Location = new Point(7, 2);
            tbxDescription.Margin = new Padding(3, 2, 3, 2);
            tbxDescription.Multiline = true;
            tbxDescription.Name = "tbxDescription";
            tbxDescription.Size = new Size(224, 21);
            tbxDescription.TabIndex = 15;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(18, 12);
            lblType.Name = "lblType";
            lblType.Size = new Size(40, 16);
            lblType.TabIndex = 14;
            lblType.Text = "Clave";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(tbxKey);
            panel3.Location = new Point(18, 30);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(98, 23);
            panel3.TabIndex = 20;
            // 
            // tbxKey
            // 
            tbxKey.BackColor = Color.Gainsboro;
            tbxKey.BorderStyle = BorderStyle.None;
            tbxKey.Location = new Point(10, 2);
            tbxKey.Margin = new Padding(3, 2, 3, 2);
            tbxKey.Multiline = true;
            tbxKey.Name = "tbxKey";
            tbxKey.Size = new Size(79, 19);
            tbxKey.TabIndex = 14;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(18, 67);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(79, 16);
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
            btnCancel.Location = new Point(817, 517);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(92, 25);
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
            btnSave.Location = new Point(720, 517);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 25);
            btnSave.TabIndex = 17;
            btnSave.Text = "Guardar";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // tbxId
            // 
            tbxId.Location = new Point(800, 224);
            tbxId.Margin = new Padding(3, 2, 3, 2);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(110, 22);
            tbxId.TabIndex = 11;
            tbxId.Visible = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(890, 208);
            lblId.Name = "lblId";
            lblId.Size = new Size(19, 16);
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
            btnDelete.Location = new Point(817, 517);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 25);
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
            btnEdit.Location = new Point(720, 517);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(92, 25);
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
            btnSearch.Location = new Point(238, 13);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(92, 25);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Buscar";
            btnSearch.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvRules
            // 
            dgvRules.AllowUserToAddRows = false;
            dgvRules.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dgvRules.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRules.BackgroundColor = Color.WhiteSmoke;
            dgvRules.BorderStyle = BorderStyle.None;
            dgvRules.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvRules.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle2.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dataGridViewCellStyle3.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRules.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRules.EnableHeadersVisualStyles = false;
            dgvRules.GridColor = Color.White;
            dgvRules.Location = new Point(14, 49);
            dgvRules.Margin = new Padding(3, 2, 3, 2);
            dgvRules.MultiSelect = false;
            dgvRules.Name = "dgvRules";
            dgvRules.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvRules.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvRules.RowHeadersVisible = false;
            dgvRules.RowHeadersWidth = 20;
            dgvRules.RowTemplate.Height = 35;
            dgvRules.RowTemplate.ReadOnly = true;
            dgvRules.Size = new Size(895, 457);
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
            btnAdd.Location = new Point(817, 14);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 25);
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
            tbxSearch.Location = new Point(10, 2);
            tbxSearch.Margin = new Padding(3, 2, 3, 2);
            tbxSearch.Multiline = true;
            tbxSearch.Name = "tbxSearch";
            tbxSearch.PlaceholderText = "Clave o nombre";
            tbxSearch.Size = new Size(199, 19);
            tbxSearch.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(tbxSearch);
            panel1.Location = new Point(14, 14);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 23);
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
            tbpList.Margin = new Padding(3, 2, 3, 2);
            tbpList.Name = "tbpList";
            tbpList.Padding = new Padding(3, 2, 3, 2);
            tbpList.Size = new Size(920, 546);
            tbpList.TabIndex = 0;
            tbpList.Text = "Listado";
            // 
            // btnOut
            // 
            btnOut.Cursor = Cursors.Hand;
            btnOut.Image = Properties.Resources.close;
            btnOut.Location = new Point(890, 16);
            btnOut.Margin = new Padding(3, 2, 3, 2);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(27, 21);
            btnOut.SizeMode = PictureBoxSizeMode.Zoom;
            btnOut.TabIndex = 19;
            btnOut.TabStop = false;
            // 
            // lblBusinessRules
            // 
            lblBusinessRules.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblBusinessRules.Location = new Point(4, 4);
            lblBusinessRules.Name = "lblBusinessRules";
            lblBusinessRules.Size = new Size(282, 48);
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
            tbpAdd.Margin = new Padding(3, 2, 3, 2);
            tbpAdd.Name = "tbpAdd";
            tbpAdd.Padding = new Padding(3, 2, 3, 2);
            tbpAdd.Size = new Size(920, 546);
            tbpAdd.TabIndex = 1;
            tbpAdd.Text = "Agregar";
            // 
            // tbcRules
            // 
            tbcRules.Controls.Add(tbpList);
            tbcRules.Controls.Add(tbpAdd);
            tbcRules.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbcRules.ItemSize = new Size(66, 26);
            tbcRules.Location = new Point(4, 56);
            tbcRules.Margin = new Padding(4, 4, 4, 4);
            tbcRules.Multiline = true;
            tbcRules.Name = "tbcRules";
            tbcRules.SelectedIndex = 0;
            tbcRules.Size = new Size(928, 580);
            tbcRules.SizeMode = TabSizeMode.FillToRight;
            tbcRules.TabIndex = 18;
            // 
            // RuleView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 639);
            Controls.Add(btnOut);
            Controls.Add(lblBusinessRules);
            Controls.Add(tbcRules);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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