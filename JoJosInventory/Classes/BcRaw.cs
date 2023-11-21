using JoJosInventory.Data;

namespace JoJosInventory.Classes
{
    public class BcRaw
    {
        DbSingleton myDb = DbSingleton.Instance;
        private static BcRaw? instance = null;
        public Base BaseMaterialEdit(int Id, string name, string sku, DateOnly? dueDate, string qty)
        {
            return myDb.BaseMaterialEdit(Id, name, sku, dueDate, qty);
        }

        public Base BaseMaterialAdd(string name, string sku, DateOnly? dueDate, string qty )
        {
            return myDb.BaseMaterialAdd(name,sku,dueDate,qty);
        }
        public Base BaseMaterialDelete(string list)
        {
            return myDb.BaseMaterialDelete(list);
        }
        public Base BaseMaterialSearch(string? category, DateOnly? Duedate, string? SKU)
        {
            return myDb.BaseMaterialSearch(category, Duedate, SKU); 
        }

        private BcRaw()
        {
        }
        public static BcRaw Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BcRaw();
                }
                return instance;
            }
        }
    }
}
