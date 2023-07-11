namespace act.Forms.UseCases.Index
{
    partial class UseCaseView
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
            btnAdd = new Button();
            tbpList = new TabPage();
            btnBaseFlow = new Button();
            panel1 = new Panel();
            tbxSearch = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSearch = new Button();
            dgvRoles = new DataGridView();
            lblName = new Label();
            lblType = new Label();
            panel3 = new Panel();
            tbxKey = new TextBox();
            tbpAdd = new TabPage();
            panel5 = new Panel();
            panel4 = new Panel();
            tbxFlowChartPath = new TextBox();
            lblUseCaseP = new Label();
            panel2 = new Panel();
            tbxName = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            tbxId = new TextBox();
            lblId = new Label();
            tbcUseCases = new TabControl();
            btnOut = new PictureBox();
            tbpList.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            panel3.SuspendLayout();
            tbpAdd.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            tbcUseCases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnOut).BeginInit();
            SuspendLayout();
            // 
            // lblUseCases
            // 
            lblUseCases.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblUseCases.Location = new Point(4, 4);
            lblUseCases.Name = "lblUseCases";
            lblUseCases.Size = new Size(333, 48);
            lblUseCases.TabIndex = 20;
            lblUseCases.Text = "Casos de uso";
            lblUseCases.TextAlign = ContentAlignment.MiddleLeft;
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
            // tbpList
            // 
            tbpList.BackColor = Color.WhiteSmoke;
            tbpList.Controls.Add(btnBaseFlow);
            tbpList.Controls.Add(panel1);
            tbpList.Controls.Add(btnDelete);
            tbpList.Controls.Add(btnEdit);
            tbpList.Controls.Add(btnSearch);
            tbpList.Controls.Add(dgvRoles);
            tbpList.Controls.Add(btnAdd);
            tbpList.Location = new Point(4, 30);
            tbpList.Margin = new Padding(3, 2, 3, 2);
            tbpList.Name = "tbpList";
            tbpList.Padding = new Padding(3, 2, 3, 2);
            tbpList.Size = new Size(920, 546);
            tbpList.TabIndex = 0;
            tbpList.Text = "Listado";
            // 
            // btnBaseFlow
            // 
            btnBaseFlow.BackColor = Color.FromArgb(27, 43, 57);
            btnBaseFlow.Cursor = Cursors.Hand;
            btnBaseFlow.FlatStyle = FlatStyle.Flat;
            btnBaseFlow.Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBaseFlow.ForeColor = SystemColors.Control;
            btnBaseFlow.ImageAlign = ContentAlignment.MiddleLeft;
            btnBaseFlow.Location = new Point(623, 517);
            btnBaseFlow.Margin = new Padding(3, 2, 3, 2);
            btnBaseFlow.Name = "btnBaseFlow";
            btnBaseFlow.Size = new Size(92, 25);
            btnBaseFlow.TabIndex = 16;
            btnBaseFlow.Text = "Flujo Base";
            btnBaseFlow.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnBaseFlow.UseVisualStyleBackColor = false;
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
            // dgvRoles
            // 
            dgvRoles.AllowUserToAddRows = false;
            dgvRoles.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dgvRoles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoles.BackgroundColor = Color.WhiteSmoke;
            dgvRoles.BorderStyle = BorderStyle.None;
            dgvRoles.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvRoles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle2.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dataGridViewCellStyle3.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(27, 43, 57);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRoles.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRoles.EnableHeadersVisualStyles = false;
            dgvRoles.GridColor = Color.White;
            dgvRoles.Location = new Point(14, 49);
            dgvRoles.Margin = new Padding(3, 2, 3, 2);
            dgvRoles.MultiSelect = false;
            dgvRoles.Name = "dgvRoles";
            dgvRoles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvRoles.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvRoles.RowHeadersVisible = false;
            dgvRoles.RowHeadersWidth = 20;
            dgvRoles.RowTemplate.Height = 35;
            dgvRoles.RowTemplate.ReadOnly = true;
            dgvRoles.Size = new Size(895, 457);
            dgvRoles.TabIndex = 10;
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
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(lblUseCaseP);
            panel5.Controls.Add(lblName);
            panel5.Controls.Add(lblType);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(panel2);
            panel5.Location = new Point(14, 12);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(895, 187);
            panel5.TabIndex = 22;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(tbxFlowChartPath);
            panel4.Location = new Point(12, 142);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(239, 23);
            panel4.TabIndex = 20;
            // 
            // tbxFlowChartPath
            // 
            tbxFlowChartPath.BackColor = Color.Gainsboro;
            tbxFlowChartPath.BorderStyle = BorderStyle.None;
            tbxFlowChartPath.Location = new Point(7, 2);
            tbxFlowChartPath.Margin = new Padding(3, 2, 3, 2);
            tbxFlowChartPath.Multiline = true;
            tbxFlowChartPath.Name = "tbxFlowChartPath";
            tbxFlowChartPath.Size = new Size(224, 19);
            tbxFlowChartPath.TabIndex = 13;
            // 
            // lblUseCaseP
            // 
            lblUseCaseP.AutoSize = true;
            lblUseCaseP.Location = new Point(12, 118);
            lblUseCaseP.Name = "lblUseCaseP";
            lblUseCaseP.Size = new Size(82, 16);
            lblUseCaseP.TabIndex = 21;
            lblUseCaseP.Text = "Caso de Uso";
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
            lblId.Location = new Point(892, 210);
            lblId.Name = "lblId";
            lblId.Size = new Size(19, 16);
            lblId.TabIndex = 10;
            lblId.Text = "Id";
            lblId.Visible = false;
            // 
            // tbcUseCases
            // 
            tbcUseCases.Controls.Add(tbpList);
            tbcUseCases.Controls.Add(tbpAdd);
            tbcUseCases.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbcUseCases.ItemSize = new Size(66, 26);
            tbcUseCases.Location = new Point(4, 56);
            tbcUseCases.Margin = new Padding(4);
            tbcUseCases.Multiline = true;
            tbcUseCases.Name = "tbcUseCases";
            tbcUseCases.SelectedIndex = 0;
            tbcUseCases.Size = new Size(928, 580);
            tbcUseCases.SizeMode = TabSizeMode.FillToRight;
            tbcUseCases.TabIndex = 21;
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
            btnOut.TabIndex = 22;
            btnOut.TabStop = false;
            // 
            // UseCaseView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 639);
            Controls.Add(lblUseCases);
            Controls.Add(tbcUseCases);
            Controls.Add(btnOut);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UseCaseView";
            Text = "UseCaseView";
            tbpList.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tbpAdd.ResumeLayout(false);
            tbpAdd.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tbcUseCases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUseCases;
        private Button btnAdd;
        private TabPage tbpList;
        private Panel panel1;
        private TextBox tbxSearch;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSearch;
        private DataGridView dgvRoles;
        private Label lblName;
        private Label lblType;
        private Panel panel3;
        private TextBox tbxKey;
        private TabPage tbpAdd;
        private Panel panel5;
        private Panel panel2;
        private TextBox tbxName;
        private Button btnCancel;
        private Button btnSave;
        private TextBox tbxId;
        private Label lblId;
        private TabControl tbcUseCases;
        private PictureBox btnOut;
        private Label lblUseCaseP;
        private Panel panel4;
        private TextBox tbxFlowChartPath;
        private Button btnBaseFlow;
    }
}