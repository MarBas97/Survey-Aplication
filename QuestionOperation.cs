using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Media;


namespace Test1
{
    /// <summary>
    /// Class responsible for operation connected with questions
    /// </summary>
    class QuestionOperation
    {

        

        public QuestionOperation()
        {

        }

        /// <summary>
        /// Sums raw value for question with the same type
        /// </summary>
        /// <param name="questions"> Table of all questions on page</param>
        /// <param name="type"> Type of question to sum</param>
        /// <returns> Returns sum </returns>
        public int Sum(Question[] questions, string type)
        {
            int sum = 0;
            for(int i =0;i<questions.Length;i++)
            {

                if(questions[i].Questionclass.Equals(type))
                    sum += questions[i].Questionvalue;
            }
            
            return sum;
        }
        /// <summary>
        /// Checks if all questions has been answered
        /// </summary>
        /// <param name="questions">  Table of all questions on page </param>
        /// <returns></returns>
        public bool NotChecked(Question question)
        {
            bool ifchecked = false;
            if (question.Questionvalue == 0)
            {
                 ifchecked = true;
            }
            return ifchecked;
            
        }

        /// <summary>
        /// Shows all not answered questions
        /// </summary>
        /// <param name="questions"> Table of all questions on page</param>
        public void ShowNotChecked(Question question)
        {

            
                question.Foreground = Brushes.Black;
            
            
                if(question.Questionvalue == 0)
                {
                    question.Foreground = Brushes.Red;
                }
            
            
        }

        /// <summary>
        /// Loading standrads from given path
        /// </summary>
        /// <param name="path"> Path to standards</param>
        /// <returns> 2D table of standards </returns>
        public int[,] LoadStandards(string path)
        {
            int[,] standard = new int[10,2];
            StreamReader sr = new StreamReader(path);
            for(int i = 0;i<10;i++)
            {

                string norm = sr.ReadLine();
                string[] tmptab = norm.Split(' ');
                for(int j =0;j<2;j++)
                {
                    standard[i, j] = int.Parse(tmptab[j]);
                }
                

            }
            return standard;                  
        }

        /// <summary>
        /// Chooses path based on age and sex
        /// </summary>
        /// <param name="age"> Age set by user </param>
        /// <param name="sex"> Sex set by user</param>
        /// <returns> Path to standard </returns>
        public string ChoosePath(int age, string sex)
        {
            string path = "";
            if(sex == "Mężczyzna")
            {
                path = "M-Standards";
            }
            else
            {
                path = "W-Standards";
            }
            if(age>=1 && age <= 19)
            {
                path = path + "\\1";
            }
            else if (age >= 20 && age <= 29)
            {
                path = path + "\\2";
            }
            else if (age >= 30 && age <= 39)
            {
                path = path + "\\3";
            }
            else if (age >= 40 && age <= 49)
            {
                path = path + "\\4";
            }
            else if (age >= 50 && age <= 59)
            {
                path = path + "\\5";
            }
            else if (age >= 60 && age <= 80)
            {
                path = path + "\\6";
            }
            
            return path;
        }

        /// <summary>
        /// Calculating sten values for RPN, SPP and SPH based on
        /// standards and raw values
        /// </summary>
        /// <param name="rpnrawvalue"></param>
        /// <param name="spprawvalue"></param>
        /// <param name="sphrawvalue"></param>
        /// <param name="pathtostandard"></param>
        /// <returns> 3 element table filled with sten values </returns>
        public int[] GetStenValues(int rpnrawvalue, int spprawvalue,int sphrawvalue,string pathtostandard)
        {
            int[] stenvalues = new int[3]; 
            int[,] standardRPN = LoadStandards(pathtostandard+ "\\RPN.txt");
            int[,] standardSPP = LoadStandards(pathtostandard + "\\SPP.txt");
            int[,] standardSPH = LoadStandards(pathtostandard + "\\SPH.txt");

            stenvalues[0] = GetSValue(rpnrawvalue, standardRPN);
            stenvalues[1] = GetSValue(spprawvalue, standardSPP);
            stenvalues[2] = GetSValue(sphrawvalue, standardSPH);

            return stenvalues;

        }

        /// <summary>
        /// Calculating sten values for RPN, SPP and SPH based on
        /// standards and raw values
        /// </summary>
        /// <param name="rawvalue"> Raw value </param>
        /// <param name="standard"> Standard to calculate sten value</param>
        /// <returns> Sten value</returns>
        int GetSValue(int rawvalue,int[,] standard)
        {
            int stenvalue = 0;
            if (rawvalue >= standard[0, 0] && rawvalue <= standard[0, 1])
            {
                stenvalue = 1;
            }
            else if (rawvalue >= standard[1, 0] && rawvalue <= standard[1, 1])
            {
                stenvalue = 2;
            }
            else if (rawvalue >= standard[2, 0] && rawvalue <= standard[2, 1])
            {
                stenvalue = 3;
            }
            else if (rawvalue >= standard[3, 0] && rawvalue <= standard[3, 1])
            {
                stenvalue = 4;
            }
            else if (rawvalue >= standard[4, 0] && rawvalue <= standard[4, 1])
            {
                stenvalue = 5;
            }
            else if (rawvalue >= standard[5, 0] && rawvalue <= standard[5, 1])
            {
                stenvalue = 6;
            }
            else if (rawvalue >= standard[6, 0] && rawvalue <= standard[6, 1])
            {
                stenvalue = 7;
            }
            else if (rawvalue >= standard[7, 0] && rawvalue <= standard[7, 1])
            {
                stenvalue = 8;
            }
            else if (rawvalue >= standard[8, 0] && rawvalue <= standard[8, 1])
            {
                stenvalue = 9;
            }
            else if (rawvalue >= standard[9, 0] && rawvalue <= standard[9, 1])
            {
                stenvalue = 10;
            }
            return stenvalue;
        }

