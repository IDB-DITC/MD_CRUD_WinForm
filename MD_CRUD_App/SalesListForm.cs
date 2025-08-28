using MD_CRUD_App.DAL;
using MD_CRUD_App.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD_CRUD_App
{
  public partial class SalesListForm : Form
  {
    Repository repo = new Repository();
    public SalesListForm()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {


      var list = repo.GetAll();
     this.  salesMasterBindingSource.DataSource = list;   

    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      SalesEntry form = new SalesEntry();
      form.ShowDialog(this);
      this.salesMasterBindingSource.DataSource = repo.GetAll();


    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      if (gridList.SelectedRows.Count == 0) return;

      int.TryParse(gridList.SelectedRows[0].Cells["SalesId"].Value.ToString(), out int id);
      SalesEntry form = new SalesEntry();

      form.model = repo.GetById(id);
      form.ShowDialog(this);

      this.salesMasterBindingSource.DataSource = repo.GetAll();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (gridList.SelectedRows.Count == 0) return;
     var row = gridList.SelectedRows[0];

      var confirm = MessageBox.Show($"Delete sales data of {row.Cells["CustomerName"].Value} ?", "Delete Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

      if (confirm != DialogResult.OK) return;

      int.TryParse(row.Cells["SalesId"].Value.ToString(), out int id);

      
      if (repo.delete(id))
      {
        MessageBox.Show("Delete Success");
        this.salesMasterBindingSource.DataSource = repo.GetAll();
      }
     
    }

    private void btnReport_Click(object sender, EventArgs e)
    {
      if (gridList.SelectedRows.Count == 0) return;

      int.TryParse(gridList.SelectedRows[0].Cells["SalesId"].Value.ToString(), out int id);

      var data = repo.GetReportData(id);

      //string reportPath = $"{Application.StartupPath}\\Reports\\SalesReport.rpt";

      SalesReport report = new SalesReport();


      ReportViewerForm form = new ReportViewerForm(report, data);


      form.ShowDialog(this);
    }
  }
}
