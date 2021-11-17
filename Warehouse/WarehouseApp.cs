using System;

namespace Warehouse
{
    class WarehouseApp
    {
        static void Main(string[] args)
        {
            Box[] warehouse = new Box[5];
            warehouse[0] = new Box(3, 4, 5);
            warehouse[1] = new Box(4, 6, 7);
            warehouse[2] = new Box(1.5f, 4, 6);
            warehouse[3] = new Box(6, 4, 4);
            warehouse[4] = new Box(2, 3.5f, 8);

            float totalVolume = 0;
            int count = 0;

            foreach (Box box in warehouse)
            {
                count++;
                Console.WriteLine("Box " + count +":");
                Console.WriteLine(box.ToString());
                totalVolume += box.Volume();
            }
            
            Console.WriteLine("Total volume of {0} boxes is {1:f2}.", warehouse.Length, totalVolume);
        }
    }
}
