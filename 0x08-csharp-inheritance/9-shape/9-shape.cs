using System;
/// <summary>
/// Base class Shape
/// </summary>
    class Shape
    {
        public virtual int Area()
        {
            throw new NotImplementedException("Area() is not implemented");
        }
    }
/// <summary>
/// Class Rectangle inherits from Shape
/// </summary>
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
      
    public new int Area()
    {
        return (height * width);
    }

    public override string ToString()
    {
        return ($"[Rectangle] {this.width} / {this.height}");
    }
    
}
/// <summary>
/// Class Sqaure inhertis from Rectangle
/// </summary>
class Square : Rectangle
{
    private int size;
    public int Size {
        get => this.size;
        set {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            else
            {
                this.size = value;
                Width = size;
                Height = size;
            }

        }
    }
    public override string ToString()
    {
        return ($"[Square] {this.size} / {this.size}");
    }
}
