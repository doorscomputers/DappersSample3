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
	partial class frmQty : System.Windows.Forms.Form
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
			this.ceQty = new DevExpress.XtraEditors.CalcEdit();
			this.ceQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceQty_KeyDown);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(frmQty_FormClosed);
			this.Load += new System.EventHandler(frmQty_Load);
			this.ceQty.EditValueChanged += new System.EventHandler(this.ceQty_EditValueChanged);
			((System.ComponentModel.ISupportInitialize) this.ceQty.Properties).BeginInit();
			this.SuspendLayout();
			//
			//ceQty
			//
			this.ceQty.Location = new System.Drawing.Point(15, 68);
			this.ceQty.Name = "ceQty";
			this.ceQty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (80.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ceQty.Properties.Appearance.Options.UseFont = true;
			this.ceQty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceQty.Properties.DisplayFormat.FormatString = "N2";
			this.ceQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.ceQty.Size = new System.Drawing.Size(436, 136);
			this.ceQty.TabIndex = 1;
			//
			//frmQty
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(466, 273);
			this.Controls.Add(this.ceQty);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmQty";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quantity Bought";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize) this.ceQty.Properties).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraEditors.CalcEdit ceQty;
	}
	
}
