using System.Windows.Forms;

namespace OGMiner
{
	partial class FormMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			menuStrip1 = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			экспортироватьНастройкиToolStripMenuItem = new ToolStripMenuItem();
			импортироватьНастройкиToolStripMenuItem = new ToolStripMenuItem();
			сброситьНастройкиToolStripMenuItem = new ToolStripMenuItem();
			languageToolStripMenuItem = new ToolStripMenuItem();
			englishToolStripMenuItem = new ToolStripMenuItem();
			русскийToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator2 = new ToolStripSeparator();
			exitToolStripMenuItem = new ToolStripMenuItem();
			helpToolStripMenuItem = new ToolStripMenuItem();
			aboutToolStripMenuItem = new ToolStripMenuItem();
			saveFileDialog1 = new SaveFileDialog();
			openFileDialog1 = new OpenFileDialog();
			statusStrip1 = new StatusStrip();
			toolStripStatusLabel1 = new ToolStripStatusLabel();
			toolStripStatusLabel2 = new ToolStripStatusLabel();
			toolStripStatusLabel3 = new ToolStripStatusLabel();
			toolStripStatusLabel4 = new ToolStripStatusLabel();
			toolStripStatusLabel5 = new ToolStripStatusLabel();
			toolStripStatusLabel6 = new ToolStripStatusLabel();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			label14 = new Label();
			textBox7 = new TextBox();
			textBox8 = new TextBox();
			label15 = new Label();
			label13 = new Label();
			checkBox1 = new CheckBox();
			groupBox1 = new GroupBox();
			label11 = new Label();
			textBox6 = new TextBox();
			label12 = new Label();
			label9 = new Label();
			textBox5 = new TextBox();
			label10 = new Label();
			label7 = new Label();
			textBox4 = new TextBox();
			label8 = new Label();
			label6 = new Label();
			textBox2 = new TextBox();
			label5 = new Label();
			comboBox2 = new ComboBox();
			button1 = new Button();
			comboBox1 = new ComboBox();
			label4 = new Label();
			textBox3 = new TextBox();
			label3 = new Label();
			textBox1 = new TextBox();
			label2 = new Label();
			label1 = new Label();
			dataGridView1 = new DataGridView();
			ProdType = new DataGridViewTextBoxColumn();
			Level = new DataGridViewTextBoxColumn();
			ProdImage = new DataGridViewImageColumn();
			m = new DataGridViewTextBoxColumn();
			k = new DataGridViewTextBoxColumn();
			d = new DataGridViewTextBoxColumn();
			e = new DataGridViewTextBoxColumn();
			ProdSetting = new DataGridViewComboBoxColumn();
			toolStrip1 = new ToolStrip();
			toolStripDropDownButton2 = new ToolStripDropDownButton();
			воиныToolStripMenuItem = new ToolStripMenuItem();
			торговцыToolStripMenuItem = new ToolStripMenuItem();
			исследователиToolStripMenuItem = new ToolStripMenuItem();
			неВыбраноToolStripMenuItem = new ToolStripMenuItem();
			toolStripDropDownButton1 = new ToolStripDropDownButton();
			toolStripMenuItem1 = new ToolStripMenuItem();
			генералToolStripMenuItem = new ToolStripMenuItem();
			исследовательToolStripMenuItem = new ToolStripMenuItem();
			неВыбранToolStripMenuItem = new ToolStripMenuItem();
			toolStripDropDownButton3 = new ToolStripDropDownButton();
			людиToolStripMenuItem = new ToolStripMenuItem();
			кэлишToolStripMenuItem = new ToolStripMenuItem();
			рокталToolStripMenuItem = new ToolStripMenuItem();
			мехиToolStripMenuItem = new ToolStripMenuItem();
			неВыбраноToolStripMenuItem1 = new ToolStripMenuItem();
			toolStripSeparator1 = new ToolStripSeparator();
			toolStripButton3 = new ToolStripButton();
			toolStripButton1 = new ToolStripButton();
			toolStripButton4 = new ToolStripButton();
			toolStripButton5 = new ToolStripButton();
			toolStripButton6 = new ToolStripButton();
			menuStrip1.SuspendLayout();
			statusStrip1.SuspendLayout();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1363, 24);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { экспортироватьНастройкиToolStripMenuItem, импортироватьНастройкиToolStripMenuItem, сброситьНастройкиToolStripMenuItem, languageToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(37, 20);
			fileToolStripMenuItem.Text = "File";
			// 
			// экспортироватьНастройкиToolStripMenuItem
			// 
			экспортироватьНастройкиToolStripMenuItem.Name = "экспортироватьНастройкиToolStripMenuItem";
			экспортироватьНастройкиToolStripMenuItem.Size = new Size(180, 22);
			экспортироватьНастройкиToolStripMenuItem.Text = "Export settings...";
			экспортироватьНастройкиToolStripMenuItem.Click += экспортироватьНастройкиToolStripMenuItem_Click;
			// 
			// импортироватьНастройкиToolStripMenuItem
			// 
			импортироватьНастройкиToolStripMenuItem.Name = "импортироватьНастройкиToolStripMenuItem";
			импортироватьНастройкиToolStripMenuItem.Size = new Size(180, 22);
			импортироватьНастройкиToolStripMenuItem.Text = "Import settings...";
			импортироватьНастройкиToolStripMenuItem.Click += импортироватьНастройкиToolStripMenuItem_Click;
			// 
			// сброситьНастройкиToolStripMenuItem
			// 
			сброситьНастройкиToolStripMenuItem.Name = "сброситьНастройкиToolStripMenuItem";
			сброситьНастройкиToolStripMenuItem.Size = new Size(180, 22);
			сброситьНастройкиToolStripMenuItem.Text = "Reset settings";
			сброситьНастройкиToolStripMenuItem.Click += сброситьНастройкиToolStripMenuItem_Click;
			// 
			// languageToolStripMenuItem
			// 
			languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { englishToolStripMenuItem, русскийToolStripMenuItem });
			languageToolStripMenuItem.Name = "languageToolStripMenuItem";
			languageToolStripMenuItem.Size = new Size(180, 22);
			languageToolStripMenuItem.Text = "Language";
			// 
			// englishToolStripMenuItem
			// 
			englishToolStripMenuItem.Name = "englishToolStripMenuItem";
			englishToolStripMenuItem.Size = new Size(180, 22);
			englishToolStripMenuItem.Text = "English";
			englishToolStripMenuItem.Click += englishToolStripMenuItem_Click;
			// 
			// русскийToolStripMenuItem
			// 
			русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
			русскийToolStripMenuItem.Size = new Size(180, 22);
			русскийToolStripMenuItem.Text = "Русский";
			русскийToolStripMenuItem.Click += русскийToolStripMenuItem_Click;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(177, 6);
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.Size = new Size(180, 22);
			exitToolStripMenuItem.Text = "Exit";
			exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
			// 
			// helpToolStripMenuItem
			// 
			helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
			helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			helpToolStripMenuItem.Size = new Size(44, 20);
			helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			aboutToolStripMenuItem.Size = new Size(107, 22);
			aboutToolStripMenuItem.Text = "About";
			aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
			// 
			// saveFileDialog1
			// 
			saveFileDialog1.DefaultExt = "xml";
			saveFileDialog1.Filter = "XML files|*.xml|All files|*.*";
			// 
			// openFileDialog1
			// 
			openFileDialog1.DefaultExt = "xml";
			openFileDialog1.Filter = "XML files|*.xml|All files|*.*";
			// 
			// statusStrip1
			// 
			statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3, toolStripStatusLabel4, toolStripStatusLabel5, toolStripStatusLabel6 });
			statusStrip1.Location = new Point(0, 620);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(1363, 24);
			statusStrip1.TabIndex = 40;
			statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new Size(105, 19);
			toolStripStatusLabel1.Text = "Production Factor:";
			// 
			// toolStripStatusLabel2
			// 
			toolStripStatusLabel2.BorderSides = ToolStripStatusLabelBorderSides.Right;
			toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			toolStripStatusLabel2.Size = new Size(26, 19);
			toolStripStatusLabel2.Text = "---";
			// 
			// toolStripStatusLabel3
			// 
			toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			toolStripStatusLabel3.Size = new Size(81, 19);
			toolStripStatusLabel3.Text = "Max Crawlers:";
			// 
			// toolStripStatusLabel4
			// 
			toolStripStatusLabel4.BorderSides = ToolStripStatusLabelBorderSides.Right;
			toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			toolStripStatusLabel4.Size = new Size(17, 19);
			toolStripStatusLabel4.Text = "0";
			// 
			// toolStripStatusLabel5
			// 
			toolStripStatusLabel5.Name = "toolStripStatusLabel5";
			toolStripStatusLabel5.Size = new Size(105, 19);
			toolStripStatusLabel5.Text = "Production (MSU):";
			// 
			// toolStripStatusLabel6
			// 
			toolStripStatusLabel6.Name = "toolStripStatusLabel6";
			toolStripStatusLabel6.Size = new Size(42, 19);
			toolStripStatusLabel6.Text = "0.00Bn";
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0, 24);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(1363, 596);
			tabControl1.TabIndex = 41;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(label14);
			tabPage1.Controls.Add(textBox7);
			tabPage1.Controls.Add(textBox8);
			tabPage1.Controls.Add(label15);
			tabPage1.Controls.Add(label13);
			tabPage1.Controls.Add(checkBox1);
			tabPage1.Controls.Add(groupBox1);
			tabPage1.Controls.Add(comboBox2);
			tabPage1.Controls.Add(button1);
			tabPage1.Controls.Add(comboBox1);
			tabPage1.Controls.Add(label4);
			tabPage1.Controls.Add(textBox3);
			tabPage1.Controls.Add(label3);
			tabPage1.Controls.Add(textBox1);
			tabPage1.Controls.Add(label2);
			tabPage1.Controls.Add(label1);
			tabPage1.Controls.Add(dataGridView1);
			tabPage1.Controls.Add(toolStrip1);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(1355, 568);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Production calculator";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
			label14.Location = new Point(1274, 249);
			label14.Name = "label14";
			label14.Size = new Size(22, 20);
			label14.TabIndex = 38;
			label14.Text = "%";
			// 
			// textBox7
			// 
			textBox7.Location = new Point(1218, 214);
			textBox7.Name = "textBox7";
			textBox7.Size = new Size(100, 23);
			textBox7.TabIndex = 26;
			textBox7.Text = "10";
			// 
			// textBox8
			// 
			textBox8.Location = new Point(1218, 243);
			textBox8.Name = "textBox8";
			textBox8.Size = new Size(47, 23);
			textBox8.TabIndex = 37;
			textBox8.Text = "0,0";
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(990, 249);
			label15.Name = "label15";
			label15.Size = new Size(186, 15);
			label15.TabIndex = 36;
			label15.Text = "Life form bonus for the class (T18)";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(990, 220);
			label13.Name = "label13";
			label13.Size = new Size(106, 15);
			label13.TabIndex = 25;
			label13.Text = "Energy technology";
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Checked = true;
			checkBox1.CheckState = CheckState.Checked;
			checkBox1.Location = new Point(990, 449);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(279, 19);
			checkBox1.TabIndex = 24;
			checkBox1.Text = "Automatically maximize the number of crawlers";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label11);
			groupBox1.Controls.Add(textBox6);
			groupBox1.Controls.Add(label12);
			groupBox1.Controls.Add(label9);
			groupBox1.Controls.Add(textBox5);
			groupBox1.Controls.Add(label10);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(textBox4);
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(textBox2);
			groupBox1.Controls.Add(label5);
			groupBox1.Location = new Point(987, 296);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(353, 144);
			groupBox1.TabIndex = 23;
			groupBox1.TabStop = false;
			groupBox1.Text = "Global life-form tech bonus";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
			label11.Location = new Point(187, 112);
			label11.Name = "label11";
			label11.Size = new Size(22, 20);
			label11.TabIndex = 35;
			label11.Text = "%";
			// 
			// textBox6
			// 
			textBox6.Location = new Point(110, 109);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(71, 23);
			textBox6.TabIndex = 34;
			textBox6.Text = "0,0";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(13, 112);
			label12.Name = "label12";
			label12.Size = new Size(43, 15);
			label12.TabIndex = 33;
			label12.Text = "Energy";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
			label9.Location = new Point(187, 83);
			label9.Name = "label9";
			label9.Size = new Size(22, 20);
			label9.TabIndex = 32;
			label9.Text = "%";
			// 
			// textBox5
			// 
			textBox5.Location = new Point(110, 80);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(71, 23);
			textBox5.TabIndex = 31;
			textBox5.Text = "0,0";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(13, 83);
			label10.Name = "label10";
			label10.Size = new Size(63, 15);
			label10.TabIndex = 30;
			label10.Text = "Deuterium";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
			label7.Location = new Point(187, 54);
			label7.Name = "label7";
			label7.Size = new Size(22, 20);
			label7.TabIndex = 29;
			label7.Text = "%";
			// 
			// textBox4
			// 
			textBox4.Location = new Point(110, 51);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(71, 23);
			textBox4.TabIndex = 28;
			textBox4.Text = "0,0";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(13, 54);
			label8.Name = "label8";
			label8.Size = new Size(43, 15);
			label8.TabIndex = 27;
			label8.Text = "Crystal";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
			label6.Location = new Point(187, 25);
			label6.Name = "label6";
			label6.Size = new Size(22, 20);
			label6.TabIndex = 26;
			label6.Text = "%";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(110, 22);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(71, 23);
			textBox2.TabIndex = 25;
			textBox2.Text = "0,0";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(13, 25);
			label5.Name = "label5";
			label5.Size = new Size(37, 15);
			label5.TabIndex = 24;
			label5.Text = "Metal";
			// 
			// comboBox2
			// 
			comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox2.FormattingEnabled = true;
			comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
			comboBox2.Location = new Point(1216, 98);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(101, 23);
			comboBox2.TabIndex = 21;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			button1.BackColor = Color.PaleGreen;
			button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
			button1.ForeColor = SystemColors.ControlText;
			button1.Location = new Point(990, 515);
			button1.Name = "button1";
			button1.Size = new Size(156, 44);
			button1.TabIndex = 20;
			button1.Text = "Recalculate";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// comboBox1
			// 
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
			comboBox1.Location = new Point(1217, 185);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(101, 23);
			comboBox1.TabIndex = 19;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(990, 191);
			label4.Name = "label4";
			label4.Size = new Size(120, 15);
			label4.TabIndex = 18;
			label4.Text = "Position of the planet";
			// 
			// textBox3
			// 
			textBox3.Location = new Point(1217, 156);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(100, 23);
			textBox3.TabIndex = 17;
			textBox3.Text = "-30";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(990, 162);
			label3.Name = "label3";
			label3.Size = new Size(164, 15);
			label3.TabIndex = 16;
			label3.Text = "Minimum planet temperature";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(1217, 127);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 23);
			textBox1.TabIndex = 14;
			textBox1.Text = "1";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(990, 104);
			label2.Name = "label2";
			label2.Size = new Size(112, 15);
			label2.TabIndex = 13;
			label2.Text = "Development speed";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(990, 133);
			label1.Name = "label1";
			label1.Size = new Size(106, 15);
			label1.TabIndex = 12;
			label1.Text = "Number of planets";
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Control;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProdType, Level, ProdImage, m, k, d, e, ProdSetting });
			dataGridView1.Location = new Point(18, 18);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(936, 541);
			dataGridView1.TabIndex = 11;
			// 
			// ProdType
			// 
			ProdType.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			ProdType.HeaderText = "Name of production/building";
			ProdType.Name = "ProdType";
			ProdType.ReadOnly = true;
			ProdType.Width = 132;
			// 
			// Level
			// 
			Level.HeaderText = "Level/number";
			Level.Name = "Level";
			// 
			// ProdImage
			// 
			ProdImage.HeaderText = "Picture";
			ProdImage.ImageLayout = DataGridViewImageCellLayout.Zoom;
			ProdImage.Name = "ProdImage";
			ProdImage.ReadOnly = true;
			ProdImage.Resizable = DataGridViewTriState.True;
			ProdImage.SortMode = DataGridViewColumnSortMode.Automatic;
			// 
			// m
			// 
			m.HeaderText = "Metal";
			m.Name = "m";
			m.ReadOnly = true;
			// 
			// k
			// 
			k.HeaderText = "Crystal";
			k.Name = "k";
			k.ReadOnly = true;
			// 
			// d
			// 
			d.HeaderText = "Deuterium";
			d.Name = "d";
			d.ReadOnly = true;
			// 
			// e
			// 
			e.HeaderText = "Energy";
			e.Name = "e";
			e.ReadOnly = true;
			// 
			// ProdSetting
			// 
			ProdSetting.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			ProdSetting.HeaderText = "Production Settings";
			ProdSetting.Items.AddRange(new object[] { "0%", "10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%", "110%", "120%", "130%", "140%", "150%" });
			ProdSetting.Name = "ProdSetting";
			ProdSetting.Width = 78;
			// 
			// toolStrip1
			// 
			toolStrip1.Dock = DockStyle.None;
			toolStrip1.ImageScalingSize = new Size(36, 36);
			toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton2, toolStripDropDownButton1, toolStripDropDownButton3, toolStripSeparator1, toolStripButton3, toolStripButton1, toolStripButton4, toolStripButton5, toolStripButton6 });
			toolStrip1.Location = new Point(967, 21);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(365, 43);
			toolStrip1.TabIndex = 10;
			toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton2
			// 
			toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { воиныToolStripMenuItem, торговцыToolStripMenuItem, исследователиToolStripMenuItem, неВыбраноToolStripMenuItem });
			toolStripDropDownButton2.Image = Properties.Resources.ally_traders;
			toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
			toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			toolStripDropDownButton2.Size = new Size(49, 40);
			toolStripDropDownButton2.Text = "toolStripDropDownButton2";
			toolStripDropDownButton2.ToolTipText = "Choose an alliance class";
			// 
			// воиныToolStripMenuItem
			// 
			воиныToolStripMenuItem.Image = Properties.Resources.ally_warriors;
			воиныToolStripMenuItem.Name = "воиныToolStripMenuItem";
			воиныToolStripMenuItem.Size = new Size(207, 22);
			воиныToolStripMenuItem.Text = "Warriors";
			воиныToolStripMenuItem.Click += воиныToolStripMenuItem_Click;
			// 
			// торговцыToolStripMenuItem
			// 
			торговцыToolStripMenuItem.Image = Properties.Resources.ally_traders;
			торговцыToolStripMenuItem.Name = "торговцыToolStripMenuItem";
			торговцыToolStripMenuItem.Size = new Size(207, 22);
			торговцыToolStripMenuItem.Text = "Traders";
			торговцыToolStripMenuItem.Click += торговцыToolStripMenuItem_Click;
			// 
			// исследователиToolStripMenuItem
			// 
			исследователиToolStripMenuItem.Image = Properties.Resources.ally_explorers;
			исследователиToolStripMenuItem.Name = "исследователиToolStripMenuItem";
			исследователиToolStripMenuItem.Size = new Size(207, 22);
			исследователиToolStripMenuItem.Text = "Researchers";
			исследователиToolStripMenuItem.Click += исследователиToolStripMenuItem_Click;
			// 
			// неВыбраноToolStripMenuItem
			// 
			неВыбраноToolStripMenuItem.Image = Properties.Resources.ally_not_selected;
			неВыбраноToolStripMenuItem.Name = "неВыбраноToolStripMenuItem";
			неВыбраноToolStripMenuItem.Size = new Size(207, 22);
			неВыбраноToolStripMenuItem.Text = "No alliance class selected";
			неВыбраноToolStripMenuItem.Click += неВыбраноToolStripMenuItem_Click;
			// 
			// toolStripDropDownButton1
			// 
			toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, генералToolStripMenuItem, исследовательToolStripMenuItem, неВыбранToolStripMenuItem });
			toolStripDropDownButton1.Image = Properties.Resources.collector;
			toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
			toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			toolStripDropDownButton1.Size = new Size(49, 40);
			toolStripDropDownButton1.Text = "toolStripDropDownButton1";
			toolStripDropDownButton1.ToolTipText = "Select a player's class";
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.BackgroundImageLayout = ImageLayout.Zoom;
			toolStripMenuItem1.Image = Properties.Resources.collector;
			toolStripMenuItem1.ImageAlign = ContentAlignment.MiddleLeft;
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new Size(199, 22);
			toolStripMenuItem1.Text = "Collector";
			toolStripMenuItem1.Click += toolStripMenuItem1_Click;
			// 
			// генералToolStripMenuItem
			// 
			генералToolStripMenuItem.Image = Properties.Resources.general;
			генералToolStripMenuItem.Name = "генералToolStripMenuItem";
			генералToolStripMenuItem.Size = new Size(199, 22);
			генералToolStripMenuItem.Text = "General";
			генералToolStripMenuItem.Click += генералToolStripMenuItem_Click;
			// 
			// исследовательToolStripMenuItem
			// 
			исследовательToolStripMenuItem.Image = Properties.Resources.explorer;
			исследовательToolStripMenuItem.Name = "исследовательToolStripMenuItem";
			исследовательToolStripMenuItem.Size = new Size(199, 22);
			исследовательToolStripMenuItem.Text = "Discoverer";
			исследовательToolStripMenuItem.Click += исследовательToolStripMenuItem_Click;
			// 
			// неВыбранToolStripMenuItem
			// 
			неВыбранToolStripMenuItem.Image = Properties.Resources.not_selected;
			неВыбранToolStripMenuItem.Name = "неВыбранToolStripMenuItem";
			неВыбранToolStripMenuItem.Size = new Size(199, 22);
			неВыбранToolStripMenuItem.Text = "No player class selected";
			неВыбранToolStripMenuItem.Click += неВыбранToolStripMenuItem_Click;
			// 
			// toolStripDropDownButton3
			// 
			toolStripDropDownButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripDropDownButton3.DropDownItems.AddRange(new ToolStripItem[] { людиToolStripMenuItem, кэлишToolStripMenuItem, рокталToolStripMenuItem, мехиToolStripMenuItem, неВыбраноToolStripMenuItem1 });
			toolStripDropDownButton3.Image = Properties.Resources.rock;
			toolStripDropDownButton3.ImageTransparentColor = Color.Magenta;
			toolStripDropDownButton3.Name = "toolStripDropDownButton3";
			toolStripDropDownButton3.Size = new Size(49, 40);
			toolStripDropDownButton3.Text = "toolStripDropDownButton3";
			toolStripDropDownButton3.ToolTipText = "Choose a life form";
			// 
			// людиToolStripMenuItem
			// 
			людиToolStripMenuItem.Image = Properties.Resources.human;
			людиToolStripMenuItem.Name = "людиToolStripMenuItem";
			людиToolStripMenuItem.Size = new Size(184, 22);
			людиToolStripMenuItem.Text = "Humans";
			людиToolStripMenuItem.Click += людиToolStripMenuItem_Click;
			// 
			// кэлишToolStripMenuItem
			// 
			кэлишToolStripMenuItem.Image = Properties.Resources.shaved_pubis;
			кэлишToolStripMenuItem.Name = "кэлишToolStripMenuItem";
			кэлишToolStripMenuItem.Size = new Size(184, 22);
			кэлишToolStripMenuItem.Text = "Kaelesh";
			кэлишToolStripMenuItem.Click += кэлишToolStripMenuItem_Click;
			// 
			// рокталToolStripMenuItem
			// 
			рокталToolStripMenuItem.Image = Properties.Resources.rock;
			рокталToolStripMenuItem.Name = "рокталToolStripMenuItem";
			рокталToolStripMenuItem.Size = new Size(184, 22);
			рокталToolStripMenuItem.Text = "Rock’tal";
			рокталToolStripMenuItem.Click += рокталToolStripMenuItem_Click;
			// 
			// мехиToolStripMenuItem
			// 
			мехиToolStripMenuItem.Image = Properties.Resources.mecha;
			мехиToolStripMenuItem.Name = "мехиToolStripMenuItem";
			мехиToolStripMenuItem.Size = new Size(184, 22);
			мехиToolStripMenuItem.Text = "Mechas";
			мехиToolStripMenuItem.Click += мехиToolStripMenuItem_Click;
			// 
			// неВыбраноToolStripMenuItem1
			// 
			неВыбраноToolStripMenuItem1.Image = Properties.Resources.nolf;
			неВыбраноToolStripMenuItem1.Name = "неВыбраноToolStripMenuItem1";
			неВыбраноToolStripMenuItem1.Size = new Size(184, 22);
			неВыбраноToolStripMenuItem1.Text = "No life form selected";
			неВыбраноToolStripMenuItem1.Click += неВыбраноToolStripMenuItem1_Click;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(6, 43);
			// 
			// toolStripButton3
			// 
			toolStripButton3.CheckOnClick = true;
			toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton3.Image = Properties.Resources.commander_on;
			toolStripButton3.ImageTransparentColor = Color.Magenta;
			toolStripButton3.Name = "toolStripButton3";
			toolStripButton3.Size = new Size(40, 40);
			toolStripButton3.Text = "toolStripButton3";
			toolStripButton3.ToolTipText = "OGame Commander\r\nGives production bonus only with full Staff";
			toolStripButton3.Click += toolStripButton3_Click;
			// 
			// toolStripButton1
			// 
			toolStripButton1.CheckOnClick = true;
			toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton1.Image = Properties.Resources.admiral_on;
			toolStripButton1.ImageTransparentColor = Color.Magenta;
			toolStripButton1.Name = "toolStripButton1";
			toolStripButton1.Size = new Size(40, 40);
			toolStripButton1.Text = "toolStripButton1";
			toolStripButton1.ToolTipText = "Admiral\r\nGives production bonus only with full Staff";
			toolStripButton1.Click += toolStripButton1_Click;
			// 
			// toolStripButton4
			// 
			toolStripButton4.CheckOnClick = true;
			toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton4.Image = Properties.Resources.engineer_on;
			toolStripButton4.ImageTransparentColor = Color.Magenta;
			toolStripButton4.Name = "toolStripButton4";
			toolStripButton4.Size = new Size(40, 40);
			toolStripButton4.Text = "toolStripButton4";
			toolStripButton4.ToolTipText = "Engineer\r\n+10% energy production";
			toolStripButton4.Click += toolStripButton4_Click;
			// 
			// toolStripButton5
			// 
			toolStripButton5.CheckOnClick = true;
			toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton5.Image = Properties.Resources.geologist_on;
			toolStripButton5.ImageTransparentColor = Color.Magenta;
			toolStripButton5.Name = "toolStripButton5";
			toolStripButton5.Size = new Size(40, 40);
			toolStripButton5.Text = "toolStripButton5";
			toolStripButton5.ToolTipText = "Geologist\r\n+10% mine production, +10% crawlers for Collector";
			toolStripButton5.Click += toolStripButton5_Click;
			// 
			// toolStripButton6
			// 
			toolStripButton6.CheckOnClick = true;
			toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton6.Image = Properties.Resources.technocrate_on;
			toolStripButton6.ImageTransparentColor = Color.Magenta;
			toolStripButton6.Name = "toolStripButton6";
			toolStripButton6.Size = new Size(40, 40);
			toolStripButton6.Text = "toolStripButton6";
			toolStripButton6.ToolTipText = "Technocrat\r\nGives production bonus only with full Staff";
			toolStripButton6.Click += toolStripButton6_Click;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(1363, 644);
			Controls.Add(tabControl1);
			Controls.Add(statusStrip1);
			Controls.Add(menuStrip1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip1;
			Name = "FormMain";
			Text = "OGMiner by Andorianin (1.1)";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem exitToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripMenuItem aboutToolStripMenuItem;
		private ToolStripMenuItem экспортироватьНастройкиToolStripMenuItem;
		private ToolStripMenuItem импортироватьНастройкиToolStripMenuItem;
		private ToolStripMenuItem сброситьНастройкиToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator2;
		private SaveFileDialog saveFileDialog1;
		private OpenFileDialog openFileDialog1;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private ToolStripStatusLabel toolStripStatusLabel2;
		private ToolStripStatusLabel toolStripStatusLabel3;
		private ToolStripStatusLabel toolStripStatusLabel4;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private Label label14;
		private TextBox textBox7;
		private TextBox textBox8;
		private Label label15;
		private Label label13;
		private CheckBox checkBox1;
		private GroupBox groupBox1;
		private Label label11;
		private TextBox textBox6;
		private Label label12;
		private Label label9;
		private TextBox textBox5;
		private Label label10;
		private Label label7;
		private TextBox textBox4;
		private Label label8;
		private Label label6;
		private TextBox textBox2;
		private Label label5;
		private ComboBox comboBox2;
		private Button button1;
		private ComboBox comboBox1;
		private Label label4;
		private TextBox textBox3;
		private Label label3;
		private TextBox textBox1;
		private Label label2;
		private Label label1;
		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn ProdType;
		private DataGridViewTextBoxColumn Level;
		private DataGridViewImageColumn ProdImage;
		private DataGridViewTextBoxColumn m;
		private DataGridViewTextBoxColumn k;
		private DataGridViewTextBoxColumn d;
		private DataGridViewTextBoxColumn e;
		private DataGridViewComboBoxColumn ProdSetting;
		private ToolStrip toolStrip1;
		private ToolStripDropDownButton toolStripDropDownButton2;
		private ToolStripMenuItem воиныToolStripMenuItem;
		private ToolStripMenuItem торговцыToolStripMenuItem;
		private ToolStripMenuItem исследователиToolStripMenuItem;
		private ToolStripMenuItem неВыбраноToolStripMenuItem;
		private ToolStripDropDownButton toolStripDropDownButton1;
		private ToolStripMenuItem toolStripMenuItem1;
		private ToolStripMenuItem генералToolStripMenuItem;
		private ToolStripMenuItem исследовательToolStripMenuItem;
		private ToolStripMenuItem неВыбранToolStripMenuItem;
		private ToolStripDropDownButton toolStripDropDownButton3;
		private ToolStripMenuItem людиToolStripMenuItem;
		private ToolStripMenuItem кэлишToolStripMenuItem;
		private ToolStripMenuItem рокталToolStripMenuItem;
		private ToolStripMenuItem мехиToolStripMenuItem;
		private ToolStripMenuItem неВыбраноToolStripMenuItem1;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripButton toolStripButton3;
		private ToolStripButton toolStripButton1;
		private ToolStripButton toolStripButton4;
		private ToolStripButton toolStripButton5;
		private ToolStripButton toolStripButton6;
		private ToolStripStatusLabel toolStripStatusLabel5;
		private ToolStripStatusLabel toolStripStatusLabel6;
		private ToolStripMenuItem languageToolStripMenuItem;
		private ToolStripMenuItem englishToolStripMenuItem;
		private ToolStripMenuItem русскийToolStripMenuItem;
	}
}
