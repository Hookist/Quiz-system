using System;
using System.Collections.Generic;
using System.IO;
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

namespace Intelligence {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        Global global;
        bool end = false;
        public MainWindow() {
            InitializeComponent();
            global = new Global(Opros);
            global.addVopros(new OneVopros(4,0, "Kto tyt", new string[] { "111111111111111111", "22222222222222222222", "33333333333333333333", "444444444444444444444" }, new bool[] { false, true, false, false }));
            global.addVopros(new OneVopros(2,1, "Kto tam", new string[] { "1", "2", "3", "4" }, new bool[] { true, false, false, false }));
            global.addVopros(new OneVopros(6,2, "Kto snizu", new string[] { "1", "2", "3", "4" }, new bool[] { false, false, true, false }));
            global.Start();
            CountQuest.Content = global.GetNow() + "/" + global.GetCount();
            TrueQuests.Content = global.GetTrue() + "/" + global.GetNow();
        }
        public void End() {
            Opros.Children.Add(new Label() {Content="Вы ответили на "+ global.GetCount()+" вопросов" });
            Opros.Children.Add(new Label() { Content = "Вы ответили правильно на " + global.GetTrue() + " вопросов" });
            Opros.Children.Add(new Label() { Content = "Вы получили балов " + global.GetNowBal()+"/" + global.GetMaxBall() });
        }
        private void Ok_Vopros(object sender, RoutedEventArgs e) {
            global.StartOtvet();
            CountQuest.Content = global.GetNow() + "/" + global.GetCount(); 
            TrueQuests.Content = global.GetTrue() + "/" + global.GetNow();

            if (global.IsEnd() == true && end == false) {
                End();
                end = true;
            }

        }
    }
}
