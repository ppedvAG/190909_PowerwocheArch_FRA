namespace ppedv.MajoDDD.Domain
{
    public class Inventory : Entity
    {
        public virtual Book Book { get; set; }
        public int Amount { get; set; }
    }

}
