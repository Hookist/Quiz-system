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
        int ball;
        List<OneVopros> Lopros;
        string[] Vop;        
        int count_true;
        int count_now;
        int nowLop = 0;
        public MainWindow() {
            InitializeComponent();
            Lopros = new List<OneVopros>();
            ball = 0;
            count_true = 0;
            count_now = 0;
            String path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            Console.WriteLine(path);
            Vop = File.ReadAllLines(path);
            for (int i = 0; i < Vop.Count(); i++) {
                string[] str = Vop[i].Split(',');
                Lopros.Add(new OneVopros(str[0],Convert.ToBoolean(str[1])));
            }
            
            
            Restart();
        }
        public void Restart() {
            if (nowLop<= Lopros.Count-5) {
                Opros.Children.Clear();
                for (int i = nowLop; i < nowLop + 3; i++) {
                    Opros.Children.Add(Lopros[i].GetElemetDock());
                    nowLop++;
                }
            }
        }
        private void Ok_Vopros(object sender, RoutedEventArgs e) {
            
            for (int i = 0; i < Lopros.Count; i++) {
                if(Lopros[i].GetBox()==Lopros[i].GetCheck()) {
                    count_now++;
                }
            }
            if(count_now== count_true) {
                ball += count_now;
            } else {
                ball -= count_now - count_true;
            }
            Restart();
        }
    }
}
