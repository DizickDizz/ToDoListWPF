using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ToDoListWPF.Models;
using ToDoListWPF.ViewModels;

namespace ToDoListWPF.Command
{
    internal class ToDoAddCommand : CommandBase
    {
        private readonly AddTaskViewModel _addTaskViewModel;
        public readonly ToDoList _toDoTasks;

        public ToDoAddCommand(AddTaskViewModel addTaskViewModel, ToDoList toDoTasks)
        {
            _addTaskViewModel = addTaskViewModel;
            _toDoTasks = toDoTasks;
            _addTaskViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }
        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(AddTaskViewModel.ToDoTask))
            {
                OnCanExecutedChanged();
            }
        }
        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_addTaskViewModel.ToDoTask);
        }


        public override void Execute(object? parameter)
        {
            ToDo toDo = new ToDo(_addTaskViewModel.ToDoTask, false);
            TaskViewModel taskViewModel = new TaskViewModel(toDo);
             _toDoTasks.AddNewTask(taskViewModel);
        }
    }
}
