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

namespace figmaZADROT
{
    /// <summary>
    /// Логика взаимодействия для profileFriend.xaml
    /// </summary>
    public partial class profileFriend : Page
    {
        Frame fr;

        public profileFriend()
        {
        }

        public profileFriend(Frame fr)
        {
            InitializeComponent();
        }

        private void closeframe_Click(object sender, RoutedEventArgs e)
        {
            fr.Content = null;
        }
    }
}
