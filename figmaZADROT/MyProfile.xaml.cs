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

namespace figmaZADROT
{
    /// <summary>
    /// Логика взаимодействия для MyProfile.xaml
    /// </summary>
    public partial class MyProfile : Page
    {
        Frame fr;
        public MyProfile(Frame fr)
        {
            InitializeComponent();
            this.fr = fr;
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }

  

        private void closebt_MouseDown(object sender, RoutedEventArgs e)
        {
            fr.Content=null;
        }
    }
}
