using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ToDoListWPF.Command;
using ToDoListWPF.Models;

namespace ToDoListWPF.ViewModels
{
    public class AddTaskViewModel : ViewModelBase
    {
        private readonly ToDoList _toDo;

        public IEnumerable<TaskViewModel> ToDos => _toDo.GetAllToDos;

        public TaskViewModel _selectedItem { get; set; }
        public TaskViewModel SelectedItem
        {
            get { return _selectedItem; }
            set { _selectedItem = value; OnPropertyChanged(nameof(SelectedItem)); }
        }

        private string _toDoTask;
        public string ToDoTask
        {
            get     { return _toDoTask; }
            set     { _toDoTask = value; OnPropertyChanged(nameof(ToDoTask)); }
        }

        public AddTaskViewModel(ToDoList toDoList)
        {
            _toDo = toDoList;
            ToDoAddCommand = new ToDoAddCommand(this, toDoList);
            RemoveTaskCommand = new RemoveTaskCommand(toDoList,this);
            EditTaskCommand = new EditTaskCommand();

        }
        public ICommand ToDoAddCommand { get; }
        public ICommand RemoveTaskCommand { get; }
        public ICommand EditTaskCommand { get; }
    }
}
