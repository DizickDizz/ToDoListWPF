using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListWPF.Models
{
    public class ToDo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string ToDoTask { get; set; }
        public bool State { get; set; }
        public ToDo(string toDoTask, bool state)
        {
            ToDoTask = toDoTask;
            State = state;
        }
        public ToDo()
        {

        }
    }
}
