using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Box
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double lenght, double width, double height)
        {

            this.Length = lenght;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get { return this.length; }

            private set
            {
                if (value <= 0)
                {
                    throw new AggregateException("Length cannot be zero or negative.");
                }

                length = value;

            }
        }
        public double Width
        {
            get { return this.width; }

            private set
            {
                if (value <= 0)
                {
                    throw new AggregateException("Width cannot be zero or negative.");
                }

                width = value;
            }
        }
        public double Height
        {
            get { return this.height; }

            private set
            {
                if (value <= 0)
                {
                    throw new AggregateException("Height cannot be zero or negative.");
                }
                height = value;
            }
        }
      
        public void GetSurfaceArea()
        {
          
                double sum = (2 * length * width) + (2 * length * height) + (2 * width * height);
                Console.WriteLine($"Surface Area - {sum:f2}");
        }
        public void GetLateralSurfaceArea()
        {
           
                double sum = (2 * length * height) + (2 * width * height);
                Console.WriteLine($"Lateral Surface Area - {sum:f2}");
            
        }
        public void GetVolume()
        {
          
                double sum = length * height * width;
                Console.WriteLine($"Volume - {sum:f2}");
            
        }


    }

}

