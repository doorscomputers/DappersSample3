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
	public class RestoreDatabases : DBConnectionMaster
	{
		public void ResToreDatabases()
		{
			sqlcon.Open();
			OpenFileDialog opDialog = new OpenFileDialog();
			
			opDialog.Filter = "BackUp Files (*.bak)|*.bak";
			opDialog.Title = "Select your .bak file for restore the database OpenMiracle";
			string path = "";
			//     path = "c:\sqlData3"
			
			if (opDialog.ShowDialog() == DialogResult.OK)
			{
				string filePath = opDialog.FileName;
				string fileName = filePath;
				
				string sqlSTR = string.Empty;
				//sqlSTR = "exec RestoreDB @file=" + fileName
				sqlSTR = "exec RestoreDB @file=" + "\'" + fileName + "\'";
				ModCon.ExecuteSQLQueryMaster(sqlSTR);
			}
			
		}
		
	}
	
}
