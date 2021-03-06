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
    /// Interaction logic for BioView.xaml
    /// </summary>
    public partial class BioView : UserControl
    {
        public BioViewModel ViewModel
        {
            get { return DataContext as BioViewModel; }
            set { DataContext = value; }
        }

        public BioView()
        {
            InitializeComponent();
        }
    }
}
