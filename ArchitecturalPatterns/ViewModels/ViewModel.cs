using ArchitecturalPatterns.Commands;
using ArchitecturalPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ArchitecturalPatterns.ViewModels
{
    public class ViewModel : NotifyPropertyChanged
    {
        private string _text;

        public ViewModel()
        {
            Model = new Model();
            SaveCommand = new Command(() => { Model.Text = Text; RaiseCommandsCanExecuteChanged(); },
                () => !string.IsNullOrWhiteSpace(Text) &&  Model.Text != Text);
            LoadCommand = new Command(() => Text = Model.Text,
                () => Model.Text != Text);
        }

        public Model Model { get; set; }
        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                OnPropertyChanged();

                RaiseCommandsCanExecuteChanged();
            }
        }

        private void RaiseCommandsCanExecuteChanged()
        {
            SaveCommand.RaiseCanExecute();
            LoadCommand.RaiseCanExecute();
        }

        public Command SaveCommand { get; set; }
        public Command LoadCommand { get; set; }
    }
}
