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

using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;


namespace DoorsPOS.WinApp
{
	public partial class frmItemlist2
	{
		
		public void frmItemlist2_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		public void frmItemlist2_Load(object sender, EventArgs e)
		{
			//TODO: This line of code loads data into the 'DsBrand.dept' table. You can move, or remove it, as needed.
			this.deptTableAdapter.Fill(this.DsBrand.dept);
			
			//DevExpress.Utils.AppearanceObject.DefaultFont = New System.Drawing.Font("Arial Unicode MS", 12.0F)
			//SetGridFont(GridView2, New Font("Courier New", 12))
			//TODO: This line of code loads data into the 'CategoryDS.categories' table. You can move, or remove it, as needed.
			
			this.categoriesTableAdapter1.Fill(this.CategoryDS.categories);
			//TODO: This line of code loads data into the 'DsCategory.categories' table. You can move, or remove it, as needed.
			this.categoriesTableAdapter.Fill(this.DsCategory.categories);
			//TODO: This line of code loads data into the 'DsStakks.stocks' table. You can move, or remove it, as needed.
			this.StocksTableAdapter1.Fill(this.DsStakks.stocks);
			//+DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Courier New", 12) ' <<< NEW LINE
			GridControl1.UseEmbeddedNavigator = true;
			GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
			
			RepositoryItemGridLookUpEdit1.View.PopulateColumns(RepositoryItemGridLookUpEdit1.DataSource);
			RepositoryItemGridLookUpEdit1.View.Columns[RepositoryItemGridLookUpEdit1.ValueMember].Visible = false;
			RepositoryItemGridLookUpEdit1.View.Columns["catgory"].Caption = "Category";
			
			RepositoryItemGridLookUpEdit2.View.PopulateColumns(RepositoryItemGridLookUpEdit2.DataSource);
			RepositoryItemGridLookUpEdit2.View.Columns[RepositoryItemGridLookUpEdit2.ValueMember].Visible = false;
			RepositoryItemGridLookUpEdit2.View.Columns["DEPTD"].Caption = "Brand";
			
		}
		private void GridControl1_DoubleClick(object sender, EventArgs e)
		{
			ShowGridPreview(GridControl1);
		}
		public void ShowGridPreview(GridControl grid)
		{
			// Check whether the GridControl can be previewed.
			if (!grid.IsPrintingAvailable)
			{
				MessageBox.Show("The Printing\' library is not found", "Error");
				return ;
			}
			// Opens the Preview window.
			grid.ShowPrintPreview();
		}
		
		public void SimpleButton1_Click(object sender, EventArgs e)
		{
			try
			{
				C1DataViewSet1.Update();
				MessageBox.Show("Item Edit Successfully Saved");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
		}
		
		public void GridControl1_DoubleClick1(object sender, EventArgs e)
		{
			ShowGridPreview(GridControl1);
		}
		
		private void btnDelete_Click(object sender, EventArgs e)
		{
			
		}
		
		public void SetGridFont(GridView view, Font font)
		{
			AppearanceObject ap = default(AppearanceObject);
			foreach (AppearanceObject tempLoopVar_ap in view.Appearance)
			{
				ap = tempLoopVar_ap;
				ap.Font = font;
			}
		}
		
	}
}
