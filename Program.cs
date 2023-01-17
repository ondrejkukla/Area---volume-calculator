using System;

namespace calcoulator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // variables & constants

            float a = 0f;
            float b = 0f;
            float diameter = 0f;
            float height = 0f;
            float area = 0f;
            float volume = 0f;
            const float PI = 3.14f;
            string type = "";
            string shape = "";

            // main screen with options
            
            Console.WriteLine("-- Area & Volume calculator --\n");
            Console.WriteLine("Options:\n\nMeasure area of a circle or a rectangle.\nMeasure volume of a cube or a cylinder. \n");
            Console.WriteLine("*Note: Use coma if you want to use a float number.*\n");

            // inputs

            Console.WriteLine("Do you want to measure area or volume?");
            type = Console.ReadLine().ToLower();
            while (type != "area" && type != "volume")
            {
                Console.WriteLine("Please type 'area' or 'volume'? ");
                type = Console.ReadLine().ToLower();    
            }


                // dimensions 2D
            
            if (type == "area")
            {
                System.Console.WriteLine("Do you want to measure a circle or a rectangle?");
                shape = Console.ReadLine().ToLower();
                while (shape != "circle" && shape != "rectangle")
                {
                    Console.WriteLine("Please type 'circle' or 'rectangle'? ");
                    shape = Console.ReadLine().ToLower(); 
                }

                if (shape == "circle")
                {
                    System.Console.WriteLine("What is the diameter? [m]");
                    diameter = Convert.ToSingle(Console.ReadLine());
                }
                else if (shape == "rectangle")
                {
                    System.Console.WriteLine("What is the first dimension? [m]");
                    a = Convert.ToSingle(Console.ReadLine());
                    System.Console.WriteLine("What is the second dimension? [m]");
                    b = Convert.ToSingle(Console.ReadLine());
                }
            }
            
                // dimensions 3D

            else if (type == "volume")
            {
                System.Console.WriteLine("Do you want to measure a cube or a cylinder?");
                shape = Console.ReadLine().ToLower();
                while (shape != "cube" && shape != "cylinder")
                {
                    Console.WriteLine("Please type 'cube' or 'cylinder'? ");
                    type = Console.ReadLine().ToLower(); 
                }

                if (shape == "cube")
                {
                    System.Console.WriteLine("What is the dimension of a side? [m]");
                    a = Convert.ToSingle(Console.ReadLine());
                }
                else if (shape == "cylinder")
                {
                    System.Console.WriteLine("What is the diameter? [m]");
                    diameter = Convert.ToSingle(Console.ReadLine());
                    System.Console.WriteLine("What is the height? [m]");
                    height = Convert.ToSingle(Console.ReadLine());
                }
            }
            
            // recap

            Console.WriteLine("\n---------------------\nYou want to measure " + type + " of a " + shape + ".\n");
            if (a !=0)
            {
                System.Console.WriteLine("Side length is " + a + " [m].");
            }
            
            if (b !=0)
            {
                System.Console.WriteLine("Second side length is " + b + " [m].");
            }            
            if (diameter !=0)
            {
                System.Console.WriteLine("The diameter is " + diameter + " [m].");
            }            
            if (height !=0)
            {
                System.Console.WriteLine("Height of the cylinder is " + height + " [m].");
            }
            System.Console.WriteLine("---------------------\n");

            // calculator

            if (shape == "circle")
            {
                area = Convert.ToSingle((PI * diameter * diameter / 4));
                System.Console.WriteLine("Area of your circle is " + area + " [m^2]. ");
            }
            else if (shape == "rectangle")
            {
                area = Convert.ToSingle(a * b);
                System.Console.WriteLine("Area of your circle is " + area + " [m^2]. ");
            }

            else if (shape == "cube")
            {
                volume = Convert.ToSingle(a * a * a);
                System.Console.WriteLine("Volume of your cube is " + volume + " [m^3]. ");
            }
            else if (shape == "cylinder")
            {
                volume = Convert.ToSingle((PI * diameter * diameter / 4) * height);
                System.Console.WriteLine("Volume of your cube is " + volume + " [m^3]. ");
            }

            Console.ReadKey();
        }
    }
}
