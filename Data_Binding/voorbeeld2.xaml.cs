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
using System.Windows.Shapes;

namespace Data_Binding
{
    /// <summary>
    /// Interaction logic for voorbeeld2.xaml
    /// </summary>
    public partial class voorbeeld2 : Window
    {
        public voorbeeld2()
        {
            InitializeComponent();
            this.DataContext = this;
        }
       
    }
}

