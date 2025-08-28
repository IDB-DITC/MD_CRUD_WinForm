using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD_CRUD_App.BLL
{
  internal class SalesData
  {
    public int SalesId { get; set; }
    public string CustomerName { get; set; }
    public DateTime SalesDate { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal PaidAmount { get; set; }
    public bool FullPaid { get; set; }
    public string ImageUrl { get; set; }
    public int Sl { get; set; }
    public string ItemName { get; set; }
    public byte Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal ItemTotal => UnitPrice * Quantity;
  }
}
