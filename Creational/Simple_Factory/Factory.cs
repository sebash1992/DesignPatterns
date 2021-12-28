using Simple_Factory.Interfaces;
using Simple_Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory
{
    /*
     * Simple Factory Pattern: returns an instance of one of several possible classes depending on the type of data provided. 
     * It is quite common to return a common parent class and common methods, but each may perform a task differently or optimise for different data or behaviours.
     * When to Use?
        When creating an object is not just a few assignments and involves some logic, it makes sense to put it in a dedicated factory instead of repeating the same code everywhere.
     */
    public static class Factory
    {
        public static IWindow MakeWindow(int height, int width)
        {
            return new WoodenWindow(height, width);
        }
    }
}
