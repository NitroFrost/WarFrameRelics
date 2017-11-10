/*
 * Created by NitroFrost
 * Version 1.01
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WarFrame
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void RunClick(object sender, EventArgs e)
		{
			try
			{
				string[] lines = System.IO.File.ReadAllLines(txtPath.Text.Trim());
				
				RelicList1.Items.Clear();
				RelicList2.Items.Clear();
				RelicList3.Items.Clear();
				RelicList4.Items.Clear();
				string cbSelection1 = cbRelic.SelectedItem.ToString() + Relic1.Text.ToString().ToUpper();
				string cbSelection2 = cbRelic.SelectedItem.ToString() + Relic2.Text.ToString().ToUpper();
				string cbSelection3 = cbRelic.SelectedItem.ToString() + Relic3.Text.ToString().ToUpper();
				string cbSelection4 = cbRelic.SelectedItem.ToString() + Relic4.Text.ToString().ToUpper();
				bool owned = cbOwned.Checked;
				
				for(int i = 0; i < lines.Length; i++)
				{
					if(cbSelection1 == lines[i].ToString())
					{
						while(lines[i].ToString() != "++")
						{
							if(owned == true)
							{
								if(lines[i].ToString()[0].ToString() != "@")
								{
									RelicList1.Items.Add(lines[i].ToString());
									i++;
								}
								else
								{
									i++;
								}
							}
							else
							{
								RelicList1.Items.Add(lines[i].ToString());
								i++;
							}
						}
						RelicList1.Items.RemoveAt(0);
						break;
					}
				}
				
				for(int i = 0; i < lines.Length; i++)
				{
					if(cbSelection2 == lines[i].ToString())
					{
						while(lines[i].ToString() != "++")
						{
							if(owned == true)
							{
								if(lines[i].ToString()[0].ToString() != "@")
								{
									RelicList2.Items.Add(lines[i].ToString());
									i++;
								}
								else
								{
									i++;
								}
							}
							else
							{
								RelicList2.Items.Add(lines[i].ToString());
								i++;
							}
						}
							RelicList2.Items.RemoveAt(0);
							break;
					}
				}
				
				for(int i = 0; i < lines.Length; i++)
				{
					if(cbSelection3 == lines[i].ToString())
					{
						while(lines[i].ToString() != "++")
						{
							if(owned == true)
							{
								if(lines[i].ToString()[0].ToString() != "@")
								{
									RelicList3.Items.Add(lines[i].ToString());
									i++;
								}
								else
								{
									i++;
								}
							}
							else
							{
								RelicList3.Items.Add(lines[i].ToString());
								i++;
							}
						}
							RelicList3.Items.RemoveAt(0);
							break;
					}
				}
				for(int i = 0; i < lines.Length; i++)
				{
					if(cbSelection4 == lines[i].ToString())
					{
						while(lines[i].ToString() != "++")
						{
							if(owned == true)
							{
								if(lines[i].ToString()[0].ToString() != "@")
								{
									RelicList4.Items.Add(lines[i].ToString());
									i++;
								}
								else
								{
									i++;
								}
							}
							else
							{
								RelicList4.Items.Add(lines[i].ToString());
								i++;
							}
						}
							RelicList4.Items.RemoveAt(0);
							break;
					}
				}
				
			}
			catch
			{
				
			}
	
		}
		void BrowseClick(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog op = new OpenFileDialog();
				//op.ShowDialog();
				if(op.ShowDialog() == DialogResult.OK)
				{
					txtPath.Text = op.FileName;
				}

			}
			catch
			{
				
			}
	
		}
	}
}
