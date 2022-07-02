using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ToDoListWPF.Models;
using ToDoListWPF.ViewModels;

namespace ToDoListWPF.Command
{
    internal class RemoveTaskCommand : CommandBase
    {
        private readonly AddTaskViewModel _addTaskViewModel;
        public readonly ToDoList _toDoTasks;

        public RemoveTaskCommand(ToDoList toDoTasks, AddTaskViewModel addTaskViewModel)
        {
            _toDoTasks = toDoTasks;
            _addTaskViewModel = addTaskViewModel;
        }

        public override void Execute(object? parameter)
        {
            TaskViewModel addTaskViewModel = (TaskViewModel)parameter;
            ToDo toDo = new ToDo(addTaskViewModel.ToDoTask, addTaskViewModel.State);
            _toDoTasks.RemoveTask(toDo);
            _addTaskViewModel.UpdateToDoList();
        }
    }
}
