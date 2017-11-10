/*
 * Created by SharpDevelop.
 * User: Yggdrasil
 * Date: 11/9/2017
 * Time: 7:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WarFrame
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox Relic1;
		private System.Windows.Forms.TextBox Relic2;
		private System.Windows.Forms.TextBox Relic3;
		private System.Windows.Forms.TextBox Relic4;
		private System.Windows.Forms.ListBox RelicList1;
		private System.Windows.Forms.ListBox RelicList2;
		private System.Windows.Forms.ListBox RelicList3;
		private System.Windows.Forms.ListBox RelicList4;
		private System.Windows.Forms.Button Run;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Button Browse;
		private System.Windows.Forms.ComboBox cbRelic;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox cbOwned;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.Relic1 = new System.Windows.Forms.TextBox();
			this.Relic2 = new System.Windows.Forms.TextBox();
			this.Relic3 = new System.Windows.Forms.TextBox();
			this.Relic4 = new System.Windows.Forms.TextBox();
			this.RelicList1 = new System.Windows.Forms.ListBox();
			this.RelicList2 = new System.Windows.Forms.ListBox();
			this.RelicList3 = new System.Windows.Forms.ListBox();
			this.RelicList4 = new System.Windows.Forms.ListBox();
			this.Run = new System.Windows.Forms.Button();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.Browse = new System.Windows.Forms.Button();
			this.cbRelic = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cbOwned = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// Relic1
			// 
			this.Relic1.Location = new System.Drawing.Point(72, 76);
			this.Relic1.MaxLength = 2;
			this.Relic1.Name = "Relic1";
			this.Relic1.Size = new System.Drawing.Size(27, 20);
			this.Relic1.TabIndex = 0;
			// 
			// Relic2
			// 
			this.Relic2.Location = new System.Drawing.Point(286, 76);
			this.Relic2.MaxLength = 2;
			this.Relic2.Name = "Relic2";
			this.Relic2.Size = new System.Drawing.Size(26, 20);
			this.Relic2.TabIndex = 1;
			// 
			// Relic3
			// 
			this.Relic3.Location = new System.Drawing.Point(498, 76);
			this.Relic3.MaxLength = 2;
			this.Relic3.Name = "Relic3";
			this.Relic3.Size = new System.Drawing.Size(31, 20);
			this.Relic3.TabIndex = 2;
			// 
			// Relic4
			// 
			this.Relic4.Location = new System.Drawing.Point(707, 76);
			this.Relic4.MaxLength = 2;
			this.Relic4.Name = "Relic4";
			this.Relic4.Size = new System.Drawing.Size(26, 20);
			this.Relic4.TabIndex = 3;
			// 
			// RelicList1
			// 
			this.RelicList1.FormattingEnabled = true;
			this.RelicList1.Location = new System.Drawing.Point(10, 114);
			this.RelicList1.Name = "RelicList1";
			this.RelicList1.Size = new System.Drawing.Size(162, 147);
			this.RelicList1.TabIndex = 4;
			// 
			// RelicList2
			// 
			this.RelicList2.FormattingEnabled = true;
			this.RelicList2.Location = new System.Drawing.Point(225, 114);
			this.RelicList2.Name = "RelicList2";
			this.RelicList2.Size = new System.Drawing.Size(161, 147);
			this.RelicList2.TabIndex = 5;
			// 
			// RelicList3
			// 
			this.RelicList3.FormattingEnabled = true;
			this.RelicList3.Location = new System.Drawing.Point(437, 114);
			this.RelicList3.Name = "RelicList3";
			this.RelicList3.Size = new System.Drawing.Size(161, 147);
			this.RelicList3.TabIndex = 6;
			// 
			// RelicList4
			// 
			this.RelicList4.FormattingEnabled = true;
			this.RelicList4.Location = new System.Drawing.Point(643, 114);
			this.RelicList4.Name = "RelicList4";
			this.RelicList4.Size = new System.Drawing.Size(164, 147);
			this.RelicList4.TabIndex = 7;
			// 
			// Run
			// 
			this.Run.Location = new System.Drawing.Point(128, 283);
			this.Run.Name = "Run";
			this.Run.Size = new System.Drawing.Size(562, 23);
			this.Run.TabIndex = 8;
			this.Run.Text = "RUN";
			this.Run.UseVisualStyleBackColor = true;
			this.Run.Click += new System.EventHandler(this.RunClick);
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(12, 33);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(453, 20);
			this.txtPath.TabIndex = 9;
			// 
			// Browse
			// 
			this.Browse.Location = new System.Drawing.Point(471, 31);
			this.Browse.Name = "Browse";
			this.Browse.Size = new System.Drawing.Size(75, 23);
			this.Browse.TabIndex = 10;
			this.Browse.Text = "Browse";
			this.Browse.UseVisualStyleBackColor = true;
			this.Browse.Click += new System.EventHandler(this.BrowseClick);
			// 
			// cbRelic
			// 
			this.cbRelic.FormattingEnabled = true;
			this.cbRelic.Items.AddRange(new object[] {
			"Lith ",
			"Meso ",
			"Neo ",
			"Axi "});
			this.cbRelic.Location = new System.Drawing.Point(565, 31);
			this.cbRelic.Name = "cbRelic";
			this.cbRelic.Size = new System.Drawing.Size(111, 21);
			this.cbRelic.TabIndex = 11;
			this.cbRelic.Text = "- Pick Relic Type -";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(452, 23);
			this.label2.TabIndex = 1000;
			this.label2.Text = "Relic List Directory";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 23);
			this.label3.TabIndex = 1001;
			this.label3.Text = "P1 Relic";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(227, 79);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 23);
			this.label4.TabIndex = 1002;
			this.label4.Text = "P2 Relic";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(439, 79);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 23);
			this.label5.TabIndex = 1003;
			this.label5.Text = "P3 Relic";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(648, 79);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 23);
			this.label6.TabIndex = 1004;
			this.label6.Text = "P4 Relic";
			// 
			// cbOwned
			// 
			this.cbOwned.Location = new System.Drawing.Point(703, 29);
			this.cbOwned.Name = "cbOwned";
			this.cbOwned.Size = new System.Drawing.Size(122, 24);
			this.cbOwned.TabIndex = 1005;
			this.cbOwned.Text = "Ignore Owned? \'@\'";
			this.cbOwned.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 361);
			this.Controls.Add(this.cbOwned);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbRelic);
			this.Controls.Add(this.Browse);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.Run);
			this.Controls.Add(this.RelicList4);
			this.Controls.Add(this.RelicList3);
			this.Controls.Add(this.RelicList2);
			this.Controls.Add(this.RelicList1);
			this.Controls.Add(this.Relic4);
			this.Controls.Add(this.Relic3);
			this.Controls.Add(this.Relic2);
			this.Controls.Add(this.Relic1);
			this.Name = "MainForm";
			this.Text = "WarFrame";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
