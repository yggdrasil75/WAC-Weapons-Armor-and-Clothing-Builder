namespace WAC_Weapons_Armor_and_Clothing_Builder
{
	partial class WACMainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WACMainForm));
			this.MainPanel = new System.Windows.Forms.TabControl();
			this.PageStart = new System.Windows.Forms.TabPage();
			this.PageMod = new System.Windows.Forms.TabPage();
			this.PageSet = new System.Windows.Forms.TabPage();
			this.PageArmor = new System.Windows.Forms.TabPage();
			this.PageWeapon = new System.Windows.Forms.TabPage();
			this.PageClothing = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.GameModsPath = new System.Windows.Forms.TextBox();
			this.ManagerModsPath = new System.Windows.Forms.TextBox();
			this.xEditPath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.PageCraft = new System.Windows.Forms.TabPage();
			this.Preview = new System.Windows.Forms.TabPage();
			this.RadioRulesetVanilla = new System.Windows.Forms.RadioButton();
			this.RadioRulesetWACCF = new System.Windows.Forms.RadioButton();
			this.RadioRulesetCCOR = new System.Windows.Forms.RadioButton();
			this.RadioRulesetCustom = new System.Windows.Forms.RadioButton();
			this.RulesetCustomGenerate = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.PanelStart = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.WeaponTabPanel = new System.Windows.Forms.TabControl();
			this.Polearms = new System.Windows.Forms.TabPage();
			this.Swords = new System.Windows.Forms.TabPage();
			this.MainPanel.SuspendLayout();
			this.PageStart.SuspendLayout();
			this.PageMod.SuspendLayout();
			this.PageArmor.SuspendLayout();
			this.PageWeapon.SuspendLayout();
			this.PanelStart.SuspendLayout();
			this.WeaponTabPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainPanel
			// 
			this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MainPanel.Controls.Add(this.PageStart);
			this.MainPanel.Controls.Add(this.PageMod);
			this.MainPanel.Controls.Add(this.PageSet);
			this.MainPanel.Controls.Add(this.PageArmor);
			this.MainPanel.Controls.Add(this.PageWeapon);
			this.MainPanel.Controls.Add(this.PageClothing);
			this.MainPanel.Controls.Add(this.PageCraft);
			this.MainPanel.Controls.Add(this.Preview);
			this.MainPanel.Location = new System.Drawing.Point(13, 13);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.SelectedIndex = 0;
			this.MainPanel.Size = new System.Drawing.Size(608, 379);
			this.MainPanel.TabIndex = 0;
			// 
			// PageStart
			// 
			this.PageStart.Controls.Add(this.PanelStart);
			this.PageStart.Controls.Add(this.label4);
			this.PageStart.Controls.Add(this.label3);
			this.PageStart.Controls.Add(this.label2);
			this.PageStart.Controls.Add(this.xEditPath);
			this.PageStart.Controls.Add(this.ManagerModsPath);
			this.PageStart.Controls.Add(this.GameModsPath);
			this.PageStart.Controls.Add(this.label1);
			this.PageStart.Location = new System.Drawing.Point(4, 22);
			this.PageStart.Name = "PageStart";
			this.PageStart.Padding = new System.Windows.Forms.Padding(3);
			this.PageStart.Size = new System.Drawing.Size(600, 353);
			this.PageStart.TabIndex = 0;
			this.PageStart.Text = "Start Here";
			this.PageStart.UseVisualStyleBackColor = true;
			// 
			// PageMod
			// 
			this.PageMod.Controls.Add(this.tableLayoutPanel1);
			this.PageMod.Location = new System.Drawing.Point(4, 22);
			this.PageMod.Name = "PageMod";
			this.PageMod.Padding = new System.Windows.Forms.Padding(3);
			this.PageMod.Size = new System.Drawing.Size(600, 353);
			this.PageMod.TabIndex = 1;
			this.PageMod.Text = "Select Mod";
			this.PageMod.UseVisualStyleBackColor = true;
			// 
			// PageSet
			// 
			this.PageSet.Location = new System.Drawing.Point(4, 22);
			this.PageSet.Name = "PageSet";
			this.PageSet.Padding = new System.Windows.Forms.Padding(3);
			this.PageSet.Size = new System.Drawing.Size(600, 353);
			this.PageSet.TabIndex = 2;
			this.PageSet.Text = "Select Sets";
			this.PageSet.UseVisualStyleBackColor = true;
			// 
			// PageArmor
			// 
			this.PageArmor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.PageArmor.Controls.Add(this.panel2);
			this.PageArmor.Controls.Add(this.panel1);
			this.PageArmor.Controls.Add(this.checkedListBox1);
			this.PageArmor.Location = new System.Drawing.Point(4, 22);
			this.PageArmor.Name = "PageArmor";
			this.PageArmor.Padding = new System.Windows.Forms.Padding(3);
			this.PageArmor.Size = new System.Drawing.Size(600, 353);
			this.PageArmor.TabIndex = 3;
			this.PageArmor.Text = "Edit Armor";
			this.PageArmor.UseVisualStyleBackColor = true;
			// 
			// PageWeapon
			// 
			this.PageWeapon.Controls.Add(this.WeaponTabPanel);
			this.PageWeapon.Location = new System.Drawing.Point(4, 22);
			this.PageWeapon.Name = "PageWeapon";
			this.PageWeapon.Padding = new System.Windows.Forms.Padding(3);
			this.PageWeapon.Size = new System.Drawing.Size(600, 353);
			this.PageWeapon.TabIndex = 4;
			this.PageWeapon.Text = "Edit Weapons";
			this.PageWeapon.UseVisualStyleBackColor = true;
			// 
			// PageClothing
			// 
			this.PageClothing.Location = new System.Drawing.Point(4, 22);
			this.PageClothing.Name = "PageClothing";
			this.PageClothing.Padding = new System.Windows.Forms.Padding(3);
			this.PageClothing.Size = new System.Drawing.Size(600, 353);
			this.PageClothing.TabIndex = 5;
			this.PageClothing.Text = "Edit Clothing";
			this.PageClothing.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(3);
			this.label1.Size = new System.Drawing.Size(594, 36);
			this.label1.TabIndex = 4;
			this.label1.Text = "Welcome to WAC Builder. there are a few things that need to be set before this ca" +
    "n work at its most efficient.  please set the specified paths below:";
			// 
			// GameModsPath
			// 
			this.GameModsPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GameModsPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
			this.GameModsPath.Location = new System.Drawing.Point(186, 39);
			this.GameModsPath.Name = "GameModsPath";
			this.GameModsPath.Size = new System.Drawing.Size(388, 20);
			this.GameModsPath.TabIndex = 5;
			this.GameModsPath.WordWrap = false;
			this.GameModsPath.TextChanged += new System.EventHandler(this.GameModsPath_TextChanged);
			// 
			// ManagerModsPath
			// 
			this.ManagerModsPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ManagerModsPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
			this.ManagerModsPath.Location = new System.Drawing.Point(186, 67);
			this.ManagerModsPath.Name = "ManagerModsPath";
			this.ManagerModsPath.Size = new System.Drawing.Size(388, 20);
			this.ManagerModsPath.TabIndex = 6;
			this.ManagerModsPath.TextChanged += new System.EventHandler(this.ManagerModsPath_TextChanged);
			// 
			// xEditPath
			// 
			this.xEditPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.xEditPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
			this.xEditPath.Location = new System.Drawing.Point(186, 93);
			this.xEditPath.Name = "xEditPath";
			this.xEditPath.Size = new System.Drawing.Size(388, 20);
			this.xEditPath.TabIndex = 7;
			this.xEditPath.TextChanged += new System.EventHandler(this.xEditPath_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Path To Game Folder";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(166, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Path To Mod manager Mods path";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(157, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Path To XEdit (sseedit/tes5edit)";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(557, 78);
			this.label5.TabIndex = 11;
			this.label5.Text = resources.GetString("label5.Text");
			// 
			// PageCraft
			// 
			this.PageCraft.Location = new System.Drawing.Point(4, 22);
			this.PageCraft.Name = "PageCraft";
			this.PageCraft.Padding = new System.Windows.Forms.Padding(3);
			this.PageCraft.Size = new System.Drawing.Size(600, 353);
			this.PageCraft.TabIndex = 6;
			this.PageCraft.Text = "Crafting review";
			this.PageCraft.UseVisualStyleBackColor = true;
			// 
			// Preview
			// 
			this.Preview.Location = new System.Drawing.Point(4, 22);
			this.Preview.Name = "Preview";
			this.Preview.Padding = new System.Windows.Forms.Padding(3);
			this.Preview.Size = new System.Drawing.Size(600, 353);
			this.Preview.TabIndex = 7;
			this.Preview.Text = "should I add a preview window here? maybe use bodyslides?";
			this.Preview.UseVisualStyleBackColor = true;
			// 
			// RadioRulesetVanilla
			// 
			this.RadioRulesetVanilla.AutoSize = true;
			this.RadioRulesetVanilla.Checked = true;
			this.RadioRulesetVanilla.Location = new System.Drawing.Point(22, 124);
			this.RadioRulesetVanilla.Name = "RadioRulesetVanilla";
			this.RadioRulesetVanilla.Size = new System.Drawing.Size(95, 17);
			this.RadioRulesetVanilla.TabIndex = 12;
			this.RadioRulesetVanilla.TabStop = true;
			this.RadioRulesetVanilla.Tag = "Ruleset";
			this.RadioRulesetVanilla.Text = "Vanilla Ruleset";
			this.RadioRulesetVanilla.UseVisualStyleBackColor = true;
			// 
			// RadioRulesetWACCF
			// 
			this.RadioRulesetWACCF.AutoSize = true;
			this.RadioRulesetWACCF.Location = new System.Drawing.Point(22, 147);
			this.RadioRulesetWACCF.Name = "RadioRulesetWACCF";
			this.RadioRulesetWACCF.Size = new System.Drawing.Size(102, 17);
			this.RadioRulesetWACCF.TabIndex = 13;
			this.RadioRulesetWACCF.Tag = "Ruleset";
			this.RadioRulesetWACCF.Text = "WACCF Ruleset";
			this.RadioRulesetWACCF.UseVisualStyleBackColor = true;
			// 
			// RadioRulesetCCOR
			// 
			this.RadioRulesetCCOR.AutoSize = true;
			this.RadioRulesetCCOR.Location = new System.Drawing.Point(22, 170);
			this.RadioRulesetCCOR.Name = "RadioRulesetCCOR";
			this.RadioRulesetCCOR.Size = new System.Drawing.Size(94, 17);
			this.RadioRulesetCCOR.TabIndex = 14;
			this.RadioRulesetCCOR.Tag = "Ruleset";
			this.RadioRulesetCCOR.Text = "CCOR Ruleset";
			this.RadioRulesetCCOR.UseVisualStyleBackColor = true;
			// 
			// RadioRulesetCustom
			// 
			this.RadioRulesetCustom.AutoSize = true;
			this.RadioRulesetCustom.Location = new System.Drawing.Point(22, 193);
			this.RadioRulesetCustom.Name = "RadioRulesetCustom";
			this.RadioRulesetCustom.Size = new System.Drawing.Size(99, 17);
			this.RadioRulesetCustom.TabIndex = 15;
			this.RadioRulesetCustom.Tag = "Ruleset";
			this.RadioRulesetCustom.Text = "Custom Ruleset";
			this.RadioRulesetCustom.UseVisualStyleBackColor = true;
			// 
			// RulesetCustomGenerate
			// 
			this.RulesetCustomGenerate.Enabled = false;
			this.RulesetCustomGenerate.Location = new System.Drawing.Point(127, 193);
			this.RulesetCustomGenerate.Name = "RulesetCustomGenerate";
			this.RulesetCustomGenerate.Size = new System.Drawing.Size(116, 23);
			this.RulesetCustomGenerate.TabIndex = 16;
			this.RulesetCustomGenerate.Text = "Generate Rulesets";
			this.RulesetCustomGenerate.UseVisualStyleBackColor = true;
			// 
			// textBox4
			// 
			this.textBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
			this.textBox4.Enabled = false;
			this.textBox4.Location = new System.Drawing.Point(249, 196);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 17;
			// 
			// PanelStart
			// 
			this.PanelStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PanelStart.Controls.Add(this.label5);
			this.PanelStart.Controls.Add(this.textBox4);
			this.PanelStart.Controls.Add(this.RadioRulesetVanilla);
			this.PanelStart.Controls.Add(this.RulesetCustomGenerate);
			this.PanelStart.Controls.Add(this.RadioRulesetWACCF);
			this.PanelStart.Controls.Add(this.RadioRulesetCustom);
			this.PanelStart.Controls.Add(this.RadioRulesetCCOR);
			this.PanelStart.Enabled = false;
			this.PanelStart.Location = new System.Drawing.Point(6, 119);
			this.PanelStart.Name = "PanelStart";
			this.PanelStart.Size = new System.Drawing.Size(588, 228);
			this.PanelStart.TabIndex = 18;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 581F));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 7);
			this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(10, 10);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(587, 343);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkedListBox1.Font = new System.Drawing.Font("Segoe Print", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
            "Helmet",
            "Bevor",
            "Pauldron",
            "Cuirass",
            "Rerebrace",
            "Couter",
            "Plackart",
            "Vambrace",
            "Faulds",
            "Gauntlets",
            "Cuisses",
            "Poleyn",
            "Greaves",
            "Sabatons"});
			this.checkedListBox1.Location = new System.Drawing.Point(423, 6);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(171, 334);
			this.checkedListBox1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panel1.Location = new System.Drawing.Point(196, 7);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(221, 340);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(186, 347);
			this.panel2.TabIndex = 2;
			// 
			// WeaponTabPanel
			// 
			this.WeaponTabPanel.Controls.Add(this.Polearms);
			this.WeaponTabPanel.Controls.Add(this.Swords);
			this.WeaponTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.WeaponTabPanel.Location = new System.Drawing.Point(3, 3);
			this.WeaponTabPanel.Margin = new System.Windows.Forms.Padding(0);
			this.WeaponTabPanel.Name = "WeaponTabPanel";
			this.WeaponTabPanel.SelectedIndex = 0;
			this.WeaponTabPanel.Size = new System.Drawing.Size(594, 347);
			this.WeaponTabPanel.TabIndex = 0;
			// 
			// Polearms
			// 
			this.Polearms.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Polearms.BackgroundImage")));
			this.Polearms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Polearms.Location = new System.Drawing.Point(4, 22);
			this.Polearms.Name = "Polearms";
			this.Polearms.Padding = new System.Windows.Forms.Padding(3);
			this.Polearms.Size = new System.Drawing.Size(586, 321);
			this.Polearms.TabIndex = 0;
			this.Polearms.Text = "Polearms";
			this.Polearms.UseVisualStyleBackColor = true;
			// 
			// Swords
			// 
			this.Swords.Location = new System.Drawing.Point(4, 22);
			this.Swords.Name = "Swords";
			this.Swords.Padding = new System.Windows.Forms.Padding(3);
			this.Swords.Size = new System.Drawing.Size(586, 321);
			this.Swords.TabIndex = 1;
			this.Swords.Text = "Swords";
			this.Swords.UseVisualStyleBackColor = true;
			// 
			// WACMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(633, 404);
			this.Controls.Add(this.MainPanel);
			this.Name = "WACMainForm";
			this.Text = "WAC Weapons Armor and Clothing Builder";
			this.MainPanel.ResumeLayout(false);
			this.PageStart.ResumeLayout(false);
			this.PageStart.PerformLayout();
			this.PageMod.ResumeLayout(false);
			this.PageMod.PerformLayout();
			this.PageArmor.ResumeLayout(false);
			this.PageWeapon.ResumeLayout(false);
			this.PanelStart.ResumeLayout(false);
			this.PanelStart.PerformLayout();
			this.WeaponTabPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl MainPanel;
		private System.Windows.Forms.TabPage PageStart;
		private System.Windows.Forms.TabPage PageMod;
		private System.Windows.Forms.TabPage PageSet;
		private System.Windows.Forms.RadioButton RadioRulesetCustom;
		private System.Windows.Forms.RadioButton RadioRulesetCCOR;
		private System.Windows.Forms.RadioButton RadioRulesetWACCF;
		private System.Windows.Forms.RadioButton RadioRulesetVanilla;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox xEditPath;
		private System.Windows.Forms.TextBox ManagerModsPath;
		private System.Windows.Forms.TextBox GameModsPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage PageArmor;
		private System.Windows.Forms.TabPage PageWeapon;
		private System.Windows.Forms.TabPage PageClothing;
		private System.Windows.Forms.TabPage PageCraft;
		private System.Windows.Forms.TabPage Preview;
		private System.Windows.Forms.Button RulesetCustomGenerate;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Panel PanelStart;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabControl WeaponTabPanel;
		private System.Windows.Forms.TabPage Polearms;
		private System.Windows.Forms.TabPage Swords;
	}
}