        /// <summary>
        /// Shows result of test to user. It is very likley to shows 
        /// nothing specific if answers were choosen randomly.
        /// </summary>
        /// <param name="spp"> SPP sten value</param>
        /// <param name="sph"> SPH sten value</param>
        /// <param name="rpn"> RPM sten value</param>
        /// <returns>Return string with result, one of four temperaments or alert that test was wrongly filled </returns>
        public string ShowResult(int spp, int sph, int rpn)
        {
            string wynik = "";
            if ((spp > sph) && (rpn > sph))
            {
                wynik = " Holeryk";
            }
            else if ((spp < sph) && (rpn < sph) && (spp < rpn))
            {
                wynik = " Melancholik";
            }
            else if ((spp > sph) && (spp > rpn) && (sph > rpn))
            {
                wynik = " Flegmatyk";
            }
            else if ((spp < sph) && (rpn < sph) && Enumerable.Range(6, 9).Contains(spp) && Enumerable.Range(6, 9).Contains(rpn))
            {
                wynik = " Sangwinik";
            }
            else
                wynik = "Wygląda na to że odpowiedzi zostały wybrane w sposób losowy. Brak możliwości obliczenia wyniku testu";

            return wynik;

        }

        /// <summary>
        /// Writes all questions with answers to .txt file
        /// </summary>
        /// <param name="questions"> Table of all questions of the test</param>
        public void WriteAnswers(Question[] questions)
        {
            StreamWriter sw = new StreamWriter("Answers.txt",true);
            for (int i = 0; i < questions.Length; i++)
            {


                if (questions[i].Answer_1.IsChecked == true)
                {
                    string answer = string.Format("{0} \r\n\r\n Odpowiedź: {1}\r\n", questions[i].Textvalue, questions[i].Answer_1.Content);
                    sw.WriteLine(answer);

                }
                else if (questions[i].Answer_2.IsChecked == true)
                {
                    string answer = string.Format("{0} \r\n\r\n Odpowiedź: {1}\r\n", questions[i].Textvalue, questions[i].Answer_2.Content);
                    sw.WriteLine(answer);
                }
                else if (questions[i].Answer_3.IsChecked == true)
                {
                    string answer = string.Format("{0} \r\n\r\n Odpowiedź: {1}\r\n", questions[i].Textvalue, questions[i].Answer_3.Content);
                    sw.WriteLine(answer);
                }
                else
                {
                    string answer = string.Format("{0} \r\n\r\n Odpowiedź: {1}\r\n", questions[i].Textvalue, questions[i].Answer_4.Content);
                    sw.WriteLine(answer);
                }
            }
            sw.Flush();
            sw.Close();
        }

        /// <summary>
        /// Clears file with questions and answers
        /// </summary>
        public void ClearAnswersFile()
        {
            File.WriteAllText("Answers.txt", string.Empty);
        }

        /// <summary>
        /// Writes result, age and sex to file with questions and answers.
        /// </summary>
        /// <param name="spp">SPP sten value</param>
        /// <param name="sph">SPH sten value</param>
        /// <param name="rpm">RPM sten value</param>
        /// <param name="age">Age set by user</param>
        /// <param name="sex">Sex set by user</param>
        public void WriteResult(int spp, int sph, int rpn, int age, string sex)
        {
            StreamWriter sw = new StreamWriter("Answers.txt", true);
            string result = string.Format("Wartość SPP: {0}\r\nWartość SPH: {1}\r\nWartość RPM: {2}\r\nWiek: {3}\r\nPłeć: {4}", spp,sph,rpn,age,sex);
            sw.WriteLine(result);
            sw.Flush();
            sw.Close();
        }
        public Question[] CreateQuestions(string path)
        {
            int licznik = 1;
            StreamReader sr = new StreamReader(path);
            int tablength = int.Parse(sr.ReadLine());
            Question[] questions = new Question[tablength];
            for(int i = 0;i<tablength;i++)
            {
                questions[i] = new Question();
                string check = sr.ReadLine();
                string[] tmp = check.Split('.');
                while (tmp[0] != licznik.ToString())
                {
                    check = sr.ReadLine();
                    tmp = check.Split('.');
                }

                questions[i].Textvalue = check;
                questions[i].Questiontype = bool.Parse(sr.ReadLine());
                questions[i].Questionclass = sr.ReadLine();
                licznik++;
            }
            sr.Close();
            return questions;
        }
    }
}
