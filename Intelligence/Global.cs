using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Intelligence {
   public class Global {
        List<OneVopros> ListVopros = new List<OneVopros>();
        int countVopros; // Сколько вопросов
        int NowVopros; // Сколько вопросов отвечено
        int TrueVopros; // Сколько вопросов отвечено правильно
        int NowId; // Текущий вопрос
        int nowBall;
        int MaxBall;
        List<bool> TrueIdVopros = new List<bool>();
        bool isEnd = false;
        StackPanel MainStack;
        public Global(StackPanel main) {
            MainStack = main;
            countVopros = 0;
            NowVopros = 0;
            TrueVopros = 0;
            NowId = 0;
            nowBall = 0;
            MaxBall = 0;
        }
        public void Start() {
            MainStack.Children.Clear();
            MainStack.Children.Add(ListVopros[NowVopros].GetElemetStack());
        }
        void restart() {
            countVopros = ListVopros.Count;
            MaxBall = 0;
            foreach (var item in ListVopros) {
                MaxBall += item.GetBall();
            }
        }
        public void addVopros(OneVopros vop) {
            ListVopros.Add(vop);
            restart();
        }
        public void StartOtvet() {
            if (countVopros > NowId) {
                MainStack.Children.Clear();
                bool otvet = ListVopros[NowVopros].GetCheck();
                TrueIdVopros.Add(otvet);
                if (otvet == true) {
                    TrueVopros++;
                    nowBall += ListVopros[NowVopros].GetBall();
                }
                NowVopros++;
                NowId++;
                
                if (countVopros == NowId) {
                    End();
                } else {
                   MainStack.Children.Add(ListVopros[NowVopros].GetElemetStack());
                }
            }
        }
        void End() {
            MainStack.Children.Clear();
            isEnd = true;
        }
        public bool IsEnd() {
            return isEnd;
        }
        public int GetId() {
            return NowId;
        }
        public int GetCount() {
            return countVopros;
        }
        public int GetNow() {
            return NowVopros;
        }
        public int GetTrue() {
            return TrueVopros;
        }
        public int GetNowBal() {
            return nowBall;
        }
        public int GetMaxBall() {
            return MaxBall;
        }
    }
}
