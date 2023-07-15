namespace act.Forms.BaseFlows.Index
{
    partial class BaseFlowsR
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
            btnOut = new PictureBox();
            tbcBFlows = new TabControl();
            tbpList = new TabPage();
            btnDelete = new Button();
            btnEdit = new Button();
            dgvBFlows = new DataGridView();
            btnAdd = new Button();
            tbpAdd = new TabPage();
            panel5 = new Panel();
            btnAddImage = new Button();
            pbxImage = new PictureBox();
            lblName = new Label();
            panel4 = new Panel();
            tbxImage = new TextBox();
            lblType = new Label();
            panel3 = new Panel();
            tbxKey = new TextBox();
            lblDesc = new Label();
            panel2 = new Panel();
            tbxName = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            tbxId = new TextBox();
            lblId = new Label();
            lblRoles = new Label();
            btnReturn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnOut).BeginInit();
            tbcBFlows.SuspendLayout();
            tbpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBFlows).BeginInit();
            tbpAdd.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxImage).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnReturn).BeginInit();
            SuspendLayout();
            // 
            // btnOut
            // 
            btnOut.Cursor = Cursors.Hand;
            btnOut.Image = Properties.Resources.close;
            btnOut.Location = new Point(890, 18);
            btnOut.Margin = new Padding(3, 2, 3, 2);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(27, 21);
            btnOut.SizeMode = PictureBoxSizeMode.Zoom;
            btnOut.TabIndex = 19;
            btnOut.TabStop = false;
            // 
            // tbcBFlows
            // 
            tbcBFlows.Controls.Add(tbpList);
            tbcBFlows.Controls.Add(tbpAdd);
            tbcBFlows.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbcBFlows.ItemSize = new Size(66, 26);
            tbcBFlows.Location = new Point(4, 56);
            tbcBFlows.Margin = new Padding(4);
            tbcBFlows.Multiline = true;
            tbcBFlows.Name = "tbcBFlows";
            tbcBFlows.SelectedIndex = 0;
            tbcBFlows.Size = new Size(928, 544);
            tbcBFlows.SizeMode = TabSizeMode.FillToRight;
            tbcBFlows.TabIndex = 18;
            // 
            // tbpList
            // 
            tbpList.BackColor = Color.WhiteSmoke;
            tbpList.Controls.Add(btnDelete);
            tbpList.Controls.Add(btnEdit);
            tbpList.Controls.Add(dgvBFlows);
            tbpList.Controls.Add(btnAdd);
            tbpList.Location = new Point(4, 30);
            tbpList.Margin = new Padding(3, 2, 3, 2);
            tbpList.Name = "tbpList";
            tbpList.Padding = new Padding(3, 2, 3, 2);
            tbpList.Size = new Size(920, 510);
            tbpList.TabIndex = 0;
            tbpList.Text = "Listado";
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
            btnDelete.Location = new Point(817, 478);
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
            btnEdit.Location = new Point(720, 478);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(92, 25);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Editar";
            btnEdit.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // dgvBFlows
            // 
            dgvBFlows.AllowUserToAddRows = false;
            dgvBFlows.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dgvBFlows.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBFlows.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBFlows.BackgroundColor = Color.WhiteSmoke;
            dgvBFlows.BorderStyle = BorderStyle.None;
            dgvBFlows.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBFlows.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Desktop;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBFlows.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBFlows.ColumnHeadersHeight = 40;
            dgvBFlows.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dataGridViewCellStyle3.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBFlows.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBFlows.EnableHeadersVisualStyles = false;
            dgvBFlows.GridColor = Color.White;
            dgvBFlows.Location = new Point(14, 49);
            dgvBFlows.Margin = new Padding(3, 2, 3, 2);
            dgvBFlows.MultiSelect = false;
            dgvBFlows.Name = "dgvBFlows";
            dgvBFlows.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvBFlows.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvBFlows.RowHeadersVisible = false;
            dgvBFlows.RowHeadersWidth = 20;
            dgvBFlows.RowTemplate.Height = 40;
            dgvBFlows.RowTemplate.ReadOnly = true;
            dgvBFlows.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBFlows.Size = new Size(895, 457);
            dgvBFlows.TabIndex = 10;
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
            tbpAdd.Size = new Size(920, 510);
            tbpAdd.TabIndex = 1;
            tbpAdd.Text = "Agregar";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(btnAddImage);
            panel5.Controls.Add(pbxImage);
            panel5.Controls.Add(lblName);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(lblType);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(lblDesc);
            panel5.Controls.Add(panel2);
            panel5.Location = new Point(14, 12);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(895, 184);
            panel5.TabIndex = 22;
            // 
            // btnAddImage
            // 
            btnAddImage.BackColor = Color.FromArgb(27, 43, 57);
            btnAddImage.Cursor = Cursors.Hand;
            btnAddImage.FlatStyle = FlatStyle.Flat;
            btnAddImage.Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddImage.ForeColor = SystemColors.Control;
            btnAddImage.Image = Properties.Resources.image;
            btnAddImage.Location = new Point(256, 140);
            btnAddImage.Margin = new Padding(3, 2, 3, 2);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(92, 25);
            btnAddImage.TabIndex = 27;
            btnAddImage.Text = "Agregar";
            btnAddImage.TextAlign = ContentAlignment.MiddleLeft;
            btnAddImage.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAddImage.UseVisualStyleBackColor = false;
            // 
            // pbxImage
            // 
            pbxImage.Location = new Point(679, 11);
            pbxImage.Margin = new Padding(3, 2, 3, 2);
            pbxImage.Name = "pbxImage";
            pbxImage.Size = new Size(204, 160);
            pbxImage.TabIndex = 26;
            pbxImage.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 11);
            lblName.Name = "lblName";
            lblName.Size = new Size(58, 16);
            lblName.TabIndex = 12;
            lblName.Text = "Nombre";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(tbxImage);
            panel4.Location = new Point(12, 140);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(239, 23);
            panel4.TabIndex = 21;
            // 
            // tbxImage
            // 
            tbxImage.BackColor = Color.Gainsboro;
            tbxImage.BorderStyle = BorderStyle.None;
            tbxImage.Location = new Point(7, 2);
            tbxImage.Margin = new Padding(3, 2, 3, 2);
            tbxImage.Multiline = true;
            tbxImage.Name = "tbxImage";
            tbxImage.Size = new Size(224, 21);
            tbxImage.TabIndex = 15;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(12, 68);
            lblType.Name = "lblType";
            lblType.Size = new Size(40, 16);
            lblType.TabIndex = 14;
            lblType.Text = "Clave";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(tbxKey);
            panel3.Location = new Point(12, 86);
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
            lblDesc.Location = new Point(12, 122);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(67, 16);
            lblDesc.TabIndex = 15;
            lblDesc.Text = "Propósito";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(tbxName);
            panel2.Location = new Point(12, 33);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 23);
            panel2.TabIndex = 19;
            // 
            // tbxName
            // 
            tbxName.BackColor = Color.Gainsboro;
            tbxName.BorderStyle = BorderStyle.None;
            tbxName.Location = new Point(7, 2);
            tbxName.Margin = new Padding(3, 2, 3, 2);
            tbxName.Multiline = true;
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(224, 19);
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
            btnCancel.Location = new Point(817, 478);
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
            btnSave.Location = new Point(720, 478);
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
            // lblRoles
            // 
            lblRoles.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoles.Location = new Point(42, 3);
            lblRoles.Name = "lblRoles";
            lblRoles.Size = new Size(203, 48);
            lblRoles.TabIndex = 17;
            lblRoles.Text = "Flujo base";
            lblRoles.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnReturn
            // 
            btnReturn.Cursor = Cursors.Hand;
            btnReturn.Image = Properties.Resources.back;
            btnReturn.Location = new Point(10, 19);
            btnReturn.Margin = new Padding(3, 2, 3, 2);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(27, 21);
            btnReturn.SizeMode = PictureBoxSizeMode.Zoom;
            btnReturn.TabIndex = 20;
            btnReturn.TabStop = false;
            // 
            // BaseFlowsR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 600);
            Controls.Add(btnReturn);
            Controls.Add(btnOut);
            Controls.Add(tbcBFlows);
            Controls.Add(lblRoles);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "BaseFlowsR";
            Text = "BaseFlowsR";
            Load += BaseFlowsR_Load;
            ((System.ComponentModel.ISupportInitialize)btnOut).EndInit();
            tbcBFlows.ResumeLayout(false);
            tbpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBFlows).EndInit();
            tbpAdd.ResumeLayout(false);
            tbpAdd.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxImage).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnReturn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btnOut;
        private TabControl tbcBFlows;
        private TabPage tbpList;
        private Button btnDelete;
        private Button btnEdit;
        private DataGridView dgvBFlows;
        private Button btnAdd;
        private TabPage tbpAdd;
        private Panel panel5;
        private Label lblName;
        private Panel panel4;
        private TextBox tbxImage;
        private Label lblType;
        private Panel panel3;
        private TextBox tbxKey;
        private Label lblDesc;
        private Panel panel2;
        private TextBox tbxName;
        private Button btnCancel;
        private Button btnSave;
        private TextBox tbxId;
        private Label lblId;
        private Label lblRoles;
        private Button btnAddImage;
        private PictureBox pbxImage;
        private PictureBox btnReturn;
    }
}