﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ToDoListWPF.Models;
using ToDoListWPF.ViewModels;

namespace ToDoListWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ToDoList _toDoList;
        public App()
        {
            _toDoList = new ToDoList(); 
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_toDoList)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }


    }
}
