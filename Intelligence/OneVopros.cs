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
      //  DockPanel dockPanel = new DockPanel();       
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
                checkBox.Add(new CheckBox());
                check.Add(otv[i]);
                stakPanel.Children.Add(checkBox.Last());
                stakPanel.Children.Add(textVop.Last());
            }
//stakPanel.Children.Add(dockPanel);

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
