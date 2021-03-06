﻿using System;
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
using DigiCard.ViewModels;

namespace DigiCard.Views
{
    /// <summary>
    /// Interaction logic for KataView.xaml
    /// </summary>
    public partial class KataView : UserControl
    {

        public KataViewModel ViewModel
        {
            get { return DataContext as KataViewModel; }
            set { DataContext = value; }
        }

        public KataView()
        {
            InitializeComponent();
        }
    }
}
