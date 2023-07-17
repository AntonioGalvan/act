﻿namespace act.Forms.Side_bar
{
    partial class SideBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SideBar));
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            btnElementosR = new Button();
            btnRoles = new Button();
            btnInicio = new Button();
            btnSalir = new Button();
            pnlExit = new Panel();
            pnlSideBar = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox6 = new PictureBox();
            lblRn = new Label();
            btnBusinessRules = new Button();
            lblMessages = new Label();
            btnMessages = new Button();
            pnlRelationEContainer = new Panel();
            lblPantalla = new Label();
            lblscreens = new Label();
            btnScreens = new Button();
            lblRnMs = new Label();
            lblStateChanges = new Label();
            btnStateChanges = new Button();
            lblStates = new Label();
            lblStatesbtn = new Label();
            btnStates = new Button();
            lblObjects = new Label();
            btnObjects = new Button();
            label4 = new Label();
            lblObjectTypes = new Label();
            btnObjectTypes = new Button();
            lblAlternativeFlows = new Label();
            btnAlternateFlows = new Button();
            lblBaseFlows = new Label();
            btnBaseFlows = new Button();
            lblCu = new Label();
            lblUseCases = new Label();
            btnCUs = new Button();
            pnlExit.SuspendLayout();
            pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            pnlRelationEContainer.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(24, 40, 54);
            label1.Font = new Font("Montserrat SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(116, 33);
            label1.Name = "label1";
            label1.Size = new Size(73, 32);
            label1.TabIndex = 19;
            label1.Text = "ACT";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 40, 54);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Image = Properties.Resources.reportes;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 302);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Padding = new Padding(18, 0, 0, 0);
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(304, 44);
            button1.TabIndex = 18;
            button1.Text = "  Informes de correspondencia";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(24, 40, 54);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Image = Properties.Resources.venn2;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 253);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Padding = new Padding(18, 0, 0, 0);
            button3.Size = new Size(304, 44);
            button3.TabIndex = 17;
            button3.Text = "  Tabla de Correspondencia";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            // 
            // btnElementosR
            // 
            btnElementosR.BackColor = Color.FromArgb(24, 40, 54);
            btnElementosR.Cursor = Cursors.Hand;
            btnElementosR.FlatAppearance.BorderSize = 0;
            btnElementosR.FlatStyle = FlatStyle.Flat;
            btnElementosR.Font = new Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnElementosR.ForeColor = SystemColors.Control;
            btnElementosR.Image = Properties.Resources.docs;
            btnElementosR.ImageAlign = ContentAlignment.MiddleLeft;
            btnElementosR.Location = new Point(0, 204);
            btnElementosR.Margin = new Padding(3, 2, 3, 2);
            btnElementosR.Name = "btnElementosR";
            btnElementosR.Padding = new Padding(18, 0, 0, 0);
            btnElementosR.Size = new Size(304, 44);
            btnElementosR.TabIndex = 16;
            btnElementosR.Text = "  Elementos a Relacionar";
            btnElementosR.TextAlign = ContentAlignment.MiddleLeft;
            btnElementosR.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnElementosR.UseVisualStyleBackColor = false;
            btnElementosR.Click += btnElementosR_Click;
            // 
            // btnRoles
            // 
            btnRoles.BackColor = Color.FromArgb(24, 40, 54);
            btnRoles.Cursor = Cursors.Hand;
            btnRoles.FlatAppearance.BorderSize = 0;
            btnRoles.FlatStyle = FlatStyle.Flat;
            btnRoles.Font = new Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRoles.ForeColor = SystemColors.Control;
            btnRoles.Image = Properties.Resources.roles;
            btnRoles.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoles.Location = new Point(0, 155);
            btnRoles.Margin = new Padding(3, 2, 3, 2);
            btnRoles.Name = "btnRoles";
            btnRoles.Padding = new Padding(18, 0, 0, 0);
            btnRoles.Size = new Size(304, 44);
            btnRoles.TabIndex = 15;
            btnRoles.Text = "  Roles";
            btnRoles.TextAlign = ContentAlignment.MiddleLeft;
            btnRoles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRoles.UseVisualStyleBackColor = false;
            btnRoles.Click += btnRoles_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(24, 40, 54);
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicio.ForeColor = SystemColors.Control;
            btnInicio.Image = Properties.Resources.hogar;
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(0, 109);
            btnInicio.Margin = new Padding(3, 2, 3, 2);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(18, 0, 0, 0);
            btnInicio.Size = new Size(304, 44);
            btnInicio.TabIndex = 13;
            btnInicio.Text = "  Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(27, 43, 57);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.Control;
            btnSalir.Image = Properties.Resources.logout;
            btnSalir.Location = new Point(184, 14);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 38);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pnlExit
            // 
            pnlExit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlExit.BackColor = Color.FromArgb(20, 35, 50);
            pnlExit.Controls.Add(btnSalir);
            pnlExit.Dock = DockStyle.Bottom;
            pnlExit.Location = new Point(0, 526);
            pnlExit.Margin = new Padding(3, 2, 3, 2);
            pnlExit.Name = "pnlExit";
            pnlExit.Size = new Size(304, 65);
            pnlExit.TabIndex = 14;
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.FromArgb(24, 40, 54);
            pnlSideBar.Controls.Add(label1);
            pnlSideBar.Controls.Add(button1);
            pnlSideBar.Controls.Add(pictureBox1);
            pnlSideBar.Controls.Add(button3);
            pnlSideBar.Controls.Add(pnlExit);
            pnlSideBar.Controls.Add(btnElementosR);
            pnlSideBar.Controls.Add(btnRoles);
            pnlSideBar.Controls.Add(pictureBox6);
            pnlSideBar.Controls.Add(btnInicio);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(0, 0);
            pnlSideBar.Margin = new Padding(3, 2, 3, 2);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(304, 591);
            pnlSideBar.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.correcto2;
            pictureBox1.Location = new Point(146, 3);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 46);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.correcto;
            pictureBox6.Location = new Point(107, 46);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(63, 46);
            pictureBox6.TabIndex = 42;
            pictureBox6.TabStop = false;
            // 
            // lblRn
            // 
            lblRn.AutoSize = true;
            lblRn.Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblRn.Location = new Point(482, 333);
            lblRn.Name = "lblRn";
            lblRn.Size = new Size(117, 16);
            lblRn.TabIndex = 40;
            lblRn.Text = "Reglas de negocio";
            // 
            // btnBusinessRules
            // 
            btnBusinessRules.BackColor = Color.FromArgb(236, 236, 236);
            btnBusinessRules.BackgroundImage = (Image)resources.GetObject("btnBusinessRules.BackgroundImage");
            btnBusinessRules.BackgroundImageLayout = ImageLayout.Center;
            btnBusinessRules.Cursor = Cursors.Hand;
            btnBusinessRules.FlatAppearance.BorderSize = 0;
            btnBusinessRules.FlatStyle = FlatStyle.Flat;
            btnBusinessRules.Font = new Font("HoloLens MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBusinessRules.Location = new Point(494, 268);
            btnBusinessRules.Margin = new Padding(3, 2, 3, 2);
            btnBusinessRules.Name = "btnBusinessRules";
            btnBusinessRules.Size = new Size(102, 60);
            btnBusinessRules.TabIndex = 39;
            btnBusinessRules.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBusinessRules.UseVisualStyleBackColor = false;
            btnBusinessRules.Click += btnBusinessRules_Click;
            // 
            // lblMessages
            // 
            lblMessages.AutoSize = true;
            lblMessages.Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessages.Location = new Point(665, 333);
            lblMessages.Name = "lblMessages";
            lblMessages.Size = new Size(62, 16);
            lblMessages.TabIndex = 42;
            lblMessages.Text = "Mensajes";
            // 
            // btnMessages
            // 
            btnMessages.BackColor = Color.FromArgb(236, 236, 236);
            btnMessages.BackgroundImage = (Image)resources.GetObject("btnMessages.BackgroundImage");
            btnMessages.BackgroundImageLayout = ImageLayout.Center;
            btnMessages.Cursor = Cursors.Hand;
            btnMessages.FlatAppearance.BorderSize = 0;
            btnMessages.FlatStyle = FlatStyle.Flat;
            btnMessages.Font = new Font("HoloLens MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMessages.Location = new Point(648, 268);
            btnMessages.Margin = new Padding(3, 2, 3, 2);
            btnMessages.Name = "btnMessages";
            btnMessages.Size = new Size(102, 60);
            btnMessages.TabIndex = 41;
            btnMessages.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMessages.UseVisualStyleBackColor = false;
            btnMessages.Click += btnMessages_Click;
            // 
            // pnlRelationEContainer
            // 
            pnlRelationEContainer.BackColor = Color.White;
            pnlRelationEContainer.Controls.Add(lblPantalla);
            pnlRelationEContainer.Controls.Add(lblscreens);
            pnlRelationEContainer.Controls.Add(btnScreens);
            pnlRelationEContainer.Controls.Add(lblMessages);
            pnlRelationEContainer.Controls.Add(btnMessages);
            pnlRelationEContainer.Controls.Add(lblRnMs);
            pnlRelationEContainer.Controls.Add(lblStateChanges);
            pnlRelationEContainer.Controls.Add(btnStateChanges);
            pnlRelationEContainer.Controls.Add(lblStates);
            pnlRelationEContainer.Controls.Add(lblRn);
            pnlRelationEContainer.Controls.Add(lblStatesbtn);
            pnlRelationEContainer.Controls.Add(btnStates);
            pnlRelationEContainer.Controls.Add(btnBusinessRules);
            pnlRelationEContainer.Controls.Add(lblObjects);
            pnlRelationEContainer.Controls.Add(btnObjects);
            pnlRelationEContainer.Controls.Add(label4);
            pnlRelationEContainer.Controls.Add(lblObjectTypes);
            pnlRelationEContainer.Controls.Add(btnObjectTypes);
            pnlRelationEContainer.Controls.Add(lblAlternativeFlows);
            pnlRelationEContainer.Controls.Add(btnAlternateFlows);
            pnlRelationEContainer.Controls.Add(lblBaseFlows);
            pnlRelationEContainer.Controls.Add(btnBaseFlows);
            pnlRelationEContainer.Controls.Add(lblCu);
            pnlRelationEContainer.Controls.Add(lblUseCases);
            pnlRelationEContainer.Controls.Add(btnCUs);
            pnlRelationEContainer.Dock = DockStyle.Fill;
            pnlRelationEContainer.Location = new Point(304, 0);
            pnlRelationEContainer.Margin = new Padding(3, 2, 3, 2);
            pnlRelationEContainer.Name = "pnlRelationEContainer";
            pnlRelationEContainer.Size = new Size(940, 591);
            pnlRelationEContainer.TabIndex = 28;
            // 
            // lblPantalla
            // 
            lblPantalla.Font = new Font("Montserrat", 13.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            lblPantalla.Location = new Point(37, 382);
            lblPantalla.Name = "lblPantalla";
            lblPantalla.Size = new Size(102, 34);
            lblPantalla.TabIndex = 45;
            lblPantalla.Text = "Pantallas";
            lblPantalla.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblscreens
            // 
            lblscreens.AutoSize = true;
            lblscreens.Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblscreens.Location = new Point(52, 509);
            lblscreens.Name = "lblscreens";
            lblscreens.Size = new Size(62, 16);
            lblscreens.TabIndex = 44;
            lblscreens.Text = "Pantallas";
            // 
            // btnScreens
            // 
            btnScreens.BackColor = Color.FromArgb(236, 236, 236);
            btnScreens.BackgroundImage = (Image)resources.GetObject("btnScreens.BackgroundImage");
            btnScreens.BackgroundImageLayout = ImageLayout.Center;
            btnScreens.Cursor = Cursors.Hand;
            btnScreens.FlatAppearance.BorderSize = 0;
            btnScreens.FlatStyle = FlatStyle.Flat;
            btnScreens.Font = new Font("HoloLens MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnScreens.Location = new Point(37, 432);
            btnScreens.Name = "btnScreens";
            btnScreens.Size = new Size(102, 74);
            btnScreens.TabIndex = 43;
            btnScreens.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnScreens.UseVisualStyleBackColor = false;
            btnScreens.Click += btnScreens_Click;
            // 
            // lblRnMs
            // 
            lblRnMs.Font = new Font("Montserrat", 13.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            lblRnMs.Location = new Point(485, 216);
            lblRnMs.Name = "lblRnMs";
            lblRnMs.Size = new Size(319, 34);
            lblRnMs.TabIndex = 38;
            lblRnMs.Text = "Reglas de negocio y Mensajes";
            lblRnMs.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStateChanges
            // 
            lblStateChanges.AutoSize = true;
            lblStateChanges.Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblStateChanges.Location = new Point(169, 332);
            lblStateChanges.Name = "lblStateChanges";
            lblStateChanges.Size = new Size(123, 16);
            lblStateChanges.TabIndex = 37;
            lblStateChanges.Text = "Cambios de estado";
            // 
            // btnStateChanges
            // 
            btnStateChanges.BackColor = Color.FromArgb(236, 236, 236);
            btnStateChanges.BackgroundImage = (Image)resources.GetObject("btnStateChanges.BackgroundImage");
            btnStateChanges.BackgroundImageLayout = ImageLayout.Center;
            btnStateChanges.Cursor = Cursors.Hand;
            btnStateChanges.FlatAppearance.BorderSize = 0;
            btnStateChanges.FlatStyle = FlatStyle.Flat;
            btnStateChanges.Font = new Font("HoloLens MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStateChanges.Location = new Point(187, 268);
            btnStateChanges.Margin = new Padding(3, 2, 3, 2);
            btnStateChanges.Name = "btnStateChanges";
            btnStateChanges.Size = new Size(102, 60);
            btnStateChanges.TabIndex = 36;
            btnStateChanges.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStateChanges.UseVisualStyleBackColor = false;
            // 
            // lblStates
            // 
            lblStates.Font = new Font("Montserrat", 13.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            lblStates.Location = new Point(37, 215);
            lblStates.Name = "lblStates";
            lblStates.Size = new Size(92, 34);
            lblStates.TabIndex = 35;
            lblStates.Text = "Estados";
            lblStates.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatesbtn
            // 
            lblStatesbtn.AutoSize = true;
            lblStatesbtn.Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatesbtn.Location = new Point(59, 332);
            lblStatesbtn.Name = "lblStatesbtn";
            lblStatesbtn.Size = new Size(55, 16);
            lblStatesbtn.TabIndex = 34;
            lblStatesbtn.Text = "Estados";
            // 
            // btnStates
            // 
            btnStates.BackColor = Color.FromArgb(236, 236, 236);
            btnStates.BackgroundImage = (Image)resources.GetObject("btnStates.BackgroundImage");
            btnStates.BackgroundImageLayout = ImageLayout.Center;
            btnStates.Cursor = Cursors.Hand;
            btnStates.FlatAppearance.BorderSize = 0;
            btnStates.FlatStyle = FlatStyle.Flat;
            btnStates.Font = new Font("HoloLens MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStates.Location = new Point(37, 268);
            btnStates.Margin = new Padding(3, 2, 3, 2);
            btnStates.Name = "btnStates";
            btnStates.Size = new Size(102, 60);
            btnStates.TabIndex = 33;
            btnStates.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStates.UseVisualStyleBackColor = false;
            btnStates.Click += btnStates_Click;
            // 
            // lblObjects
            // 
            lblObjects.Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblObjects.Location = new Point(665, 158);
            lblObjects.Name = "lblObjects";
            lblObjects.Size = new Size(78, 15);
            lblObjects.TabIndex = 30;
            lblObjects.Text = "Objetos";
            lblObjects.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnObjects
            // 
            btnObjects.BackColor = Color.FromArgb(236, 236, 236);
            btnObjects.BackgroundImage = (Image)resources.GetObject("btnObjects.BackgroundImage");
            btnObjects.BackgroundImageLayout = ImageLayout.Center;
            btnObjects.Cursor = Cursors.Hand;
            btnObjects.FlatAppearance.BorderSize = 0;
            btnObjects.FlatStyle = FlatStyle.Flat;
            btnObjects.Font = new Font("HoloLens MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnObjects.Location = new Point(648, 93);
            btnObjects.Margin = new Padding(3, 2, 3, 2);
            btnObjects.Name = "btnObjects";
            btnObjects.Size = new Size(102, 60);
            btnObjects.TabIndex = 29;
            btnObjects.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnObjects.UseVisualStyleBackColor = false;
            btnObjects.Click += btnObjects_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Montserrat", 13.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(494, 48);
            label4.Name = "label4";
            label4.Size = new Size(90, 34);
            label4.TabIndex = 28;
            label4.Text = "Objetos";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblObjectTypes
            // 
            lblObjectTypes.Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblObjectTypes.Location = new Point(485, 159);
            lblObjectTypes.Name = "lblObjectTypes";
            lblObjectTypes.Size = new Size(124, 15);
            lblObjectTypes.TabIndex = 27;
            lblObjectTypes.Text = "Tipos de objetos";
            // 
            // btnObjectTypes
            // 
            btnObjectTypes.BackColor = Color.FromArgb(236, 236, 236);
            btnObjectTypes.BackgroundImage = (Image)resources.GetObject("btnObjectTypes.BackgroundImage");
            btnObjectTypes.BackgroundImageLayout = ImageLayout.Center;
            btnObjectTypes.Cursor = Cursors.Hand;
            btnObjectTypes.FlatAppearance.BorderSize = 0;
            btnObjectTypes.FlatStyle = FlatStyle.Flat;
            btnObjectTypes.Font = new Font("HoloLens MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnObjectTypes.Location = new Point(494, 93);
            btnObjectTypes.Margin = new Padding(3, 2, 3, 2);
            btnObjectTypes.Name = "btnObjectTypes";
            btnObjectTypes.Size = new Size(102, 60);
            btnObjectTypes.TabIndex = 26;
            btnObjectTypes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnObjectTypes.UseVisualStyleBackColor = false;
            btnObjectTypes.Click += btnObjectTypes_Click;
            // 
            // lblAlternativeFlows
            // 
            lblAlternativeFlows.AutoSize = true;
            lblAlternativeFlows.Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlternativeFlows.Location = new Point(290, 158);
            lblAlternativeFlows.Name = "lblAlternativeFlows";
            lblAlternativeFlows.Size = new Size(95, 16);
            lblAlternativeFlows.TabIndex = 25;
            lblAlternativeFlows.Text = "Flujos alternos";
            // 
            // btnAlternateFlows
            // 
            btnAlternateFlows.BackColor = Color.FromArgb(236, 236, 236);
            btnAlternateFlows.BackgroundImage = Properties.Resources.icons8_flow_48;
            btnAlternateFlows.BackgroundImageLayout = ImageLayout.Center;
            btnAlternateFlows.Cursor = Cursors.Hand;
            btnAlternateFlows.FlatAppearance.BorderSize = 0;
            btnAlternateFlows.FlatStyle = FlatStyle.Flat;
            btnAlternateFlows.Font = new Font("HoloLens MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlternateFlows.Location = new Point(290, 93);
            btnAlternateFlows.Margin = new Padding(3, 2, 3, 2);
            btnAlternateFlows.Name = "btnAlternateFlows";
            btnAlternateFlows.Size = new Size(102, 60);
            btnAlternateFlows.TabIndex = 24;
            btnAlternateFlows.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAlternateFlows.UseVisualStyleBackColor = false;
            // 
            // lblBaseFlows
            // 
            lblBaseFlows.AutoSize = true;
            lblBaseFlows.Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblBaseFlows.Location = new Point(173, 158);
            lblBaseFlows.Name = "lblBaseFlows";
            lblBaseFlows.Size = new Size(74, 16);
            lblBaseFlows.TabIndex = 23;
            lblBaseFlows.Text = "Flujos base";
            // 
            // btnBaseFlows
            // 
            btnBaseFlows.BackColor = Color.FromArgb(236, 236, 236);
            btnBaseFlows.BackgroundImage = (Image)resources.GetObject("btnBaseFlows.BackgroundImage");
            btnBaseFlows.BackgroundImageLayout = ImageLayout.Center;
            btnBaseFlows.Cursor = Cursors.Hand;
            btnBaseFlows.FlatAppearance.BorderSize = 0;
            btnBaseFlows.FlatStyle = FlatStyle.Flat;
            btnBaseFlows.Font = new Font("HoloLens MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaseFlows.Location = new Point(164, 93);
            btnBaseFlows.Margin = new Padding(3, 2, 3, 2);
            btnBaseFlows.Name = "btnBaseFlows";
            btnBaseFlows.Size = new Size(102, 60);
            btnBaseFlows.TabIndex = 22;
            btnBaseFlows.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBaseFlows.UseVisualStyleBackColor = false;
            btnBaseFlows.Click += btnBaseFlows_Click;
            // 
            // lblCu
            // 
            lblCu.Font = new Font("Montserrat", 13.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            lblCu.Location = new Point(37, 43);
            lblCu.Name = "lblCu";
            lblCu.Size = new Size(149, 34);
            lblCu.TabIndex = 21;
            lblCu.Text = "CU, FB y FA";
            lblCu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUseCases
            // 
            lblUseCases.AutoSize = true;
            lblUseCases.Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUseCases.Location = new Point(37, 158);
            lblUseCases.Name = "lblUseCases";
            lblUseCases.Size = new Size(86, 16);
            lblUseCases.TabIndex = 19;
            lblUseCases.Text = "Casos de uso";
            // 
            // btnCUs
            // 
            btnCUs.BackColor = Color.FromArgb(236, 236, 236);
            btnCUs.BackgroundImage = (Image)resources.GetObject("btnCUs.BackgroundImage");
            btnCUs.BackgroundImageLayout = ImageLayout.Center;
            btnCUs.Cursor = Cursors.Hand;
            btnCUs.FlatAppearance.BorderSize = 0;
            btnCUs.FlatStyle = FlatStyle.Flat;
            btnCUs.Font = new Font("HoloLens MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCUs.Location = new Point(37, 93);
            btnCUs.Margin = new Padding(3, 2, 3, 2);
            btnCUs.Name = "btnCUs";
            btnCUs.Size = new Size(102, 60);
            btnCUs.TabIndex = 18;
            btnCUs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCUs.UseVisualStyleBackColor = false;
            btnCUs.Click += btnCUs_Click;
            // 
            // SideBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 236, 236);
            ClientSize = new Size(1244, 591);
            Controls.Add(pnlRelationEContainer);
            Controls.Add(pnlSideBar);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SideBar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ACT";
            pnlExit.ResumeLayout(false);
            pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            pnlRelationEContainer.ResumeLayout(false);
            pnlRelationEContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button button3;
        private Button btnElementosR;
        private Button btnRoles;
        private Button btnInicio;
        private Button btnSalir;
        private Panel pnlExit;
        private Panel pnlSideBar;
        private Panel pnlRelationEContainer;
        private Button btnCUs;
        private Label lblUseCases;
        private Label lblBaseFlows;
        private Button btnBaseFlows;
        private Label lblCu;
        private Label lblAlternativeFlows;
        private Button btnAlternateFlows;
        private Label label6;
        private Label lblStateChanges;
        private Button btnStateChanges;
        private Label lblStates;
        private Label lblStatesbtn;
        private Button btnStates;
        private Label lblObjects;
        private Button btnObjects;
        private Label label4;
        private Label lblObjectTypes;
        private Button btnObjectTypes;
        private Label lblMessages;
        private Button btnMessages;
        private Label lblRn;
        private Button btnBusinessRules;
        private Label lblRnMs;
        private PictureBox pictureBox1;
        private PictureBox pictureBox6;
        private Label lblPantalla;
        private Label lblscreens;
        private Button btnScreens;
    }
}