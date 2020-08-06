using System;

    class Shape
    {
        public virtual int Area()
        {
            throw new NotImplementedException("Area() is not implemented");
        }
    }

    class Rectangle : Shape
    {
        private int width;
        private int height;
        public int Width {
            get => this.width;
            set { 
                if (value < 0)
                    throw new ArgumentException("Width must be greater than or equal to 0");
                else
                    this.width = value;
            }
        }
        public int Height {
            get => this.height;
            set { 
                if (value < 0)
                    throw new ArgumentException("Height must be greater than or equal to 0");
                else
                    this.height = value;
            }
        }
    }

