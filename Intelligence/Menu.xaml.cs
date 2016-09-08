using Intelligence.Admin;
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

namespace Intelligence {
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window {
        CreateMenu m;

        public Menu() {
            InitializeComponent();
            m = new CreateMenu(Body);
           // m.ChangeQuest(2, 8, "Kto tyt", new string[] { "111111111111111111", "22222222222222222222", "33333333333333333333", "444444444444444444444","sdffsdsd" }, new bool[] { false, true, false, false,false });
        }

        private void New_Click(object sender, RoutedEventArgs e) {
            m.CreateNew(Convert.ToInt32(NewCount.Text));
        }

        private void Change_Click(object sender, RoutedEventArgs e) {

        }

        private void Dellete_Click(object sender, RoutedEventArgs e) {
            ListQuest.Items.RemoveAt(ListQuest.SelectedIndex);
        }

        private void Add_Click(object sender, RoutedEventArgs e) {
            ListQuest.Items.Add(m.GetQuest().NameQuest);
        }

        private void Return_Click(object sender, RoutedEventArgs e) {
            MainWindow mw = new MainWindow();
            mw.Visibility = Visibility.Visible;
            this.Close();
        }
    }
}
