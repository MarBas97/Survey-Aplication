using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Test1
{
    /// <summary>
    /// Logika interakcji dla klasy App.xaml
    /// </summary>
    public partial class App : Application
    {
        public int Age { get; set; }
        public string Sex { get; set; }
        public int SumSPP { get; set; }
        public int SumSPH { get; set; }
        public int SumRPN { get; set; }
        public Question[] questions { get; set; }
    }
}
