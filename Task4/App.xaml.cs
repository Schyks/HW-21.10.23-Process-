﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Task4
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
   
        public partial class App : Application
        {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            string[] args = e.Args;
            MainWindow mainWindow = new MainWindow(args);
            mainWindow.Show();
        }
    }
}
