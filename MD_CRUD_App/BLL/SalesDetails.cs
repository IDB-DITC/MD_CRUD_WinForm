using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD_CRUD_App.BLL
{
  internal class SalesDetails
  {
    public int Sl { get; set; }
    public int SalesId { get; set; }
    public string ItemName { get; set; }
    public byte Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal ItemTotal =>  UnitPrice * Quantity;
  }



}
