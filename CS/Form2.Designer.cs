// VBConversions Note: VB project level imports
using System.Data;
using System.Collections.Generic;
using PDSA.Data;
using PDSA.WinForms.Forms;
using PDSA.Security;
using System.Diagnostics;
using PDSA.Common;
using PDSA.WinForms;
using PDSA.WinForms.Security;
using PDSA.PDSACryptography;
using DoorsPOS.Utility;
using Microsoft.VisualBasic;
using System.Collections;
using System;
using DoorsPOS.BusinessLayer;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using DoorsPOS.DataLayer;
// End of VB project level imports


namespace DoorsPOS.WinApp
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class Form2 : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.DoubleClick += new System.EventHandler(Form2_DoubleClick);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Form2_FormClosed);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(Form2_FormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(Form2_KeyDown);
			base.Load += new System.EventHandler(Form2_Load);
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.txtPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPwd_KeyPress);
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(246, 3);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(152, 36);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Login";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button1.Visible = false;
			//
			//txtPwd
			//
			this.txtPwd.Location = new System.Drawing.Point(88, 19);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.PasswordChar = global::Microsoft.VisualBasic.Strings.ChrW(42);
			this.txtPwd.Size = new System.Drawing.Size(152, 20);
			this.txtPwd.TabIndex = 1;
			this.txtPwd.Visible = false;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(23, 22);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(59, 13);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Password :";
			this.Label1.Visible = false;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (150.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)));
			this.Label2.Location = new System.Drawing.Point(118, 58);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(847, 226);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "N E X T ";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (150.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.ForeColor = System.Drawing.Color.Red;
			this.Label3.Location = new System.Drawing.Point(-3, 270);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(1089, 226);
			this.Label3.TabIndex = 3;
			this.Label3.Text = "COUNTER";
			//
			//Form2
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1083, 584);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.txtPwd);
			this.Controls.Add(this.Button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.TextBox txtPwd;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
	}
	
}
