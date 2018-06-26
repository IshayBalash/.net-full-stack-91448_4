namespace _03_single_table_in_ef
{
    public partial class Product
    {
        public override string ToString()
        {
            return $"ProductID: {ProductID},ProductName {ProductName}, SupplierID { SupplierID } ,CategoryID { CategoryID },  UnitPrice { UnitPrice }";
        }
        
    }
}
