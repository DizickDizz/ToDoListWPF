using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListWPF.ViewModels;

namespace ToDoListWPF.Command
{
    internal class EditTaskCommand : CommandBase
    {
        public override void Execute(object? parameter)
        {
            var Task = (TaskViewModel)parameter;
            Task.ToDoTask = "Text";
        }
    }
}
