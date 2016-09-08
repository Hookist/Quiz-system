using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Intelligence.Admin {
   public class CreateMenu {
        StackPanel StackMain;
        Label QuestDescription = new Label();
        TextBox Quest = new TextBox();

        DockPanel dk = new DockPanel();
        Label CountRating = new Label();
        TextBox TextRating = new TextBox();

        List<DockPanel> dock = new List<DockPanel>();        
        List<TextBox> TextOtvet = new List<TextBox>();
        List<Label> Description = new List<Label>();
        List<CheckBox> TruOtvet = new List<CheckBox>();

        

        string str1 = "Текст вопроса";
        string str2 = "Кол-во Балов";
        string str3 = "Правельный ответ";
        string[] answer = new[] {"Ответ один", "Ответ два", "Ответ три", "Ответ четыре", "Ответ пять", "Ответ шесть", "Ответ семь", "Ответ восемь", "Ответ девять", "Ответ десять" };
       public CreateMenu (StackPanel st) {
            StackMain = st;
        }
        public void ChangeQuest(int Count,int Rating,string NameQuest, string[] Answer,bool[] TruAnswer) {
            StackMain.Children.Clear();
            dk.Children.Clear();
            dock.Clear();
            TextOtvet.Clear();
            Description.Clear();
            TruOtvet.Clear();
            Quest.Text = "";
            TextRating.Text = "0";
            StackMain.Children.Add(QuestDescription);
            StackMain.Children.Add(Quest);

            Quest.Text = NameQuest;
            QuestDescription.Content = str1;

            for (int i = 0; i < Count; i++) {
                dock.Add(new DockPanel());
                TextOtvet.Add(new TextBox());
                Description.Add(new Label());
                TruOtvet.Add(new CheckBox());

                StackMain.Children.Add(Description[i]);
                StackMain.Children.Add(dock[i]);

                dock[i].Children.Add(TextOtvet[i]);
                dock[i].Children.Add(TruOtvet[i]);
                Description[i].Content = answer[i];
                TruOtvet[i].Content = str3;
                TextOtvet[i].Width = 350;
                TruOtvet[i].IsChecked = TruAnswer[i];
                TextOtvet[i].Text = Answer[i];
            }
            CountRating.Content = str2;
            TextRating.Width = 50;
            TextRating.Text = Rating.ToString();
            dk.Children.Add(TextRating);
            dk.Children.Add(CountRating);
            StackMain.Children.Add(dk);

            
        }
        public void CreateNew(int Count) {
            StackMain.Children.Clear();
            dk.Children.Clear();
            dock.Clear();
            TextOtvet.Clear();
            Description.Clear();
            TruOtvet.Clear();
            Quest.Text = "";
            TextRating.Text = "0";
            if (Count > 10)
                Count = 10;
            if (Count < 2)
                Count = 2;

            StackMain.Children.Add(QuestDescription);
            StackMain.Children.Add(Quest);

            //Quest.Text = NameQuest;
            QuestDescription.Content = str1;

            for (int i = 0; i < Count; i++) {
                dock.Add(new DockPanel());
                TextOtvet.Add(new TextBox());
                Description.Add(new Label());
                TruOtvet.Add(new CheckBox());

                StackMain.Children.Add(Description[i]);
                StackMain.Children.Add(dock[i]);

                dock[i].Children.Add(TextOtvet[i]);
                dock[i].Children.Add(TruOtvet[i]);
                Description[i].Content = answer[i];
                TruOtvet[i].Content = str3;
                TextOtvet[i].Width = 350;
                
            }
            CountRating.Content = str2;
            TextRating.Width = 50;
            
            dk.Children.Add(TextRating);
            dk.Children.Add(CountRating);
            StackMain.Children.Add(dk);
        }
        public QuestBody GetQuest()
            {
            string[] str1 = new string[Convert.ToInt32(TextOtvet.Count)];
            bool[] bool1 = new bool[Convert.ToInt32(TruOtvet.Count)];
            for (int i = 0; i < str1.Count(); i++) {
                str1[i] = TextOtvet[i].Text;
                if (TruOtvet[i].IsChecked == true)
                    bool1[i] = true;
                else {
                    bool1[i] = false;
                }
            }
            QuestBody quest = new QuestBody(Quest.Text,Convert.ToInt32(TextRating.Text), Convert.ToInt32(TextOtvet.Count), str1, bool1);
            return quest;
            }
    }
}
