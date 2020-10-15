﻿using ArchitecturalPatterns.Models;
using ArchitecturalPatterns.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ArchitecturalPatterns.Views
{
    /// <summary>
    /// Interaction logic for MvpView.xaml
    /// </summary>
    public partial class MvpView : Page, IMvpView
    {
        private IPresenter _presenter;

        public MvpView()
        {
            InitializeComponent();
            _presenter = new Presenter.Presenter(this);
        }

        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {
            _presenter.Save(TextBox_Input.Text);
        }

        private void Button_Click_Load(object sender, RoutedEventArgs e)
        {
            _presenter.Load();
        }

        public void Load(string value)
        {
            TextBox_Input.Text = value;
        }

        public void Display(string value)
        {
            Label_Text.Content = value;
        }
    }
}
