using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListWPF.Models
{
    public class ToDo
    {
        public string ToDoTask { get; }
        public bool State { get; }
        public ToDo(string toDoTask, bool state)
        {
            ToDoTask = toDoTask;
            State = state;
        }
    }
}
