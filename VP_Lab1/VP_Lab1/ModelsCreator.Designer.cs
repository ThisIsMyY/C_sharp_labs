namespace VP_Lab1
{
    partial class ModelsCreator
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
            this.components = new System.ComponentModel.Container();
            this.saveButton = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.processorSelect = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.companySelect = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.inStock = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.changeModelButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.limitedEditionCheck = new System.Windows.Forms.CheckBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ViewModelsButton = new System.Windows.Forms.Button();
            this.deleteModelButton = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.comboBoxChangeModel = new System.Windows.Forms.ComboBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.comboBoxDeleteModel = new System.Windows.Forms.ComboBox();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(540, 150);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(253, 111);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Create new model";
            this.toolTip1.SetToolTip(this.saveButton, "Create a file with model info");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(6, 283);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(253, 111);
            this.panel8.TabIndex = 17;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel10.Controls.Add(this.processorSelect);
            this.panel10.Location = new System.Drawing.Point(10, 33);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(231, 59);
            this.panel10.TabIndex = 3;
            // 
            // processorSelect
            // 
            this.processorSelect.DisplayMember = "adwa";
            this.processorSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processorSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.processorSelect.FormattingEnabled = true;
            this.processorSelect.Items.AddRange(new object[] {
            "Aboba",
            "Kwantory",
            "Exenos",
            "Tor",
            "Lighting",
            "MixFight",
            "Rocky",
            "Delta\""});
            this.processorSelect.Location = new System.Drawing.Point(11, 13);
            this.processorSelect.MaxDropDownItems = 3;
            this.processorSelect.Name = "processorSelect";
            this.processorSelect.Size = new System.Drawing.Size(209, 33);
            this.processorSelect.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Choose processor model:";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel12.Controls.Add(this.panel14);
            this.panel12.Controls.Add(this.label12);
            this.panel12.Location = new System.Drawing.Point(540, 21);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(253, 112);
            this.panel12.TabIndex = 17;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel14.Controls.Add(this.companySelect);
            this.panel14.Location = new System.Drawing.Point(10, 33);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(231, 60);
            this.panel14.TabIndex = 3;
            // 
            // companySelect
            // 
            this.companySelect.DisplayMember = "adwa";
            this.companySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companySelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companySelect.FormattingEnabled = true;
            this.companySelect.Items.AddRange(new object[] {
            "The Rock",
            "Cubix",
            "ElectroHeart",
            "Dodli",
            "Roots",
            "Xiaomi",
            "Apple",
            "Samsung"});
            this.companySelect.Location = new System.Drawing.Point(9, 13);
            this.companySelect.MaxDropDownItems = 3;
            this.companySelect.Name = "companySelect";
            this.companySelect.Size = new System.Drawing.Size(209, 33);
            this.companySelect.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "Choose company:";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Controls.Add(this.label13);
            this.panel15.Location = new System.Drawing.Point(809, 22);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(253, 111);
            this.panel15.TabIndex = 17;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel16.Controls.Add(this.inStock);
            this.panel16.Location = new System.Drawing.Point(10, 33);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(231, 58);
            this.panel16.TabIndex = 3;
            // 
            // inStock
            // 
            this.inStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inStock.FormattingEnabled = true;
            this.inStock.ItemHeight = 25;
            this.inStock.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.inStock.Location = new System.Drawing.Point(14, 0);
            this.inStock.Name = "inStock";
            this.inStock.Size = new System.Drawing.Size(203, 54);
            this.inStock.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(6, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 18);
            this.label13.TabIndex = 2;
            this.label13.Text = "In stoke?";
            // 
            // changeModelButton
            // 
            this.changeModelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeModelButton.Location = new System.Drawing.Point(8, 41);
            this.changeModelButton.Name = "changeModelButton";
            this.changeModelButton.Size = new System.Drawing.Size(253, 67);
            this.changeModelButton.TabIndex = 19;
            this.changeModelButton.Text = "Change model";
            this.toolTip1.SetToolTip(this.changeModelButton, "Change model");
            this.changeModelButton.UseVisualStyleBackColor = true;
            this.changeModelButton.Click += new System.EventHandler(this.ChangeModelButton_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(6, 148);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(253, 111);
            this.panel6.TabIndex = 17;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel7.Controls.Add(this.trackBar2);
            this.panel7.Controls.Add(this.numericUpDown2);
            this.panel7.Location = new System.Drawing.Point(10, 33);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(231, 59);
            this.panel7.TabIndex = 3;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(83, 8);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(142, 45);
            this.trackBar2.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown2.Location = new System.Drawing.Point(3, 14);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(76, 32);
            this.numericUpDown2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter memory value:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(274, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 111);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.trackBar1);
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Location = new System.Drawing.Point(10, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 59);
            this.panel4.TabIndex = 3;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(83, 8);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(142, 45);
            this.trackBar1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(3, 14);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(76, 32);
            this.numericUpDown1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Enter price:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(274, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 111);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.trackBar3);
            this.panel2.Controls.Add(this.numericUpDown3);
            this.panel2.Location = new System.Drawing.Point(10, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 59);
            this.panel2.TabIndex = 3;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(83, 7);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(142, 45);
            this.trackBar3.TabIndex = 5;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown3.Location = new System.Drawing.Point(3, 13);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(76, 32);
            this.numericUpDown3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter display size:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(6, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(253, 111);
            this.panel5.TabIndex = 16;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel9.Controls.Add(this.textBox1);
            this.panel9.Location = new System.Drawing.Point(10, 33);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(231, 59);
            this.panel9.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(15, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter model name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 276);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // limitedEditionCheck
            // 
            this.limitedEditionCheck.AutoSize = true;
            this.limitedEditionCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.limitedEditionCheck.Location = new System.Drawing.Point(15, 16);
            this.limitedEditionCheck.Name = "limitedEditionCheck";
            this.limitedEditionCheck.Size = new System.Drawing.Size(165, 30);
            this.limitedEditionCheck.TabIndex = 21;
            this.limitedEditionCheck.Text = "limited edition";
            this.limitedEditionCheck.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Location = new System.Drawing.Point(274, 283);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(253, 111);
            this.panel11.TabIndex = 18;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel13.Controls.Add(this.limitedEditionCheck);
            this.panel13.Location = new System.Drawing.Point(10, 33);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(231, 59);
            this.panel13.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Check the box for limited edition:";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ViewModelsButton
            // 
            this.ViewModelsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewModelsButton.Location = new System.Drawing.Point(539, 283);
            this.ViewModelsButton.Name = "ViewModelsButton";
            this.ViewModelsButton.Size = new System.Drawing.Size(254, 111);
            this.ViewModelsButton.TabIndex = 21;
            this.ViewModelsButton.Text = "View models";
            this.toolTip1.SetToolTip(this.ViewModelsButton, "View models info");
            this.ViewModelsButton.UseVisualStyleBackColor = true;
            this.ViewModelsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteModelButton
            // 
            this.deleteModelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteModelButton.Location = new System.Drawing.Point(8, 41);
            this.deleteModelButton.Name = "deleteModelButton";
            this.deleteModelButton.Size = new System.Drawing.Size(253, 67);
            this.deleteModelButton.TabIndex = 19;
            this.deleteModelButton.Text = "Delete model";
            this.toolTip1.SetToolTip(this.deleteModelButton, "Change model");
            this.deleteModelButton.UseVisualStyleBackColor = true;
            this.deleteModelButton.Click += new System.EventHandler(this.DeleteModelButton_Click);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.comboBoxChangeModel);
            this.panel17.Controls.Add(this.changeModelButton);
            this.panel17.Location = new System.Drawing.Point(799, 150);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(269, 111);
            this.panel17.TabIndex = 22;
            // 
            // comboBoxChangeModel
            // 
            this.comboBoxChangeModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxChangeModel.FormattingEnabled = true;
            this.comboBoxChangeModel.Location = new System.Drawing.Point(25, 2);
            this.comboBoxChangeModel.Name = "comboBoxChangeModel";
            this.comboBoxChangeModel.Size = new System.Drawing.Size(220, 33);
            this.comboBoxChangeModel.TabIndex = 20;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.comboBoxDeleteModel);
            this.panel18.Controls.Add(this.deleteModelButton);
            this.panel18.Location = new System.Drawing.Point(799, 283);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(269, 111);
            this.panel18.TabIndex = 23;
            // 
            // comboBoxDeleteModel
            // 
            this.comboBoxDeleteModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDeleteModel.FormattingEnabled = true;
            this.comboBoxDeleteModel.Location = new System.Drawing.Point(25, 2);
            this.comboBoxDeleteModel.Name = "comboBoxDeleteModel";
            this.comboBoxDeleteModel.Size = new System.Drawing.Size(220, 33);
            this.comboBoxDeleteModel.TabIndex = 20;
            // 
            // ModelsCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 409);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.ViewModelsButton);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.saveButton);
            this.Name = "ModelsCreator";
            this.Text = "ModelsCreator";
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox processorSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox companySelect;
        private System.Windows.Forms.Button changeModelButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox limitedEditionCheck;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ListBox inStock;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button ViewModelsButton;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.ComboBox comboBoxChangeModel;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.ComboBox comboBoxDeleteModel;
        private System.Windows.Forms.Button deleteModelButton;
    }
}