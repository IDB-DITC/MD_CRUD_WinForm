using MD_CRUD_App.BLL;
using MD_CRUD_App.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD_CRUD_App
{
  public partial class SalesEntry : Form
  {

    internal SalesMaster model = new SalesMaster();
     Repository repo = new Repository();
    public SalesEntry()
    {
      InitializeComponent();
    }

    private void SalesEntry_Load(object sender, EventArgs e)
    {
      if (model.SalesId > 0)
      {
        this.txtSalesId.Text = model.SalesId.ToString();
        this.txtCustomerName.Text = model.CustomerName.ToString();
        this.salesDate.Value = model.SalesDate;
        this.nmTotal.Value = model.TotalAmount;
        this.nmPaid.Value = model.PaidAmount;
        this.chkFullPaid.Checked = model.FullPaid;
        if( !string.IsNullOrEmpty(  model.ImageUrl))
        {
          string path = $"{Application.StartupPath}{model.ImageUrl}";
          pictureBox1.Image = Image.FromFile(path);
        }

       


      }
      salesDetailsBindingSource.DataSource = model.ItemList;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      try
      {

        

        model.SalesId = Convert.ToInt32(txtSalesId.Text);
        model.CustomerName = txtCustomerName.Text;
        model.SalesDate = salesDate.Value;
        model.TotalAmount = nmTotal.Value =  model.ItemList.Sum(i => i.ItemTotal);
        model.PaidAmount = nmPaid.Value;
        model.FullPaid = chkFullPaid.Checked;
        if (!string.IsNullOrEmpty(pictureBox1.Tag?.ToString()))
        {

          string imagepath = $"\\Images\\{Guid.NewGuid()}.png";
          string filePath = $"{Application.StartupPath}{imagepath}";

          pictureBox1.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);    

          model.ImageUrl = imagepath;

        }

        //save

        if (repo.AddOrUpdate(model))
        {
          MessageBox.Show("Data saved");
          this.Close();
        }
      }
      catch (Exception ee)
      {
        MessageBox.Show(ee.Message);
      }

    }

    private void btnReset_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {


        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"; // Filter for image files
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
          pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

        }

        pictureBox1.Tag = openFileDialog1.FileName;
      }
      catch (Exception er)
      {
        MessageBox.Show(er.Message);
      }
    }
  }
}
