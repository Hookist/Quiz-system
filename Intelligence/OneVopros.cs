using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Intelligence {
  public   class OneVopros {
        DockPanel dockPanel = new DockPanel();
        CheckBox checkBox = new CheckBox();
        Label label = new Label();
        bool check;
        public OneVopros(string Text, bool t) {
            label.Content = Text;
            check = t;
            dockPanel.Children.Add(checkBox);
            dockPanel.Children.Add(label);
        }
        public DockPanel GetElemetDock() {
            return dockPanel;
        }
        public bool GetCheck() {
            return check;
        }
        public bool GetBox() {
         if(checkBox.IsChecked==true) {
                return true;
            } else {
                return false;
            }
        }
    }
}
