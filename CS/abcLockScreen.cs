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

using System.Threading;

/// <summary>
/// I got this piece of code spread on another tutorial, that I found on interent. So, I collected and joined together for my use.
/// </summary>
/// <remarks>I have removed some unwanted piece of information. But it requires more updation to use it effectively.</remarks>
namespace DoorsPOS.WinApp
{
	public sealed class abcLockScreen
	{
		private Form myForm; //~~~ Will hold the form which you want to display. In this example, I'll display a Login screen
#region  System Locking Methods
		
		public bool LockSystemAndShow(Form myDForm)
		{
			myForm = myDForm;
			
			//Dim owner As Control = TryCast(Form1.Button1, Control)
			Screen scr = default(Screen);
			//If owner Is Nothing Then
			scr = Screen.PrimaryScreen;
			//Else
			//scr = Screen.FromControl(owner)
			//End If
			Bitmap background = new Bitmap(scr.Bounds.Width, scr.Bounds.Height);
			using (Graphics g = Graphics.FromImage(background))
			{
				
				g.CopyFromScreen(0, 0, 0, 0, scr.Bounds.Size);
				using (Brush br = new SolidBrush(Color.FromArgb(192, Color.Black)))
				{
					g.FillRectangle(br, scr.Bounds);
				}
				
				
				//If owner IsNot Nothing Then
				// Dim form As Form = owner.FindForm()
				// g.CopyFromScreen(form.Location, form.Location, form.Size)
				// Using br As Brush = New SolidBrush(Color.FromArgb(128, Color.Black))
				// g.FillRectangle(br, New Rectangle(Form.Location, Form.Size))
				//End Using
				//End If
				
			}
			
			
			IntPtr originalThread = default(IntPtr);
			IntPtr originalInput = default(IntPtr);
			IntPtr newDesktop = default(IntPtr);
			
			originalThread = Native.GetThreadDesktop(Thread.CurrentThread.ManagedThreadId);
			originalInput = Native.OpenInputDesktop(0, false, Native.DESKTOP_SWITCHDESKTOP);
			
			newDesktop = Native.CreateDesktop("Desktop" + Guid.NewGuid().ToString(), null, null, 0, Native.GENERIC_ALL, null);
			Native.SetThreadDesktop(newDesktop);
			Native.SwitchDesktop(newDesktop);
			
			Thread newThread = new Thread(new System.Threading.ThreadStart(NewThreadMethod));
			newThread.CurrentCulture = Thread.CurrentThread.CurrentCulture;
			newThread.CurrentUICulture = Thread.CurrentThread.CurrentUICulture;
			newThread.Start(new abcLockSystemParameters(newDesktop, background));
			newThread.Join();
			
			Native.SwitchDesktop(originalInput);
			Native.SetThreadDesktop(originalThread);
			
			Native.CloseDesktop(newDesktop);
			Native.CloseDesktop(originalInput);
			
			return true; //Result
			
		}
		
		private void NewThreadMethod(object @params)
		{
			abcLockSystemParameters v = (abcLockSystemParameters) (@params);
			Native.SetThreadDesktop(v.NewDesktop);
			using (Form f = new BackgroundForm(v.Background))
			{
				f.Show();
				myForm.ShowDialog(); //~~~~ Show the login screen here
				f.BackgroundImage = null;
				Application.DoEvents();
				Thread.Sleep(250);
			}
			
		}
		
#endregion
	}
	
}
