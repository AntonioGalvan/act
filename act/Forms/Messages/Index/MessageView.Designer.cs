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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            btnOut = new PictureBox();
            btnCancel = new Button();
            btnSave = new Button();
            tbxId = new TextBox();
            tbxKey = new TextBox();
            tbxDescription = new TextBox();
            panel5 = new Panel();
            panel4 = new Panel();
            lblType = new Label();
            panel3 = new Panel();
            lblDesc = new Label();
            lblId = new Label();
            tbpAdd = new TabPage();
            btnSearch = new Button();
            dgvMessages = new DataGridView();
            btnEdit = new Button();
            btnDelete = new Button();
            tbxSearch = new TextBox();
            panel1 = new Panel();
            tbpList = new TabPage();
            btnAdd = new Button();
            tbcMessages = new TabControl();
            lblMessages = new Label();
            ((System.ComponentModel.ISupportInitialize)btnOut).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tbpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMessages).BeginInit();
            panel1.SuspendLayout();
            tbpList.SuspendLayout();
            tbcMessages.SuspendLayout();
            SuspendLayout();
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
            panel4.Location = new Point(18, 116);
            panel4.Name = "panel4";
            panel4.Size = new Size(273, 31);
            panel4.TabIndex = 21;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(18, 19);
            lblType.Name = "lblType";
            lblType.Size = new Size(51, 21);
            lblType.TabIndex = 14;
            lblType.Text = "Clave";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(tbxKey);
            panel3.Location = new Point(18, 43);
            panel3.Name = "panel3";
            panel3.Size = new Size(112, 31);
            panel3.TabIndex = 20;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(18, 92);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(97, 21);
            lblDesc.TabIndex = 15;
            lblDesc.Text = "Descripción";
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
            // dgvMessages
            // 
            dgvMessages.AllowUserToAddRows = false;
            dgvMessages.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.Padding = new Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Control;
            dgvMessages.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvMessages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMessages.BackgroundColor = Color.WhiteSmoke;
            dgvMessages.BorderStyle = BorderStyle.None;
            dgvMessages.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvMessages.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle6.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.Control;
            dataGridViewCellStyle6.Padding = new Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvMessages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvMessages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.Gainsboro;
            dataGridViewCellStyle7.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvMessages.DefaultCellStyle = dataGridViewCellStyle7;
            dgvMessages.EnableHeadersVisualStyles = false;
            dgvMessages.GridColor = Color.White;
            dgvMessages.Location = new Point(16, 65);
            dgvMessages.MultiSelect = false;
            dgvMessages.Name = "dgvMessages";
            dgvMessages.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvMessages.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvMessages.RowHeadersVisible = false;
            dgvMessages.RowHeadersWidth = 20;
            dgvMessages.RowTemplate.Height = 35;
            dgvMessages.RowTemplate.ReadOnly = true;
            dgvMessages.Size = new Size(1023, 609);
            dgvMessages.TabIndex = 10;
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
            tbpList.Controls.Add(dgvMessages);
            tbpList.Controls.Add(btnAdd);
            tbpList.Location = new Point(4, 30);
            tbpList.Name = "tbpList";
            tbpList.Padding = new Padding(3);
            tbpList.Size = new Size(1053, 739);
            tbpList.TabIndex = 0;
            tbpList.Text = "Listado";
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
            // tbcMessages
            // 
            tbcMessages.Controls.Add(tbpList);
            tbcMessages.Controls.Add(tbpAdd);
            tbcMessages.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbcMessages.ItemSize = new Size(66, 26);
            tbcMessages.Location = new Point(4, 74);
            tbcMessages.Margin = new Padding(5);
            tbcMessages.Multiline = true;
            tbcMessages.Name = "tbcMessages";
            tbcMessages.SelectedIndex = 0;
            tbcMessages.Size = new Size(1061, 773);
            tbcMessages.SizeMode = TabSizeMode.FillToRight;
            tbcMessages.TabIndex = 18;
            // 
            // lblMessages
            // 
            lblMessages.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblMessages.Location = new Point(4, 5);
            lblMessages.Name = "lblMessages";
            lblMessages.Size = new Size(197, 64);
            lblMessages.TabIndex = 17;
            lblMessages.Text = "Mensajes";
            lblMessages.TextAlign = ContentAlignment.MiddleLeft;
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
            Text = "MessageView";
            ((System.ComponentModel.ISupportInitialize)btnOut).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tbpAdd.ResumeLayout(false);
            tbpAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMessages).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tbpList.ResumeLayout(false);
            tbcMessages.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btnOut;
        private Button btnCancel;
        private Button btnSave;
        private TextBox tbxId;
        private TextBox tbxKey;
        private TextBox tbxDescription;
        private Panel panel5;
        private Panel panel4;
        private Label lblType;
        private Panel panel3;
        private Label lblDesc;
        private Label lblId;
        private TabPage tbpAdd;
        private Button btnSearch;
        private DataGridView dgvMessages;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox tbxSearch;
        private Panel panel1;
        private TabPage tbpList;
        private Button btnAdd;
        private TabControl tbcMessages;
        private Label lblMessages;
    }
}