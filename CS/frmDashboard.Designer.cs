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
	partial class frmDashboard : DevExpress.XtraEditors.XtraForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
			DevExpress.XtraBars.Ribbon.GalleryItemGroup GalleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem4 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem5 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem6 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem7 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem8 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem9 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem10 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem11 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem12 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem13 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItemGroup GalleryItemGroup2 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem14 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem15 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem16 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem17 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem18 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem19 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem20 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem21 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem22 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem23 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem24 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem25 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem26 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem27 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem28 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem29 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem30 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem31 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem32 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem33 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem34 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem35 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem36 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem37 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem38 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem39 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItemGroup GalleryItemGroup3 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem40 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem41 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem42 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem43 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem44 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem45 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem46 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem GalleryItem47 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItemGroup GalleryItemGroup4 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.XtraBars.Ribbon.GalleryItemGroup GalleryItemGroup5 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.XtraBars.Ribbon.GalleryItemGroup GalleryItemGroup6 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.XtraBars.Ribbon.GalleryItemGroup GalleryItemGroup7 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.XtraBars.Ribbon.GalleryItemGroup GalleryItemGroup8 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.XtraBars.Ribbon.GalleryItemGroup GalleryItemGroup9 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem ChartSeriesTypeGalleryItem1 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
			DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem ChartSeriesTypeGalleryItem2 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
			DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem ChartSeriesTypeGalleryItem3 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItemGroup GalleryItemGroup10 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem ChartSeriesTypeGalleryItem4 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
			DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem ChartSeriesTypeGalleryItem5 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
			DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem ChartSeriesTypeGalleryItem6 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
			DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem ChartSeriesTypeGalleryItem7 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
			DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem ChartSeriesTypeGalleryItem8 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
			DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem ChartSeriesTypeGalleryItem9 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItemGroup GalleryItemGroup11 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem ChartSeriesTypeGalleryItem10 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
			DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem ChartSeriesTypeGalleryItem11 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
			DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem ChartSeriesTypeGalleryItem12 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
			DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem ChartSeriesTypeGalleryItem13 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
			DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem ChartSeriesTypeGalleryItem14 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
			DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem ChartSeriesTypeGalleryItem15 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
			DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem ChartSeriesTypeGalleryItem16 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItemGroup GalleryItemGroup12 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem ChartSeriesTypeGalleryItem17 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
			DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem ChartSeriesTypeGalleryItem18 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItemGroup GalleryItemGroup13 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem ChartSeriesTypeGalleryItem19 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItemGroup GalleryItemGroup14 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem ChartSeriesTypeGalleryItem20 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
			DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem ChartSeriesTypeGalleryItem21 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
			DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem ChartSeriesTypeGalleryItem22 = new DevExpress.DashboardWin.Bars.ChartSeriesTypeGalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItemGroup GalleryItemGroup15 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.XtraBars.Ribbon.GalleryItemGroup GalleryItemGroup16 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			this.FormAssistant1 = new DevExpress.XtraBars.FormAssistant();
			this.DashboardViewer1 = new DevExpress.DashboardWin.DashboardViewer(this.components);
			this.DashboardDesigner1 = new DevExpress.DashboardWin.DashboardDesigner();
			this.RibbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.DashboardBackstageViewControl1 = new DevExpress.DashboardWin.Bars.DashboardBackstageViewControl();
			this.DashboardBarAndDockingController1 = new DevExpress.DashboardWin.Native.DashboardBarAndDockingController(this.components);
			this.BackstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
			this.RecentDashboardsControl1 = new DevExpress.DashboardWin.Bars.RecentDashboardsControl();
			this.DashboardBackstageRecentTab1 = new DevExpress.DashboardWin.Bars.DashboardBackstageRecentTab();
			this.DashboardBackstageNewButton1 = new DevExpress.DashboardWin.Bars.DashboardBackstageNewButton();
			this.DashboardBackstageOpenButton1 = new DevExpress.DashboardWin.Bars.DashboardBackstageOpenButton();
			this.DashboardBackstageSaveButton1 = new DevExpress.DashboardWin.Bars.DashboardBackstageSaveButton();
			this.DashboardBackstageSaveAsButton1 = new DevExpress.DashboardWin.Bars.DashboardBackstageSaveAsButton();
			this.FileNewBarItem1 = new DevExpress.DashboardWin.Bars.FileNewBarItem();
			this.FileOpenBarItem1 = new DevExpress.DashboardWin.Bars.FileOpenBarItem();
			this.FileSaveBarItem1 = new DevExpress.DashboardWin.Bars.FileSaveBarItem();
			this.FileSaveAsBarItem1 = new DevExpress.DashboardWin.Bars.FileSaveAsBarItem();
			this.UndoBarItem1 = new DevExpress.DashboardWin.Bars.UndoBarItem();
			this.RedoBarItem1 = new DevExpress.DashboardWin.Bars.RedoBarItem();
			this.NewDataSourceBarItem1 = new DevExpress.DashboardWin.Bars.NewDataSourceBarItem();
			this.EditDataSourceBarItem1 = new DevExpress.DashboardWin.Bars.EditDataSourceBarItem();
			this.DeleteDataSourceBarItem1 = new DevExpress.DashboardWin.Bars.DeleteDataSourceBarItem();
			this.AddCalculatedFieldBarItem1 = new DevExpress.DashboardWin.Bars.AddCalculatedFieldBarItem();
			this.DashboardParametersBarItem1 = new DevExpress.DashboardWin.Bars.DashboardParametersBarItem();
			this.EditDataSourceFilterBarItem1 = new DevExpress.DashboardWin.Bars.EditDataSourceFilterBarItem();
			this.ClearDataSourceFilterBarItem1 = new DevExpress.DashboardWin.Bars.ClearDataSourceFilterBarItem();
			this.InsertPivotBarItem1 = new DevExpress.DashboardWin.Bars.InsertPivotBarItem();
			this.InsertGridBarItem1 = new DevExpress.DashboardWin.Bars.InsertGridBarItem();
			this.InsertChartBarItem1 = new DevExpress.DashboardWin.Bars.InsertChartBarItem();
			this.InsertPiesBarItem1 = new DevExpress.DashboardWin.Bars.InsertPiesBarItem();
			this.InsertGaugesBarItem1 = new DevExpress.DashboardWin.Bars.InsertGaugesBarItem();
			this.InsertCardsBarItem1 = new DevExpress.DashboardWin.Bars.InsertCardsBarItem();
			this.InsertChoroplethMapBarItem1 = new DevExpress.DashboardWin.Bars.InsertChoroplethMapBarItem();
			this.InsertGeoPointMapBarItem1 = new DevExpress.DashboardWin.Bars.InsertGeoPointMapBarItem();
			this.InsertRangeFilterBarItem1 = new DevExpress.DashboardWin.Bars.InsertRangeFilterBarItem();
			this.InsertImageBarItem1 = new DevExpress.DashboardWin.Bars.InsertImageBarItem();
			this.InsertTextBoxBarItem1 = new DevExpress.DashboardWin.Bars.InsertTextBoxBarItem();
			this.DuplicateItemBarItem1 = new DevExpress.DashboardWin.Bars.DuplicateItemBarItem();
			this.DeleteItemBarItem1 = new DevExpress.DashboardWin.Bars.DeleteItemBarItem();
			this.DashboardTitleBarItem1 = new DevExpress.DashboardWin.Bars.DashboardTitleBarItem();
			this.SetCurrencyCultureBarItem1 = new DevExpress.DashboardWin.Bars.SetCurrencyCultureBarItem();
			this.DashboardSkinsBarItem1 = new DevExpress.DashboardWin.Bars.DashboardSkinsBarItem();
			this.EditFilterBarItem1 = new DevExpress.DashboardWin.Bars.EditFilterBarItem();
			this.ClearFilterBarItem1 = new DevExpress.DashboardWin.Bars.ClearFilterBarItem();
			this.MasterFilterBarItem1 = new DevExpress.DashboardWin.Bars.MasterFilterBarItem();
			this.MultipleValuesMasterFilterBarItem1 = new DevExpress.DashboardWin.Bars.MultipleValuesMasterFilterBarItem();
			this.DrillDownBarItem1 = new DevExpress.DashboardWin.Bars.DrillDownBarItem();
			this.IgnoreMasterFiltersBarItem1 = new DevExpress.DashboardWin.Bars.IgnoreMasterFiltersBarItem();
			this.CrossDataSourceFilteringBarItem1 = new DevExpress.DashboardWin.Bars.CrossDataSourceFilteringBarItem();
			this.ChartTargetDimensionsArgumentsBarItem1 = new DevExpress.DashboardWin.Bars.ChartTargetDimensionsArgumentsBarItem();
			this.ChartTargetDimensionsSeriesBarItem1 = new DevExpress.DashboardWin.Bars.ChartTargetDimensionsSeriesBarItem();
			this.PieTargetDimensionsArgumentsBarItem1 = new DevExpress.DashboardWin.Bars.PieTargetDimensionsArgumentsBarItem();
			this.PieTargetDimensionsSeriesBarItem1 = new DevExpress.DashboardWin.Bars.PieTargetDimensionsSeriesBarItem();
			this.ShowItemCaptionBarItem1 = new DevExpress.DashboardWin.Bars.ShowItemCaptionBarItem();
			this.EditItemNamesBarItem1 = new DevExpress.DashboardWin.Bars.EditItemNamesBarItem();
			this.ContentAutoArrangeBarItem1 = new DevExpress.DashboardWin.Bars.ContentAutoArrangeBarItem();
			this.ContentArrangeInColumnsBarItem1 = new DevExpress.DashboardWin.Bars.ContentArrangeInColumnsBarItem();
			this.ContentArrangeInRowsBarItem1 = new DevExpress.DashboardWin.Bars.ContentArrangeInRowsBarItem();
			this.ContentArrangementCountBarItem1 = new DevExpress.DashboardWin.Bars.ContentArrangementCountBarItem();
			this.RepositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
			this.GridHorizontalLinesBarItem1 = new DevExpress.DashboardWin.Bars.GridHorizontalLinesBarItem();
			this.GridVerticalLinesBarItem1 = new DevExpress.DashboardWin.Bars.GridVerticalLinesBarItem();
			this.GridMergeCellsBarItem1 = new DevExpress.DashboardWin.Bars.GridMergeCellsBarItem();
			this.GridBandedRowsBarItem1 = new DevExpress.DashboardWin.Bars.GridBandedRowsBarItem();
			this.GridColumnHeadersBarItem1 = new DevExpress.DashboardWin.Bars.GridColumnHeadersBarItem();
			this.ChartRotateBarItem1 = new DevExpress.DashboardWin.Bars.ChartRotateBarItem();
			this.ChartXAxisSettingsBarItem1 = new DevExpress.DashboardWin.Bars.ChartXAxisSettingsBarItem();
			this.ChartYAxisSettingsBarItem1 = new DevExpress.DashboardWin.Bars.ChartYAxisSettingsBarItem();
			this.ChartShowLegendBarItem1 = new DevExpress.DashboardWin.Bars.ChartShowLegendBarItem();
			this.GalleryChartLegendPositionItem1 = new DevExpress.DashboardWin.Bars.GalleryChartLegendPositionItem();
			this.GalleryChartSeriesTypeItem1 = new DevExpress.DashboardWin.Bars.GalleryChartSeriesTypeItem();
			this.PieLabelsDataLabelsBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsDataLabelsBarItem();
			this.PieLabelsDataLabelsNoneBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsDataLabelsNoneBarItem();
			this.PieLabelsDataLabelArgumentBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsDataLabelArgumentBarItem();
			this.PieLabelsDataLabelsValueBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsDataLabelsValueBarItem();
			this.PieLabelsDataLabelsArgumentAndValueBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsDataLabelsArgumentAndValueBarItem();
			this.PieLabelsDataLabelsPercentBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsDataLabelsPercentBarItem();
			this.PieLabelsDataLabelsValueAndPercentBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsDataLabelsValueAndPercentBarItem();
			this.PieLabelsDataLabelsArgumentAndPercentBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsDataLabelsArgumentAndPercentBarItem();
			this.PieLabelsDataLabelsArgumentValueAndPercentBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsDataLabelsArgumentValueAndPercentBarItem();
			this.PieTooltipsBarItem1 = new DevExpress.DashboardWin.Bars.PieTooltipsBarItem();
			this.PieLabelsTooltipsNoneBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsTooltipsNoneBarItem();
			this.PieLabelsTooltipsArgumentBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsTooltipsArgumentBarItem();
			this.PieLabelsTooltipsValueBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsTooltipsValueBarItem();
			this.PieLabelsTooltipsArgumentAndValueBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsTooltipsArgumentAndValueBarItem();
			this.PieLabelsTooltipsPercentBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsTooltipsPercentBarItem();
			this.PieLabelsTooltipsValueAndPercentBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsTooltipsValueAndPercentBarItem();
			this.PieLabelsTooltipsArgumentAndPercentBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsTooltipsArgumentAndPercentBarItem();
			this.PieLabelsTooltipsArgumentValueAndPercentBarItem1 = new DevExpress.DashboardWin.Bars.PieLabelsTooltipsArgumentValueAndPercentBarItem();
			this.PieStylePieBarItem1 = new DevExpress.DashboardWin.Bars.PieStylePieBarItem();
			this.PieStyleDonutBarItem1 = new DevExpress.DashboardWin.Bars.PieStyleDonutBarItem();
			this.PieShowCaptionsBarItem1 = new DevExpress.DashboardWin.Bars.PieShowCaptionsBarItem();
			this.GaugeStyleFullCircularBarItem1 = new DevExpress.DashboardWin.Bars.GaugeStyleFullCircularBarItem();
			this.GaugeStyleHalfCircularBarItem1 = new DevExpress.DashboardWin.Bars.GaugeStyleHalfCircularBarItem();
			this.GaugeStyleLeftQuarterCircularBarItem1 = new DevExpress.DashboardWin.Bars.GaugeStyleLeftQuarterCircularBarItem();
			this.GaugeStyleRightQuarterCircularBarItem1 = new DevExpress.DashboardWin.Bars.GaugeStyleRightQuarterCircularBarItem();
			this.GaugeStyleThreeForthCircularBarItem1 = new DevExpress.DashboardWin.Bars.GaugeStyleThreeForthCircularBarItem();
			this.GaugeStyleLinearHorizontalBarItem1 = new DevExpress.DashboardWin.Bars.GaugeStyleLinearHorizontalBarItem();
			this.GaugeStyleLinearVerticalBarItem1 = new DevExpress.DashboardWin.Bars.GaugeStyleLinearVerticalBarItem();
			this.GaugeShowCaptionsBarItem1 = new DevExpress.DashboardWin.Bars.GaugeShowCaptionsBarItem();
			this.ImageLoadBarItem1 = new DevExpress.DashboardWin.Bars.ImageLoadBarItem();
			this.ImageImportBarItem1 = new DevExpress.DashboardWin.Bars.ImageImportBarItem();
			this.ImageSizeModeClipBarItem1 = new DevExpress.DashboardWin.Bars.ImageSizeModeClipBarItem();
			this.ImageSizeModeStretchBarItem1 = new DevExpress.DashboardWin.Bars.ImageSizeModeStretchBarItem();
			this.ImageSizeModeSqueezeBarItem1 = new DevExpress.DashboardWin.Bars.ImageSizeModeSqueezeBarItem();
			this.ImageSizeModeZoomBarItem1 = new DevExpress.DashboardWin.Bars.ImageSizeModeZoomBarItem();
			this.ImageAlignmentTopLeftBarItem1 = new DevExpress.DashboardWin.Bars.ImageAlignmentTopLeftBarItem();
			this.ImageAlignmentCenterLeftBarItem1 = new DevExpress.DashboardWin.Bars.ImageAlignmentCenterLeftBarItem();
			this.ImageAlignmentBottomLeftBarItem1 = new DevExpress.DashboardWin.Bars.ImageAlignmentBottomLeftBarItem();
			this.ImageAlignmentTopCenterBarItem1 = new DevExpress.DashboardWin.Bars.ImageAlignmentTopCenterBarItem();
			this.ImageAlignmentCenterCenterBarItem1 = new DevExpress.DashboardWin.Bars.ImageAlignmentCenterCenterBarItem();
			this.ImageAlignmentBottomCenterBarItem1 = new DevExpress.DashboardWin.Bars.ImageAlignmentBottomCenterBarItem();
			this.ImageAlignmentTopRightBarItem1 = new DevExpress.DashboardWin.Bars.ImageAlignmentTopRightBarItem();
			this.ImageAlignmentCenterRightBarItem1 = new DevExpress.DashboardWin.Bars.ImageAlignmentCenterRightBarItem();
			this.ImageAlignmentBottomRightBarItem1 = new DevExpress.DashboardWin.Bars.ImageAlignmentBottomRightBarItem();
			this.TextBoxEditTextBarItem1 = new DevExpress.DashboardWin.Bars.TextBoxEditTextBarItem();
			this.RangeFilterLineSeriesTypeBarItem1 = new DevExpress.DashboardWin.Bars.RangeFilterLineSeriesTypeBarItem();
			this.RangeFilterStackedLineSeriesTypeBarItem1 = new DevExpress.DashboardWin.Bars.RangeFilterStackedLineSeriesTypeBarItem();
			this.RangeFilterFullStackedLineSeriesTypeBarItem1 = new DevExpress.DashboardWin.Bars.RangeFilterFullStackedLineSeriesTypeBarItem();
			this.RangeFilterAreaSeriesTypeBarItem1 = new DevExpress.DashboardWin.Bars.RangeFilterAreaSeriesTypeBarItem();
			this.RangeFilterStackedAreaSeriesTypeBarItem1 = new DevExpress.DashboardWin.Bars.RangeFilterStackedAreaSeriesTypeBarItem();
			this.RangeFilterFullStackedAreaSeriesTypeBarItem1 = new DevExpress.DashboardWin.Bars.RangeFilterFullStackedAreaSeriesTypeBarItem();
			this.PivotInitialStateBarItem1 = new DevExpress.DashboardWin.Bars.PivotInitialStateBarItem();
			this.PivotAutoExpandColumnBarItem1 = new DevExpress.DashboardWin.Bars.PivotAutoExpandColumnBarItem();
			this.PivotAutoExpandRowBarItem1 = new DevExpress.DashboardWin.Bars.PivotAutoExpandRowBarItem();
			this.MapShowLegendBarItem1 = new DevExpress.DashboardWin.Bars.MapShowLegendBarItem();
			this.GalleryMapLegendPositionItem1 = new DevExpress.DashboardWin.Bars.GalleryMapLegendPositionItem();
			this.MapLoadBarItem1 = new DevExpress.DashboardWin.Bars.MapLoadBarItem();
			this.MapImportBarItem1 = new DevExpress.DashboardWin.Bars.MapImportBarItem();
			this.MapDefaultShapefileBarItem1 = new DevExpress.DashboardWin.Bars.MapDefaultShapefileBarItem();
			this.MapWorldCountriesBarItem1 = new DevExpress.DashboardWin.Bars.MapWorldCountriesBarItem();
			this.MapEuropeBarItem1 = new DevExpress.DashboardWin.Bars.MapEuropeBarItem();
			this.MapAsiaBarItem1 = new DevExpress.DashboardWin.Bars.MapAsiaBarItem();
			this.MapNorthAmericaBarItem1 = new DevExpress.DashboardWin.Bars.MapNorthAmericaBarItem();
			this.MapSouthAmericaBarItem1 = new DevExpress.DashboardWin.Bars.MapSouthAmericaBarItem();
			this.MapAfricaBarItem1 = new DevExpress.DashboardWin.Bars.MapAfricaBarItem();
			this.MapUSABarItem1 = new DevExpress.DashboardWin.Bars.MapUSABarItem();
			this.MapCanadaBarItem1 = new DevExpress.DashboardWin.Bars.MapCanadaBarItem();
			this.QuickAccessUndoBarItem1 = new DevExpress.DashboardWin.Bars.QuickAccessUndoBarItem();
			this.QuickAccessRedoBarItem1 = new DevExpress.DashboardWin.Bars.QuickAccessRedoBarItem();
			this.PivotToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.PivotToolsRibbonPageCategory();
			this.DataRibbonPage1 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
			this.FilteringRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
			this.InteractivitySettingsRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
			this.PivotLayoutRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.PivotLayoutRibbonPageGroup();
			this.DashboardItemDesignRibbonPage9 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
			this.CommonItemDesignRibbonPageGroup9 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
			this.GridToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.GridToolsRibbonPageCategory();
			this.DataRibbonPage2 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
			this.FilteringRibbonPageGroup2 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
			this.MasterFilterRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup();
			this.InteractivitySettingsRibbonPageGroup2 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
			this.DashboardItemDesignRibbonPage1 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
			this.CommonItemDesignRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
			this.GridCellsRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.GridCellsRibbonPageGroup();
			this.ChartToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.ChartToolsRibbonPageCategory();
			this.DataRibbonPage3 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
			this.FilteringRibbonPageGroup3 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
			this.MasterFilterRibbonPageGroup2 = new DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup();
			this.InteractivitySettingsRibbonPageGroup3 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
			this.TargetDimensionsRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.TargetDimensionsRibbonPageGroup();
			this.DashboardItemDesignRibbonPage2 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
			this.CommonItemDesignRibbonPageGroup2 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
			this.ChartLayoutPageGroup1 = new DevExpress.DashboardWin.Bars.ChartLayoutPageGroup();
			this.ChartLegendPositionPageGroup1 = new DevExpress.DashboardWin.Bars.ChartLegendPositionPageGroup();
			this.ChartStylePageGroup1 = new DevExpress.DashboardWin.Bars.ChartStylePageGroup();
			this.PiesToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.PiesToolsRibbonPageCategory();
			this.DataRibbonPage4 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
			this.FilteringRibbonPageGroup4 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
			this.MasterFilterRibbonPageGroup3 = new DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup();
			this.InteractivitySettingsRibbonPageGroup4 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
			this.TargetDimensionsRibbonPageGroup2 = new DevExpress.DashboardWin.Bars.TargetDimensionsRibbonPageGroup();
			this.DashboardItemDesignRibbonPage3 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
			this.CommonItemDesignRibbonPageGroup3 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
			this.ContentArrangementRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.ContentArrangementRibbonPageGroup();
			this.PieLabelsRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.PieLabelsRibbonPageGroup();
			this.PieStyleRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.PieStyleRibbonPageGroup();
			this.GaugesToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.GaugesToolsRibbonPageCategory();
			this.DataRibbonPage5 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
			this.FilteringRibbonPageGroup5 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
			this.MasterFilterRibbonPageGroup4 = new DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup();
			this.InteractivitySettingsRibbonPageGroup5 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
			this.DashboardItemDesignRibbonPage4 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
			this.CommonItemDesignRibbonPageGroup4 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
			this.ContentArrangementRibbonPageGroup2 = new DevExpress.DashboardWin.Bars.ContentArrangementRibbonPageGroup();
			this.GaugeStyleRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.GaugeStyleRibbonPageGroup();
			this.GaugesLabelsRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.GaugesLabelsRibbonPageGroup();
			this.CardsToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.CardsToolsRibbonPageCategory();
			this.DataRibbonPage6 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
			this.FilteringRibbonPageGroup6 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
			this.MasterFilterRibbonPageGroup5 = new DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup();
			this.InteractivitySettingsRibbonPageGroup6 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
			this.DashboardItemDesignRibbonPage5 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
			this.CommonItemDesignRibbonPageGroup5 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
			this.ContentArrangementRibbonPageGroup3 = new DevExpress.DashboardWin.Bars.ContentArrangementRibbonPageGroup();
			this.RangeFilterToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.RangeFilterToolsRibbonPageCategory();
			this.DataRibbonPage7 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
			this.FilteringRibbonPageGroup7 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
			this.InteractivitySettingsRibbonPageGroup7 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
			this.DashboardItemDesignRibbonPage8 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
			this.CommonItemDesignRibbonPageGroup8 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
			this.RangeFilterSeriesTypeRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.RangeFilterSeriesTypeRibbonPageGroup();
			this.ChoroplethMapToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.ChoroplethMapToolsRibbonPageCategory();
			this.DataRibbonPage8 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
			this.FilteringRibbonPageGroup8 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
			this.MasterFilterRibbonPageGroup6 = new DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup();
			this.InteractivitySettingsRibbonPageGroup8 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
			this.DashboardItemDesignRibbonPage10 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
			this.CommonItemDesignRibbonPageGroup10 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
			this.MapLegendPositionPageGroup1 = new DevExpress.DashboardWin.Bars.MapLegendPositionPageGroup();
			this.MapShapefileRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.MapShapefileRibbonPageGroup();
			this.GeoPointMapToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.GeoPointMapToolsRibbonPageCategory();
			this.DataRibbonPage9 = new DevExpress.DashboardWin.Bars.DataRibbonPage();
			this.FilteringRibbonPageGroup9 = new DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup();
			this.MasterFilterRibbonPageGroup7 = new DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup();
			this.InteractivitySettingsRibbonPageGroup9 = new DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup();
			this.DashboardItemDesignRibbonPage11 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
			this.CommonItemDesignRibbonPageGroup11 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
			this.MapShapefileRibbonPageGroup2 = new DevExpress.DashboardWin.Bars.MapShapefileRibbonPageGroup();
			this.ImageToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.ImageToolsRibbonPageCategory();
			this.DashboardItemDesignRibbonPage6 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
			this.CommonItemDesignRibbonPageGroup6 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
			this.ImageOpenRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.ImageOpenRibbonPageGroup();
			this.ImageSizeModeRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.ImageSizeModeRibbonPageGroup();
			this.ImageAlignmentRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.ImageAlignmentRibbonPageGroup();
			this.TextBoxToolsRibbonPageCategory1 = new DevExpress.DashboardWin.Bars.TextBoxToolsRibbonPageCategory();
			this.DashboardItemDesignRibbonPage7 = new DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage();
			this.CommonItemDesignRibbonPageGroup7 = new DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup();
			this.TextBoxSettingsRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.TextBoxSettingsRibbonPageGroup();
			this.HomeRibbonPage1 = new DevExpress.DashboardWin.Bars.HomeRibbonPage();
			this.FileRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.FileRibbonPageGroup();
			this.HistoryRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.HistoryRibbonPageGroup();
			this.InsertRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.InsertRibbonPageGroup();
			this.ItemOperationRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.ItemOperationRibbonPageGroup();
			this.DashboardDesignRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.DashboardDesignRibbonPageGroup();
			this.QuickAccessHistoryRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.QuickAccessHistoryRibbonPageGroup();
			this.DataSourceRibbonPage1 = new DevExpress.DashboardWin.Bars.DataSourceRibbonPage();
			this.DataSourceRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.DataSourceRibbonPageGroup();
			this.DataSourceElementsRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.DataSourceElementsRibbonPageGroup();
			this.DataSourceFilteringRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.DataSourceFilteringRibbonPageGroup();
			this.ViewRibbonPage1 = new DevExpress.DashboardWin.Bars.ViewRibbonPage();
			this.SkinsRibbonPageGroup1 = new DevExpress.DashboardWin.Bars.SkinsRibbonPageGroup();
			this.DashboardBarController1 = new DevExpress.DashboardWin.Bars.DashboardBarController();
			((System.ComponentModel.ISupportInitialize) this.DashboardViewer1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.RibbonControl1).BeginInit();
			this.DashboardBackstageViewControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.DashboardBarAndDockingController1).BeginInit();
			this.BackstageViewClientControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.RepositoryItemSpinEdit1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DashboardBarController1).BeginInit();
			this.SuspendLayout();
			//
			//DashboardViewer1
			//
			this.DashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DashboardViewer1.Location = new System.Drawing.Point(0, 142);
			this.DashboardViewer1.Name = "DashboardViewer1";
			this.DashboardViewer1.Size = new System.Drawing.Size(1046, 292);
			this.DashboardViewer1.TabIndex = 0;
			//
			//DashboardDesigner1
			//
			this.DashboardDesigner1.CustomDBSchemaProvider = null;
			this.DashboardDesigner1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DashboardDesigner1.Location = new System.Drawing.Point(0, 142);
			this.DashboardDesigner1.MenuManager = this.RibbonControl1;
			this.DashboardDesigner1.Name = "DashboardDesigner1";
			this.DashboardDesigner1.Size = new System.Drawing.Size(1046, 292);
			this.DashboardDesigner1.TabIndex = 1;
			//
			//RibbonControl1
			//
			this.RibbonControl1.ApplicationButtonDropDownControl = this.DashboardBackstageViewControl1;
			this.RibbonControl1.Controller = this.DashboardBarAndDockingController1;
			this.RibbonControl1.ExpandCollapseItem.Id = 0;
			this.RibbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.RibbonControl1.ExpandCollapseItem, this.FileNewBarItem1, this.FileOpenBarItem1, this.FileSaveBarItem1, this.FileSaveAsBarItem1, this.UndoBarItem1, this.RedoBarItem1, this.NewDataSourceBarItem1, this.EditDataSourceBarItem1, this.DeleteDataSourceBarItem1, this.AddCalculatedFieldBarItem1, this.DashboardParametersBarItem1, this.EditDataSourceFilterBarItem1, this.ClearDataSourceFilterBarItem1, this.InsertPivotBarItem1, this.InsertGridBarItem1, this.InsertChartBarItem1, this.InsertPiesBarItem1, this.InsertGaugesBarItem1, this.InsertCardsBarItem1, this.InsertChoroplethMapBarItem1, this.InsertGeoPointMapBarItem1, this.InsertRangeFilterBarItem1, this.InsertImageBarItem1, this.InsertTextBoxBarItem1, this.DuplicateItemBarItem1, this.DeleteItemBarItem1, this.DashboardTitleBarItem1, this.SetCurrencyCultureBarItem1, this.DashboardSkinsBarItem1, this.EditFilterBarItem1, this.ClearFilterBarItem1, this.MasterFilterBarItem1, this.MultipleValuesMasterFilterBarItem1, this.DrillDownBarItem1, this.IgnoreMasterFiltersBarItem1, this.CrossDataSourceFilteringBarItem1, this.ChartTargetDimensionsArgumentsBarItem1, this.ChartTargetDimensionsSeriesBarItem1, this.PieTargetDimensionsArgumentsBarItem1, this.PieTargetDimensionsSeriesBarItem1, this.ShowItemCaptionBarItem1, this.EditItemNamesBarItem1, this.ContentAutoArrangeBarItem1, this.ContentArrangeInColumnsBarItem1, this.ContentArrangeInRowsBarItem1, this.ContentArrangementCountBarItem1, this.GridHorizontalLinesBarItem1, this.GridVerticalLinesBarItem1, this.GridMergeCellsBarItem1, this.GridBandedRowsBarItem1, this.GridColumnHeadersBarItem1, this.ChartRotateBarItem1, this.ChartXAxisSettingsBarItem1, this.ChartYAxisSettingsBarItem1, this.ChartShowLegendBarItem1, this.GalleryChartLegendPositionItem1, this.GalleryChartSeriesTypeItem1, this.PieLabelsDataLabelsBarItem1, this.PieLabelsDataLabelsNoneBarItem1, this.PieLabelsDataLabelArgumentBarItem1
			, this.PieLabelsDataLabelsValueBarItem1, this.PieLabelsDataLabelsArgumentAndValueBarItem1, this.PieLabelsDataLabelsPercentBarItem1, this.PieLabelsDataLabelsValueAndPercentBarItem1, this.PieLabelsDataLabelsArgumentAndPercentBarItem1, this.PieLabelsDataLabelsArgumentValueAndPercentBarItem1, this.PieTooltipsBarItem1, this.PieLabelsTooltipsNoneBarItem1, this.PieLabelsTooltipsArgumentBarItem1, this.PieLabelsTooltipsValueBarItem1, this.PieLabelsTooltipsArgumentAndValueBarItem1, this.PieLabelsTooltipsPercentBarItem1, this.PieLabelsTooltipsValueAndPercentBarItem1, this.PieLabelsTooltipsArgumentAndPercentBarItem1, this.PieLabelsTooltipsArgumentValueAndPercentBarItem1, this.PieStylePieBarItem1, this.PieStyleDonutBarItem1, this.PieShowCaptionsBarItem1, this.GaugeStyleFullCircularBarItem1, this.GaugeStyleHalfCircularBarItem1, this.GaugeStyleLeftQuarterCircularBarItem1, this.GaugeStyleRightQuarterCircularBarItem1, this.GaugeStyleThreeForthCircularBarItem1, this.GaugeStyleLinearHorizontalBarItem1, this.GaugeStyleLinearVerticalBarItem1, this.GaugeShowCaptionsBarItem1, this.ImageLoadBarItem1, this.ImageImportBarItem1, this.ImageSizeModeClipBarItem1, this.ImageSizeModeStretchBarItem1, this.ImageSizeModeSqueezeBarItem1, this.ImageSizeModeZoomBarItem1, this.ImageAlignmentTopLeftBarItem1, this.ImageAlignmentCenterLeftBarItem1, this.ImageAlignmentBottomLeftBarItem1, this.ImageAlignmentTopCenterBarItem1, this.ImageAlignmentCenterCenterBarItem1, this.ImageAlignmentBottomCenterBarItem1, this.ImageAlignmentTopRightBarItem1, this.ImageAlignmentCenterRightBarItem1, this.ImageAlignmentBottomRightBarItem1, this.TextBoxEditTextBarItem1, this.RangeFilterLineSeriesTypeBarItem1, this.RangeFilterStackedLineSeriesTypeBarItem1, this.RangeFilterFullStackedLineSeriesTypeBarItem1, this.RangeFilterAreaSeriesTypeBarItem1, this.RangeFilterStackedAreaSeriesTypeBarItem1, this.RangeFilterFullStackedAreaSeriesTypeBarItem1
			, this.PivotInitialStateBarItem1, this.PivotAutoExpandColumnBarItem1, this.PivotAutoExpandRowBarItem1, this.MapShowLegendBarItem1, this.GalleryMapLegendPositionItem1, this.MapLoadBarItem1, this.MapImportBarItem1, this.MapDefaultShapefileBarItem1, this.MapWorldCountriesBarItem1, this.MapEuropeBarItem1, this.MapAsiaBarItem1, this.MapNorthAmericaBarItem1, this.MapSouthAmericaBarItem1, this.MapAfricaBarItem1, this.MapUSABarItem1, this.MapCanadaBarItem1, this.QuickAccessUndoBarItem1, this.QuickAccessRedoBarItem1}
			);
			this.RibbonControl1.Location = new System.Drawing.Point(0, 0);
			this.RibbonControl1.MaxItemId = 127;
			this.RibbonControl1.Name = "RibbonControl1";
			this.RibbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {this.PivotToolsRibbonPageCategory1, this.GridToolsRibbonPageCategory1, this.ChartToolsRibbonPageCategory1, this.PiesToolsRibbonPageCategory1, this.GaugesToolsRibbonPageCategory1, this.CardsToolsRibbonPageCategory1, this.RangeFilterToolsRibbonPageCategory1, this.ChoroplethMapToolsRibbonPageCategory1, this.GeoPointMapToolsRibbonPageCategory1, this.ImageToolsRibbonPageCategory1, this.TextBoxToolsRibbonPageCategory1});
			this.RibbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {this.HomeRibbonPage1, this.DataSourceRibbonPage1, this.ViewRibbonPage1});
			this.RibbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.RepositoryItemSpinEdit1});
			this.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
			this.RibbonControl1.Size = new System.Drawing.Size(1046, 142);
			this.RibbonControl1.Toolbar.ItemLinks.Add(this.FileSaveBarItem1);
			this.RibbonControl1.Toolbar.ItemLinks.Add(this.QuickAccessUndoBarItem1);
			this.RibbonControl1.Toolbar.ItemLinks.Add(this.QuickAccessRedoBarItem1);
			this.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
			//
			//DashboardBackstageViewControl1
			//
			this.DashboardBackstageViewControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow;
			this.DashboardBackstageViewControl1.Controller = this.DashboardBarAndDockingController1;
			this.DashboardBackstageViewControl1.Controls.Add(this.BackstageViewClientControl1);
			this.DashboardBackstageViewControl1.DashboardRecentTab = this.DashboardBackstageRecentTab1;
			this.DashboardBackstageViewControl1.Items.Add(this.DashboardBackstageNewButton1);
			this.DashboardBackstageViewControl1.Items.Add(this.DashboardBackstageOpenButton1);
			this.DashboardBackstageViewControl1.Items.Add(this.DashboardBackstageSaveButton1);
			this.DashboardBackstageViewControl1.Items.Add(this.DashboardBackstageSaveAsButton1);
			this.DashboardBackstageViewControl1.Items.Add(this.DashboardBackstageRecentTab1);
			this.DashboardBackstageViewControl1.Location = new System.Drawing.Point(0, 0);
			this.DashboardBackstageViewControl1.Name = "DashboardBackstageViewControl1";
			this.DashboardBackstageViewControl1.Ribbon = this.RibbonControl1;
			this.DashboardBackstageViewControl1.SelectedTab = this.DashboardBackstageRecentTab1;
			this.DashboardBackstageViewControl1.SelectedTabIndex = 4;
			this.DashboardBackstageViewControl1.Size = new System.Drawing.Size(240, 150);
			this.DashboardBackstageViewControl1.TabIndex = 3;
			//
			//DashboardBarAndDockingController1
			//
			this.DashboardBarAndDockingController1.PropertiesBar.AllowLinkLighting = false;
			this.DashboardBarAndDockingController1.PropertiesBar.DefaultGlyphSize = new System.Drawing.Size(16, 16);
			this.DashboardBarAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = new System.Drawing.Size(32, 32);
			//
			//BackstageViewClientControl1
			//
			this.BackstageViewClientControl1.Controls.Add(this.RecentDashboardsControl1);
			this.BackstageViewClientControl1.Location = new System.Drawing.Point(132, 0);
			this.BackstageViewClientControl1.Name = "BackstageViewClientControl1";
			this.BackstageViewClientControl1.Size = new System.Drawing.Size(108, 150);
			this.BackstageViewClientControl1.TabIndex = 0;
			//
			//RecentDashboardsControl1
			//
			this.RecentDashboardsControl1.DashboardDesigner = this.DashboardDesigner1;
			this.RecentDashboardsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RecentDashboardsControl1.ForeColor = System.Drawing.Color.Transparent;
			this.RecentDashboardsControl1.Location = new System.Drawing.Point(0, 0);
			this.RecentDashboardsControl1.Name = "RecentDashboardsControl1";
			this.RecentDashboardsControl1.Size = new System.Drawing.Size(108, 150);
			this.RecentDashboardsControl1.TabIndex = 0;
			//
			//DashboardBackstageRecentTab1
			//
			this.DashboardBackstageRecentTab1.ContentControl = this.BackstageViewClientControl1;
			this.DashboardBackstageRecentTab1.Name = "DashboardBackstageRecentTab1";
			this.DashboardBackstageRecentTab1.RecentDashboardsControl = this.RecentDashboardsControl1;
			this.DashboardBackstageRecentTab1.Selected = true;
			//
			//DashboardBackstageNewButton1
			//
			this.DashboardBackstageNewButton1.DashboardDesigner = this.DashboardDesigner1;
			this.DashboardBackstageNewButton1.Glyph = (System.Drawing.Image) (resources.GetObject("DashboardBackstageNewButton1.Glyph"));
			this.DashboardBackstageNewButton1.Name = "DashboardBackstageNewButton1";
			//
			//DashboardBackstageOpenButton1
			//
			this.DashboardBackstageOpenButton1.DashboardDesigner = this.DashboardDesigner1;
			this.DashboardBackstageOpenButton1.Glyph = (System.Drawing.Image) (resources.GetObject("DashboardBackstageOpenButton1.Glyph"));
			this.DashboardBackstageOpenButton1.Name = "DashboardBackstageOpenButton1";
			//
			//DashboardBackstageSaveButton1
			//
			this.DashboardBackstageSaveButton1.DashboardDesigner = this.DashboardDesigner1;
			this.DashboardBackstageSaveButton1.Glyph = (System.Drawing.Image) (resources.GetObject("DashboardBackstageSaveButton1.Glyph"));
			this.DashboardBackstageSaveButton1.Name = "DashboardBackstageSaveButton1";
			//
			//DashboardBackstageSaveAsButton1
			//
			this.DashboardBackstageSaveAsButton1.DashboardDesigner = this.DashboardDesigner1;
			this.DashboardBackstageSaveAsButton1.Glyph = (System.Drawing.Image) (resources.GetObject("DashboardBackstageSaveAsButton1.Glyph"));
			this.DashboardBackstageSaveAsButton1.Name = "DashboardBackstageSaveAsButton1";
			//
			//FileNewBarItem1
			//
			this.FileNewBarItem1.Id = 1;
			this.FileNewBarItem1.Name = "FileNewBarItem1";
			//
			//FileOpenBarItem1
			//
			this.FileOpenBarItem1.Id = 2;
			this.FileOpenBarItem1.Name = "FileOpenBarItem1";
			//
			//FileSaveBarItem1
			//
			this.FileSaveBarItem1.Id = 3;
			this.FileSaveBarItem1.Name = "FileSaveBarItem1";
			//
			//FileSaveAsBarItem1
			//
			this.FileSaveAsBarItem1.Id = 4;
			this.FileSaveAsBarItem1.Name = "FileSaveAsBarItem1";
			//
			//UndoBarItem1
			//
			this.UndoBarItem1.Id = 5;
			this.UndoBarItem1.Name = "UndoBarItem1";
			//
			//RedoBarItem1
			//
			this.RedoBarItem1.Id = 6;
			this.RedoBarItem1.Name = "RedoBarItem1";
			//
			//NewDataSourceBarItem1
			//
			this.NewDataSourceBarItem1.Id = 7;
			this.NewDataSourceBarItem1.Name = "NewDataSourceBarItem1";
			//
			//EditDataSourceBarItem1
			//
			this.EditDataSourceBarItem1.Id = 8;
			this.EditDataSourceBarItem1.Name = "EditDataSourceBarItem1";
			//
			//DeleteDataSourceBarItem1
			//
			this.DeleteDataSourceBarItem1.Id = 9;
			this.DeleteDataSourceBarItem1.Name = "DeleteDataSourceBarItem1";
			//
			//AddCalculatedFieldBarItem1
			//
			this.AddCalculatedFieldBarItem1.Id = 10;
			this.AddCalculatedFieldBarItem1.Name = "AddCalculatedFieldBarItem1";
			//
			//DashboardParametersBarItem1
			//
			this.DashboardParametersBarItem1.Id = 11;
			this.DashboardParametersBarItem1.Name = "DashboardParametersBarItem1";
			//
			//EditDataSourceFilterBarItem1
			//
			this.EditDataSourceFilterBarItem1.Id = 12;
			this.EditDataSourceFilterBarItem1.Name = "EditDataSourceFilterBarItem1";
			//
			//ClearDataSourceFilterBarItem1
			//
			this.ClearDataSourceFilterBarItem1.Id = 13;
			this.ClearDataSourceFilterBarItem1.Name = "ClearDataSourceFilterBarItem1";
			//
			//InsertPivotBarItem1
			//
			this.InsertPivotBarItem1.Id = 14;
			this.InsertPivotBarItem1.Name = "InsertPivotBarItem1";
			//
			//InsertGridBarItem1
			//
			this.InsertGridBarItem1.Id = 15;
			this.InsertGridBarItem1.Name = "InsertGridBarItem1";
			//
			//InsertChartBarItem1
			//
			this.InsertChartBarItem1.Id = 16;
			this.InsertChartBarItem1.Name = "InsertChartBarItem1";
			//
			//InsertPiesBarItem1
			//
			this.InsertPiesBarItem1.Id = 17;
			this.InsertPiesBarItem1.Name = "InsertPiesBarItem1";
			//
			//InsertGaugesBarItem1
			//
			this.InsertGaugesBarItem1.Id = 18;
			this.InsertGaugesBarItem1.Name = "InsertGaugesBarItem1";
			//
			//InsertCardsBarItem1
			//
			this.InsertCardsBarItem1.Id = 19;
			this.InsertCardsBarItem1.Name = "InsertCardsBarItem1";
			//
			//InsertChoroplethMapBarItem1
			//
			this.InsertChoroplethMapBarItem1.Id = 20;
			this.InsertChoroplethMapBarItem1.Name = "InsertChoroplethMapBarItem1";
			//
			//InsertGeoPointMapBarItem1
			//
			this.InsertGeoPointMapBarItem1.Id = 21;
			this.InsertGeoPointMapBarItem1.Name = "InsertGeoPointMapBarItem1";
			//
			//InsertRangeFilterBarItem1
			//
			this.InsertRangeFilterBarItem1.Id = 22;
			this.InsertRangeFilterBarItem1.Name = "InsertRangeFilterBarItem1";
			//
			//InsertImageBarItem1
			//
			this.InsertImageBarItem1.Id = 23;
			this.InsertImageBarItem1.Name = "InsertImageBarItem1";
			//
			//InsertTextBoxBarItem1
			//
			this.InsertTextBoxBarItem1.Id = 24;
			this.InsertTextBoxBarItem1.Name = "InsertTextBoxBarItem1";
			//
			//DuplicateItemBarItem1
			//
			this.DuplicateItemBarItem1.Id = 25;
			this.DuplicateItemBarItem1.Name = "DuplicateItemBarItem1";
			//
			//DeleteItemBarItem1
			//
			this.DeleteItemBarItem1.Id = 26;
			this.DeleteItemBarItem1.Name = "DeleteItemBarItem1";
			//
			//DashboardTitleBarItem1
			//
			this.DashboardTitleBarItem1.Id = 27;
			this.DashboardTitleBarItem1.Name = "DashboardTitleBarItem1";
			//
			//SetCurrencyCultureBarItem1
			//
			this.SetCurrencyCultureBarItem1.Id = 28;
			this.SetCurrencyCultureBarItem1.Name = "SetCurrencyCultureBarItem1";
			//
			//DashboardSkinsBarItem1
			//
			//
			//
			//
			this.DashboardSkinsBarItem1.Gallery.AllowHoverImages = true;
			this.DashboardSkinsBarItem1.Gallery.ColumnCount = 4;
			this.DashboardSkinsBarItem1.Gallery.FixedHoverImageSize = false;
			GalleryItemGroup1.Caption = "Standard Skins";
			GalleryItem1.Caption = "DevExpress Style";
			GalleryItem1.Hint = "DevExpress Style";
			GalleryItem1.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem1.HoverImage"));
			GalleryItem1.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem1.Image"));
			GalleryItem1.Tag = "DevExpress Style";
			GalleryItem2.Caption = "DevExpress Dark Style";
			GalleryItem2.Hint = "DevExpress Dark Style";
			GalleryItem2.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem2.HoverImage"));
			GalleryItem2.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem2.Image"));
			GalleryItem2.Tag = "DevExpress Dark Style";
			GalleryItem3.Caption = "Office 2013 White";
			GalleryItem3.Hint = "Office 2013 White";
			GalleryItem3.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem3.HoverImage"));
			GalleryItem3.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem3.Image"));
			GalleryItem3.Tag = "Office 2013";
			GalleryItem4.Caption = "Office 2013 Dark Gray";
			GalleryItem4.Hint = "Office 2013 Dark Gray";
			GalleryItem4.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem4.HoverImage"));
			GalleryItem4.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem4.Image"));
			GalleryItem4.Tag = "Office 2013 Dark Gray";
			GalleryItem5.Caption = "Office 2013 Light Gray";
			GalleryItem5.Hint = "Office 2013 Light Gray";
			GalleryItem5.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem5.HoverImage"));
			GalleryItem5.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem5.Image"));
			GalleryItem5.Tag = "Office 2013 Light Gray";
			GalleryItem6.Caption = "Office 2010 Blue";
			GalleryItem6.Hint = "Office 2010 Blue";
			GalleryItem6.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem6.HoverImage"));
			GalleryItem6.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem6.Image"));
			GalleryItem6.Tag = "Office 2010 Blue";
			GalleryItem7.Caption = "Office 2010 Black";
			GalleryItem7.Hint = "Office 2010 Black";
			GalleryItem7.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem7.HoverImage"));
			GalleryItem7.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem7.Image"));
			GalleryItem7.Tag = "Office 2010 Black";
			GalleryItem8.Caption = "Office 2010 Silver";
			GalleryItem8.Hint = "Office 2010 Silver";
			GalleryItem8.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem8.HoverImage"));
			GalleryItem8.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem8.Image"));
			GalleryItem8.Tag = "Office 2010 Silver";
			GalleryItem9.Caption = "Visual Studio 2013 Blue";
			GalleryItem9.Hint = "Visual Studio 2013 Blue";
			GalleryItem9.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem9.HoverImage"));
			GalleryItem9.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem9.Image"));
			GalleryItem9.Tag = "Visual Studio 2013 Blue";
			GalleryItem10.Caption = "Visual Studio 2013 Dark";
			GalleryItem10.Hint = "Visual Studio 2013 Dark";
			GalleryItem10.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem10.HoverImage"));
			GalleryItem10.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem10.Image"));
			GalleryItem10.Tag = "Visual Studio 2013 Dark";
			GalleryItem11.Caption = "Visual Studio 2013 Light";
			GalleryItem11.Hint = "Visual Studio 2013 Light";
			GalleryItem11.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem11.HoverImage"));
			GalleryItem11.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem11.Image"));
			GalleryItem11.Tag = "Visual Studio 2013 Light";
			GalleryItem12.Caption = "Seven Classic";
			GalleryItem12.Hint = "Seven Classic";
			GalleryItem12.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem12.HoverImage"));
			GalleryItem12.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem12.Image"));
			GalleryItem12.Tag = "Seven Classic";
			GalleryItem13.Caption = "Visual Studio 2010";
			GalleryItem13.Hint = "Visual Studio 2010";
			GalleryItem13.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem13.HoverImage"));
			GalleryItem13.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem13.Image"));
			GalleryItem13.Tag = "VS2010";
			GalleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {GalleryItem1, GalleryItem2, GalleryItem3, GalleryItem4, GalleryItem5, GalleryItem6, GalleryItem7, GalleryItem8, GalleryItem9, GalleryItem10, GalleryItem11, GalleryItem12, GalleryItem13});
			GalleryItemGroup2.Caption = "Bonus Skins";
			GalleryItem14.Caption = "Black";
			GalleryItem14.Hint = "Black";
			GalleryItem14.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem14.HoverImage"));
			GalleryItem14.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem14.Image"));
			GalleryItem14.Tag = "Black";
			GalleryItem15.Caption = "Blue";
			GalleryItem15.Hint = "Blue";
			GalleryItem15.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem15.HoverImage"));
			GalleryItem15.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem15.Image"));
			GalleryItem15.Tag = "Blue";
			GalleryItem16.Caption = "Caramel";
			GalleryItem16.Hint = "Caramel";
			GalleryItem16.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem16.HoverImage"));
			GalleryItem16.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem16.Image"));
			GalleryItem16.Tag = "Caramel";
			GalleryItem17.Caption = "Coffee";
			GalleryItem17.Hint = "Coffee";
			GalleryItem17.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem17.HoverImage"));
			GalleryItem17.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem17.Image"));
			GalleryItem17.Tag = "Coffee";
			GalleryItem18.Caption = "Dark Side";
			GalleryItem18.Hint = "Dark Side";
			GalleryItem18.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem18.HoverImage"));
			GalleryItem18.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem18.Image"));
			GalleryItem18.Tag = "Dark Side";
			GalleryItem19.Caption = "Darkroom";
			GalleryItem19.Hint = "Darkroom";
			GalleryItem19.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem19.HoverImage"));
			GalleryItem19.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem19.Image"));
			GalleryItem19.Tag = "Darkroom";
			GalleryItem20.Caption = "Foggy";
			GalleryItem20.Hint = "Foggy";
			GalleryItem20.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem20.HoverImage"));
			GalleryItem20.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem20.Image"));
			GalleryItem20.Tag = "Foggy";
			GalleryItem21.Caption = "Glass Oceans";
			GalleryItem21.Hint = "Glass Oceans";
			GalleryItem21.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem21.HoverImage"));
			GalleryItem21.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem21.Image"));
			GalleryItem21.Tag = "Glass Oceans";
			GalleryItem22.Caption = "High Contrast";
			GalleryItem22.Hint = "High Contrast";
			GalleryItem22.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem22.HoverImage"));
			GalleryItem22.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem22.Image"));
			GalleryItem22.Tag = "High Contrast";
			GalleryItem23.Caption = "iMaginary";
			GalleryItem23.Hint = "iMaginary";
			GalleryItem23.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem23.HoverImage"));
			GalleryItem23.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem23.Image"));
			GalleryItem23.Tag = "iMaginary";
			GalleryItem24.Caption = "Lilian";
			GalleryItem24.Hint = "Lilian";
			GalleryItem24.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem24.HoverImage"));
			GalleryItem24.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem24.Image"));
			GalleryItem24.Tag = "Lilian";
			GalleryItem25.Caption = "Liquid Sky";
			GalleryItem25.Hint = "Liquid Sky";
			GalleryItem25.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem25.HoverImage"));
			GalleryItem25.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem25.Image"));
			GalleryItem25.Tag = "Liquid Sky";
			GalleryItem26.Caption = "London Liquid Sky";
			GalleryItem26.Hint = "London Liquid Sky";
			GalleryItem26.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem26.HoverImage"));
			GalleryItem26.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem26.Image"));
			GalleryItem26.Tag = "London Liquid Sky";
			GalleryItem27.Caption = "Metropolis";
			GalleryItem27.Hint = "Metropolis";
			GalleryItem27.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem27.HoverImage"));
			GalleryItem27.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem27.Image"));
			GalleryItem27.Tag = "Metropolis";
			GalleryItem28.Caption = "Metropolis Dark";
			GalleryItem28.Hint = "Metropolis Dark";
			GalleryItem28.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem28.HoverImage"));
			GalleryItem28.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem28.Image"));
			GalleryItem28.Tag = "Metropolis Dark";
			GalleryItem29.Caption = "Money Twins";
			GalleryItem29.Hint = "Money Twins";
			GalleryItem29.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem29.HoverImage"));
			GalleryItem29.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem29.Image"));
			GalleryItem29.Tag = "Money Twins";
			GalleryItem30.Caption = "Office 2007 Black";
			GalleryItem30.Hint = "Office 2007 Black";
			GalleryItem30.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem30.HoverImage"));
			GalleryItem30.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem30.Image"));
			GalleryItem30.Tag = "Office 2007 Black";
			GalleryItem31.Caption = "Office 2007 Blue";
			GalleryItem31.Hint = "Office 2007 Blue";
			GalleryItem31.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem31.HoverImage"));
			GalleryItem31.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem31.Image"));
			GalleryItem31.Tag = "Office 2007 Blue";
			GalleryItem32.Caption = "Office 2007 Green";
			GalleryItem32.Checked = true;
			GalleryItem32.Hint = "Office 2007 Green";
			GalleryItem32.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem32.HoverImage"));
			GalleryItem32.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem32.Image"));
			GalleryItem32.Tag = "Office 2007 Green";
			GalleryItem33.Caption = "Office 2007 Pink";
			GalleryItem33.Hint = "Office 2007 Pink";
			GalleryItem33.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem33.HoverImage"));
			GalleryItem33.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem33.Image"));
			GalleryItem33.Tag = "Office 2007 Pink";
			GalleryItem34.Caption = "Office 2007 Silver";
			GalleryItem34.Hint = "Office 2007 Silver";
			GalleryItem34.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem34.HoverImage"));
			GalleryItem34.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem34.Image"));
			GalleryItem34.Tag = "Office 2007 Silver";
			GalleryItem35.Caption = "Seven";
			GalleryItem35.Hint = "Seven";
			GalleryItem35.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem35.HoverImage"));
			GalleryItem35.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem35.Image"));
			GalleryItem35.Tag = "Seven";
			GalleryItem36.Caption = "Sharp";
			GalleryItem36.Hint = "Sharp";
			GalleryItem36.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem36.HoverImage"));
			GalleryItem36.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem36.Image"));
			GalleryItem36.Tag = "Sharp";
			GalleryItem37.Caption = "Sharp Plus";
			GalleryItem37.Hint = "Sharp Plus";
			GalleryItem37.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem37.HoverImage"));
			GalleryItem37.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem37.Image"));
			GalleryItem37.Tag = "Sharp Plus";
			GalleryItem38.Caption = "Stardust";
			GalleryItem38.Hint = "Stardust";
			GalleryItem38.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem38.HoverImage"));
			GalleryItem38.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem38.Image"));
			GalleryItem38.Tag = "Stardust";
			GalleryItem39.Caption = "The Asphalt World";
			GalleryItem39.Hint = "The Asphalt World";
			GalleryItem39.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem39.HoverImage"));
			GalleryItem39.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem39.Image"));
			GalleryItem39.Tag = "The Asphalt World";
			GalleryItemGroup2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {GalleryItem14, GalleryItem15, GalleryItem16, GalleryItem17, GalleryItem18, GalleryItem19, GalleryItem20, GalleryItem21, GalleryItem22, GalleryItem23, GalleryItem24, GalleryItem25, GalleryItem26, GalleryItem27, GalleryItem28, GalleryItem29, GalleryItem30, GalleryItem31, GalleryItem32, GalleryItem33, GalleryItem34, GalleryItem35, GalleryItem36, GalleryItem37, GalleryItem38, GalleryItem39});
			GalleryItemGroup3.Caption = "Theme Skins";
			GalleryItem40.Caption = "Pumpkin";
			GalleryItem40.Hint = "Pumpkin";
			GalleryItem40.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem40.HoverImage"));
			GalleryItem40.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem40.Image"));
			GalleryItem40.Tag = "Pumpkin";
			GalleryItem41.Caption = "Springtime";
			GalleryItem41.Hint = "Springtime";
			GalleryItem41.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem41.HoverImage"));
			GalleryItem41.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem41.Image"));
			GalleryItem41.Tag = "Springtime";
			GalleryItem42.Caption = "Summer";
			GalleryItem42.Hint = "Summer";
			GalleryItem42.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem42.HoverImage"));
			GalleryItem42.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem42.Image"));
			GalleryItem42.Tag = "Summer 2008";
			GalleryItem43.Caption = "Valentine";
			GalleryItem43.Hint = "Valentine";
			GalleryItem43.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem43.HoverImage"));
			GalleryItem43.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem43.Image"));
			GalleryItem43.Tag = "Valentine";
			GalleryItem44.Caption = "Xmas (Blue)";
			GalleryItem44.Hint = "Xmas (Blue)";
			GalleryItem44.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem44.HoverImage"));
			GalleryItem44.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem44.Image"));
			GalleryItem44.Tag = "Xmas 2008 Blue";
			GalleryItem45.Caption = "McSkin";
			GalleryItem45.Hint = "McSkin";
			GalleryItem45.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem45.HoverImage"));
			GalleryItem45.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem45.Image"));
			GalleryItem45.Tag = "McSkin";
			GalleryItem46.Caption = "Blueprint";
			GalleryItem46.Hint = "Blueprint";
			GalleryItem46.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem46.HoverImage"));
			GalleryItem46.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem46.Image"));
			GalleryItem46.Tag = "Blueprint";
			GalleryItem47.Caption = "Whiteprint";
			GalleryItem47.Hint = "Whiteprint";
			GalleryItem47.HoverImage = (System.Drawing.Image) (resources.GetObject("GalleryItem47.HoverImage"));
			GalleryItem47.Image = (System.Drawing.Image) (resources.GetObject("GalleryItem47.Image"));
			GalleryItem47.Tag = "Whiteprint";
			GalleryItemGroup3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {GalleryItem40, GalleryItem41, GalleryItem42, GalleryItem43, GalleryItem44, GalleryItem45, GalleryItem46, GalleryItem47});
			GalleryItemGroup4.Caption = "Custom Skins";
			GalleryItemGroup4.Visible = false;
			this.DashboardSkinsBarItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {GalleryItemGroup1, GalleryItemGroup2, GalleryItemGroup3, GalleryItemGroup4});
			this.DashboardSkinsBarItem1.Gallery.ImageSize = new System.Drawing.Size(32, 16);
			this.DashboardSkinsBarItem1.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio;
			this.DashboardSkinsBarItem1.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top;
			this.DashboardSkinsBarItem1.Glyph = (System.Drawing.Image) (resources.GetObject("DashboardSkinsBarItem1.Glyph"));
			this.DashboardSkinsBarItem1.Id = 29;
			this.DashboardSkinsBarItem1.Name = "DashboardSkinsBarItem1";
			//
			//EditFilterBarItem1
			//
			this.EditFilterBarItem1.Id = 30;
			this.EditFilterBarItem1.Name = "EditFilterBarItem1";
			//
			//ClearFilterBarItem1
			//
			this.ClearFilterBarItem1.Id = 31;
			this.ClearFilterBarItem1.Name = "ClearFilterBarItem1";
			//
			//MasterFilterBarItem1
			//
			this.MasterFilterBarItem1.Id = 32;
			this.MasterFilterBarItem1.Name = "MasterFilterBarItem1";
			//
			//MultipleValuesMasterFilterBarItem1
			//
			this.MultipleValuesMasterFilterBarItem1.Id = 33;
			this.MultipleValuesMasterFilterBarItem1.Name = "MultipleValuesMasterFilterBarItem1";
			//
			//DrillDownBarItem1
			//
			this.DrillDownBarItem1.Id = 34;
			this.DrillDownBarItem1.Name = "DrillDownBarItem1";
			//
			//IgnoreMasterFiltersBarItem1
			//
			this.IgnoreMasterFiltersBarItem1.Id = 35;
			this.IgnoreMasterFiltersBarItem1.Name = "IgnoreMasterFiltersBarItem1";
			//
			//CrossDataSourceFilteringBarItem1
			//
			this.CrossDataSourceFilteringBarItem1.Id = 36;
			this.CrossDataSourceFilteringBarItem1.Name = "CrossDataSourceFilteringBarItem1";
			//
			//ChartTargetDimensionsArgumentsBarItem1
			//
			this.ChartTargetDimensionsArgumentsBarItem1.Id = 37;
			this.ChartTargetDimensionsArgumentsBarItem1.Name = "ChartTargetDimensionsArgumentsBarItem1";
			//
			//ChartTargetDimensionsSeriesBarItem1
			//
			this.ChartTargetDimensionsSeriesBarItem1.Id = 38;
			this.ChartTargetDimensionsSeriesBarItem1.Name = "ChartTargetDimensionsSeriesBarItem1";
			//
			//PieTargetDimensionsArgumentsBarItem1
			//
			this.PieTargetDimensionsArgumentsBarItem1.Id = 39;
			this.PieTargetDimensionsArgumentsBarItem1.Name = "PieTargetDimensionsArgumentsBarItem1";
			//
			//PieTargetDimensionsSeriesBarItem1
			//
			this.PieTargetDimensionsSeriesBarItem1.Id = 40;
			this.PieTargetDimensionsSeriesBarItem1.Name = "PieTargetDimensionsSeriesBarItem1";
			//
			//ShowItemCaptionBarItem1
			//
			this.ShowItemCaptionBarItem1.Id = 41;
			this.ShowItemCaptionBarItem1.Name = "ShowItemCaptionBarItem1";
			//
			//EditItemNamesBarItem1
			//
			this.EditItemNamesBarItem1.Id = 42;
			this.EditItemNamesBarItem1.Name = "EditItemNamesBarItem1";
			//
			//ContentAutoArrangeBarItem1
			//
			this.ContentAutoArrangeBarItem1.Id = 43;
			this.ContentAutoArrangeBarItem1.Name = "ContentAutoArrangeBarItem1";
			//
			//ContentArrangeInColumnsBarItem1
			//
			this.ContentArrangeInColumnsBarItem1.Id = 44;
			this.ContentArrangeInColumnsBarItem1.Name = "ContentArrangeInColumnsBarItem1";
			//
			//ContentArrangeInRowsBarItem1
			//
			this.ContentArrangeInRowsBarItem1.Id = 45;
			this.ContentArrangeInRowsBarItem1.Name = "ContentArrangeInRowsBarItem1";
			//
			//ContentArrangementCountBarItem1
			//
			this.ContentArrangementCountBarItem1.Edit = this.RepositoryItemSpinEdit1;
			this.ContentArrangementCountBarItem1.Id = 46;
			this.ContentArrangementCountBarItem1.Name = "ContentArrangementCountBarItem1";
			//
			//RepositoryItemSpinEdit1
			//
			this.RepositoryItemSpinEdit1.AutoHeight = false;
			this.RepositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.RepositoryItemSpinEdit1.IsFloatValue = false;
			this.RepositoryItemSpinEdit1.Mask.EditMask = "N00";
			this.RepositoryItemSpinEdit1.MaxValue = new decimal(new int[] {10000, 0, 0, 0});
			this.RepositoryItemSpinEdit1.MinValue = new decimal(new int[] {1, 0, 0, 0});
			this.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1";
			//
			//GridHorizontalLinesBarItem1
			//
			this.GridHorizontalLinesBarItem1.Id = 47;
			this.GridHorizontalLinesBarItem1.Name = "GridHorizontalLinesBarItem1";
			//
			//GridVerticalLinesBarItem1
			//
			this.GridVerticalLinesBarItem1.Id = 48;
			this.GridVerticalLinesBarItem1.Name = "GridVerticalLinesBarItem1";
			//
			//GridMergeCellsBarItem1
			//
			this.GridMergeCellsBarItem1.Id = 49;
			this.GridMergeCellsBarItem1.Name = "GridMergeCellsBarItem1";
			//
			//GridBandedRowsBarItem1
			//
			this.GridBandedRowsBarItem1.Id = 50;
			this.GridBandedRowsBarItem1.Name = "GridBandedRowsBarItem1";
			//
			//GridColumnHeadersBarItem1
			//
			this.GridColumnHeadersBarItem1.Id = 51;
			this.GridColumnHeadersBarItem1.Name = "GridColumnHeadersBarItem1";
			//
			//ChartRotateBarItem1
			//
			this.ChartRotateBarItem1.Id = 52;
			this.ChartRotateBarItem1.Name = "ChartRotateBarItem1";
			//
			//ChartXAxisSettingsBarItem1
			//
			this.ChartXAxisSettingsBarItem1.Id = 53;
			this.ChartXAxisSettingsBarItem1.Name = "ChartXAxisSettingsBarItem1";
			//
			//ChartYAxisSettingsBarItem1
			//
			this.ChartYAxisSettingsBarItem1.Id = 54;
			this.ChartYAxisSettingsBarItem1.Name = "ChartYAxisSettingsBarItem1";
			//
			//ChartShowLegendBarItem1
			//
			this.ChartShowLegendBarItem1.Id = 55;
			this.ChartShowLegendBarItem1.Name = "ChartShowLegendBarItem1";
			//
			//GalleryChartLegendPositionItem1
			//
			//
			//
			//
			this.GalleryChartLegendPositionItem1.Gallery.ColumnCount = 3;
			GalleryItemGroup5.Caption = "Inside Horizontal";
			GalleryItemGroup6.Caption = "Inside Vertical";
			GalleryItemGroup7.Caption = "Outside Horizontal";
			GalleryItemGroup8.Caption = "Outside Vertical";
			this.GalleryChartLegendPositionItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {GalleryItemGroup5, GalleryItemGroup6, GalleryItemGroup7, GalleryItemGroup8});
			this.GalleryChartLegendPositionItem1.Gallery.ImageSize = new System.Drawing.Size(32, 32);
			this.GalleryChartLegendPositionItem1.Gallery.RowCount = 8;
			this.GalleryChartLegendPositionItem1.Id = 56;
			this.GalleryChartLegendPositionItem1.Name = "GalleryChartLegendPositionItem1";
			//
			//GalleryChartSeriesTypeItem1
			//
			//
			//
			//
			GalleryItemGroup9.Caption = "Bar";
			ChartSeriesTypeGalleryItem1.Hint = "Bar";
			ChartSeriesTypeGalleryItem1.Image = (System.Drawing.Image) (resources.GetObject("ChartSeriesTypeGalleryItem1.Image"));
			ChartSeriesTypeGalleryItem1.SeriesTypeCaption = "Bar";
			ChartSeriesTypeGalleryItem2.Hint = "Stacked Bar";
			ChartSeriesTypeGalleryItem2.Image = (System.Drawing.Image) (resources.GetObject("ChartSeriesTypeGalleryItem2.Image"));
			ChartSeriesTypeGalleryItem2.SeriesTypeCaption = "Stacked Bar";
			ChartSeriesTypeGalleryItem3.Hint = "Full-Stacked Bar";
			ChartSeriesTypeGalleryItem3.Image = (System.Drawing.Image) (resources.GetObject("ChartSeriesTypeGalleryItem3.Image"));
			ChartSeriesTypeGalleryItem3.SeriesTypeCaption = "Full-Stacked Bar";
			GalleryItemGroup9.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {ChartSeriesTypeGalleryItem1, ChartSeriesTypeGalleryItem2, ChartSeriesTypeGalleryItem3});
			GalleryItemGroup10.Caption = "Point / Line";
			ChartSeriesTypeGalleryItem4.Hint = "Point";
			ChartSeriesTypeGalleryItem4.Image = (System.Drawing.Image) (resources.GetObject("ChartSeriesTypeGalleryItem4.Image"));
			ChartSeriesTypeGalleryItem4.SeriesTypeCaption = "Point";
			ChartSeriesTypeGalleryItem5.Hint = "Line";
			ChartSeriesTypeGalleryItem5.Image = (System.Drawing.Image) (resources.GetObject("ChartSeriesTypeGalleryItem5.Image"));
			ChartSeriesTypeGalleryItem5.SeriesTypeCaption = "Line";
			ChartSeriesTypeGalleryItem6.Hint = "Stacked Line";
			ChartSeriesTypeGalleryItem6.Image = (System.Drawing.Image) (resources.GetObject("ChartSeriesTypeGalleryItem6.Image"));
			ChartSeriesTypeGalleryItem6.SeriesTypeCaption = "Stacked Line";
			ChartSeriesTypeGalleryItem7.Hint = "Full-Stacked Line";
			ChartSeriesTypeGalleryItem7.Image = (System.Drawing.Image) (resources.GetObject("ChartSeriesTypeGalleryItem7.Image"));
			ChartSeriesTypeGalleryItem7.SeriesTypeCaption = "Full-Stacked Line";
			ChartSeriesTypeGalleryItem8.Hint = "Step Line";
			ChartSeriesTypeGalleryItem8.Image = (System.Drawing.Image) (resources.GetObject("ChartSeriesTypeGalleryItem8.Image"));
			ChartSeriesTypeGalleryItem8.SeriesTypeCaption = "Step Line";
			ChartSeriesTypeGalleryItem9.Hint = "Spline";
			ChartSeriesTypeGalleryItem9.Image = (System.Drawing.Image) (resources.GetObject("ChartSeriesTypeGalleryItem9.Image"));
			ChartSeriesTypeGalleryItem9.SeriesTypeCaption = "Spline";
			GalleryItemGroup10.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {ChartSeriesTypeGalleryItem4, ChartSeriesTypeGalleryItem5, ChartSeriesTypeGalleryItem6, ChartSeriesTypeGalleryItem7, ChartSeriesTypeGalleryItem8, ChartSeriesTypeGalleryItem9});
			GalleryItemGroup11.Caption = "Area";
			ChartSeriesTypeGalleryItem10.Hint = "Area";
			ChartSeriesTypeGalleryItem10.Image = (System.Drawing.Image) (resources.GetObject("ChartSeriesTypeGalleryItem10.Image"));
			ChartSeriesTypeGalleryItem10.SeriesTypeCaption = "Area";
			ChartSeriesTypeGalleryItem11.Hint = "Stacked Area";
			ChartSeriesTypeGalleryItem11.Image = (System.Drawing.Image) (resources.GetObject("ChartSeriesTypeGalleryItem11.Image"));
			ChartSeriesTypeGalleryItem11.SeriesTypeCaption = "Stacked Area";
			ChartSeriesTypeGalleryItem12.Hint = "Full-Stacked Area";
			ChartSeriesTypeGalleryItem12.Image = (System.Drawing.Image) (resources.GetObject("ChartSeriesTypeGalleryItem12.Image"));
			ChartSeriesTypeGalleryItem12.SeriesTypeCaption = "Full-Stacked Area";
			ChartSeriesTypeGalleryItem13.Hint = "Step Area";
			ChartSeriesTypeGalleryItem13.Image = (System.Drawing.Image) (resources.GetObject("ChartSeriesTypeGalleryItem13.Image"));
			ChartSeriesTypeGalleryItem13.SeriesTypeCaption = "Step Area";
			ChartSeriesTypeGalleryItem14.Hint = "Spline Area";
			ChartSeriesTypeGalleryItem14.Image = (System.Drawing.Image) (resources.GetObject("ChartSeriesTypeGalleryItem14.Image"));
			ChartSeriesTypeGalleryItem14.SeriesTypeCaption = "Spline Area";
			ChartSeriesTypeGalleryItem15.Hint = "Stacked Spline Area";
			ChartSeriesTypeGalleryItem15.Image = (System.Drawing.Image) (resources.GetObject("ChartSeriesTypeGalleryItem15.Image"));
			ChartSeriesTypeGalleryItem15.SeriesTypeCaption = "Stacked Spline Area";
			ChartSeriesTypeGalleryItem16.Hint = "Full-Stacked Spline Area";
			ChartSeriesTypeGalleryItem16.Image = (System.Drawing.Image) (resources.GetObject("ChartSeriesTypeGalleryItem16.Image"));
			ChartSeriesTypeGalleryItem16.SeriesTypeCaption = "Full-Stacked Spline Area";
			GalleryItemGroup11.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {ChartSeriesTypeGalleryItem10, ChartSeriesTypeGalleryItem11, ChartSeriesTypeGalleryItem12, ChartSeriesTypeGalleryItem13, ChartSeriesTypeGalleryItem14, ChartSeriesTypeGalleryItem15, ChartSeriesTypeGalleryItem16});
			GalleryItemGroup12.Caption = "Range";
			ChartSeriesTypeGalleryItem17.Hint = "Range Bar Side-by-Side";
			ChartSeriesTypeGalleryItem17.Image = (System.Drawing.Image) (resources.GetObject("ChartSeriesTypeGalleryItem17.Image"));
			ChartSeriesTypeGalleryItem17.SeriesTypeCaption = "Range Bar Side-by-Side";
			ChartSeriesTypeGalleryItem18.Hint = "Range Area";
			ChartSeriesTypeGalleryItem18.Image = (System.Drawing.Image) (resources.GetObject("ChartSeriesTypeGalleryItem18.Image"));
			ChartSeriesTypeGalleryItem18.SeriesTypeCaption = "Range Area";
			GalleryItemGroup12.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {ChartSeriesTypeGalleryItem17, ChartSeriesTypeGalleryItem18});
			GalleryItemGroup13.Caption = "Bubble";
			ChartSeriesTypeGalleryItem19.Hint = "Bubble";
			ChartSeriesTypeGalleryItem19.Image = (System.Drawing.Image) (resources.GetObject("ChartSeriesTypeGalleryItem19.Image"));
			ChartSeriesTypeGalleryItem19.SeriesTypeCaption = "Bubble";
			GalleryItemGroup13.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {ChartSeriesTypeGalleryItem19});
			GalleryItemGroup14.Caption = "Financial";
			ChartSeriesTypeGalleryItem20.Hint = "High-Low-Close";
			ChartSeriesTypeGalleryItem20.Image = (System.Drawing.Image) (resources.GetObject("ChartSeriesTypeGalleryItem20.Image"));
			ChartSeriesTypeGalleryItem20.SeriesTypeCaption = "High-Low-Close";
			ChartSeriesTypeGalleryItem21.Hint = "Open-High-Low-Close (Candle Stick)";
			ChartSeriesTypeGalleryItem21.Image = (System.Drawing.Image) (resources.GetObject("ChartSeriesTypeGalleryItem21.Image"));
			ChartSeriesTypeGalleryItem21.SeriesTypeCaption = "Open-High-Low-Close (Candle Stick)";
			ChartSeriesTypeGalleryItem22.Hint = "Open-High-Low-Close (Stock)";
			ChartSeriesTypeGalleryItem22.Image = (System.Drawing.Image) (resources.GetObject("ChartSeriesTypeGalleryItem22.Image"));
			ChartSeriesTypeGalleryItem22.SeriesTypeCaption = "Open-High-Low-Close (Stock)";
			GalleryItemGroup14.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {ChartSeriesTypeGalleryItem20, ChartSeriesTypeGalleryItem21, ChartSeriesTypeGalleryItem22});
			this.GalleryChartSeriesTypeItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {GalleryItemGroup9, GalleryItemGroup10, GalleryItemGroup11, GalleryItemGroup12, GalleryItemGroup13, GalleryItemGroup14});
			this.GalleryChartSeriesTypeItem1.Gallery.ImageSize = new System.Drawing.Size(32, 32);
			this.GalleryChartSeriesTypeItem1.Gallery.RowCount = 8;
			this.GalleryChartSeriesTypeItem1.Id = 57;
			this.GalleryChartSeriesTypeItem1.Name = "GalleryChartSeriesTypeItem1";
			//
			//PieLabelsDataLabelsBarItem1
			//
			this.PieLabelsDataLabelsBarItem1.Id = 58;
			this.PieLabelsDataLabelsBarItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {new DevExpress.XtraBars.LinkPersistInfo(this.PieLabelsDataLabelsNoneBarItem1), new DevExpress.XtraBars.LinkPersistInfo(this.PieLabelsDataLabelArgumentBarItem1), new DevExpress.XtraBars.LinkPersistInfo(this.PieLabelsDataLabelsValueBarItem1), new DevExpress.XtraBars.LinkPersistInfo(this.PieLabelsDataLabelsArgumentAndValueBarItem1), new DevExpress.XtraBars.LinkPersistInfo(this.PieLabelsDataLabelsPercentBarItem1), new DevExpress.XtraBars.LinkPersistInfo(this.PieLabelsDataLabelsValueAndPercentBarItem1), new DevExpress.XtraBars.LinkPersistInfo(this.PieLabelsDataLabelsArgumentAndPercentBarItem1), new DevExpress.XtraBars.LinkPersistInfo(this.PieLabelsDataLabelsArgumentValueAndPercentBarItem1)});
			this.PieLabelsDataLabelsBarItem1.Name = "PieLabelsDataLabelsBarItem1";
			this.PieLabelsDataLabelsBarItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
			//
			//PieLabelsDataLabelsNoneBarItem1
			//
			this.PieLabelsDataLabelsNoneBarItem1.Id = 59;
			this.PieLabelsDataLabelsNoneBarItem1.Name = "PieLabelsDataLabelsNoneBarItem1";
			//
			//PieLabelsDataLabelArgumentBarItem1
			//
			this.PieLabelsDataLabelArgumentBarItem1.Id = 60;
			this.PieLabelsDataLabelArgumentBarItem1.Name = "PieLabelsDataLabelArgumentBarItem1";
			//
			//PieLabelsDataLabelsValueBarItem1
			//
			this.PieLabelsDataLabelsValueBarItem1.Id = 61;
			this.PieLabelsDataLabelsValueBarItem1.Name = "PieLabelsDataLabelsValueBarItem1";
			//
			//PieLabelsDataLabelsArgumentAndValueBarItem1
			//
			this.PieLabelsDataLabelsArgumentAndValueBarItem1.Id = 62;
			this.PieLabelsDataLabelsArgumentAndValueBarItem1.Name = "PieLabelsDataLabelsArgumentAndValueBarItem1";
			//
			//PieLabelsDataLabelsPercentBarItem1
			//
			this.PieLabelsDataLabelsPercentBarItem1.Id = 63;
			this.PieLabelsDataLabelsPercentBarItem1.Name = "PieLabelsDataLabelsPercentBarItem1";
			//
			//PieLabelsDataLabelsValueAndPercentBarItem1
			//
			this.PieLabelsDataLabelsValueAndPercentBarItem1.Id = 64;
			this.PieLabelsDataLabelsValueAndPercentBarItem1.Name = "PieLabelsDataLabelsValueAndPercentBarItem1";
			//
			//PieLabelsDataLabelsArgumentAndPercentBarItem1
			//
			this.PieLabelsDataLabelsArgumentAndPercentBarItem1.Id = 65;
			this.PieLabelsDataLabelsArgumentAndPercentBarItem1.Name = "PieLabelsDataLabelsArgumentAndPercentBarItem1";
			//
			//PieLabelsDataLabelsArgumentValueAndPercentBarItem1
			//
			this.PieLabelsDataLabelsArgumentValueAndPercentBarItem1.Id = 66;
			this.PieLabelsDataLabelsArgumentValueAndPercentBarItem1.Name = "PieLabelsDataLabelsArgumentValueAndPercentBarItem1";
			//
			//PieTooltipsBarItem1
			//
			this.PieTooltipsBarItem1.Id = 67;
			this.PieTooltipsBarItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {new DevExpress.XtraBars.LinkPersistInfo(this.PieLabelsTooltipsNoneBarItem1), new DevExpress.XtraBars.LinkPersistInfo(this.PieLabelsTooltipsArgumentBarItem1), new DevExpress.XtraBars.LinkPersistInfo(this.PieLabelsTooltipsValueBarItem1), new DevExpress.XtraBars.LinkPersistInfo(this.PieLabelsTooltipsArgumentAndValueBarItem1), new DevExpress.XtraBars.LinkPersistInfo(this.PieLabelsTooltipsPercentBarItem1), new DevExpress.XtraBars.LinkPersistInfo(this.PieLabelsTooltipsValueAndPercentBarItem1), new DevExpress.XtraBars.LinkPersistInfo(this.PieLabelsTooltipsArgumentAndPercentBarItem1), new DevExpress.XtraBars.LinkPersistInfo(this.PieLabelsTooltipsArgumentValueAndPercentBarItem1)});
			this.PieTooltipsBarItem1.Name = "PieTooltipsBarItem1";
			this.PieTooltipsBarItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
			//
			//PieLabelsTooltipsNoneBarItem1
			//
			this.PieLabelsTooltipsNoneBarItem1.Id = 68;
			this.PieLabelsTooltipsNoneBarItem1.Name = "PieLabelsTooltipsNoneBarItem1";
			//
			//PieLabelsTooltipsArgumentBarItem1
			//
			this.PieLabelsTooltipsArgumentBarItem1.Id = 69;
			this.PieLabelsTooltipsArgumentBarItem1.Name = "PieLabelsTooltipsArgumentBarItem1";
			//
			//PieLabelsTooltipsValueBarItem1
			//
			this.PieLabelsTooltipsValueBarItem1.Id = 70;
			this.PieLabelsTooltipsValueBarItem1.Name = "PieLabelsTooltipsValueBarItem1";
			//
			//PieLabelsTooltipsArgumentAndValueBarItem1
			//
			this.PieLabelsTooltipsArgumentAndValueBarItem1.Id = 71;
			this.PieLabelsTooltipsArgumentAndValueBarItem1.Name = "PieLabelsTooltipsArgumentAndValueBarItem1";
			//
			//PieLabelsTooltipsPercentBarItem1
			//
			this.PieLabelsTooltipsPercentBarItem1.Id = 72;
			this.PieLabelsTooltipsPercentBarItem1.Name = "PieLabelsTooltipsPercentBarItem1";
			//
			//PieLabelsTooltipsValueAndPercentBarItem1
			//
			this.PieLabelsTooltipsValueAndPercentBarItem1.Id = 73;
			this.PieLabelsTooltipsValueAndPercentBarItem1.Name = "PieLabelsTooltipsValueAndPercentBarItem1";
			//
			//PieLabelsTooltipsArgumentAndPercentBarItem1
			//
			this.PieLabelsTooltipsArgumentAndPercentBarItem1.Id = 74;
			this.PieLabelsTooltipsArgumentAndPercentBarItem1.Name = "PieLabelsTooltipsArgumentAndPercentBarItem1";
			//
			//PieLabelsTooltipsArgumentValueAndPercentBarItem1
			//
			this.PieLabelsTooltipsArgumentValueAndPercentBarItem1.Id = 75;
			this.PieLabelsTooltipsArgumentValueAndPercentBarItem1.Name = "PieLabelsTooltipsArgumentValueAndPercentBarItem1";
			//
			//PieStylePieBarItem1
			//
			this.PieStylePieBarItem1.Id = 76;
			this.PieStylePieBarItem1.Name = "PieStylePieBarItem1";
			//
			//PieStyleDonutBarItem1
			//
			this.PieStyleDonutBarItem1.Id = 77;
			this.PieStyleDonutBarItem1.Name = "PieStyleDonutBarItem1";
			//
			//PieShowCaptionsBarItem1
			//
			this.PieShowCaptionsBarItem1.Id = 78;
			this.PieShowCaptionsBarItem1.Name = "PieShowCaptionsBarItem1";
			//
			//GaugeStyleFullCircularBarItem1
			//
			this.GaugeStyleFullCircularBarItem1.Id = 79;
			this.GaugeStyleFullCircularBarItem1.Name = "GaugeStyleFullCircularBarItem1";
			//
			//GaugeStyleHalfCircularBarItem1
			//
			this.GaugeStyleHalfCircularBarItem1.Id = 80;
			this.GaugeStyleHalfCircularBarItem1.Name = "GaugeStyleHalfCircularBarItem1";
			//
			//GaugeStyleLeftQuarterCircularBarItem1
			//
			this.GaugeStyleLeftQuarterCircularBarItem1.Id = 81;
			this.GaugeStyleLeftQuarterCircularBarItem1.Name = "GaugeStyleLeftQuarterCircularBarItem1";
			//
			//GaugeStyleRightQuarterCircularBarItem1
			//
			this.GaugeStyleRightQuarterCircularBarItem1.Id = 82;
			this.GaugeStyleRightQuarterCircularBarItem1.Name = "GaugeStyleRightQuarterCircularBarItem1";
			//
			//GaugeStyleThreeForthCircularBarItem1
			//
			this.GaugeStyleThreeForthCircularBarItem1.Id = 83;
			this.GaugeStyleThreeForthCircularBarItem1.Name = "GaugeStyleThreeForthCircularBarItem1";
			//
			//GaugeStyleLinearHorizontalBarItem1
			//
			this.GaugeStyleLinearHorizontalBarItem1.Id = 84;
			this.GaugeStyleLinearHorizontalBarItem1.Name = "GaugeStyleLinearHorizontalBarItem1";
			//
			//GaugeStyleLinearVerticalBarItem1
			//
			this.GaugeStyleLinearVerticalBarItem1.Id = 85;
			this.GaugeStyleLinearVerticalBarItem1.Name = "GaugeStyleLinearVerticalBarItem1";
			//
			//GaugeShowCaptionsBarItem1
			//
			this.GaugeShowCaptionsBarItem1.Id = 86;
			this.GaugeShowCaptionsBarItem1.Name = "GaugeShowCaptionsBarItem1";
			//
			//ImageLoadBarItem1
			//
			this.ImageLoadBarItem1.Id = 87;
			this.ImageLoadBarItem1.Name = "ImageLoadBarItem1";
			//
			//ImageImportBarItem1
			//
			this.ImageImportBarItem1.Id = 88;
			this.ImageImportBarItem1.Name = "ImageImportBarItem1";
			//
			//ImageSizeModeClipBarItem1
			//
			this.ImageSizeModeClipBarItem1.Id = 89;
			this.ImageSizeModeClipBarItem1.Name = "ImageSizeModeClipBarItem1";
			//
			//ImageSizeModeStretchBarItem1
			//
			this.ImageSizeModeStretchBarItem1.Id = 90;
			this.ImageSizeModeStretchBarItem1.Name = "ImageSizeModeStretchBarItem1";
			//
			//ImageSizeModeSqueezeBarItem1
			//
			this.ImageSizeModeSqueezeBarItem1.Id = 91;
			this.ImageSizeModeSqueezeBarItem1.Name = "ImageSizeModeSqueezeBarItem1";
			//
			//ImageSizeModeZoomBarItem1
			//
			this.ImageSizeModeZoomBarItem1.Id = 92;
			this.ImageSizeModeZoomBarItem1.Name = "ImageSizeModeZoomBarItem1";
			//
			//ImageAlignmentTopLeftBarItem1
			//
			this.ImageAlignmentTopLeftBarItem1.Id = 93;
			this.ImageAlignmentTopLeftBarItem1.Name = "ImageAlignmentTopLeftBarItem1";
			this.ImageAlignmentTopLeftBarItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
			//
			//ImageAlignmentCenterLeftBarItem1
			//
			this.ImageAlignmentCenterLeftBarItem1.Id = 94;
			this.ImageAlignmentCenterLeftBarItem1.Name = "ImageAlignmentCenterLeftBarItem1";
			this.ImageAlignmentCenterLeftBarItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
			//
			//ImageAlignmentBottomLeftBarItem1
			//
			this.ImageAlignmentBottomLeftBarItem1.Id = 95;
			this.ImageAlignmentBottomLeftBarItem1.Name = "ImageAlignmentBottomLeftBarItem1";
			this.ImageAlignmentBottomLeftBarItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
			//
			//ImageAlignmentTopCenterBarItem1
			//
			this.ImageAlignmentTopCenterBarItem1.Id = 96;
			this.ImageAlignmentTopCenterBarItem1.Name = "ImageAlignmentTopCenterBarItem1";
			this.ImageAlignmentTopCenterBarItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
			//
			//ImageAlignmentCenterCenterBarItem1
			//
			this.ImageAlignmentCenterCenterBarItem1.Id = 97;
			this.ImageAlignmentCenterCenterBarItem1.Name = "ImageAlignmentCenterCenterBarItem1";
			this.ImageAlignmentCenterCenterBarItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
			//
			//ImageAlignmentBottomCenterBarItem1
			//
			this.ImageAlignmentBottomCenterBarItem1.Id = 98;
			this.ImageAlignmentBottomCenterBarItem1.Name = "ImageAlignmentBottomCenterBarItem1";
			this.ImageAlignmentBottomCenterBarItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
			//
			//ImageAlignmentTopRightBarItem1
			//
			this.ImageAlignmentTopRightBarItem1.Id = 99;
			this.ImageAlignmentTopRightBarItem1.Name = "ImageAlignmentTopRightBarItem1";
			this.ImageAlignmentTopRightBarItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
			//
			//ImageAlignmentCenterRightBarItem1
			//
			this.ImageAlignmentCenterRightBarItem1.Id = 100;
			this.ImageAlignmentCenterRightBarItem1.Name = "ImageAlignmentCenterRightBarItem1";
			this.ImageAlignmentCenterRightBarItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
			//
			//ImageAlignmentBottomRightBarItem1
			//
			this.ImageAlignmentBottomRightBarItem1.Id = 101;
			this.ImageAlignmentBottomRightBarItem1.Name = "ImageAlignmentBottomRightBarItem1";
			this.ImageAlignmentBottomRightBarItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
			//
			//TextBoxEditTextBarItem1
			//
			this.TextBoxEditTextBarItem1.Id = 102;
			this.TextBoxEditTextBarItem1.Name = "TextBoxEditTextBarItem1";
			//
			//RangeFilterLineSeriesTypeBarItem1
			//
			this.RangeFilterLineSeriesTypeBarItem1.Id = 103;
			this.RangeFilterLineSeriesTypeBarItem1.Name = "RangeFilterLineSeriesTypeBarItem1";
			//
			//RangeFilterStackedLineSeriesTypeBarItem1
			//
			this.RangeFilterStackedLineSeriesTypeBarItem1.Id = 104;
			this.RangeFilterStackedLineSeriesTypeBarItem1.Name = "RangeFilterStackedLineSeriesTypeBarItem1";
			//
			//RangeFilterFullStackedLineSeriesTypeBarItem1
			//
			this.RangeFilterFullStackedLineSeriesTypeBarItem1.Id = 105;
			this.RangeFilterFullStackedLineSeriesTypeBarItem1.Name = "RangeFilterFullStackedLineSeriesTypeBarItem1";
			//
			//RangeFilterAreaSeriesTypeBarItem1
			//
			this.RangeFilterAreaSeriesTypeBarItem1.Id = 106;
			this.RangeFilterAreaSeriesTypeBarItem1.Name = "RangeFilterAreaSeriesTypeBarItem1";
			//
			//RangeFilterStackedAreaSeriesTypeBarItem1
			//
			this.RangeFilterStackedAreaSeriesTypeBarItem1.Id = 107;
			this.RangeFilterStackedAreaSeriesTypeBarItem1.Name = "RangeFilterStackedAreaSeriesTypeBarItem1";
			//
			//RangeFilterFullStackedAreaSeriesTypeBarItem1
			//
			this.RangeFilterFullStackedAreaSeriesTypeBarItem1.Id = 108;
			this.RangeFilterFullStackedAreaSeriesTypeBarItem1.Name = "RangeFilterFullStackedAreaSeriesTypeBarItem1";
			//
			//PivotInitialStateBarItem1
			//
			this.PivotInitialStateBarItem1.Id = 109;
			this.PivotInitialStateBarItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {new DevExpress.XtraBars.LinkPersistInfo(this.PivotAutoExpandColumnBarItem1), new DevExpress.XtraBars.LinkPersistInfo(this.PivotAutoExpandRowBarItem1)});
			this.PivotInitialStateBarItem1.Name = "PivotInitialStateBarItem1";
			this.PivotInitialStateBarItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
			//
			//PivotAutoExpandColumnBarItem1
			//
			this.PivotAutoExpandColumnBarItem1.Id = 110;
			this.PivotAutoExpandColumnBarItem1.Name = "PivotAutoExpandColumnBarItem1";
			//
			//PivotAutoExpandRowBarItem1
			//
			this.PivotAutoExpandRowBarItem1.Id = 111;
			this.PivotAutoExpandRowBarItem1.Name = "PivotAutoExpandRowBarItem1";
			//
			//MapShowLegendBarItem1
			//
			this.MapShowLegendBarItem1.Id = 112;
			this.MapShowLegendBarItem1.Name = "MapShowLegendBarItem1";
			//
			//GalleryMapLegendPositionItem1
			//
			//
			//
			//
			this.GalleryMapLegendPositionItem1.Gallery.ColumnCount = 3;
			GalleryItemGroup15.Caption = "Vertical";
			GalleryItemGroup16.Caption = "Horizontal";
			this.GalleryMapLegendPositionItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {GalleryItemGroup15, GalleryItemGroup16});
			this.GalleryMapLegendPositionItem1.Gallery.ImageSize = new System.Drawing.Size(32, 32);
			this.GalleryMapLegendPositionItem1.Gallery.RowCount = 4;
			this.GalleryMapLegendPositionItem1.Id = 113;
			this.GalleryMapLegendPositionItem1.Name = "GalleryMapLegendPositionItem1";
			//
			//MapLoadBarItem1
			//
			this.MapLoadBarItem1.Id = 114;
			this.MapLoadBarItem1.Name = "MapLoadBarItem1";
			//
			//MapImportBarItem1
			//
			this.MapImportBarItem1.Id = 115;
			this.MapImportBarItem1.Name = "MapImportBarItem1";
			//
			//MapDefaultShapefileBarItem1
			//
			this.MapDefaultShapefileBarItem1.Id = 116;
			this.MapDefaultShapefileBarItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {new DevExpress.XtraBars.LinkPersistInfo(this.MapWorldCountriesBarItem1), new DevExpress.XtraBars.LinkPersistInfo(this.MapEuropeBarItem1), new DevExpress.XtraBars.LinkPersistInfo(this.MapAsiaBarItem1), new DevExpress.XtraBars.LinkPersistInfo(this.MapNorthAmericaBarItem1), new DevExpress.XtraBars.LinkPersistInfo(this.MapSouthAmericaBarItem1), new DevExpress.XtraBars.LinkPersistInfo(this.MapAfricaBarItem1), new DevExpress.XtraBars.LinkPersistInfo(this.MapUSABarItem1), new DevExpress.XtraBars.LinkPersistInfo(this.MapCanadaBarItem1)});
			this.MapDefaultShapefileBarItem1.Name = "MapDefaultShapefileBarItem1";
			this.MapDefaultShapefileBarItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
			//
			//MapWorldCountriesBarItem1
			//
			this.MapWorldCountriesBarItem1.Id = 117;
			this.MapWorldCountriesBarItem1.Name = "MapWorldCountriesBarItem1";
			//
			//MapEuropeBarItem1
			//
			this.MapEuropeBarItem1.Id = 118;
			this.MapEuropeBarItem1.Name = "MapEuropeBarItem1";
			//
			//MapAsiaBarItem1
			//
			this.MapAsiaBarItem1.Id = 119;
			this.MapAsiaBarItem1.Name = "MapAsiaBarItem1";
			//
			//MapNorthAmericaBarItem1
			//
			this.MapNorthAmericaBarItem1.Id = 120;
			this.MapNorthAmericaBarItem1.Name = "MapNorthAmericaBarItem1";
			//
			//MapSouthAmericaBarItem1
			//
			this.MapSouthAmericaBarItem1.Id = 121;
			this.MapSouthAmericaBarItem1.Name = "MapSouthAmericaBarItem1";
			//
			//MapAfricaBarItem1
			//
			this.MapAfricaBarItem1.Id = 122;
			this.MapAfricaBarItem1.Name = "MapAfricaBarItem1";
			//
			//MapUSABarItem1
			//
			this.MapUSABarItem1.Id = 123;
			this.MapUSABarItem1.Name = "MapUSABarItem1";
			//
			//MapCanadaBarItem1
			//
			this.MapCanadaBarItem1.Id = 124;
			this.MapCanadaBarItem1.Name = "MapCanadaBarItem1";
			//
			//QuickAccessUndoBarItem1
			//
			this.QuickAccessUndoBarItem1.Id = 125;
			this.QuickAccessUndoBarItem1.Name = "QuickAccessUndoBarItem1";
			//
			//QuickAccessRedoBarItem1
			//
			this.QuickAccessRedoBarItem1.Id = 126;
			this.QuickAccessRedoBarItem1.Name = "QuickAccessRedoBarItem1";
			//
			//PivotToolsRibbonPageCategory1
			//
			this.PivotToolsRibbonPageCategory1.Control = this.DashboardDesigner1;
			this.PivotToolsRibbonPageCategory1.Name = "PivotToolsRibbonPageCategory1";
			this.PivotToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {this.DataRibbonPage1, this.DashboardItemDesignRibbonPage9});
			this.PivotToolsRibbonPageCategory1.Visible = false;
			//
			//DataRibbonPage1
			//
			this.DataRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.FilteringRibbonPageGroup1, this.InteractivitySettingsRibbonPageGroup1, this.PivotLayoutRibbonPageGroup1});
			this.DataRibbonPage1.Name = "DataRibbonPage1";
			this.DataRibbonPage1.Visible = false;
			//
			//FilteringRibbonPageGroup1
			//
			this.FilteringRibbonPageGroup1.ItemLinks.Add(this.EditFilterBarItem1);
			this.FilteringRibbonPageGroup1.ItemLinks.Add(this.ClearFilterBarItem1);
			this.FilteringRibbonPageGroup1.Name = "FilteringRibbonPageGroup1";
			//
			//InteractivitySettingsRibbonPageGroup1
			//
			this.InteractivitySettingsRibbonPageGroup1.ItemLinks.Add(this.IgnoreMasterFiltersBarItem1);
			this.InteractivitySettingsRibbonPageGroup1.Name = "InteractivitySettingsRibbonPageGroup1";
			//
			//PivotLayoutRibbonPageGroup1
			//
			this.PivotLayoutRibbonPageGroup1.ItemLinks.Add(this.PivotInitialStateBarItem1);
			this.PivotLayoutRibbonPageGroup1.Name = "PivotLayoutRibbonPageGroup1";
			//
			//DashboardItemDesignRibbonPage9
			//
			this.DashboardItemDesignRibbonPage9.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.CommonItemDesignRibbonPageGroup9});
			this.DashboardItemDesignRibbonPage9.Name = "DashboardItemDesignRibbonPage9";
			this.DashboardItemDesignRibbonPage9.Visible = false;
			//
			//CommonItemDesignRibbonPageGroup9
			//
			this.CommonItemDesignRibbonPageGroup9.ItemLinks.Add(this.ShowItemCaptionBarItem1);
			this.CommonItemDesignRibbonPageGroup9.ItemLinks.Add(this.EditItemNamesBarItem1);
			this.CommonItemDesignRibbonPageGroup9.Name = "CommonItemDesignRibbonPageGroup9";
			//
			//GridToolsRibbonPageCategory1
			//
			this.GridToolsRibbonPageCategory1.Control = this.DashboardDesigner1;
			this.GridToolsRibbonPageCategory1.Name = "GridToolsRibbonPageCategory1";
			this.GridToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {this.DataRibbonPage2, this.DashboardItemDesignRibbonPage1});
			this.GridToolsRibbonPageCategory1.Visible = false;
			//
			//DataRibbonPage2
			//
			this.DataRibbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.FilteringRibbonPageGroup2, this.MasterFilterRibbonPageGroup1, this.InteractivitySettingsRibbonPageGroup2});
			this.DataRibbonPage2.Name = "DataRibbonPage2";
			this.DataRibbonPage2.Visible = false;
			//
			//FilteringRibbonPageGroup2
			//
			this.FilteringRibbonPageGroup2.ItemLinks.Add(this.EditFilterBarItem1);
			this.FilteringRibbonPageGroup2.ItemLinks.Add(this.ClearFilterBarItem1);
			this.FilteringRibbonPageGroup2.Name = "FilteringRibbonPageGroup2";
			//
			//MasterFilterRibbonPageGroup1
			//
			this.MasterFilterRibbonPageGroup1.ItemLinks.Add(this.MasterFilterBarItem1);
			this.MasterFilterRibbonPageGroup1.ItemLinks.Add(this.MultipleValuesMasterFilterBarItem1);
			this.MasterFilterRibbonPageGroup1.ItemLinks.Add(this.DrillDownBarItem1);
			this.MasterFilterRibbonPageGroup1.Name = "MasterFilterRibbonPageGroup1";
			//
			//InteractivitySettingsRibbonPageGroup2
			//
			this.InteractivitySettingsRibbonPageGroup2.ItemLinks.Add(this.CrossDataSourceFilteringBarItem1);
			this.InteractivitySettingsRibbonPageGroup2.ItemLinks.Add(this.IgnoreMasterFiltersBarItem1);
			this.InteractivitySettingsRibbonPageGroup2.Name = "InteractivitySettingsRibbonPageGroup2";
			//
			//DashboardItemDesignRibbonPage1
			//
			this.DashboardItemDesignRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.CommonItemDesignRibbonPageGroup1, this.GridCellsRibbonPageGroup1});
			this.DashboardItemDesignRibbonPage1.Name = "DashboardItemDesignRibbonPage1";
			this.DashboardItemDesignRibbonPage1.Visible = false;
			//
			//CommonItemDesignRibbonPageGroup1
			//
			this.CommonItemDesignRibbonPageGroup1.ItemLinks.Add(this.ShowItemCaptionBarItem1);
			this.CommonItemDesignRibbonPageGroup1.ItemLinks.Add(this.EditItemNamesBarItem1);
			this.CommonItemDesignRibbonPageGroup1.Name = "CommonItemDesignRibbonPageGroup1";
			//
			//GridCellsRibbonPageGroup1
			//
			this.GridCellsRibbonPageGroup1.ItemLinks.Add(this.GridHorizontalLinesBarItem1);
			this.GridCellsRibbonPageGroup1.ItemLinks.Add(this.GridVerticalLinesBarItem1);
			this.GridCellsRibbonPageGroup1.ItemLinks.Add(this.GridMergeCellsBarItem1);
			this.GridCellsRibbonPageGroup1.ItemLinks.Add(this.GridBandedRowsBarItem1);
			this.GridCellsRibbonPageGroup1.ItemLinks.Add(this.GridColumnHeadersBarItem1);
			this.GridCellsRibbonPageGroup1.Name = "GridCellsRibbonPageGroup1";
			//
			//ChartToolsRibbonPageCategory1
			//
			this.ChartToolsRibbonPageCategory1.Control = this.DashboardDesigner1;
			this.ChartToolsRibbonPageCategory1.Name = "ChartToolsRibbonPageCategory1";
			this.ChartToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {this.DataRibbonPage3, this.DashboardItemDesignRibbonPage2});
			this.ChartToolsRibbonPageCategory1.Visible = false;
			//
			//DataRibbonPage3
			//
			this.DataRibbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.FilteringRibbonPageGroup3, this.MasterFilterRibbonPageGroup2, this.InteractivitySettingsRibbonPageGroup3, this.TargetDimensionsRibbonPageGroup1});
			this.DataRibbonPage3.Name = "DataRibbonPage3";
			this.DataRibbonPage3.Visible = false;
			//
			//FilteringRibbonPageGroup3
			//
			this.FilteringRibbonPageGroup3.ItemLinks.Add(this.EditFilterBarItem1);
			this.FilteringRibbonPageGroup3.ItemLinks.Add(this.ClearFilterBarItem1);
			this.FilteringRibbonPageGroup3.Name = "FilteringRibbonPageGroup3";
			//
			//MasterFilterRibbonPageGroup2
			//
			this.MasterFilterRibbonPageGroup2.ItemLinks.Add(this.MasterFilterBarItem1);
			this.MasterFilterRibbonPageGroup2.ItemLinks.Add(this.MultipleValuesMasterFilterBarItem1);
			this.MasterFilterRibbonPageGroup2.ItemLinks.Add(this.DrillDownBarItem1);
			this.MasterFilterRibbonPageGroup2.Name = "MasterFilterRibbonPageGroup2";
			//
			//InteractivitySettingsRibbonPageGroup3
			//
			this.InteractivitySettingsRibbonPageGroup3.ItemLinks.Add(this.CrossDataSourceFilteringBarItem1);
			this.InteractivitySettingsRibbonPageGroup3.ItemLinks.Add(this.IgnoreMasterFiltersBarItem1);
			this.InteractivitySettingsRibbonPageGroup3.Name = "InteractivitySettingsRibbonPageGroup3";
			//
			//TargetDimensionsRibbonPageGroup1
			//
			this.TargetDimensionsRibbonPageGroup1.ItemLinks.Add(this.ChartTargetDimensionsArgumentsBarItem1);
			this.TargetDimensionsRibbonPageGroup1.ItemLinks.Add(this.ChartTargetDimensionsSeriesBarItem1);
			this.TargetDimensionsRibbonPageGroup1.Name = "TargetDimensionsRibbonPageGroup1";
			//
			//DashboardItemDesignRibbonPage2
			//
			this.DashboardItemDesignRibbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.CommonItemDesignRibbonPageGroup2, this.ChartLayoutPageGroup1, this.ChartLegendPositionPageGroup1, this.ChartStylePageGroup1});
			this.DashboardItemDesignRibbonPage2.Name = "DashboardItemDesignRibbonPage2";
			this.DashboardItemDesignRibbonPage2.Visible = false;
			//
			//CommonItemDesignRibbonPageGroup2
			//
			this.CommonItemDesignRibbonPageGroup2.ItemLinks.Add(this.ShowItemCaptionBarItem1);
			this.CommonItemDesignRibbonPageGroup2.ItemLinks.Add(this.EditItemNamesBarItem1);
			this.CommonItemDesignRibbonPageGroup2.Name = "CommonItemDesignRibbonPageGroup2";
			//
			//ChartLayoutPageGroup1
			//
			this.ChartLayoutPageGroup1.ItemLinks.Add(this.ChartRotateBarItem1);
			this.ChartLayoutPageGroup1.ItemLinks.Add(this.ChartXAxisSettingsBarItem1);
			this.ChartLayoutPageGroup1.ItemLinks.Add(this.ChartYAxisSettingsBarItem1);
			this.ChartLayoutPageGroup1.Name = "ChartLayoutPageGroup1";
			//
			//ChartLegendPositionPageGroup1
			//
			this.ChartLegendPositionPageGroup1.ItemLinks.Add(this.ChartShowLegendBarItem1);
			this.ChartLegendPositionPageGroup1.ItemLinks.Add(this.GalleryChartLegendPositionItem1);
			this.ChartLegendPositionPageGroup1.Name = "ChartLegendPositionPageGroup1";
			//
			//ChartStylePageGroup1
			//
			this.ChartStylePageGroup1.ItemLinks.Add(this.GalleryChartSeriesTypeItem1);
			this.ChartStylePageGroup1.Name = "ChartStylePageGroup1";
			//
			//PiesToolsRibbonPageCategory1
			//
			this.PiesToolsRibbonPageCategory1.Control = this.DashboardDesigner1;
			this.PiesToolsRibbonPageCategory1.Name = "PiesToolsRibbonPageCategory1";
			this.PiesToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {this.DataRibbonPage4, this.DashboardItemDesignRibbonPage3});
			this.PiesToolsRibbonPageCategory1.Visible = false;
			//
			//DataRibbonPage4
			//
			this.DataRibbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.FilteringRibbonPageGroup4, this.MasterFilterRibbonPageGroup3, this.InteractivitySettingsRibbonPageGroup4, this.TargetDimensionsRibbonPageGroup2});
			this.DataRibbonPage4.Name = "DataRibbonPage4";
			this.DataRibbonPage4.Visible = false;
			//
			//FilteringRibbonPageGroup4
			//
			this.FilteringRibbonPageGroup4.ItemLinks.Add(this.EditFilterBarItem1);
			this.FilteringRibbonPageGroup4.ItemLinks.Add(this.ClearFilterBarItem1);
			this.FilteringRibbonPageGroup4.Name = "FilteringRibbonPageGroup4";
			//
			//MasterFilterRibbonPageGroup3
			//
			this.MasterFilterRibbonPageGroup3.ItemLinks.Add(this.MasterFilterBarItem1);
			this.MasterFilterRibbonPageGroup3.ItemLinks.Add(this.MultipleValuesMasterFilterBarItem1);
			this.MasterFilterRibbonPageGroup3.ItemLinks.Add(this.DrillDownBarItem1);
			this.MasterFilterRibbonPageGroup3.Name = "MasterFilterRibbonPageGroup3";
			//
			//InteractivitySettingsRibbonPageGroup4
			//
			this.InteractivitySettingsRibbonPageGroup4.ItemLinks.Add(this.CrossDataSourceFilteringBarItem1);
			this.InteractivitySettingsRibbonPageGroup4.ItemLinks.Add(this.IgnoreMasterFiltersBarItem1);
			this.InteractivitySettingsRibbonPageGroup4.Name = "InteractivitySettingsRibbonPageGroup4";
			//
			//TargetDimensionsRibbonPageGroup2
			//
			this.TargetDimensionsRibbonPageGroup2.ItemLinks.Add(this.PieTargetDimensionsArgumentsBarItem1);
			this.TargetDimensionsRibbonPageGroup2.ItemLinks.Add(this.PieTargetDimensionsSeriesBarItem1);
			this.TargetDimensionsRibbonPageGroup2.Name = "TargetDimensionsRibbonPageGroup2";
			//
			//DashboardItemDesignRibbonPage3
			//
			this.DashboardItemDesignRibbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.CommonItemDesignRibbonPageGroup3, this.ContentArrangementRibbonPageGroup1, this.PieLabelsRibbonPageGroup1, this.PieStyleRibbonPageGroup1});
			this.DashboardItemDesignRibbonPage3.Name = "DashboardItemDesignRibbonPage3";
			this.DashboardItemDesignRibbonPage3.Visible = false;
			//
			//CommonItemDesignRibbonPageGroup3
			//
			this.CommonItemDesignRibbonPageGroup3.ItemLinks.Add(this.ShowItemCaptionBarItem1);
			this.CommonItemDesignRibbonPageGroup3.ItemLinks.Add(this.EditItemNamesBarItem1);
			this.CommonItemDesignRibbonPageGroup3.Name = "CommonItemDesignRibbonPageGroup3";
			//
			//ContentArrangementRibbonPageGroup1
			//
			this.ContentArrangementRibbonPageGroup1.ItemLinks.Add(this.ContentAutoArrangeBarItem1);
			this.ContentArrangementRibbonPageGroup1.ItemLinks.Add(this.ContentArrangeInColumnsBarItem1);
			this.ContentArrangementRibbonPageGroup1.ItemLinks.Add(this.ContentArrangeInRowsBarItem1);
			this.ContentArrangementRibbonPageGroup1.ItemLinks.Add(this.ContentArrangementCountBarItem1);
			this.ContentArrangementRibbonPageGroup1.Name = "ContentArrangementRibbonPageGroup1";
			//
			//PieLabelsRibbonPageGroup1
			//
			this.PieLabelsRibbonPageGroup1.ItemLinks.Add(this.PieLabelsDataLabelsBarItem1);
			this.PieLabelsRibbonPageGroup1.ItemLinks.Add(this.PieTooltipsBarItem1);
			this.PieLabelsRibbonPageGroup1.ItemLinks.Add(this.PieShowCaptionsBarItem1);
			this.PieLabelsRibbonPageGroup1.Name = "PieLabelsRibbonPageGroup1";
			//
			//PieStyleRibbonPageGroup1
			//
			this.PieStyleRibbonPageGroup1.ItemLinks.Add(this.PieStylePieBarItem1);
			this.PieStyleRibbonPageGroup1.ItemLinks.Add(this.PieStyleDonutBarItem1);
			this.PieStyleRibbonPageGroup1.Name = "PieStyleRibbonPageGroup1";
			//
			//GaugesToolsRibbonPageCategory1
			//
			this.GaugesToolsRibbonPageCategory1.Control = this.DashboardDesigner1;
			this.GaugesToolsRibbonPageCategory1.Name = "GaugesToolsRibbonPageCategory1";
			this.GaugesToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {this.DataRibbonPage5, this.DashboardItemDesignRibbonPage4});
			this.GaugesToolsRibbonPageCategory1.Visible = false;
			//
			//DataRibbonPage5
			//
			this.DataRibbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.FilteringRibbonPageGroup5, this.MasterFilterRibbonPageGroup4, this.InteractivitySettingsRibbonPageGroup5});
			this.DataRibbonPage5.Name = "DataRibbonPage5";
			this.DataRibbonPage5.Visible = false;
			//
			//FilteringRibbonPageGroup5
			//
			this.FilteringRibbonPageGroup5.ItemLinks.Add(this.EditFilterBarItem1);
			this.FilteringRibbonPageGroup5.ItemLinks.Add(this.ClearFilterBarItem1);
			this.FilteringRibbonPageGroup5.Name = "FilteringRibbonPageGroup5";
			//
			//MasterFilterRibbonPageGroup4
			//
			this.MasterFilterRibbonPageGroup4.ItemLinks.Add(this.MasterFilterBarItem1);
			this.MasterFilterRibbonPageGroup4.ItemLinks.Add(this.MultipleValuesMasterFilterBarItem1);
			this.MasterFilterRibbonPageGroup4.ItemLinks.Add(this.DrillDownBarItem1);
			this.MasterFilterRibbonPageGroup4.Name = "MasterFilterRibbonPageGroup4";
			//
			//InteractivitySettingsRibbonPageGroup5
			//
			this.InteractivitySettingsRibbonPageGroup5.ItemLinks.Add(this.CrossDataSourceFilteringBarItem1);
			this.InteractivitySettingsRibbonPageGroup5.ItemLinks.Add(this.IgnoreMasterFiltersBarItem1);
			this.InteractivitySettingsRibbonPageGroup5.Name = "InteractivitySettingsRibbonPageGroup5";
			//
			//DashboardItemDesignRibbonPage4
			//
			this.DashboardItemDesignRibbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.CommonItemDesignRibbonPageGroup4, this.ContentArrangementRibbonPageGroup2, this.GaugeStyleRibbonPageGroup1, this.GaugesLabelsRibbonPageGroup1});
			this.DashboardItemDesignRibbonPage4.Name = "DashboardItemDesignRibbonPage4";
			this.DashboardItemDesignRibbonPage4.Visible = false;
			//
			//CommonItemDesignRibbonPageGroup4
			//
			this.CommonItemDesignRibbonPageGroup4.ItemLinks.Add(this.ShowItemCaptionBarItem1);
			this.CommonItemDesignRibbonPageGroup4.ItemLinks.Add(this.EditItemNamesBarItem1);
			this.CommonItemDesignRibbonPageGroup4.Name = "CommonItemDesignRibbonPageGroup4";
			//
			//ContentArrangementRibbonPageGroup2
			//
			this.ContentArrangementRibbonPageGroup2.ItemLinks.Add(this.ContentAutoArrangeBarItem1);
			this.ContentArrangementRibbonPageGroup2.ItemLinks.Add(this.ContentArrangeInColumnsBarItem1);
			this.ContentArrangementRibbonPageGroup2.ItemLinks.Add(this.ContentArrangeInRowsBarItem1);
			this.ContentArrangementRibbonPageGroup2.ItemLinks.Add(this.ContentArrangementCountBarItem1);
			this.ContentArrangementRibbonPageGroup2.Name = "ContentArrangementRibbonPageGroup2";
			//
			//GaugeStyleRibbonPageGroup1
			//
			this.GaugeStyleRibbonPageGroup1.ItemLinks.Add(this.GaugeStyleFullCircularBarItem1);
			this.GaugeStyleRibbonPageGroup1.ItemLinks.Add(this.GaugeStyleHalfCircularBarItem1);
			this.GaugeStyleRibbonPageGroup1.ItemLinks.Add(this.GaugeStyleLeftQuarterCircularBarItem1);
			this.GaugeStyleRibbonPageGroup1.ItemLinks.Add(this.GaugeStyleRightQuarterCircularBarItem1);
			this.GaugeStyleRibbonPageGroup1.ItemLinks.Add(this.GaugeStyleThreeForthCircularBarItem1);
			this.GaugeStyleRibbonPageGroup1.ItemLinks.Add(this.GaugeStyleLinearHorizontalBarItem1);
			this.GaugeStyleRibbonPageGroup1.ItemLinks.Add(this.GaugeStyleLinearVerticalBarItem1);
			this.GaugeStyleRibbonPageGroup1.Name = "GaugeStyleRibbonPageGroup1";
			//
			//GaugesLabelsRibbonPageGroup1
			//
			this.GaugesLabelsRibbonPageGroup1.ItemLinks.Add(this.GaugeShowCaptionsBarItem1);
			this.GaugesLabelsRibbonPageGroup1.Name = "GaugesLabelsRibbonPageGroup1";
			//
			//CardsToolsRibbonPageCategory1
			//
			this.CardsToolsRibbonPageCategory1.Control = this.DashboardDesigner1;
			this.CardsToolsRibbonPageCategory1.Name = "CardsToolsRibbonPageCategory1";
			this.CardsToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {this.DataRibbonPage6, this.DashboardItemDesignRibbonPage5});
			this.CardsToolsRibbonPageCategory1.Visible = false;
			//
			//DataRibbonPage6
			//
			this.DataRibbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.FilteringRibbonPageGroup6, this.MasterFilterRibbonPageGroup5, this.InteractivitySettingsRibbonPageGroup6});
			this.DataRibbonPage6.Name = "DataRibbonPage6";
			this.DataRibbonPage6.Visible = false;
			//
			//FilteringRibbonPageGroup6
			//
			this.FilteringRibbonPageGroup6.ItemLinks.Add(this.EditFilterBarItem1);
			this.FilteringRibbonPageGroup6.ItemLinks.Add(this.ClearFilterBarItem1);
			this.FilteringRibbonPageGroup6.Name = "FilteringRibbonPageGroup6";
			//
			//MasterFilterRibbonPageGroup5
			//
			this.MasterFilterRibbonPageGroup5.ItemLinks.Add(this.MasterFilterBarItem1);
			this.MasterFilterRibbonPageGroup5.ItemLinks.Add(this.MultipleValuesMasterFilterBarItem1);
			this.MasterFilterRibbonPageGroup5.ItemLinks.Add(this.DrillDownBarItem1);
			this.MasterFilterRibbonPageGroup5.Name = "MasterFilterRibbonPageGroup5";
			//
			//InteractivitySettingsRibbonPageGroup6
			//
			this.InteractivitySettingsRibbonPageGroup6.ItemLinks.Add(this.CrossDataSourceFilteringBarItem1);
			this.InteractivitySettingsRibbonPageGroup6.ItemLinks.Add(this.IgnoreMasterFiltersBarItem1);
			this.InteractivitySettingsRibbonPageGroup6.Name = "InteractivitySettingsRibbonPageGroup6";
			//
			//DashboardItemDesignRibbonPage5
			//
			this.DashboardItemDesignRibbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.CommonItemDesignRibbonPageGroup5, this.ContentArrangementRibbonPageGroup3});
			this.DashboardItemDesignRibbonPage5.Name = "DashboardItemDesignRibbonPage5";
			this.DashboardItemDesignRibbonPage5.Visible = false;
			//
			//CommonItemDesignRibbonPageGroup5
			//
			this.CommonItemDesignRibbonPageGroup5.ItemLinks.Add(this.ShowItemCaptionBarItem1);
			this.CommonItemDesignRibbonPageGroup5.ItemLinks.Add(this.EditItemNamesBarItem1);
			this.CommonItemDesignRibbonPageGroup5.Name = "CommonItemDesignRibbonPageGroup5";
			//
			//ContentArrangementRibbonPageGroup3
			//
			this.ContentArrangementRibbonPageGroup3.ItemLinks.Add(this.ContentAutoArrangeBarItem1);
			this.ContentArrangementRibbonPageGroup3.ItemLinks.Add(this.ContentArrangeInColumnsBarItem1);
			this.ContentArrangementRibbonPageGroup3.ItemLinks.Add(this.ContentArrangeInRowsBarItem1);
			this.ContentArrangementRibbonPageGroup3.ItemLinks.Add(this.ContentArrangementCountBarItem1);
			this.ContentArrangementRibbonPageGroup3.Name = "ContentArrangementRibbonPageGroup3";
			//
			//RangeFilterToolsRibbonPageCategory1
			//
			this.RangeFilterToolsRibbonPageCategory1.Control = this.DashboardDesigner1;
			this.RangeFilterToolsRibbonPageCategory1.Name = "RangeFilterToolsRibbonPageCategory1";
			this.RangeFilterToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {this.DataRibbonPage7, this.DashboardItemDesignRibbonPage8});
			this.RangeFilterToolsRibbonPageCategory1.Visible = false;
			//
			//DataRibbonPage7
			//
			this.DataRibbonPage7.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.FilteringRibbonPageGroup7, this.InteractivitySettingsRibbonPageGroup7});
			this.DataRibbonPage7.Name = "DataRibbonPage7";
			this.DataRibbonPage7.Visible = false;
			//
			//FilteringRibbonPageGroup7
			//
			this.FilteringRibbonPageGroup7.ItemLinks.Add(this.EditFilterBarItem1);
			this.FilteringRibbonPageGroup7.ItemLinks.Add(this.ClearFilterBarItem1);
			this.FilteringRibbonPageGroup7.Name = "FilteringRibbonPageGroup7";
			//
			//InteractivitySettingsRibbonPageGroup7
			//
			this.InteractivitySettingsRibbonPageGroup7.ItemLinks.Add(this.CrossDataSourceFilteringBarItem1);
			this.InteractivitySettingsRibbonPageGroup7.Name = "InteractivitySettingsRibbonPageGroup7";
			//
			//DashboardItemDesignRibbonPage8
			//
			this.DashboardItemDesignRibbonPage8.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.CommonItemDesignRibbonPageGroup8, this.RangeFilterSeriesTypeRibbonPageGroup1});
			this.DashboardItemDesignRibbonPage8.Name = "DashboardItemDesignRibbonPage8";
			this.DashboardItemDesignRibbonPage8.Visible = false;
			//
			//CommonItemDesignRibbonPageGroup8
			//
			this.CommonItemDesignRibbonPageGroup8.ItemLinks.Add(this.ShowItemCaptionBarItem1);
			this.CommonItemDesignRibbonPageGroup8.ItemLinks.Add(this.EditItemNamesBarItem1);
			this.CommonItemDesignRibbonPageGroup8.Name = "CommonItemDesignRibbonPageGroup8";
			//
			//RangeFilterSeriesTypeRibbonPageGroup1
			//
			this.RangeFilterSeriesTypeRibbonPageGroup1.ItemLinks.Add(this.RangeFilterLineSeriesTypeBarItem1);
			this.RangeFilterSeriesTypeRibbonPageGroup1.ItemLinks.Add(this.RangeFilterStackedLineSeriesTypeBarItem1);
			this.RangeFilterSeriesTypeRibbonPageGroup1.ItemLinks.Add(this.RangeFilterFullStackedLineSeriesTypeBarItem1);
			this.RangeFilterSeriesTypeRibbonPageGroup1.ItemLinks.Add(this.RangeFilterAreaSeriesTypeBarItem1);
			this.RangeFilterSeriesTypeRibbonPageGroup1.ItemLinks.Add(this.RangeFilterStackedAreaSeriesTypeBarItem1);
			this.RangeFilterSeriesTypeRibbonPageGroup1.ItemLinks.Add(this.RangeFilterFullStackedAreaSeriesTypeBarItem1);
			this.RangeFilterSeriesTypeRibbonPageGroup1.Name = "RangeFilterSeriesTypeRibbonPageGroup1";
			//
			//ChoroplethMapToolsRibbonPageCategory1
			//
			this.ChoroplethMapToolsRibbonPageCategory1.Control = this.DashboardDesigner1;
			this.ChoroplethMapToolsRibbonPageCategory1.Name = "ChoroplethMapToolsRibbonPageCategory1";
			this.ChoroplethMapToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {this.DataRibbonPage8, this.DashboardItemDesignRibbonPage10});
			this.ChoroplethMapToolsRibbonPageCategory1.Visible = false;
			//
			//DataRibbonPage8
			//
			this.DataRibbonPage8.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.FilteringRibbonPageGroup8, this.MasterFilterRibbonPageGroup6, this.InteractivitySettingsRibbonPageGroup8});
			this.DataRibbonPage8.Name = "DataRibbonPage8";
			this.DataRibbonPage8.Visible = false;
			//
			//FilteringRibbonPageGroup8
			//
			this.FilteringRibbonPageGroup8.ItemLinks.Add(this.EditFilterBarItem1);
			this.FilteringRibbonPageGroup8.ItemLinks.Add(this.ClearFilterBarItem1);
			this.FilteringRibbonPageGroup8.Name = "FilteringRibbonPageGroup8";
			//
			//MasterFilterRibbonPageGroup6
			//
			this.MasterFilterRibbonPageGroup6.ItemLinks.Add(this.MasterFilterBarItem1);
			this.MasterFilterRibbonPageGroup6.ItemLinks.Add(this.MultipleValuesMasterFilterBarItem1);
			this.MasterFilterRibbonPageGroup6.Name = "MasterFilterRibbonPageGroup6";
			//
			//InteractivitySettingsRibbonPageGroup8
			//
			this.InteractivitySettingsRibbonPageGroup8.ItemLinks.Add(this.CrossDataSourceFilteringBarItem1);
			this.InteractivitySettingsRibbonPageGroup8.ItemLinks.Add(this.IgnoreMasterFiltersBarItem1);
			this.InteractivitySettingsRibbonPageGroup8.Name = "InteractivitySettingsRibbonPageGroup8";
			//
			//DashboardItemDesignRibbonPage10
			//
			this.DashboardItemDesignRibbonPage10.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.CommonItemDesignRibbonPageGroup10, this.MapLegendPositionPageGroup1, this.MapShapefileRibbonPageGroup1});
			this.DashboardItemDesignRibbonPage10.Name = "DashboardItemDesignRibbonPage10";
			this.DashboardItemDesignRibbonPage10.Visible = false;
			//
			//CommonItemDesignRibbonPageGroup10
			//
			this.CommonItemDesignRibbonPageGroup10.ItemLinks.Add(this.ShowItemCaptionBarItem1);
			this.CommonItemDesignRibbonPageGroup10.ItemLinks.Add(this.EditItemNamesBarItem1);
			this.CommonItemDesignRibbonPageGroup10.Name = "CommonItemDesignRibbonPageGroup10";
			//
			//MapLegendPositionPageGroup1
			//
			this.MapLegendPositionPageGroup1.ItemLinks.Add(this.MapShowLegendBarItem1);
			this.MapLegendPositionPageGroup1.ItemLinks.Add(this.GalleryMapLegendPositionItem1);
			this.MapLegendPositionPageGroup1.Name = "MapLegendPositionPageGroup1";
			//
			//MapShapefileRibbonPageGroup1
			//
			this.MapShapefileRibbonPageGroup1.ItemLinks.Add(this.MapLoadBarItem1);
			this.MapShapefileRibbonPageGroup1.ItemLinks.Add(this.MapImportBarItem1);
			this.MapShapefileRibbonPageGroup1.ItemLinks.Add(this.MapDefaultShapefileBarItem1);
			this.MapShapefileRibbonPageGroup1.Name = "MapShapefileRibbonPageGroup1";
			//
			//GeoPointMapToolsRibbonPageCategory1
			//
			this.GeoPointMapToolsRibbonPageCategory1.Control = this.DashboardDesigner1;
			this.GeoPointMapToolsRibbonPageCategory1.Name = "GeoPointMapToolsRibbonPageCategory1";
			this.GeoPointMapToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {this.DataRibbonPage9, this.DashboardItemDesignRibbonPage11});
			this.GeoPointMapToolsRibbonPageCategory1.Visible = false;
			//
			//DataRibbonPage9
			//
			this.DataRibbonPage9.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.FilteringRibbonPageGroup9, this.MasterFilterRibbonPageGroup7, this.InteractivitySettingsRibbonPageGroup9});
			this.DataRibbonPage9.Name = "DataRibbonPage9";
			this.DataRibbonPage9.Visible = false;
			//
			//FilteringRibbonPageGroup9
			//
			this.FilteringRibbonPageGroup9.ItemLinks.Add(this.EditFilterBarItem1);
			this.FilteringRibbonPageGroup9.ItemLinks.Add(this.ClearFilterBarItem1);
			this.FilteringRibbonPageGroup9.Name = "FilteringRibbonPageGroup9";
			//
			//MasterFilterRibbonPageGroup7
			//
			this.MasterFilterRibbonPageGroup7.ItemLinks.Add(this.MasterFilterBarItem1);
			this.MasterFilterRibbonPageGroup7.ItemLinks.Add(this.MultipleValuesMasterFilterBarItem1);
			this.MasterFilterRibbonPageGroup7.Name = "MasterFilterRibbonPageGroup7";
			//
			//InteractivitySettingsRibbonPageGroup9
			//
			this.InteractivitySettingsRibbonPageGroup9.ItemLinks.Add(this.CrossDataSourceFilteringBarItem1);
			this.InteractivitySettingsRibbonPageGroup9.ItemLinks.Add(this.IgnoreMasterFiltersBarItem1);
			this.InteractivitySettingsRibbonPageGroup9.Name = "InteractivitySettingsRibbonPageGroup9";
			//
			//DashboardItemDesignRibbonPage11
			//
			this.DashboardItemDesignRibbonPage11.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.CommonItemDesignRibbonPageGroup11, this.MapShapefileRibbonPageGroup2});
			this.DashboardItemDesignRibbonPage11.Name = "DashboardItemDesignRibbonPage11";
			this.DashboardItemDesignRibbonPage11.Visible = false;
			//
			//CommonItemDesignRibbonPageGroup11
			//
			this.CommonItemDesignRibbonPageGroup11.ItemLinks.Add(this.ShowItemCaptionBarItem1);
			this.CommonItemDesignRibbonPageGroup11.ItemLinks.Add(this.EditItemNamesBarItem1);
			this.CommonItemDesignRibbonPageGroup11.Name = "CommonItemDesignRibbonPageGroup11";
			//
			//MapShapefileRibbonPageGroup2
			//
			this.MapShapefileRibbonPageGroup2.ItemLinks.Add(this.MapLoadBarItem1);
			this.MapShapefileRibbonPageGroup2.ItemLinks.Add(this.MapImportBarItem1);
			this.MapShapefileRibbonPageGroup2.ItemLinks.Add(this.MapDefaultShapefileBarItem1);
			this.MapShapefileRibbonPageGroup2.Name = "MapShapefileRibbonPageGroup2";
			//
			//ImageToolsRibbonPageCategory1
			//
			this.ImageToolsRibbonPageCategory1.Control = this.DashboardDesigner1;
			this.ImageToolsRibbonPageCategory1.Name = "ImageToolsRibbonPageCategory1";
			this.ImageToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {this.DashboardItemDesignRibbonPage6});
			this.ImageToolsRibbonPageCategory1.Visible = false;
			//
			//DashboardItemDesignRibbonPage6
			//
			this.DashboardItemDesignRibbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.CommonItemDesignRibbonPageGroup6, this.ImageOpenRibbonPageGroup1, this.ImageSizeModeRibbonPageGroup1, this.ImageAlignmentRibbonPageGroup1});
			this.DashboardItemDesignRibbonPage6.Name = "DashboardItemDesignRibbonPage6";
			this.DashboardItemDesignRibbonPage6.Visible = false;
			//
			//CommonItemDesignRibbonPageGroup6
			//
			this.CommonItemDesignRibbonPageGroup6.ItemLinks.Add(this.ShowItemCaptionBarItem1);
			this.CommonItemDesignRibbonPageGroup6.ItemLinks.Add(this.EditItemNamesBarItem1);
			this.CommonItemDesignRibbonPageGroup6.Name = "CommonItemDesignRibbonPageGroup6";
			//
			//ImageOpenRibbonPageGroup1
			//
			this.ImageOpenRibbonPageGroup1.ItemLinks.Add(this.ImageLoadBarItem1);
			this.ImageOpenRibbonPageGroup1.ItemLinks.Add(this.ImageImportBarItem1);
			this.ImageOpenRibbonPageGroup1.Name = "ImageOpenRibbonPageGroup1";
			//
			//ImageSizeModeRibbonPageGroup1
			//
			this.ImageSizeModeRibbonPageGroup1.ItemLinks.Add(this.ImageSizeModeClipBarItem1);
			this.ImageSizeModeRibbonPageGroup1.ItemLinks.Add(this.ImageSizeModeStretchBarItem1);
			this.ImageSizeModeRibbonPageGroup1.ItemLinks.Add(this.ImageSizeModeSqueezeBarItem1);
			this.ImageSizeModeRibbonPageGroup1.ItemLinks.Add(this.ImageSizeModeZoomBarItem1);
			this.ImageSizeModeRibbonPageGroup1.Name = "ImageSizeModeRibbonPageGroup1";
			//
			//ImageAlignmentRibbonPageGroup1
			//
			this.ImageAlignmentRibbonPageGroup1.ItemLinks.Add(this.ImageAlignmentTopLeftBarItem1);
			this.ImageAlignmentRibbonPageGroup1.ItemLinks.Add(this.ImageAlignmentCenterLeftBarItem1);
			this.ImageAlignmentRibbonPageGroup1.ItemLinks.Add(this.ImageAlignmentBottomLeftBarItem1);
			this.ImageAlignmentRibbonPageGroup1.ItemLinks.Add(this.ImageAlignmentTopCenterBarItem1);
			this.ImageAlignmentRibbonPageGroup1.ItemLinks.Add(this.ImageAlignmentCenterCenterBarItem1);
			this.ImageAlignmentRibbonPageGroup1.ItemLinks.Add(this.ImageAlignmentBottomCenterBarItem1);
			this.ImageAlignmentRibbonPageGroup1.ItemLinks.Add(this.ImageAlignmentTopRightBarItem1);
			this.ImageAlignmentRibbonPageGroup1.ItemLinks.Add(this.ImageAlignmentCenterRightBarItem1);
			this.ImageAlignmentRibbonPageGroup1.ItemLinks.Add(this.ImageAlignmentBottomRightBarItem1);
			this.ImageAlignmentRibbonPageGroup1.Name = "ImageAlignmentRibbonPageGroup1";
			//
			//TextBoxToolsRibbonPageCategory1
			//
			this.TextBoxToolsRibbonPageCategory1.Control = this.DashboardDesigner1;
			this.TextBoxToolsRibbonPageCategory1.Name = "TextBoxToolsRibbonPageCategory1";
			this.TextBoxToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {this.DashboardItemDesignRibbonPage7});
			this.TextBoxToolsRibbonPageCategory1.Visible = false;
			//
			//DashboardItemDesignRibbonPage7
			//
			this.DashboardItemDesignRibbonPage7.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.CommonItemDesignRibbonPageGroup7, this.TextBoxSettingsRibbonPageGroup1});
			this.DashboardItemDesignRibbonPage7.Name = "DashboardItemDesignRibbonPage7";
			this.DashboardItemDesignRibbonPage7.Visible = false;
			//
			//CommonItemDesignRibbonPageGroup7
			//
			this.CommonItemDesignRibbonPageGroup7.ItemLinks.Add(this.ShowItemCaptionBarItem1);
			this.CommonItemDesignRibbonPageGroup7.ItemLinks.Add(this.EditItemNamesBarItem1);
			this.CommonItemDesignRibbonPageGroup7.Name = "CommonItemDesignRibbonPageGroup7";
			//
			//TextBoxSettingsRibbonPageGroup1
			//
			this.TextBoxSettingsRibbonPageGroup1.ItemLinks.Add(this.TextBoxEditTextBarItem1);
			this.TextBoxSettingsRibbonPageGroup1.Name = "TextBoxSettingsRibbonPageGroup1";
			//
			//HomeRibbonPage1
			//
			this.HomeRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.FileRibbonPageGroup1, this.HistoryRibbonPageGroup1, this.InsertRibbonPageGroup1, this.ItemOperationRibbonPageGroup1, this.DashboardDesignRibbonPageGroup1, this.QuickAccessHistoryRibbonPageGroup1});
			this.HomeRibbonPage1.Name = "HomeRibbonPage1";
			//
			//FileRibbonPageGroup1
			//
			this.FileRibbonPageGroup1.ItemLinks.Add(this.FileNewBarItem1);
			this.FileRibbonPageGroup1.ItemLinks.Add(this.FileOpenBarItem1);
			this.FileRibbonPageGroup1.ItemLinks.Add(this.FileSaveBarItem1);
			this.FileRibbonPageGroup1.ItemLinks.Add(this.FileSaveAsBarItem1);
			this.FileRibbonPageGroup1.Name = "FileRibbonPageGroup1";
			//
			//HistoryRibbonPageGroup1
			//
			this.HistoryRibbonPageGroup1.ItemLinks.Add(this.UndoBarItem1);
			this.HistoryRibbonPageGroup1.ItemLinks.Add(this.RedoBarItem1);
			this.HistoryRibbonPageGroup1.Name = "HistoryRibbonPageGroup1";
			//
			//InsertRibbonPageGroup1
			//
			this.InsertRibbonPageGroup1.ItemLinks.Add(this.InsertPivotBarItem1);
			this.InsertRibbonPageGroup1.ItemLinks.Add(this.InsertGridBarItem1);
			this.InsertRibbonPageGroup1.ItemLinks.Add(this.InsertChartBarItem1);
			this.InsertRibbonPageGroup1.ItemLinks.Add(this.InsertPiesBarItem1);
			this.InsertRibbonPageGroup1.ItemLinks.Add(this.InsertGaugesBarItem1);
			this.InsertRibbonPageGroup1.ItemLinks.Add(this.InsertCardsBarItem1);
			this.InsertRibbonPageGroup1.ItemLinks.Add(this.InsertChoroplethMapBarItem1);
			this.InsertRibbonPageGroup1.ItemLinks.Add(this.InsertGeoPointMapBarItem1);
			this.InsertRibbonPageGroup1.ItemLinks.Add(this.InsertRangeFilterBarItem1);
			this.InsertRibbonPageGroup1.ItemLinks.Add(this.InsertImageBarItem1);
			this.InsertRibbonPageGroup1.ItemLinks.Add(this.InsertTextBoxBarItem1);
			this.InsertRibbonPageGroup1.Name = "InsertRibbonPageGroup1";
			//
			//ItemOperationRibbonPageGroup1
			//
			this.ItemOperationRibbonPageGroup1.ItemLinks.Add(this.DuplicateItemBarItem1);
			this.ItemOperationRibbonPageGroup1.ItemLinks.Add(this.DeleteItemBarItem1);
			this.ItemOperationRibbonPageGroup1.Name = "ItemOperationRibbonPageGroup1";
			//
			//DashboardDesignRibbonPageGroup1
			//
			this.DashboardDesignRibbonPageGroup1.ItemLinks.Add(this.DashboardTitleBarItem1);
			this.DashboardDesignRibbonPageGroup1.ItemLinks.Add(this.SetCurrencyCultureBarItem1);
			this.DashboardDesignRibbonPageGroup1.Name = "DashboardDesignRibbonPageGroup1";
			//
			//QuickAccessHistoryRibbonPageGroup1
			//
			this.QuickAccessHistoryRibbonPageGroup1.ItemLinks.Add(this.QuickAccessUndoBarItem1);
			this.QuickAccessHistoryRibbonPageGroup1.ItemLinks.Add(this.QuickAccessRedoBarItem1);
			this.QuickAccessHistoryRibbonPageGroup1.Name = "QuickAccessHistoryRibbonPageGroup1";
			this.QuickAccessHistoryRibbonPageGroup1.Visible = false;
			//
			//DataSourceRibbonPage1
			//
			this.DataSourceRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.DataSourceRibbonPageGroup1, this.DataSourceElementsRibbonPageGroup1, this.DataSourceFilteringRibbonPageGroup1});
			this.DataSourceRibbonPage1.Name = "DataSourceRibbonPage1";
			//
			//DataSourceRibbonPageGroup1
			//
			this.DataSourceRibbonPageGroup1.ItemLinks.Add(this.NewDataSourceBarItem1);
			this.DataSourceRibbonPageGroup1.ItemLinks.Add(this.EditDataSourceBarItem1);
			this.DataSourceRibbonPageGroup1.ItemLinks.Add(this.DeleteDataSourceBarItem1);
			this.DataSourceRibbonPageGroup1.Name = "DataSourceRibbonPageGroup1";
			//
			//DataSourceElementsRibbonPageGroup1
			//
			this.DataSourceElementsRibbonPageGroup1.ItemLinks.Add(this.AddCalculatedFieldBarItem1);
			this.DataSourceElementsRibbonPageGroup1.ItemLinks.Add(this.DashboardParametersBarItem1);
			this.DataSourceElementsRibbonPageGroup1.Name = "DataSourceElementsRibbonPageGroup1";
			//
			//DataSourceFilteringRibbonPageGroup1
			//
			this.DataSourceFilteringRibbonPageGroup1.ItemLinks.Add(this.EditDataSourceFilterBarItem1);
			this.DataSourceFilteringRibbonPageGroup1.ItemLinks.Add(this.ClearDataSourceFilterBarItem1);
			this.DataSourceFilteringRibbonPageGroup1.Name = "DataSourceFilteringRibbonPageGroup1";
			//
			//ViewRibbonPage1
			//
			this.ViewRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {this.SkinsRibbonPageGroup1});
			this.ViewRibbonPage1.Name = "ViewRibbonPage1";
			//
			//SkinsRibbonPageGroup1
			//
			this.SkinsRibbonPageGroup1.ItemLinks.Add(this.DashboardSkinsBarItem1);
			this.SkinsRibbonPageGroup1.Name = "SkinsRibbonPageGroup1";
			//
			//DashboardBarController1
			//
			this.DashboardBarController1.BarItems.Add(this.FileNewBarItem1);
			this.DashboardBarController1.BarItems.Add(this.FileOpenBarItem1);
			this.DashboardBarController1.BarItems.Add(this.FileSaveBarItem1);
			this.DashboardBarController1.BarItems.Add(this.FileSaveAsBarItem1);
			this.DashboardBarController1.BarItems.Add(this.UndoBarItem1);
			this.DashboardBarController1.BarItems.Add(this.RedoBarItem1);
			this.DashboardBarController1.BarItems.Add(this.NewDataSourceBarItem1);
			this.DashboardBarController1.BarItems.Add(this.EditDataSourceBarItem1);
			this.DashboardBarController1.BarItems.Add(this.DeleteDataSourceBarItem1);
			this.DashboardBarController1.BarItems.Add(this.AddCalculatedFieldBarItem1);
			this.DashboardBarController1.BarItems.Add(this.DashboardParametersBarItem1);
			this.DashboardBarController1.BarItems.Add(this.EditDataSourceFilterBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ClearDataSourceFilterBarItem1);
			this.DashboardBarController1.BarItems.Add(this.InsertPivotBarItem1);
			this.DashboardBarController1.BarItems.Add(this.InsertGridBarItem1);
			this.DashboardBarController1.BarItems.Add(this.InsertChartBarItem1);
			this.DashboardBarController1.BarItems.Add(this.InsertPiesBarItem1);
			this.DashboardBarController1.BarItems.Add(this.InsertGaugesBarItem1);
			this.DashboardBarController1.BarItems.Add(this.InsertCardsBarItem1);
			this.DashboardBarController1.BarItems.Add(this.InsertChoroplethMapBarItem1);
			this.DashboardBarController1.BarItems.Add(this.InsertGeoPointMapBarItem1);
			this.DashboardBarController1.BarItems.Add(this.InsertRangeFilterBarItem1);
			this.DashboardBarController1.BarItems.Add(this.InsertImageBarItem1);
			this.DashboardBarController1.BarItems.Add(this.InsertTextBoxBarItem1);
			this.DashboardBarController1.BarItems.Add(this.DuplicateItemBarItem1);
			this.DashboardBarController1.BarItems.Add(this.DeleteItemBarItem1);
			this.DashboardBarController1.BarItems.Add(this.DashboardTitleBarItem1);
			this.DashboardBarController1.BarItems.Add(this.SetCurrencyCultureBarItem1);
			this.DashboardBarController1.BarItems.Add(this.DashboardSkinsBarItem1);
			this.DashboardBarController1.BarItems.Add(this.EditFilterBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ClearFilterBarItem1);
			this.DashboardBarController1.BarItems.Add(this.MasterFilterBarItem1);
			this.DashboardBarController1.BarItems.Add(this.MultipleValuesMasterFilterBarItem1);
			this.DashboardBarController1.BarItems.Add(this.DrillDownBarItem1);
			this.DashboardBarController1.BarItems.Add(this.IgnoreMasterFiltersBarItem1);
			this.DashboardBarController1.BarItems.Add(this.CrossDataSourceFilteringBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ChartTargetDimensionsArgumentsBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ChartTargetDimensionsSeriesBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PieTargetDimensionsArgumentsBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PieTargetDimensionsSeriesBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ShowItemCaptionBarItem1);
			this.DashboardBarController1.BarItems.Add(this.EditItemNamesBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ContentAutoArrangeBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ContentArrangeInColumnsBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ContentArrangeInRowsBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ContentArrangementCountBarItem1);
			this.DashboardBarController1.BarItems.Add(this.GridHorizontalLinesBarItem1);
			this.DashboardBarController1.BarItems.Add(this.GridVerticalLinesBarItem1);
			this.DashboardBarController1.BarItems.Add(this.GridMergeCellsBarItem1);
			this.DashboardBarController1.BarItems.Add(this.GridBandedRowsBarItem1);
			this.DashboardBarController1.BarItems.Add(this.GridColumnHeadersBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ChartRotateBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ChartXAxisSettingsBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ChartYAxisSettingsBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ChartShowLegendBarItem1);
			this.DashboardBarController1.BarItems.Add(this.GalleryChartLegendPositionItem1);
			this.DashboardBarController1.BarItems.Add(this.GalleryChartSeriesTypeItem1);
			this.DashboardBarController1.BarItems.Add(this.PieLabelsDataLabelsBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PieLabelsDataLabelsNoneBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PieLabelsDataLabelArgumentBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PieLabelsDataLabelsValueBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PieLabelsDataLabelsArgumentAndValueBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PieLabelsDataLabelsPercentBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PieLabelsDataLabelsValueAndPercentBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PieLabelsDataLabelsArgumentAndPercentBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PieLabelsDataLabelsArgumentValueAndPercentBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PieTooltipsBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PieLabelsTooltipsNoneBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PieLabelsTooltipsArgumentBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PieLabelsTooltipsValueBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PieLabelsTooltipsArgumentAndValueBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PieLabelsTooltipsPercentBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PieLabelsTooltipsValueAndPercentBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PieLabelsTooltipsArgumentAndPercentBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PieLabelsTooltipsArgumentValueAndPercentBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PieStylePieBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PieStyleDonutBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PieShowCaptionsBarItem1);
			this.DashboardBarController1.BarItems.Add(this.GaugeStyleFullCircularBarItem1);
			this.DashboardBarController1.BarItems.Add(this.GaugeStyleHalfCircularBarItem1);
			this.DashboardBarController1.BarItems.Add(this.GaugeStyleLeftQuarterCircularBarItem1);
			this.DashboardBarController1.BarItems.Add(this.GaugeStyleRightQuarterCircularBarItem1);
			this.DashboardBarController1.BarItems.Add(this.GaugeStyleThreeForthCircularBarItem1);
			this.DashboardBarController1.BarItems.Add(this.GaugeStyleLinearHorizontalBarItem1);
			this.DashboardBarController1.BarItems.Add(this.GaugeStyleLinearVerticalBarItem1);
			this.DashboardBarController1.BarItems.Add(this.GaugeShowCaptionsBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ImageLoadBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ImageImportBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ImageSizeModeClipBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ImageSizeModeStretchBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ImageSizeModeSqueezeBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ImageSizeModeZoomBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ImageAlignmentTopLeftBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ImageAlignmentCenterLeftBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ImageAlignmentBottomLeftBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ImageAlignmentTopCenterBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ImageAlignmentCenterCenterBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ImageAlignmentBottomCenterBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ImageAlignmentTopRightBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ImageAlignmentCenterRightBarItem1);
			this.DashboardBarController1.BarItems.Add(this.ImageAlignmentBottomRightBarItem1);
			this.DashboardBarController1.BarItems.Add(this.TextBoxEditTextBarItem1);
			this.DashboardBarController1.BarItems.Add(this.RangeFilterLineSeriesTypeBarItem1);
			this.DashboardBarController1.BarItems.Add(this.RangeFilterStackedLineSeriesTypeBarItem1);
			this.DashboardBarController1.BarItems.Add(this.RangeFilterFullStackedLineSeriesTypeBarItem1);
			this.DashboardBarController1.BarItems.Add(this.RangeFilterAreaSeriesTypeBarItem1);
			this.DashboardBarController1.BarItems.Add(this.RangeFilterStackedAreaSeriesTypeBarItem1);
			this.DashboardBarController1.BarItems.Add(this.RangeFilterFullStackedAreaSeriesTypeBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PivotInitialStateBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PivotAutoExpandColumnBarItem1);
			this.DashboardBarController1.BarItems.Add(this.PivotAutoExpandRowBarItem1);
			this.DashboardBarController1.BarItems.Add(this.MapShowLegendBarItem1);
			this.DashboardBarController1.BarItems.Add(this.GalleryMapLegendPositionItem1);
			this.DashboardBarController1.BarItems.Add(this.MapLoadBarItem1);
			this.DashboardBarController1.BarItems.Add(this.MapImportBarItem1);
			this.DashboardBarController1.BarItems.Add(this.MapDefaultShapefileBarItem1);
			this.DashboardBarController1.BarItems.Add(this.MapWorldCountriesBarItem1);
			this.DashboardBarController1.BarItems.Add(this.MapEuropeBarItem1);
			this.DashboardBarController1.BarItems.Add(this.MapAsiaBarItem1);
			this.DashboardBarController1.BarItems.Add(this.MapNorthAmericaBarItem1);
			this.DashboardBarController1.BarItems.Add(this.MapSouthAmericaBarItem1);
			this.DashboardBarController1.BarItems.Add(this.MapAfricaBarItem1);
			this.DashboardBarController1.BarItems.Add(this.MapUSABarItem1);
			this.DashboardBarController1.BarItems.Add(this.MapCanadaBarItem1);
			this.DashboardBarController1.BarItems.Add(this.QuickAccessUndoBarItem1);
			this.DashboardBarController1.BarItems.Add(this.QuickAccessRedoBarItem1);
			this.DashboardBarController1.Control = this.DashboardDesigner1;
			//
			//frmDashboard
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1046, 434);
			this.Controls.Add(this.DashboardDesigner1);
			this.Controls.Add(this.DashboardViewer1);
			this.Controls.Add(this.RibbonControl1);
			this.Controls.Add(this.DashboardBackstageViewControl1);
			this.Name = "frmDashboard";
			this.Text = "frmDashboard";
			((System.ComponentModel.ISupportInitialize) this.DashboardViewer1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.RibbonControl1).EndInit();
			this.DashboardBackstageViewControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.DashboardBarAndDockingController1).EndInit();
			this.BackstageViewClientControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.RepositoryItemSpinEdit1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DashboardBarController1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraBars.FormAssistant FormAssistant1;
		internal DevExpress.DashboardWin.DashboardViewer DashboardViewer1;
		internal DevExpress.DashboardWin.DashboardDesigner DashboardDesigner1;
		internal DevExpress.XtraBars.Ribbon.RibbonControl RibbonControl1;
		internal DevExpress.DashboardWin.Bars.DashboardBackstageViewControl DashboardBackstageViewControl1;
		internal DevExpress.DashboardWin.Native.DashboardBarAndDockingController DashboardBarAndDockingController1;
		internal DevExpress.XtraBars.Ribbon.BackstageViewClientControl BackstageViewClientControl1;
		internal DevExpress.DashboardWin.Bars.RecentDashboardsControl RecentDashboardsControl1;
		internal DevExpress.DashboardWin.Bars.DashboardBackstageRecentTab DashboardBackstageRecentTab1;
		internal DevExpress.DashboardWin.Bars.DashboardBackstageNewButton DashboardBackstageNewButton1;
		internal DevExpress.DashboardWin.Bars.DashboardBackstageOpenButton DashboardBackstageOpenButton1;
		internal DevExpress.DashboardWin.Bars.DashboardBackstageSaveButton DashboardBackstageSaveButton1;
		internal DevExpress.DashboardWin.Bars.DashboardBackstageSaveAsButton DashboardBackstageSaveAsButton1;
		internal DevExpress.DashboardWin.Bars.FileNewBarItem FileNewBarItem1;
		internal DevExpress.DashboardWin.Bars.FileOpenBarItem FileOpenBarItem1;
		internal DevExpress.DashboardWin.Bars.FileSaveBarItem FileSaveBarItem1;
		internal DevExpress.DashboardWin.Bars.FileSaveAsBarItem FileSaveAsBarItem1;
		internal DevExpress.DashboardWin.Bars.UndoBarItem UndoBarItem1;
		internal DevExpress.DashboardWin.Bars.RedoBarItem RedoBarItem1;
		internal DevExpress.DashboardWin.Bars.NewDataSourceBarItem NewDataSourceBarItem1;
		internal DevExpress.DashboardWin.Bars.EditDataSourceBarItem EditDataSourceBarItem1;
		internal DevExpress.DashboardWin.Bars.DeleteDataSourceBarItem DeleteDataSourceBarItem1;
		internal DevExpress.DashboardWin.Bars.AddCalculatedFieldBarItem AddCalculatedFieldBarItem1;
		internal DevExpress.DashboardWin.Bars.DashboardParametersBarItem DashboardParametersBarItem1;
		internal DevExpress.DashboardWin.Bars.EditDataSourceFilterBarItem EditDataSourceFilterBarItem1;
		internal DevExpress.DashboardWin.Bars.ClearDataSourceFilterBarItem ClearDataSourceFilterBarItem1;
		internal DevExpress.DashboardWin.Bars.InsertPivotBarItem InsertPivotBarItem1;
		internal DevExpress.DashboardWin.Bars.InsertGridBarItem InsertGridBarItem1;
		internal DevExpress.DashboardWin.Bars.InsertChartBarItem InsertChartBarItem1;
		internal DevExpress.DashboardWin.Bars.InsertPiesBarItem InsertPiesBarItem1;
		internal DevExpress.DashboardWin.Bars.InsertGaugesBarItem InsertGaugesBarItem1;
		internal DevExpress.DashboardWin.Bars.InsertCardsBarItem InsertCardsBarItem1;
		internal DevExpress.DashboardWin.Bars.InsertChoroplethMapBarItem InsertChoroplethMapBarItem1;
		internal DevExpress.DashboardWin.Bars.InsertGeoPointMapBarItem InsertGeoPointMapBarItem1;
		internal DevExpress.DashboardWin.Bars.InsertRangeFilterBarItem InsertRangeFilterBarItem1;
		internal DevExpress.DashboardWin.Bars.InsertImageBarItem InsertImageBarItem1;
		internal DevExpress.DashboardWin.Bars.InsertTextBoxBarItem InsertTextBoxBarItem1;
		internal DevExpress.DashboardWin.Bars.DuplicateItemBarItem DuplicateItemBarItem1;
		internal DevExpress.DashboardWin.Bars.DeleteItemBarItem DeleteItemBarItem1;
		internal DevExpress.DashboardWin.Bars.DashboardTitleBarItem DashboardTitleBarItem1;
		internal DevExpress.DashboardWin.Bars.SetCurrencyCultureBarItem SetCurrencyCultureBarItem1;
		internal DevExpress.DashboardWin.Bars.DashboardSkinsBarItem DashboardSkinsBarItem1;
		internal DevExpress.DashboardWin.Bars.EditFilterBarItem EditFilterBarItem1;
		internal DevExpress.DashboardWin.Bars.ClearFilterBarItem ClearFilterBarItem1;
		internal DevExpress.DashboardWin.Bars.MasterFilterBarItem MasterFilterBarItem1;
		internal DevExpress.DashboardWin.Bars.MultipleValuesMasterFilterBarItem MultipleValuesMasterFilterBarItem1;
		internal DevExpress.DashboardWin.Bars.DrillDownBarItem DrillDownBarItem1;
		internal DevExpress.DashboardWin.Bars.IgnoreMasterFiltersBarItem IgnoreMasterFiltersBarItem1;
		internal DevExpress.DashboardWin.Bars.CrossDataSourceFilteringBarItem CrossDataSourceFilteringBarItem1;
		internal DevExpress.DashboardWin.Bars.ChartTargetDimensionsArgumentsBarItem ChartTargetDimensionsArgumentsBarItem1;
		internal DevExpress.DashboardWin.Bars.ChartTargetDimensionsSeriesBarItem ChartTargetDimensionsSeriesBarItem1;
		internal DevExpress.DashboardWin.Bars.PieTargetDimensionsArgumentsBarItem PieTargetDimensionsArgumentsBarItem1;
		internal DevExpress.DashboardWin.Bars.PieTargetDimensionsSeriesBarItem PieTargetDimensionsSeriesBarItem1;
		internal DevExpress.DashboardWin.Bars.ShowItemCaptionBarItem ShowItemCaptionBarItem1;
		internal DevExpress.DashboardWin.Bars.EditItemNamesBarItem EditItemNamesBarItem1;
		internal DevExpress.DashboardWin.Bars.ContentAutoArrangeBarItem ContentAutoArrangeBarItem1;
		internal DevExpress.DashboardWin.Bars.ContentArrangeInColumnsBarItem ContentArrangeInColumnsBarItem1;
		internal DevExpress.DashboardWin.Bars.ContentArrangeInRowsBarItem ContentArrangeInRowsBarItem1;
		internal DevExpress.DashboardWin.Bars.ContentArrangementCountBarItem ContentArrangementCountBarItem1;
		internal DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit RepositoryItemSpinEdit1;
		internal DevExpress.DashboardWin.Bars.GridHorizontalLinesBarItem GridHorizontalLinesBarItem1;
		internal DevExpress.DashboardWin.Bars.GridVerticalLinesBarItem GridVerticalLinesBarItem1;
		internal DevExpress.DashboardWin.Bars.GridMergeCellsBarItem GridMergeCellsBarItem1;
		internal DevExpress.DashboardWin.Bars.GridBandedRowsBarItem GridBandedRowsBarItem1;
		internal DevExpress.DashboardWin.Bars.GridColumnHeadersBarItem GridColumnHeadersBarItem1;
		internal DevExpress.DashboardWin.Bars.ChartRotateBarItem ChartRotateBarItem1;
		internal DevExpress.DashboardWin.Bars.ChartXAxisSettingsBarItem ChartXAxisSettingsBarItem1;
		internal DevExpress.DashboardWin.Bars.ChartYAxisSettingsBarItem ChartYAxisSettingsBarItem1;
		internal DevExpress.DashboardWin.Bars.ChartShowLegendBarItem ChartShowLegendBarItem1;
		internal DevExpress.DashboardWin.Bars.GalleryChartLegendPositionItem GalleryChartLegendPositionItem1;
		internal DevExpress.DashboardWin.Bars.GalleryChartSeriesTypeItem GalleryChartSeriesTypeItem1;
		internal DevExpress.DashboardWin.Bars.PieLabelsDataLabelsBarItem PieLabelsDataLabelsBarItem1;
		internal DevExpress.DashboardWin.Bars.PieLabelsDataLabelsNoneBarItem PieLabelsDataLabelsNoneBarItem1;
		internal DevExpress.DashboardWin.Bars.PieLabelsDataLabelArgumentBarItem PieLabelsDataLabelArgumentBarItem1;
		internal DevExpress.DashboardWin.Bars.PieLabelsDataLabelsValueBarItem PieLabelsDataLabelsValueBarItem1;
		internal DevExpress.DashboardWin.Bars.PieLabelsDataLabelsArgumentAndValueBarItem PieLabelsDataLabelsArgumentAndValueBarItem1;
		internal DevExpress.DashboardWin.Bars.PieLabelsDataLabelsPercentBarItem PieLabelsDataLabelsPercentBarItem1;
		internal DevExpress.DashboardWin.Bars.PieLabelsDataLabelsValueAndPercentBarItem PieLabelsDataLabelsValueAndPercentBarItem1;
		internal DevExpress.DashboardWin.Bars.PieLabelsDataLabelsArgumentAndPercentBarItem PieLabelsDataLabelsArgumentAndPercentBarItem1;
		internal DevExpress.DashboardWin.Bars.PieLabelsDataLabelsArgumentValueAndPercentBarItem PieLabelsDataLabelsArgumentValueAndPercentBarItem1;
		internal DevExpress.DashboardWin.Bars.PieTooltipsBarItem PieTooltipsBarItem1;
		internal DevExpress.DashboardWin.Bars.PieLabelsTooltipsNoneBarItem PieLabelsTooltipsNoneBarItem1;
		internal DevExpress.DashboardWin.Bars.PieLabelsTooltipsArgumentBarItem PieLabelsTooltipsArgumentBarItem1;
		internal DevExpress.DashboardWin.Bars.PieLabelsTooltipsValueBarItem PieLabelsTooltipsValueBarItem1;
		internal DevExpress.DashboardWin.Bars.PieLabelsTooltipsArgumentAndValueBarItem PieLabelsTooltipsArgumentAndValueBarItem1;
		internal DevExpress.DashboardWin.Bars.PieLabelsTooltipsPercentBarItem PieLabelsTooltipsPercentBarItem1;
		internal DevExpress.DashboardWin.Bars.PieLabelsTooltipsValueAndPercentBarItem PieLabelsTooltipsValueAndPercentBarItem1;
		internal DevExpress.DashboardWin.Bars.PieLabelsTooltipsArgumentAndPercentBarItem PieLabelsTooltipsArgumentAndPercentBarItem1;
		internal DevExpress.DashboardWin.Bars.PieLabelsTooltipsArgumentValueAndPercentBarItem PieLabelsTooltipsArgumentValueAndPercentBarItem1;
		internal DevExpress.DashboardWin.Bars.PieStylePieBarItem PieStylePieBarItem1;
		internal DevExpress.DashboardWin.Bars.PieStyleDonutBarItem PieStyleDonutBarItem1;
		internal DevExpress.DashboardWin.Bars.PieShowCaptionsBarItem PieShowCaptionsBarItem1;
		internal DevExpress.DashboardWin.Bars.GaugeStyleFullCircularBarItem GaugeStyleFullCircularBarItem1;
		internal DevExpress.DashboardWin.Bars.GaugeStyleHalfCircularBarItem GaugeStyleHalfCircularBarItem1;
		internal DevExpress.DashboardWin.Bars.GaugeStyleLeftQuarterCircularBarItem GaugeStyleLeftQuarterCircularBarItem1;
		internal DevExpress.DashboardWin.Bars.GaugeStyleRightQuarterCircularBarItem GaugeStyleRightQuarterCircularBarItem1;
		internal DevExpress.DashboardWin.Bars.GaugeStyleThreeForthCircularBarItem GaugeStyleThreeForthCircularBarItem1;
		internal DevExpress.DashboardWin.Bars.GaugeStyleLinearHorizontalBarItem GaugeStyleLinearHorizontalBarItem1;
		internal DevExpress.DashboardWin.Bars.GaugeStyleLinearVerticalBarItem GaugeStyleLinearVerticalBarItem1;
		internal DevExpress.DashboardWin.Bars.GaugeShowCaptionsBarItem GaugeShowCaptionsBarItem1;
		internal DevExpress.DashboardWin.Bars.ImageLoadBarItem ImageLoadBarItem1;
		internal DevExpress.DashboardWin.Bars.ImageImportBarItem ImageImportBarItem1;
		internal DevExpress.DashboardWin.Bars.ImageSizeModeClipBarItem ImageSizeModeClipBarItem1;
		internal DevExpress.DashboardWin.Bars.ImageSizeModeStretchBarItem ImageSizeModeStretchBarItem1;
		internal DevExpress.DashboardWin.Bars.ImageSizeModeSqueezeBarItem ImageSizeModeSqueezeBarItem1;
		internal DevExpress.DashboardWin.Bars.ImageSizeModeZoomBarItem ImageSizeModeZoomBarItem1;
		internal DevExpress.DashboardWin.Bars.ImageAlignmentTopLeftBarItem ImageAlignmentTopLeftBarItem1;
		internal DevExpress.DashboardWin.Bars.ImageAlignmentCenterLeftBarItem ImageAlignmentCenterLeftBarItem1;
		internal DevExpress.DashboardWin.Bars.ImageAlignmentBottomLeftBarItem ImageAlignmentBottomLeftBarItem1;
		internal DevExpress.DashboardWin.Bars.ImageAlignmentTopCenterBarItem ImageAlignmentTopCenterBarItem1;
		internal DevExpress.DashboardWin.Bars.ImageAlignmentCenterCenterBarItem ImageAlignmentCenterCenterBarItem1;
		internal DevExpress.DashboardWin.Bars.ImageAlignmentBottomCenterBarItem ImageAlignmentBottomCenterBarItem1;
		internal DevExpress.DashboardWin.Bars.ImageAlignmentTopRightBarItem ImageAlignmentTopRightBarItem1;
		internal DevExpress.DashboardWin.Bars.ImageAlignmentCenterRightBarItem ImageAlignmentCenterRightBarItem1;
		internal DevExpress.DashboardWin.Bars.ImageAlignmentBottomRightBarItem ImageAlignmentBottomRightBarItem1;
		internal DevExpress.DashboardWin.Bars.TextBoxEditTextBarItem TextBoxEditTextBarItem1;
		internal DevExpress.DashboardWin.Bars.RangeFilterLineSeriesTypeBarItem RangeFilterLineSeriesTypeBarItem1;
		internal DevExpress.DashboardWin.Bars.RangeFilterStackedLineSeriesTypeBarItem RangeFilterStackedLineSeriesTypeBarItem1;
		internal DevExpress.DashboardWin.Bars.RangeFilterFullStackedLineSeriesTypeBarItem RangeFilterFullStackedLineSeriesTypeBarItem1;
		internal DevExpress.DashboardWin.Bars.RangeFilterAreaSeriesTypeBarItem RangeFilterAreaSeriesTypeBarItem1;
		internal DevExpress.DashboardWin.Bars.RangeFilterStackedAreaSeriesTypeBarItem RangeFilterStackedAreaSeriesTypeBarItem1;
		internal DevExpress.DashboardWin.Bars.RangeFilterFullStackedAreaSeriesTypeBarItem RangeFilterFullStackedAreaSeriesTypeBarItem1;
		internal DevExpress.DashboardWin.Bars.PivotInitialStateBarItem PivotInitialStateBarItem1;
		internal DevExpress.DashboardWin.Bars.PivotAutoExpandColumnBarItem PivotAutoExpandColumnBarItem1;
		internal DevExpress.DashboardWin.Bars.PivotAutoExpandRowBarItem PivotAutoExpandRowBarItem1;
		internal DevExpress.DashboardWin.Bars.MapShowLegendBarItem MapShowLegendBarItem1;
		internal DevExpress.DashboardWin.Bars.GalleryMapLegendPositionItem GalleryMapLegendPositionItem1;
		internal DevExpress.DashboardWin.Bars.MapLoadBarItem MapLoadBarItem1;
		internal DevExpress.DashboardWin.Bars.MapImportBarItem MapImportBarItem1;
		internal DevExpress.DashboardWin.Bars.MapDefaultShapefileBarItem MapDefaultShapefileBarItem1;
		internal DevExpress.DashboardWin.Bars.MapWorldCountriesBarItem MapWorldCountriesBarItem1;
		internal DevExpress.DashboardWin.Bars.MapEuropeBarItem MapEuropeBarItem1;
		internal DevExpress.DashboardWin.Bars.MapAsiaBarItem MapAsiaBarItem1;
		internal DevExpress.DashboardWin.Bars.MapNorthAmericaBarItem MapNorthAmericaBarItem1;
		internal DevExpress.DashboardWin.Bars.MapSouthAmericaBarItem MapSouthAmericaBarItem1;
		internal DevExpress.DashboardWin.Bars.MapAfricaBarItem MapAfricaBarItem1;
		internal DevExpress.DashboardWin.Bars.MapUSABarItem MapUSABarItem1;
		internal DevExpress.DashboardWin.Bars.MapCanadaBarItem MapCanadaBarItem1;
		internal DevExpress.DashboardWin.Bars.QuickAccessUndoBarItem QuickAccessUndoBarItem1;
		internal DevExpress.DashboardWin.Bars.QuickAccessRedoBarItem QuickAccessRedoBarItem1;
		internal DevExpress.DashboardWin.Bars.PivotToolsRibbonPageCategory PivotToolsRibbonPageCategory1;
		internal DevExpress.DashboardWin.Bars.DataRibbonPage DataRibbonPage1;
		internal DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup FilteringRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup InteractivitySettingsRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.PivotLayoutRibbonPageGroup PivotLayoutRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage DashboardItemDesignRibbonPage9;
		internal DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup CommonItemDesignRibbonPageGroup9;
		internal DevExpress.DashboardWin.Bars.GridToolsRibbonPageCategory GridToolsRibbonPageCategory1;
		internal DevExpress.DashboardWin.Bars.DataRibbonPage DataRibbonPage2;
		internal DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup FilteringRibbonPageGroup2;
		internal DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup MasterFilterRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup InteractivitySettingsRibbonPageGroup2;
		internal DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage DashboardItemDesignRibbonPage1;
		internal DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup CommonItemDesignRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.GridCellsRibbonPageGroup GridCellsRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.ChartToolsRibbonPageCategory ChartToolsRibbonPageCategory1;
		internal DevExpress.DashboardWin.Bars.DataRibbonPage DataRibbonPage3;
		internal DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup FilteringRibbonPageGroup3;
		internal DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup MasterFilterRibbonPageGroup2;
		internal DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup InteractivitySettingsRibbonPageGroup3;
		internal DevExpress.DashboardWin.Bars.TargetDimensionsRibbonPageGroup TargetDimensionsRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage DashboardItemDesignRibbonPage2;
		internal DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup CommonItemDesignRibbonPageGroup2;
		internal DevExpress.DashboardWin.Bars.ChartLayoutPageGroup ChartLayoutPageGroup1;
		internal DevExpress.DashboardWin.Bars.ChartLegendPositionPageGroup ChartLegendPositionPageGroup1;
		internal DevExpress.DashboardWin.Bars.ChartStylePageGroup ChartStylePageGroup1;
		internal DevExpress.DashboardWin.Bars.PiesToolsRibbonPageCategory PiesToolsRibbonPageCategory1;
		internal DevExpress.DashboardWin.Bars.DataRibbonPage DataRibbonPage4;
		internal DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup FilteringRibbonPageGroup4;
		internal DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup MasterFilterRibbonPageGroup3;
		internal DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup InteractivitySettingsRibbonPageGroup4;
		internal DevExpress.DashboardWin.Bars.TargetDimensionsRibbonPageGroup TargetDimensionsRibbonPageGroup2;
		internal DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage DashboardItemDesignRibbonPage3;
		internal DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup CommonItemDesignRibbonPageGroup3;
		internal DevExpress.DashboardWin.Bars.ContentArrangementRibbonPageGroup ContentArrangementRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.PieLabelsRibbonPageGroup PieLabelsRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.PieStyleRibbonPageGroup PieStyleRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.GaugesToolsRibbonPageCategory GaugesToolsRibbonPageCategory1;
		internal DevExpress.DashboardWin.Bars.DataRibbonPage DataRibbonPage5;
		internal DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup FilteringRibbonPageGroup5;
		internal DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup MasterFilterRibbonPageGroup4;
		internal DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup InteractivitySettingsRibbonPageGroup5;
		internal DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage DashboardItemDesignRibbonPage4;
		internal DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup CommonItemDesignRibbonPageGroup4;
		internal DevExpress.DashboardWin.Bars.ContentArrangementRibbonPageGroup ContentArrangementRibbonPageGroup2;
		internal DevExpress.DashboardWin.Bars.GaugeStyleRibbonPageGroup GaugeStyleRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.GaugesLabelsRibbonPageGroup GaugesLabelsRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.CardsToolsRibbonPageCategory CardsToolsRibbonPageCategory1;
		internal DevExpress.DashboardWin.Bars.DataRibbonPage DataRibbonPage6;
		internal DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup FilteringRibbonPageGroup6;
		internal DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup MasterFilterRibbonPageGroup5;
		internal DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup InteractivitySettingsRibbonPageGroup6;
		internal DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage DashboardItemDesignRibbonPage5;
		internal DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup CommonItemDesignRibbonPageGroup5;
		internal DevExpress.DashboardWin.Bars.ContentArrangementRibbonPageGroup ContentArrangementRibbonPageGroup3;
		internal DevExpress.DashboardWin.Bars.RangeFilterToolsRibbonPageCategory RangeFilterToolsRibbonPageCategory1;
		internal DevExpress.DashboardWin.Bars.DataRibbonPage DataRibbonPage7;
		internal DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup FilteringRibbonPageGroup7;
		internal DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup InteractivitySettingsRibbonPageGroup7;
		internal DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage DashboardItemDesignRibbonPage8;
		internal DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup CommonItemDesignRibbonPageGroup8;
		internal DevExpress.DashboardWin.Bars.RangeFilterSeriesTypeRibbonPageGroup RangeFilterSeriesTypeRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.ChoroplethMapToolsRibbonPageCategory ChoroplethMapToolsRibbonPageCategory1;
		internal DevExpress.DashboardWin.Bars.DataRibbonPage DataRibbonPage8;
		internal DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup FilteringRibbonPageGroup8;
		internal DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup MasterFilterRibbonPageGroup6;
		internal DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup InteractivitySettingsRibbonPageGroup8;
		internal DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage DashboardItemDesignRibbonPage10;
		internal DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup CommonItemDesignRibbonPageGroup10;
		internal DevExpress.DashboardWin.Bars.MapLegendPositionPageGroup MapLegendPositionPageGroup1;
		internal DevExpress.DashboardWin.Bars.MapShapefileRibbonPageGroup MapShapefileRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.GeoPointMapToolsRibbonPageCategory GeoPointMapToolsRibbonPageCategory1;
		internal DevExpress.DashboardWin.Bars.DataRibbonPage DataRibbonPage9;
		internal DevExpress.DashboardWin.Bars.FilteringRibbonPageGroup FilteringRibbonPageGroup9;
		internal DevExpress.DashboardWin.Bars.MasterFilterRibbonPageGroup MasterFilterRibbonPageGroup7;
		internal DevExpress.DashboardWin.Bars.InteractivitySettingsRibbonPageGroup InteractivitySettingsRibbonPageGroup9;
		internal DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage DashboardItemDesignRibbonPage11;
		internal DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup CommonItemDesignRibbonPageGroup11;
		internal DevExpress.DashboardWin.Bars.MapShapefileRibbonPageGroup MapShapefileRibbonPageGroup2;
		internal DevExpress.DashboardWin.Bars.ImageToolsRibbonPageCategory ImageToolsRibbonPageCategory1;
		internal DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage DashboardItemDesignRibbonPage6;
		internal DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup CommonItemDesignRibbonPageGroup6;
		internal DevExpress.DashboardWin.Bars.ImageOpenRibbonPageGroup ImageOpenRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.ImageSizeModeRibbonPageGroup ImageSizeModeRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.ImageAlignmentRibbonPageGroup ImageAlignmentRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.TextBoxToolsRibbonPageCategory TextBoxToolsRibbonPageCategory1;
		internal DevExpress.DashboardWin.Bars.DashboardItemDesignRibbonPage DashboardItemDesignRibbonPage7;
		internal DevExpress.DashboardWin.Bars.CommonItemDesignRibbonPageGroup CommonItemDesignRibbonPageGroup7;
		internal DevExpress.DashboardWin.Bars.TextBoxSettingsRibbonPageGroup TextBoxSettingsRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.HomeRibbonPage HomeRibbonPage1;
		internal DevExpress.DashboardWin.Bars.FileRibbonPageGroup FileRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.HistoryRibbonPageGroup HistoryRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.InsertRibbonPageGroup InsertRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.ItemOperationRibbonPageGroup ItemOperationRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.DashboardDesignRibbonPageGroup DashboardDesignRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.QuickAccessHistoryRibbonPageGroup QuickAccessHistoryRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.DataSourceRibbonPage DataSourceRibbonPage1;
		internal DevExpress.DashboardWin.Bars.DataSourceRibbonPageGroup DataSourceRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.DataSourceElementsRibbonPageGroup DataSourceElementsRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.DataSourceFilteringRibbonPageGroup DataSourceFilteringRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.ViewRibbonPage ViewRibbonPage1;
		internal DevExpress.DashboardWin.Bars.SkinsRibbonPageGroup SkinsRibbonPageGroup1;
		internal DevExpress.DashboardWin.Bars.DashboardBarController DashboardBarController1;
	}
	
}
