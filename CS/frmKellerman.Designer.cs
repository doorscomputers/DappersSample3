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
	partial class frmKellerman : System.Windows.Forms.Form
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
			this.btnButton1 = new System.Windows.Forms.Button();
			base.Load += new System.EventHandler(frmKellerman_Load);
			this.btnButton1.Click += new System.EventHandler(this.btnButton1_Click);
			this.SuspendLayout();
			//
			//btnButton1
			//
			this.btnButton1.Location = new System.Drawing.Point(58, 221);
			this.btnButton1.Name = "btnButton1";
			this.btnButton1.Size = new System.Drawing.Size(166, 28);
			this.btnButton1.TabIndex = 0;
			this.btnButton1.Text = "Button1";
			this.btnButton1.UseVisualStyleBackColor = true;
			//
			//frmKellerman
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnButton1);
			this.Name = "frmKellerman";
			this.Text = "frmKellerman";
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.Button btnButton1;
	}
	
}
