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
	partial class frmPasswordInput : System.Windows.Forms.Form
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
			this.labLblPassword = new DevExpress.XtraEditors.LabelControl();
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(frmPasswordInput_FormClosed);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(frmPasswordInput_KeyDown);
			this.txtPassword = new DevExpress.XtraEditors.TextEdit();
			this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
			((System.ComponentModel.ISupportInitialize) this.txtPassword.Properties).BeginInit();
			this.SuspendLayout();
			//
			//labLblPassword
			//
			this.labLblPassword.Appearance.Font = new System.Drawing.Font("Courier New", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.labLblPassword.Location = new System.Drawing.Point(12, 62);
			this.labLblPassword.Name = "labLblPassword";
			this.labLblPassword.Size = new System.Drawing.Size(140, 18);
			this.labLblPassword.TabIndex = 0;
			this.labLblPassword.Text = "Enter Password";
			//
			//txtPassword
			//
			this.txtPassword.Location = new System.Drawing.Point(158, 59);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Courier New", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtPassword.Properties.Appearance.Options.UseFont = true;
			this.txtPassword.Properties.PasswordChar = global::Microsoft.VisualBasic.Strings.ChrW(42);
			this.txtPassword.Size = new System.Drawing.Size(263, 24);
			this.txtPassword.TabIndex = 1;
			//
			//frmPasswordInput
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(436, 157);
			this.ControlBox = false;
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.labLblPassword);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPasswordInput";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Enter Password";
			((System.ComponentModel.ISupportInitialize) this.txtPassword.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal DevExpress.XtraEditors.LabelControl labLblPassword;
		internal DevExpress.XtraEditors.TextEdit txtPassword;
	}
	
}
