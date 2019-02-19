using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private readonly QuestionOperation _operation = null;
        private readonly Question[] questions = null;
        private int licznik = 0;
       
        public Window2()
        {          
            InitializeComponent();       
            _operation = new QuestionOperation();     
            _operation.ClearAnswersFile(); 
            if((App.Current as App).Sex == "Kobieta")
                questions =  _operation.CreateQuestions("TestQuestionsWomen.txt");
            else
                questions = _operation.CreateQuestions("TestQuestionsMen.txt");
            this.ContentHolder.Content = questions[licznik];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!_operation.NotChecked(questions[licznik]))
            { 
                licznik++;
                counter_tb.Text = (licznik+1).ToString() + "/" + "57";
                if(licznik == 56)
                {
                    (App.Current as App).questions = questions;
                    Window3 window3 = new Window3();
                    window3.Show();
                    this.Close();
                }
                else
                    this.ContentHolder.Content = questions[licznik];
            }
            else
            {
                _operation.ShowNotChecked(questions[licznik]);
                MessageBox.Show("Proszę udzielić odpowiedzi na pytanie");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                licznik--;
                questions[licznik].Foreground = Brushes.Black;
                this.ContentHolder.Content = questions[licznik];
                counter_tb.Text = (licznik+1).ToString() + "/" + "57";
            }
            catch(IndexOutOfRangeException )
            {
                licznik++;
                Window1 window1 = new Window1();
                window1.Show();
                this.Close();
            }
        }

        
    }
}
