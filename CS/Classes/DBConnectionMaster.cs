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

using System.Data.SqlClient;
using System.Threading;

namespace DoorsPOS.WinApp
{
	public class DBConnectionMaster
	{
		protected SqlConnection sqlcon;
		
		//protected SqlConnection sqlconTest;
		private string strServer = "DOORSCOMPUTERS\\\\sqlexpress";
		
		private string path1 = string.Empty;
		
		public DBConnectionMaster()
		{
			//-------------Single User----------------------//
			try
			{
				strServer = "DOORSCOMPUTERS\\\\sqlexpress";
				
				ChangeConnectionForServerMaster();
				
			}
			catch (Exception)
			{
				//Catche any other exception
			}
			finally
			{
				
			}
			
		}
		
		/// <summary>
		/// SQL Express may take time to start up due to AutoClose Behaviour of SQLEXPRESS
		///
		/// </summary>
		private void Reconnect()
		{
			try
			{
				Thread.Sleep(30000);
				if (sqlcon.State == ConnectionState.Closed)
				{
					sqlcon.Open();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Your SQL Server is starting up... Please close and re-open the application");
			}
		}
		
		/// <summary>
		/// Cheanges the connection string to support SQLServer version instead of SQLExpress
		/// </summary>
		private void ChangeConnectionForServerMaster()
		{
			//sqlcon = New SqlConnection(("Data Source=" _
			//                + (strServer + (";AttachDbFilename=" _
			//                + (path1 + ";Integrated Security=True;Connect Timeout=120;")))))
			sqlcon = new SqlConnection("Data Source=DOORSCOMPUTERS\\SqlExpress;Initial Catalog=master;Integrated Security=True;");
		}
	}
	
	
	
	
	
}
