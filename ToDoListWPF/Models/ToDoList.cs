using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ToDoListWPF.ViewModels;

namespace ToDoListWPF.Models
{
    public class ToDoList
    {
        private readonly ObservableCollection<TaskViewModel> _toDos;
        private readonly string DbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MyData.db");

        public ToDoList()
        {
            _toDos = new ObservableCollection<TaskViewModel>();
            Init();
        }

        public ObservableCollection<TaskViewModel> GetAllToDos => _toDos;

        public void AddNewTask(TaskViewModel toDo)
        {
            _toDos.Add(toDo);
        }
        public void RemoveTask(TaskViewModel toDo)
        {
            _toDos.Remove(toDo);
        }

        public void Init()
        { 
            var db = new SQLiteConnection(DbFilePath);
            db.CreateTable<ToDo>();
        }
        public void Save()
        {
            var db = new SQLiteConnection(DbFilePath);
            db.DeleteAll<ToDo>();

            foreach (var taskViewModel in _toDos)
            {
                ToDo toDo = new ToDo(taskViewModel.ToDoTask, taskViewModel.State);
                db.InsertOrReplace(toDo);
            }
        }
        public void Load()
        {
            var db = new SQLiteConnection(DbFilePath);

            var query = db.Table<ToDo>();
            foreach (var toDo in query.ToList())
            {
                var taskViewModel = new TaskViewModel(toDo);
                AddNewTask(taskViewModel);
            }
        }
    }
}
