/*
 * Created by SharpDevelop.
 * User: Lenovo
 * Date: 3/22/2022
 * Time: 8:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PV_Tugas5
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void ButtontambahClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textboxangka1.Text) || string.IsNullOrEmpty(textboxangka2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 Tidak Boleh Kosong");
			}
			else
			{
				int a,b,c;
				a = int.Parse(this.textboxangka1.Text);
				b = int.Parse(this.textboxangka2.Text);
				c = a + b;
				this.labeltampilhasil.Text = c.ToString();
			}
		}
		
		void ButtonkurangClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textboxangka1.Text) || string.IsNullOrEmpty(textboxangka2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 Tidak Boleh Kosong");
			}
			else
			{
				int a,b,c;
				a = int.Parse(this.textboxangka1.Text);
				b = int.Parse(this.textboxangka2.Text);
				c = a - b;
				this.labeltampilhasil.Text = c.ToString();
			}
		}
		
		void ButtonkaliClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textboxangka1.Text) || string.IsNullOrEmpty(textboxangka2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 Tidak Boleh Kosong");
			}
			else
			{
				int a,b,c;
				a = int.Parse(this.textboxangka1.Text);
				b = int.Parse(this.textboxangka2.Text);
				c = a * b;
				this.labeltampilhasil.Text = c.ToString();
			}
		}
		
		void ButtonbagiClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textboxangka1.Text) || string.IsNullOrEmpty(textboxangka2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 Tidak Boleh Kosong");
			}
			else
			{
				int a,b,c;
				a = int.Parse(this.textboxangka1.Text);
				b = int.Parse(this.textboxangka2.Text);
				c = a / b;
				this.labeltampilhasil.Text = c.ToString();
			}
		}
		
		void ButtonclearClick(object sender, EventArgs e)
		{
			textboxangka1.Clear();
			textboxangka2.Clear();
			labeltampilhasil.Text = "";
		}
	}
}
