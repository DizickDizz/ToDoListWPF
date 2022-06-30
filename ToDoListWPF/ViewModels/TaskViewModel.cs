using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListWPF.Models;

namespace ToDoListWPF.ViewModels
{
    public class TaskViewModel : ViewModelBase
    {
        public readonly ToDo _toDo;
        public string ToDoTask => _toDo.ToDoTask;
        public bool State => _toDo.State;

        public TaskViewModel(ToDo toDo)
        {
            _toDo = toDo;
        }
    }
}
