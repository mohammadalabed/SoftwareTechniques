internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        ModifyProductsByReference();
    }
    class Product
    {
        public Product(string name, int newID)
        {
            ItemName = name;
            ItemID = newID;
        }

        public string ItemName { get; set; }
        public int ItemID { get; set; }
    }

    private static void ChangeByReference(ref Product itemRef)
    {
        // Change the address that is stored in the itemRef parameter.
        itemRef = new Product("Stapler", 12345);
        //itemRef.ItemID = 5;
        //itemRef.ItemName = "NewItem";
    }

    private static void ModifyProductsByReference()
    {
        // Declare an instance of Product and display its initial values.
        Product item = new Product("Fasteners", 54321);
        System.Console.WriteLine("Original values in Main.  Name: {0}, ID: {1}\n",
            item.ItemName, item.ItemID);

        // Pass the product instance to ChangeByReference.
        ChangeByReference(ref item);
        System.Console.WriteLine("Calling method.  Name: {0}, ID: {1}\n",
            item.ItemName, item.ItemID);
    }

    // This method displays the following output:
    // Original values in Main.  Name: Fasteners, ID: 54321
    // Calling method.  Name: Stapler, ID: 12345
}
