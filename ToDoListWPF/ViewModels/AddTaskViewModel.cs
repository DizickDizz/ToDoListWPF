using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoListWPF.Command;
using ToDoListWPF.Models;

namespace ToDoListWPF.ViewModels
{
    public class AddTaskViewModel : ViewModelBase
    {
        private readonly ObservableCollection<TaskViewModel> _toDo;
        private readonly ToDoList _toDoList;

        public IEnumerable<TaskViewModel> ToDos => _toDo;

        private string _toDoTask;
        public string ToDoTask
        {
            get     { return _toDoTask; }
            set { _toDoTask = value; OnPropertyChanged(nameof(ToDoTask)); }
        }

        private bool _state;
        public bool State
        {
            get { return _state; }
            set { _state = value; OnPropertyChanged(nameof(State)); }
        }

        public void UpdateToDoList()
        {
            _toDo.Clear();

            foreach (ToDo toDo in _toDoList.GetAllToDos())
            {
                TaskViewModel taskViewModel = new TaskViewModel(toDo);
                _toDo.Add(taskViewModel);
            }
        }
        public AddTaskViewModel(ToDoList toDoList)
        {
            _toDoList = toDoList;
            _toDo = new ObservableCollection<TaskViewModel>();
            ToDoAddCommand = new ToDoAddCommand(this, toDoList);
            UpdateToDoList();

        }
        public ICommand ToDoAddCommand { get; }


    }
}
