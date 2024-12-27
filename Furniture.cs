using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    internal class Furniture
    {
        public string Material;
        public double Price;

        public Furniture(String material, double price)
        {
            Material = material;
            Price = price;
        }

        public void displayFurnitureDetails()
        {
            Console.WriteLine("Material: " + Material);
            Console.WriteLine("Price: " + Price);
        }
    }

    internal class Table : Furniture
    {
        public double Height;
        public double Surface_Area;

        public Table(string material, double price, double height, double surface_Area) : base(material, price)
        {
            Height = height;
            Surface_Area = surface_Area;
        }

        public void DisplayTableDetails()
        {
            displayFurnitureDetails();
            Console.WriteLine("Height: " + Height);
            Console.WriteLine("Surface Area:  " + Surface_Area);
        }
    }
}
