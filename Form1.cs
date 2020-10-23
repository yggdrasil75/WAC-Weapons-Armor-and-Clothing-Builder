using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WAC_Weapons_Armor_and_Clothing_Builder
{
	public partial class WACMainForm : Form
	{
		public WACMainForm()
		{
			InitializeComponent();
			if (!File.Exists(xEditPath.Text) || !Directory.Exists(GameModsPath.Text) || !Directory.Exists(ManagerModsPath.Text))
			{
				PanelStart.Enabled = false;
			}
			else
			{
				PanelStart.Enabled = true;
			}
		}

		private void xEditPath_TextChanged(object sender, EventArgs e)
		{
			if (!File.Exists(xEditPath.Text) || !Directory.Exists(GameModsPath.Text) || !Directory.Exists(ManagerModsPath.Text) )
			{
				PanelStart.Enabled = false;
			}
			else
			{
				PanelStart.Enabled = true;
			}
		}

		private void ManagerModsPath_TextChanged(object sender, EventArgs e)
		{
			if (!File.Exists(xEditPath.Text) || !Directory.Exists(GameModsPath.Text) || !Directory.Exists(ManagerModsPath.Text))
			{
				PanelStart.Enabled = false;
			}
			else
			{
				PanelStart.Enabled = true;
			}
		}

		private void GameModsPath_TextChanged(object sender, EventArgs e)
		{
			if (!File.Exists(xEditPath.Text) || !Directory.Exists(GameModsPath.Text) || !Directory.Exists(ManagerModsPath.Text))
			{
				PanelStart.Enabled = false;
			}
			else
			{
				PanelStart.Enabled = true;
			}
		}
	}
}
