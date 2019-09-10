using System.Collections.Generic;

namespace ppedv.MajoDDD.Domain
{
    public class BookStore : Entity
    {
        public string Address { get; set; }
        public virtual HashSet<Inventory> InventoryList { get; set; } = new HashSet<Inventory>();
    }

}
