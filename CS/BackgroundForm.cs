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


/// <summary>
/// Form used in LockSystem mode. Contains an image of grayed desktop.
/// </summary>
namespace DoorsPOS.WinApp
{
	internal class BackgroundForm : Form
	{
		
		private Bitmap background;
		
		public BackgroundForm(Bitmap background)
		{
			this.BackColor = Color.Black;
			this.FormBorderStyle = FormBorderStyle.None;
			this.Location = Point.Empty;
			this.Size = Screen.PrimaryScreen.Bounds.Size;
			this.StartPosition = FormStartPosition.Manual;
			this.Visible = true;
			this.background = background;
		}
		
		protected override void OnShown(System.EventArgs e)
		{
			this.BackgroundImage = background;
			this.DoubleBuffered = true;
			base.OnShown(e);
		}
		
	}
}
