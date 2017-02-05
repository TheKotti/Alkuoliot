using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class InvoiceItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total
        {
            get { return Price * Quantity; }
        }

        public override string ToString()
        {
            return Name + "\t" + Price + "e\t" + Quantity + "kpl\tTotal: " + Total;
        }
    }
    public class Invoice
    {
        private double total = 0;
        public string Customer { get; set; }
        private List<InvoiceItem> items;
        public List<InvoiceItem> ItemList
        {
            get { return items; }
        }
        public Invoice()
        {
            items = new List<InvoiceItem>();
        }
        public void AddItem(InvoiceItem item)
        {
            items.Add(item);
        }

        public double CountTotal()
        {
            for (int i = 0; i < items.Count; i++)
            {
                total = total + items[i].Total;
            }
            return total;
        }
    }
}
