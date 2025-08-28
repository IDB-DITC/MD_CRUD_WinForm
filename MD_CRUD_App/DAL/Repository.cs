using MD_CRUD_App.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD_CRUD_App.DAL
{
  internal class Repository
  {
    SqlConnection con;
    public Repository()
    {
      string dbs = ConfigurationManager.ConnectionStrings["appDb"].ConnectionString;
      this.con = new SqlConnection(dbs);
    }

    public List<SalesMaster> GetAll()
    {
      List<SalesMaster> data = new List<SalesMaster>();
      try
      {
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandText = "exec getData";
        // "select * from SalesMaster;  select * from SalesDetails; ";
        if (con.State != ConnectionState.Open)
          con.Open();

        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        foreach (DataRow row in ds.Tables[0].Rows)
        {
          SalesMaster obj = new SalesMaster();
          obj.SalesId = int.Parse(row["SalesId"].ToString());
          obj.CustomerName = row["CustomerName"]?.ToString();
          obj.SalesDate = DateTime.Parse(row["SalesDate"].ToString());
          obj.TotalAmount = decimal.Parse(row["TotalAmount"].ToString());
          obj.PaidAmount = decimal.Parse(row["PaidAmount"].ToString());
          obj.FullPaid = bool.Parse(row["FullPaid"].ToString());
          obj.ImageUrl = row["ImageUrl"]?.ToString();

          DataView dv = new DataView(ds.Tables[1]);

          dv.RowFilter = $"SalesId = {obj.SalesId}";

          foreach (DataRowView itemRow in dv)
          {
            SalesDetails item = new SalesDetails();
            item.Sl = int.Parse(itemRow.Row["Sl"].ToString());
            item.SalesId = int.Parse(itemRow.Row["SalesId"].ToString());
            item.ItemName = itemRow.Row["ItemName"].ToString();
            item.Quantity = byte.Parse(itemRow.Row["Quantity"].ToString());
            item.UnitPrice = decimal.Parse(itemRow.Row["UnitPrice"].ToString());

            obj.ItemList.Add(item);
          }

          data.Add(obj);
        }

      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message);
      }


      return data;

    }



    public SalesMaster GetById(int id)
    {
      try
      {
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandText = $"exec getData {id}";
        // "select * from SalesMaster;  select * from SalesDetails; ";
        if (con.State != ConnectionState.Open)
          con.Open();

        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        foreach (DataRow row in ds.Tables[0].Rows)
        {
          SalesMaster obj = new SalesMaster();
          obj.SalesId = int.Parse(row["SalesId"].ToString());
          obj.CustomerName = row["CustomerName"]?.ToString();
          obj.SalesDate = DateTime.Parse(row["SalesDate"].ToString());
          obj.TotalAmount = decimal.Parse(row["TotalAmount"].ToString());
          obj.PaidAmount = decimal.Parse(row["PaidAmount"].ToString());
          obj.FullPaid = bool.Parse(row["FullPaid"].ToString());
          obj.ImageUrl = row["ImageUrl"]?.ToString();

          DataView dv = new DataView(ds.Tables[1]);

          dv.RowFilter = $"SalesId = {obj.SalesId}";

          foreach (DataRowView itemRow in dv)
          {
            SalesDetails item = new SalesDetails();
            item.Sl = int.Parse(itemRow.Row["Sl"].ToString());
            item.SalesId = int.Parse(itemRow.Row["SalesId"].ToString());
            item.ItemName = itemRow.Row["ItemName"].ToString();
            item.Quantity = byte.Parse(itemRow.Row["Quantity"].ToString());
            item.UnitPrice = decimal.Parse(itemRow.Row["UnitPrice"].ToString());

            obj.ItemList.Add(item);
          }

          return obj;
        }

      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message);
      }
      return null;
    }

    public List<SalesData> GetReportData(int id)
    {
      List<SalesData> data = new List<SalesData>();
      try
      {
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandText = $"select * from SalesData where salesid = {id}";
        // "select * from SalesMaster;  select * from SalesDetails; ";
        if (con.State != ConnectionState.Open)
          con.Open();

        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataTable dt = new DataTable();
        da.Fill(dt);
        con.Close();
        foreach (DataRow row in dt.Rows)
        {
          SalesData obj = new SalesData();
          obj.SalesId = int.Parse(row["SalesId"].ToString());
          obj.CustomerName = row["CustomerName"]?.ToString();
          obj.SalesDate = DateTime.Parse(row["SalesDate"].ToString());
          obj.TotalAmount = decimal.Parse(row["TotalAmount"].ToString());
          obj.PaidAmount = decimal.Parse(row["PaidAmount"].ToString());
          obj.FullPaid = bool.Parse(row["FullPaid"].ToString());
          if (!string.IsNullOrEmpty(row["ImageUrl"]?.ToString()))
          {
            obj.ImageUrl =Application.StartupPath+ row["ImageUrl"]?.ToString();
          }
          
          obj.Sl = int.Parse(row["Sl"].ToString());
          obj.SalesId = int.Parse(row["SalesId"].ToString());
          obj.ItemName = row["ItemName"].ToString();
          obj.Quantity = byte.Parse(row["Quantity"].ToString());
          obj.UnitPrice = decimal.Parse(row["UnitPrice"].ToString());

          data.Add(obj);
        }

      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message);
      }
      return data;
    }
    public bool delete(int id)
    {
      int rn = 0;
      try
      {
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandText = $"delete from salesMaster where salesid =  {id}";

        if (con.State != ConnectionState.Open)
          con.Open();
        rn = cmd.ExecuteNonQuery();

      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message);
      }
      finally
      {
        con.Close();
      }
      return rn > 0;
    }

    public bool AddOrUpdate(SalesMaster sales)
    {
      bool success = false;
      if (con.State != ConnectionState.Open)
        con.Open();
      SqlTransaction sqlTransaction = con.BeginTransaction(IsolationLevel.Serializable);
      try
      {


        SqlCommand cmd = con.CreateCommand();
        cmd.Transaction = sqlTransaction;
        string path = "NULL";
        if (!(sales.ImageUrl is null))
        {
          path = $"'{sales.ImageUrl}'";
        }


        if (sales.SalesId == 0)//add new sale
        {
          cmd.CommandText = $"select isnull(Max(salesid) , 0) + 1 as Id from salesmaster";
          var id = cmd.ExecuteScalar();

          cmd.CommandText = $@"INSERT INTO [dbo].[SalesMaster] ([SalesId] ,[CustomerName] ,[SalesDate] ,[TotalAmount] ,[PaidAmount] ,[FullPaid] ,[ImageUrl]) VALUES ({id} , '{sales.CustomerName}' ,'{sales.SalesDate}' ,{sales.TotalAmount} ,{sales.PaidAmount} , {Convert.ToInt16(sales.FullPaid)}, {path})";
          cmd.ExecuteNonQuery();

          sales.SalesId = int.Parse(id.ToString());

        }
        else //update sale data
        {
          cmd.CommandText = $"delete from salesDetails where salesid =  {sales.SalesId}";
          cmd.ExecuteNonQuery();
          cmd.CommandText = $@"UPDATE [dbo].[SalesMaster]
   SET [CustomerName] = '{sales.CustomerName}'
      ,[SalesDate] = '{sales.SalesDate}'
      ,[TotalAmount] = {sales.TotalAmount}
      ,[PaidAmount] = {sales.PaidAmount}
      ,[FullPaid] = {Convert.ToInt16(sales.FullPaid)}
      ,[ImageUrl] = {path}
 WHERE salesid =  {sales.SalesId}";
          cmd.ExecuteNonQuery();
        }

        //sales item list

        foreach (SalesDetails item in sales.ItemList)
        {
          cmd.CommandText = $@"INSERT INTO [dbo].[SalesDetails] ([SalesId] ,[ItemName] ,[Quantity] ,[UnitPrice]) VALUES ( {sales.SalesId} , '{item.ItemName}' , {item.Quantity} , {item.UnitPrice})";
          cmd.ExecuteNonQuery();
        }
        sqlTransaction.Commit();
        success = true;
      }
      catch (Exception e)
      {
        sqlTransaction.Rollback();
        MessageBox.Show(e.Message);
      }
      return success;
    }
  }
}
