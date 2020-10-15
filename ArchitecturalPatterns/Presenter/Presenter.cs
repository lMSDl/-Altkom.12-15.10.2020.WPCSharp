using ArchitecturalPatterns.Models;
using ArchitecturalPatterns.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturalPatterns.Presenter
{
    public class Presenter : IPresenter
    {
        private IMvpView _view;
        private Model _model;

        public Presenter(IMvpView view)
        {
            _view = view;
            _model = new Model();
        }

        public void Load()
        {
            _view.Load(_model.Text);
        }

        public void Save(string value)
        {
            _model.Text = value;
            _view.Display(value);
        }
    }
}
