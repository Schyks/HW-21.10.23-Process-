using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace HW_21._10._23_Process_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
       int pid = 0;
        public MainWindow()
        {
            InitializeComponent();
            Stop.IsEnabled = false;
        }
            
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Text1.Text = "Start";
            Process pr = new Process();
            pr.StartInfo = new ProcessStartInfo("calc.exe");
            pr.Start();
            pr.WaitForExit();
            Text1.Text = "The program ended with the code - " + pr.ExitCode.ToString();
        }

        private void Start1_Click(object sender, RoutedEventArgs e)
        {
            Text1.Text = "Start";
            Process pr = new Process();
            pr.StartInfo = new ProcessStartInfo("notepad.exe");
            pr.Start();
            pid = pr.Id;
            Start1.IsEnabled = false;
            Stop.IsEnabled = true;
        }
        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            if (pid != 0)
            {
                Process np = Process.GetProcessById(pid);
                np.Kill();
                Start1.IsEnabled = true;
                Stop.IsEnabled = false;
            }
        }
        private void Numb1_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Numb1.Text == "Number 1")
            {
                Numb1.Text = string.Empty;
            }
        }

        private void Numb1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Numb1.Text))
            {
                Numb1.Text = "Number 1";
            }
        }

        private void Numb2_GotFocus(object sender, RoutedEventArgs e)
        {

            if (Numb2.Text == "Number 2")
            {
                Numb2.Text = string.Empty;
            }
        }

        private void Numb2_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Numb2.Text))
            {
                Numb2.Text = "Number 2";
            }
        }

        private void Operation_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!"+-/*".Contains(e.Text))
            {
                e.Handled = true;
            }
        }
        private void Operation_GotFocus(object sender, RoutedEventArgs e)
        {

            if (Operation.Text == "Operation")
            {
                Operation.Text = string.Empty;
            }
        }

        private void Operation_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Operation.Text))
            {
                Operation.Text = "Operation";
            }
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            Process pr = new Process();
            pr.StartInfo.FileName = @"C:\Users\Schyks\source\repos\HW-21.10.23(Process)\Task3\bin\Debug\net7.0-windows\Task3.exe";
            pr.StartInfo.Arguments = $"{Numb1.Text} {Numb2.Text} {Operation.Text}";
            pr.Start();
            pr.WaitForExit();
        }

        private void Path_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Path.Text == "Path")
            {
                Path.Text = string.Empty;
            }
        }
        
        private void Word_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Word.Text))
            {
                Word.Text = "Word";
            }
        }
        private void Word_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Word.Text == "Word")
            {
                Word.Text = string.Empty;
            }
        }
        private void Path_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Path.Text))
            {
                Path.Text = "Path";
            }
        }


        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Process pr = new Process();
            pr.StartInfo.FileName = @"C:\Users\Schyks\source\repos\HW-21.10.23(Process)\Task4\bin\Debug\net7.0-windows\Task4.exe";
            pr.StartInfo.Arguments = $"{Path.Text} {Word.Text}";
            pr.Start();
            pr.WaitForExit();
        }
    }
}
