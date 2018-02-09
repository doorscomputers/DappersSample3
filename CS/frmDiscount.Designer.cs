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
	partial class frmDiscount : System.Windows.Forms.Form
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
			this.ceDisc = new DevExpress.XtraEditors.CalcEdit();
			this.ceDisc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceDisc_KeyDown);
			this.ceDisc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ceDisc_KeyPress);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(frmDiscount_FormClosed);
			((System.ComponentModel.ISupportInitialize) this.ceDisc.Properties).BeginInit();
			this.SuspendLayout();
			//
			//ceDisc
			//
			this.ceDisc.Location = new System.Drawing.Point(78, 63);
			this.ceDisc.Name = "ceDisc";
			this.ceDisc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (80.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ceDisc.Properties.Appearance.Options.UseFont = true;
			this.ceDisc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceDisc.Properties.DisplayFormat.FormatString = "N2";
			this.ceDisc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.ceDisc.Size = new System.Drawing.Size(436, 136);
			this.ceDisc.TabIndex = 0;
			//
			//frmDiscount
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 273);
			this.Controls.Add(this.ceDisc);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmDiscount";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Discount";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize) this.ceDisc.Properties).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraEditors.CalcEdit ceDisc;
	}
	
}
