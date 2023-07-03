namespace act.Forms.Relation_Elements
{
    partial class RelationElements
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
            btnCasosUso = new Button();
            btnBaseFlows = new Button();
            SuspendLayout();
            // 
            // btnCasosUso
            // 
            btnCasosUso.BackColor = Color.FromArgb(236, 236, 236);
            btnCasosUso.FlatAppearance.BorderSize = 0;
            btnCasosUso.FlatStyle = FlatStyle.Flat;
            btnCasosUso.Font = new Font("HoloLens MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCasosUso.Location = new Point(99, 76);
            btnCasosUso.Name = "btnCasosUso";
            btnCasosUso.Size = new Size(346, 115);
            btnCasosUso.TabIndex = 17;
            btnCasosUso.Text = "Casos de uso";
            btnCasosUso.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCasosUso.UseVisualStyleBackColor = false;
            // 
            // btnBaseFlows
            // 
            btnBaseFlows.BackColor = Color.FromArgb(236, 236, 236);
            btnBaseFlows.FlatAppearance.BorderSize = 0;
            btnBaseFlows.FlatStyle = FlatStyle.Flat;
            btnBaseFlows.Font = new Font("HoloLens MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaseFlows.Location = new Point(603, 76);
            btnBaseFlows.Name = "btnBaseFlows";
            btnBaseFlows.Size = new Size(346, 115);
            btnBaseFlows.TabIndex = 18;
            btnBaseFlows.Text = "Flujos Base";
            btnBaseFlows.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBaseFlows.UseVisualStyleBackColor = false;
            // 
            // RelationElements
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1068, 658);
            Controls.Add(btnBaseFlows);
            Controls.Add(btnCasosUso);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RelationElements";
            Text = "RelationElements";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCasosUso;
        private Button btnBaseFlows;
    }
}