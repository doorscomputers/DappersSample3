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

using PDSA.DataLayer.DataClasses;
using PDSA.Validation;
using DevExpress.Utils;


namespace DoorsPOS.WinApp
{
	public partial class frmSearchItemsforRefunds
	{
		
		
		protected internal void LoadItems()
		{
			if (txtItem.Text == string.Empty)
			{
				MessageBox.Show("Enter an item description to seaarch.");
				txtItem.Focus();
				return;
			}
			else
			{
				PDSATransaction TranspStock = new PDSATransaction();
				spGetSalesLast30daysManager mgrloaditem = default(spGetSalesLast30daysManager);
				
				try
				{
					
					mgrloaditem = new spGetSalesLast30daysManager();
					mgrloaditem.Entity.Itemdescription = txtItem.Text.Trim();
					TranspStock.Add(mgrloaditem.DataObject);
					TranspStock.Execute();
					GridControl1.DataSource = mgrloaditem.DataObject.GetDataSet().Tables[0];
					gridView1.Columns[0].Visible = false;
					gridView1.Columns["categoryid"].Visible = false;
					gridView1.Columns["catgory"].Visible = false;
					gridView1.Columns["mowd"].Visible = false;
					gridView1.Columns["dtInsert_dt"].Visible = false;
					gridView1.Columns[1].Width = 350;
					gridView1.Columns[1].Caption = "Items Bought";
					gridView1.Columns[2].Caption = "Price";
					gridView1.Columns[3].Caption = "Qty";
					gridView1.Columns[4].Caption = "Amount";
					gridView1.Columns[7].Caption = "Sales No.";
					gridView1.Columns[8].Caption = "Date Sold";
					
					gridView1.Columns[2].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
					gridView1.Columns[3].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
					gridView1.Columns[4].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
					gridView1.Columns[5].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
					gridView1.Columns[8].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
					gridView1.Columns[7].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
					gridView1.Columns[7].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
					gridView1.Columns[8].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
					
					gridView1.Columns[2].DisplayFormat.FormatType = FormatType.Numeric;
					gridView1.Columns[2].DisplayFormat.FormatString = "n2";
					
					gridView1.Columns[3].DisplayFormat.FormatType = FormatType.Numeric;
					gridView1.Columns[3].DisplayFormat.FormatString = "n2";
					
					gridView1.Columns[4].DisplayFormat.FormatType = FormatType.Numeric;
					gridView1.Columns[4].DisplayFormat.FormatString = "n2";
					
					//Dim mgritem As spgetsaleslast30daysManager = New spgetsaleslast30daysManager()
					//Dim cols As posstocksCollection
					//mgritem.DataObject.WhereFilter = posstocksData.WhereFilters.cashier
					//mgritem.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
					//mgritem.Entity.itemdesc = Trim(txtitem.Text)
					//mgritem.DataObject.OrderByFilter = posstocksData.OrderByFilters.item_desc
					//cols = mgritem.BuildCollection()
					//If mgritem.DataObject.RowsAffected > 0 Then
					
					
					//Else
					
					//End If
					
				}
				catch (PDSAValidationException ex)
				{
					MessageBox.Show(ex.Message);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}
		
		public void btnButton1_Click(object sender, EventArgs e)
		{
			LoadItems();
		}
		
		public void lblLabel1_Click(object sender, EventArgs e)
		{
			
		}
		
		public void txtItem_EditValueChanged(object sender, EventArgs e)
		{
			
		}
		
		public void txtItem_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				LoadItems();
				GridControl1.Focus();
			}
		}
	}
}
