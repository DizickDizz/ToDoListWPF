using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ToDoListWPF.Models
{
    public class ToDoList
    {
        public readonly List<ToDo> _toDos;

        public ToDoList()
        {
            _toDos = new List<ToDo>();
        }

        public IEnumerable<ToDo> GetAllToDos()
        {
            return _toDos;
        }

        public void AddNewTask(ToDo toDo)
        {
            _toDos.Add(toDo);
        }
        public void RemoveTask(ToDo toDo)
        {
            var needsToBeDeleted = _toDos.FirstOrDefault(t => t.ToDoTask == toDo.ToDoTask);
            _toDos.Remove(needsToBeDeleted);
        }
    }
}
