using Simple_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory.Models
{
    internal class SilverWindow : IWindow
    {
        private int Height { get; set; }
        private int Width { get; set; }

        public SilverWindow(int height, int width)
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