using Simple_Factory.Interfaces;

namespace Simple_Factory.Models
{
    internal class WoodenWindow : IWindow
    {
        private int Height { get; set; }
        private int Width { get; set; }

        public WoodenWindow(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }

        public int GetHeight()
        {
            return this.Height;
        }
        public int GetWidth()
        {
            return this.Width;
        }
    }
}