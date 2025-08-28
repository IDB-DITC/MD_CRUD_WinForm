using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MD_CRUD_App
{
  public partial class ReportViewerForm : Form
  {

    public ReportViewerForm()
    {
      InitializeComponent();
    }
    ReportClass rpt;
    public ReportViewerForm(ReportClass report, object ReportData)
    {
      InitializeComponent();
      this.rpt = report;
      this.ReportData = ReportData;
    }



    public ReportViewerForm(string reportPath, object ReportData)
    {
      InitializeComponent();
      this.reportPath = reportPath;
      this.ReportData = ReportData;

    }
    private string reportPath;
    private object ReportData;
    private Dictionary<string, object> parameters = new Dictionary<string, object>();
    public ReportViewerForm(string reportPath, object ReportData, Dictionary<string, object> parameters)
    {
      InitializeComponent();

      this.reportPath = reportPath;
      this.ReportData = ReportData;
      this.parameters = parameters;
    }

    private void ReportViewerForm_Load(object sender, EventArgs e)
    {

      this.crystalReportViewer1.ShowCopyButton = false;
      this.crystalReportViewer1.ShowCloseButton = false;
      this.crystalReportViewer1.ReuseParameterValuesOnRefresh = true;



      rpt.SetDataSource(this.ReportData);
      foreach (var parameter in parameters)
      {
        rpt.SetParameterValue(parameter.Key, parameter.Value);
      }
      rpt.Refresh();
      this.crystalReportViewer1.ReportSource = rpt;
      this.crystalReportViewer1.Refresh();
     
      //ReportDocument rd = new ReportDocument();

      //rd.Load(reportPath);

      ////if (rd.IsLoaded)
      ////{
      //  rd.SetDataSource(ReportData);
      ////}

      ////rd.SetParameterValue("AppPath", Application.StartupPath);

      //foreach (var parameter in parameters)
      //{
      //  rd.SetParameterValue(parameter.Key, parameter.Value);
      //}
      //rd.Refresh();
      //Thread.Sleep(500);
      //this.crystalReportViewer1.ReportSource = rd;
      //rd.Refresh();
      //this.crystalReportViewer1.Refresh();
      //this.crystalReportViewer1.RefreshReport();
      //this.crystalReportViewer1.Update();

    }
  }
}
