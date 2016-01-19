namespace SizeCalculation
{
    using System;

    public class Size
    {
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        /// <summary>
        /// The GetRotatedSize method calculates the shape's size after a rotation by X degrees
        /// </summary>
        /// <param name="angleOfRotation">The degrees of rotation</param>
        /// <returns>result as a new object of type Size</returns>
        public Size GetRotatedSize(double angleOfRotation)
        {
            double angleSineAbsolute = Math.Abs(Math.Sin(angleOfRotation));
            double angleCosineAbsolute = Math.Abs(Math.Cos(angleOfRotation));
            double rotatedWidth = angleCosineAbsolute * this.Width +
                                    angleSineAbsolute * this.Height;
            double rotatedHeight = angleSineAbsolute * this.Width +
                                    angleCosineAbsolute * this.Height;
            Size sizeAtRotation = new Size(rotatedWidth, rotatedHeight);
            return sizeAtRotation;
        }

        // Added for testing purposes
        public override string ToString()
        {
            return String.Format("Dimensions: width {0:F2}, height {1:F2}", this.Width, this.Height);
        }
    }
}
