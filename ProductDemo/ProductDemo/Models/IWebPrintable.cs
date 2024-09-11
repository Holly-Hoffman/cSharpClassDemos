using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDemo.Models
{
    public interface IWebPrintable
    {
        //This method will print consistent-looking web content
        public abstract void PrintToWeb();
    }
}
