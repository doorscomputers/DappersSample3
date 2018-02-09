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

using System.Data.OleDb;

namespace DoorsPOS.WinApp
{
	sealed class ModCon
	{
		//'Public fso As New filesystemobject
		//Public ParamDVFrom As New CrystalDecisions.Shared.ParameterDiscreteValue
		//Public ParamDVTo As New CrystalDecisions.Shared.ParameterDiscreteValue
		//Public ParamCompanyName As New CrystalDecisions.Shared.ParameterDiscreteValue
		//Public ParamCompanyLoc As New CrystalDecisions.Shared.ParameterDiscreteValue
		//Public ParamCompanyContact As New CrystalDecisions.Shared.ParameterDiscreteValue
		//Public ParamCompanyTIN As New CrystalDecisions.Shared.ParameterDiscreteValue
		//Public _USER As New CrystalDecisions.Shared.ParameterDiscreteValue
		//Public mReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
		public static DataTable sqlDT = new DataTable();
		public static DataTable sqlDTx = new DataTable();
		public static System.IO.Stream openedFileStream;
		
		//'Public Const cnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=../database/SaleInv_DB.mdb"
		//'Public Const cnString As String = "Provider=SQLNCLI10;Server=CPAT;Database=SaleInv_DB; Trusted_Connection=yes;"
		//'Public Const cnString As String = "Provider=SQLNCLI10;Server=CPAT;Database=SaleInv_DB;Uid=sa; Pwd=angelito;"
		
		//'Public Const cnstring As String = "Provider=SQLOLEDB;" & _
		//'                                  "Data Source=;" & _
		//'                                 "Network=CPAT;" & _
		//'                                  "Initial Catalog=SaleInv_DB;" & _
		//'                                  "User Id=sa;" & _
		//'                                  "Password=angelito"
		//'192.168.1.104;" & _'
		
		public static string CnString;
		
		//'Public conn As OleDbConnection = New OleDbConnection(cnString)
		//' Public DataFileLock As New System.Threading.ReaderWriterLock
		
		public static string sqlSTR;
		public static string Rpt_SqlStr;
		public static bool pass;
		public static double VAT;
		public static string username;
		public static int xUser_ID;
		public static string xUser_Access;
		public static int Pending_ID;
		public static int Pending_QTY;
		public static int Pending_Item_ID;
		public static byte[] dataBytes;
		public static bool xpass;
		public static int howx;
		public static int[] xid = new int[2];
		public static bool xlock;
		public static int iMin;
		public static string tmpStr;
		public static int LOGID;
		public static int PreviousPage;
		public static int NextPage;
		public static int i_Print;
		
		public static bool checkServer()
		{
			//Try
			
			//    With FrmSERVERSETTINGS
			//        .OpenFileDialog1.FileName = Application.StartupPath & "\Config.ini"
			//        openedFileStream = .OpenFileDialog1.OpenFile()
			//    End With
			
			//    ReDim dataBytes(openedFileStream.Length - 1) 'Init
			//    openedFileStream.Read(dataBytes, 0, openedFileStream.Length)
			//    openedFileStream.Close()
			//    tmpStr = System.Text.Encoding.Unicode.GetString(dataBytes)
			
			//    With FrmSERVERSETTINGS
			//        If Split(tmpStr, ":")(4) = "1" Then
			//            'network
			//            CnString = "Provider=SQLOLEDB;" & _
			//                       "Data Source=" & Split(tmpStr, ":")(0) & _
			//                       ";Network=" & Split(tmpStr, ":")(1) & _
			//                       ";Server=" & Split(tmpStr, ":")(1) & _
			//                       ";Initial Catalog=SaleInv_DB" & _
			//                       ";User Id=" & Split(tmpStr, ":")(2) & _
			//                       ";Password=" & Split(tmpStr, ":")(3)
			//        Else
			//            'local
			//            'MsgBox(Split(tmpStr, ":")(1))
			//            CnString = "Provider=SQLOLEDB;Server=" & Split(tmpStr, ":")(1) & _
			//                       ";Database=SaleInv_DB; Trusted_Connection=yes;"
			//        End If
			//    End With
			//    Dim sqlCon As New OleDbConnection
			//    sqlCon.ConnectionString = CnString
			//    sqlCon.Open()
			//    checkServer = True
			//    sqlCon.Close()
			//Catch ex As Exception
			//    checkServer = False
			//End Try
			return default(bool);
		}
		
