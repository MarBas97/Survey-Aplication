using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Test1
{
    /// <summary>
    /// Logika interakcji dla klasy Question.xaml
    /// </summary>
    public partial class Question : UserControl
    {
        #region       
        public static readonly DependencyProperty QuestiontypeProperty = DependencyProperty.Register("Questiontype", typeof(bool), typeof(Question), new PropertyMetadata(null));
        public static readonly DependencyProperty QuestionvalueProperty = DependencyProperty.Register("Questionvalue", typeof(int), typeof(Question), new PropertyMetadata(null));
        public static readonly DependencyProperty QuestionclassProperty = DependencyProperty.Register("Questionclass", typeof(string), typeof(Question));
        #endregion
       
        public string Textvalue
        {
            get
            {

                return textblock.Text;

            }
            set
            {
                textblock.Text = value;
            }
        }

        public bool Questiontype
        {
            get
            {

                return (bool)GetValue(QuestiontypeProperty);

            }
            set
            {
                SetValue(QuestiontypeProperty, value);
            }
        }

        public int Questionvalue
        {
            get
            {

                return (int)GetValue(QuestionvalueProperty);

            }
            set
            {
                SetValue(QuestionvalueProperty, value);
            }
        }

        public string Questionclass
        {
            get
            {

                return (string)GetValue(QuestionclassProperty);

            }
            set
            {
                SetValue(QuestionclassProperty, value);
            }
        }

        public Question()
        {
            InitializeComponent();
            
        }

       

        

        private void Answer_1_Checked(object sender, RoutedEventArgs e)
        {
            if (Questiontype)
                Questionvalue = 1;
            else
                Questionvalue = 4;
        }

        private void Answer_2_Checked(object sender, RoutedEventArgs e)
        {
            if (Questiontype)
                Questionvalue = 2;
            else
                Questionvalue = 3;
        }

        private void Answer_3_Checked(object sender, RoutedEventArgs e)
        {
            if (Questiontype)
                Questionvalue = 3;
            else
                Questionvalue = 2;
        }

        private void Answer_4_Checked(object sender, RoutedEventArgs e)
        {
            if (Questiontype)
                Questionvalue = 4;
            else
                Questionvalue = 1;
        }

        
    }
}
