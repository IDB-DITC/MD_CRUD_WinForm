using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD_CRUD_App.BLL
{
  internal class SalesMaster
  {
    public int SalesId { get; set; }
    public string CustomerName { get; set; }
    public DateTime SalesDate { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal PaidAmount { get; set; }
    public bool FullPaid { get; set; }
    public string ImageUrl { get; set; }
    public Image Image
    {
      get
      {
        if (!string.IsNullOrEmpty(ImageUrl))
        {
          string path = $"{Application.StartupPath}{ImageUrl}";
          return Image.FromFile(path);
        }
        //else
        //{
        //
        //  return Properties.Resources.BG;
        //}
        return null;
      }
    }

    public List<SalesDetails> ItemList { get; set; }
    public SalesMaster()
    {
      ItemList = new List<SalesDetails>();
    }
    public SalesMaster Copy()
    {
      var copy = new SalesMaster { SalesId = SalesId, CustomerName = CustomerName, SalesDate = SalesDate, TotalAmount = TotalAmount, PaidAmount = PaidAmount };
      copy.ItemList.AddRange(ItemList);
      return copy;
    }
  }
}
