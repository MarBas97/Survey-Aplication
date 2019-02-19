using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Test1
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        QuestionOperation _operation;
        private readonly int Age_dept = 0;
        private readonly string Sex_dept = null;

        public Window3()
        {
            InitializeComponent();
            _operation = new QuestionOperation();
            (App.Current as App).SumRPN = _operation.Sum((App.Current as App).questions, "RPN");
            (App.Current as App).SumSPH = _operation.Sum((App.Current as App).questions, "SPH");
            (App.Current as App).SumSPP = _operation.Sum((App.Current as App).questions, "SPP");

            Age_dept = (App.Current as App).Age;
            Sex_dept = (App.Current as App).Sex;

            int rpmResult = (App.Current as App).SumRPN;
            int sppResult = (App.Current as App).SumSPP;
            int sphResult = (App.Current as App).SumSPH;

            string path = _operation.ChoosePath(Age_dept, Sex_dept);
            int[] result = _operation.GetStenValues(rpmResult, sppResult, sphResult, path);

            Wynik.Text += _operation.ShowResult(result[1], result[2], result[0]);
            _operation.WriteAnswers((App.Current as App).questions);
            _operation.WriteResult(result[1], result[2], result[0], Age_dept, Sex_dept);
        }
    }
}
