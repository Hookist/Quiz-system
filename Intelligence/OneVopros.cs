using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Intelligence {
  public   class OneVopros {
        StackPanel stakPanel = new StackPanel();
        Label Quest = new Label();
       List< DockPanel> dockPanel = new List<DockPanel>();       
        List<CheckBox> checkBox = new List<CheckBox>();
        List<Label> textVop = new List<Label>();
        int idQuest = 0;
        List<bool> check = new List<bool>();
        int Ball = 1;
        public OneVopros(int ball,int id,string quest, string[] vop, bool[] otv) {
            Ball = ball;
            idQuest = id;
            Quest.Content = id.ToString() + ". " + quest;
            stakPanel.Children.Add(Quest);
            for (int i = 0; i < vop.Count(); i++) {
                textVop.Add(new Label() { Content = vop[i]} );
                textVop[i].HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                textVop[i].VerticalAlignment = System.Windows.VerticalAlignment.Top;
                textVop[i].Padding = new System.Windows.Thickness(10,0,0,0);
                checkBox.Add(new CheckBox());
                checkBox[i].Height = 30;
                check.Add(otv[i]);
                dockPanel.Add(new DockPanel());
                dockPanel[i].HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                dockPanel[i].VerticalAlignment = System.Windows.VerticalAlignment.Top;
                

                dockPanel[i].Children.Add(checkBox.Last());
                dockPanel[i].Children.Add(textVop.Last());
                stakPanel.Children.Add(dockPanel[i]);
            }


        }
        public StackPanel GetElemetStack() {
            return stakPanel;
        }
        public bool GetCheck() {
            bool b = false;
            for (int i = 0; i < checkBox.Count; i++) {
                if(checkBox[i].IsChecked==true && check[i]==false) {
                    return false;
                }
                if(checkBox[i].IsChecked == false && check[i] == true) {
                    return false;
                } else {
                    b = true;
                }
            }
            return b;
        }
        public int GetBall() {
            return Ball;
        }
    }
}