		public static DataTable ExecuteSQLQuery(string SQLQuery)
		{
			//Try
			CnString = "Provider=SQLOLEDB;Server=DOORSCOMPUTERS\\SQLEXPRESS" + 
				";Database=doorspos; Trusted_Connection=yes;";
			OleDbConnection sqlCon = new OleDbConnection(CnString);
			OleDbDataAdapter sqlDA = new OleDbDataAdapter(SQLQuery, sqlCon);
			OleDbCommandBuilder sqlCB = new OleDbCommandBuilder(sqlDA);
			sqlDT.Reset(); // refresh
			sqlDA.Fill(sqlDT);
			//Catch ex As Exception
			//    'MsgBox("Error: " & ex.ToString)
			//    ' If Err.Number = 5 Then
			//    ' MsgBox("Invalid Database, Configure TCP/IP", MsgBoxStyle.Exclamation, "Sales and Inventory")
			//    ' Else
			//    MsgBox("Error : " & ex.Message)
			//    ' End If
			//    'MsgBox("Error No. " & Err.Number & " Invalid database or no database found !! Adjust settings first", MsgBoxStyle.Critical, "Sales And Inventory")
			//    'MsgBox(SQLQuery)
			//End Try
			return sqlDT;
		}
		public static DataTable ExecuteSQLQueryMaster(string SQLQuery)
		{
			try
			{
				CnString = "Provider=SQLOLEDB;Server=DOORSCOMPUTERS\\SQLEXPRESS" + 
					";Database=master; Trusted_Connection=yes;";
				OleDbConnection sqlCon = new OleDbConnection(CnString);
				OleDbDataAdapter sqlDA = new OleDbDataAdapter(SQLQuery, sqlCon);
				OleDbCommandBuilder sqlCB = new OleDbCommandBuilder(sqlDA);
				sqlDT.Reset(); // refresh
				sqlDA.Fill(sqlDT);
			}
			catch (Exception ex)
			{
				//MsgBox("Error: " & ex.ToString)
				// If Err.Number = 5 Then
				// MsgBox("Invalid Database, Configure TCP/IP", MsgBoxStyle.Exclamation, "Sales and Inventory")
				// Else
				MessageBox.Show("Error : " + ex.Message);
				// End If
				//MsgBox("Error No. " & Err.Number & " Invalid database or no database found !! Adjust settings first", MsgBoxStyle.Critical, "Sales And Inventory")
				//MsgBox(SQLQuery)
			}
			return sqlDT;
		}
		public static void FILLComboBox(string sql, ComboBox cb)
		{
			OleDbConnection conn = new OleDbConnection(CnString);
			cb.Items.Clear();
			try
			{
				conn.Open();
				OleDbCommand cmd = new OleDbCommand(sql, conn);
				OleDbDataReader rdr = cmd.ExecuteReader();
				while (rdr.Read())
				{
					cb.Items.Add(rdr[0].ToString() + " - " + rdr[1].ToString());
				}
				rdr.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error:" + ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}
		
		public static void FILLComboBox2(string sql, ComboBox cb)
		{
			OleDbConnection conn = new OleDbConnection(CnString);
			cb.Items.Clear();
			try
			{
				conn.Open();
				OleDbCommand cmd = new OleDbCommand(sql, conn);
				OleDbDataReader rdr = cmd.ExecuteReader();
				while (rdr.Read())
				{
					cb.Items.Add(rdr[1].ToString());
				}
				rdr.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error:" + ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}
		public static string str_Filter(string txt, int ascKey1, int ascKey2, int ascKey3, int N_Repeat)
		{
			string returnValue = "";
			//On Error Resume Next VBConversions Warning: On Error Resume Next not supported in C#
			//-----function dump all strings except
			string Delimeter = "";
			long X = 0;
			string intStr = "";
			int NumberToRepeatCharacter = 0;
			
			//MsgBox(Chr(Asc(txt)))
			//MsgBox(Asc(txt))
			for (X = 1; X <= txt.Length; X++) //asckey1                                asckey2                              asckey3
			{
				if (Strings.Asc(Strings.Mid(txt, (int) X, 1)) >= ascKey1 && Strings.Asc(Strings.Mid(txt, (int) X, 1)) <= ascKey2 || Strings.Asc(txt.Substring((int) X - 1, 1)) == ascKey3)
				{
				}
				else
				{
					Delimeter = System.Convert.ToString(Strings.Chr(Strings.Asc(txt.Substring((int) X - 1, 1))));
					MessageBox.Show(Delimeter);
				}
			}
			intStr = "";
			for (X = 1; X <= txt.Length; X++)
			{
				if (N_Repeat > 0)
				{
					if (Strings.Asc(txt.Substring((int) X - 1, 1)) == ascKey3)
					{
						if (NumberToRepeatCharacter >= N_Repeat)
						{
							SendKeys.Send("{END}");
							break;
						}
						NumberToRepeatCharacter++;
					}
				}
				//If NumberToRepeatCharacter <> N_Repeat Then
				if (txt.Substring((int) X - 1, 1) != Delimeter)
				{
					intStr = intStr + txt.Substring((int) X - 1, 1);
					//NumberToRepeatCharacter = NumberToRepeatCharacter + 1
				}
				else
				{
					//can be uncomment if you want
					//SendKeys.Send("{END}")
				}
				// Else
				// SendKeys.Send("{END}")
				// End If
				
				//NumberToRepeatCharacter = X
			}
			//MsgBox(NumberToRepeatCharacter)
			returnValue = intStr;
			return returnValue;
		}
		
		
		//Public Function DataSourceConnection_Report()
		//    If Split(tmpStr, ":")(4) = "1" Then
		//        'mReport.DataSourceConnections
		//        'mReport()
		//        'mReport.DataSourceConnections(0).SetConnection(Split(tmpStr, ":")(1), "SaleInv_DB", Split(tmpStr, ":")(2), Split(tmpStr, ":")(3))
		//        mReport.DataSourceConnections(0).SetConnection(Split(tmpStr, ":")(1), "SaleInv_DB", False)
		//        'MsgBox(Split(tmpStr, ":")(2) & "  " & Split(tmpStr, ":")(3))
		//        mReport.DataSourceConnections(0).SetLogon(Split(tmpStr, ":")(2), Split(tmpStr, ":")(3))
		//    Else
		
		//        mReport.DataSourceConnections(0).SetConnection(Split(tmpStr, ":")(1), "SaleInv_DB", True)
		//    End If
		//    'MsgBox(mReport.DataSourceConnections(0).ServerName.ToString)
		//    Return 0
		//End Function
	}
	
}
