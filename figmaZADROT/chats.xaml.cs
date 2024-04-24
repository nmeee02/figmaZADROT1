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
using System.Windows.Shapes;

namespace figmaZADROT
{
    /// <summary>
    /// Логика взаимодействия для chats.xaml
    /// </summary>
    public partial class chats : Window
    {
        public chats()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            allthis.Content = new MyProfile();        
        }

        private void ListRazdelov_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
