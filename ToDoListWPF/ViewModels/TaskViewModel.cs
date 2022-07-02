using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using ToDoListWPF.Models;

namespace ToDoListWPF.ViewModels
{
    public class TaskViewModel : ViewModelBase
    {
        public readonly ToDo _toDo;
        public string ToDoTask
        {
            get { return _toDo.ToDoTask; }
            set { _toDo.ToDoTask = value; OnPropertyChanged(nameof(ToDoTask)); }
        }
        
        public bool State
        {
            get => _toDo.State;
            set { _toDo.State = value; OnPropertyChanged(nameof(TextStyle)); } 
        }

        public string TextStyle
        {
            get
            {
                if (State)
                    return "Strikethrough";
                else
                    return "";
            }
        }

        public TaskViewModel(ToDo toDo)
        {
            _toDo = toDo;
        }


    }
}
