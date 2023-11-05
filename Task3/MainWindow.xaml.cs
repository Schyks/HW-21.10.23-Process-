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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Close();
        }
        public MainWindow(string[] args)
        {
            InitializeComponent();

           if (args.Length >= 3)
            {
                double numb1, numb2;
                if (double.TryParse(args[0], out numb1) && double.TryParse(args[1], out numb2))
                {
                    string oper = args[2];
                    double res = 0;
                    switch (oper)
                    {
                        case "+":
                            res = numb1 + numb2;
                            Test.Text = $"{numb1} {oper} {numb2} = {res}";
                            break;
                        case "-":
                            res = numb1 - numb2;
                            Test.Text = $"{numb1} {oper} {numb2} = {res}";
                            break;
                        case "*":
                            res = numb1 * numb2;
                            Test.Text = $"{numb1} {oper} {numb2} = {res}";
                            break;
                        case "/":
                            if (numb2 != 0)
                            {
                                res = numb1 / numb2;
                                Test.Text = $"{numb1} {oper} {numb2} = {res}";
                            }
                            else { Test.Text = "Prohibited action"; }
                            break;
                    }

                }
                else { Test.Text = "Invalid input for number1 or(and) number2"; }
            }

        }
    }
}



