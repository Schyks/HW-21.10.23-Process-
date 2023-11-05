using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Task4
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

            if (args.Length >= 2)
            {
                string path = args[0];
                string word = args[1];
                if (File.Exists(path))
                {
                    string fileContent = File.ReadAllText(path);
                    int count = Regex.Matches(fileContent, @"\b" + word + @"\b", RegexOptions.IgnoreCase).Count;
                    Test1.Text = ($"Слово '{word}' зустрiчається в файлi {count} разiв.");
                }
                else { Test1.Text = ("Файл не знайдено."); }
            }
        }
    }
}
