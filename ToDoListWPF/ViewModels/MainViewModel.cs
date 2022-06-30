using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListWPF.Models;

namespace ToDoListWPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel(ToDoList toDolist)
        {
            CurrentViewModel = new AddTaskViewModel(toDolist);
        }
    }
}
