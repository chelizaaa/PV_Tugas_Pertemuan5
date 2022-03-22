/*
 * Created by SharpDevelop.
 * User: Lenovo
 * Date: 3/22/2022
 * Time: 8:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PV_Tugas5
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.labelangka1 = new System.Windows.Forms.Label();
			this.labelangka2 = new System.Windows.Forms.Label();
			this.labelhasil = new System.Windows.Forms.Label();
			this.labeltampilhasil = new System.Windows.Forms.Label();
			this.textboxangka1 = new System.Windows.Forms.TextBox();
			this.textboxangka2 = new System.Windows.Forms.TextBox();
			this.buttontambah = new System.Windows.Forms.Button();
			this.buttonkurang = new System.Windows.Forms.Button();
			this.buttonkali = new System.Windows.Forms.Button();
			this.buttonbagi = new System.Windows.Forms.Button();
			this.buttonclear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelangka1
			// 
			this.labelangka1.Location = new System.Drawing.Point(12, 25);
			this.labelangka1.Name = "labelangka1";
			this.labelangka1.Size = new System.Drawing.Size(100, 23);
			this.labelangka1.TabIndex = 0;
			this.labelangka1.Text = "Angka 1";
			// 
			// labelangka2
			// 
			this.labelangka2.Location = new System.Drawing.Point(12, 48);
			this.labelangka2.Name = "labelangka2";
			this.labelangka2.Size = new System.Drawing.Size(100, 23);
			this.labelangka2.TabIndex = 1;
			this.labelangka2.Text = "Angka 2";
			// 
			// labelhasil
			// 
			this.labelhasil.Location = new System.Drawing.Point(12, 71);
			this.labelhasil.Name = "labelhasil";
			this.labelhasil.Size = new System.Drawing.Size(100, 23);
			this.labelhasil.TabIndex = 2;
			this.labelhasil.Text = "Hasil";
			// 
			// labeltampilhasil
			// 
			this.labeltampilhasil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labeltampilhasil.Location = new System.Drawing.Point(72, 68);
			this.labeltampilhasil.Name = "labeltampilhasil";
			this.labeltampilhasil.Size = new System.Drawing.Size(153, 26);
			this.labeltampilhasil.TabIndex = 3;
			// 
			// textboxangka1
			// 
			this.textboxangka1.Location = new System.Drawing.Point(72, 22);
			this.textboxangka1.Name = "textboxangka1";
			this.textboxangka1.Size = new System.Drawing.Size(153, 20);
			this.textboxangka1.TabIndex = 4;
			// 
			// textboxangka2
			// 
			this.textboxangka2.Location = new System.Drawing.Point(72, 45);
			this.textboxangka2.Name = "textboxangka2";
			this.textboxangka2.Size = new System.Drawing.Size(153, 20);
			this.textboxangka2.TabIndex = 5;
			// 
			// buttontambah
			// 
			this.buttontambah.Location = new System.Drawing.Point(69, 119);
			this.buttontambah.Name = "buttontambah";
			this.buttontambah.Size = new System.Drawing.Size(75, 23);
			this.buttontambah.TabIndex = 6;
			this.buttontambah.Text = "+";
			this.buttontambah.UseVisualStyleBackColor = true;
			this.buttontambah.Click += new System.EventHandler(this.ButtontambahClick);
			// 
			// buttonkurang
			// 
			this.buttonkurang.Location = new System.Drawing.Point(150, 119);
			this.buttonkurang.Name = "buttonkurang";
			this.buttonkurang.Size = new System.Drawing.Size(75, 23);
			this.buttonkurang.TabIndex = 7;
			this.buttonkurang.Text = "-";
			this.buttonkurang.UseVisualStyleBackColor = true;
			this.buttonkurang.Click += new System.EventHandler(this.ButtonkurangClick);
			// 
			// buttonkali
			// 
			this.buttonkali.Location = new System.Drawing.Point(69, 148);
			this.buttonkali.Name = "buttonkali";
			this.buttonkali.Size = new System.Drawing.Size(75, 23);
			this.buttonkali.TabIndex = 8;
			this.buttonkali.Text = "*";
			this.buttonkali.UseVisualStyleBackColor = true;
			this.buttonkali.Click += new System.EventHandler(this.ButtonkaliClick);
			// 
			// buttonbagi
			// 
			this.buttonbagi.Location = new System.Drawing.Point(150, 148);
			this.buttonbagi.Name = "buttonbagi";
			this.buttonbagi.Size = new System.Drawing.Size(75, 23);
			this.buttonbagi.TabIndex = 9;
			this.buttonbagi.Text = "/";
			this.buttonbagi.UseVisualStyleBackColor = true;
			this.buttonbagi.Click += new System.EventHandler(this.ButtonbagiClick);
			// 
			// buttonclear
			// 
			this.buttonclear.Location = new System.Drawing.Point(110, 177);
			this.buttonclear.Name = "buttonclear";
			this.buttonclear.Size = new System.Drawing.Size(75, 23);
			this.buttonclear.TabIndex = 10;
			this.buttonclear.Text = "C";
			this.buttonclear.UseVisualStyleBackColor = true;
			this.buttonclear.Click += new System.EventHandler(this.ButtonclearClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.buttonclear);
			this.Controls.Add(this.buttonbagi);
			this.Controls.Add(this.buttonkali);
			this.Controls.Add(this.buttonkurang);
			this.Controls.Add(this.buttontambah);
			this.Controls.Add(this.textboxangka2);
			this.Controls.Add(this.textboxangka1);
			this.Controls.Add(this.labeltampilhasil);
			this.Controls.Add(this.labelhasil);
			this.Controls.Add(this.labelangka2);
			this.Controls.Add(this.labelangka1);
			this.Name = "MainForm";
			this.Text = "Kalkulator";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button buttonclear;
		private System.Windows.Forms.Button buttonbagi;
		private System.Windows.Forms.Button buttonkali;
		private System.Windows.Forms.Button buttonkurang;
		private System.Windows.Forms.Button buttontambah;
		private System.Windows.Forms.TextBox textboxangka2;
		private System.Windows.Forms.TextBox textboxangka1;
		private System.Windows.Forms.Label labeltampilhasil;
		private System.Windows.Forms.Label labelhasil;
		private System.Windows.Forms.Label labelangka2;
		private System.Windows.Forms.Label labelangka1;
	}
}
