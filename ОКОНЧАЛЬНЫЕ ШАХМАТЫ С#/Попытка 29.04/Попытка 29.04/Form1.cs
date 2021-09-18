using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Попытка_29._04
{
    public partial class Form1 : Form
    {
        public static Kletka[,] Pole = new Kletka[8, 8];
        public int ech = 0;
        public static int n1 = 1;

        int m, s;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = false;
            m = 59;
            s = 59;
        }


        public static T DeepCopy<T>(T other)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(ms, other);
                ms.Position = 0;
                return (T)formatter.Deserialize(ms);
            }
        }
        

        delegate void UI();

        class Event  //СОБЫТИЕ
        {
            // Объявляем событие
            public event UI whiteWin;
            public event UI blackWin;
            // Используем метод для запуска события
            public void OnBlackEvent()
            {
                blackWin();
            }
            public void OnWhiteEvent()
            {
                whiteWin();
            }
        }

        public void Handler3()   //
        {
            int x = n1 * 40;
            int y = n1 * 40;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Pole[i, j] = new Kletka(n1 * x, n1 * y, i, j);
                    x += n1 * 80;
                }
                x = n1 * 40;
                y += n1 * 80;
            }

            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            zapolnPole(g);

            Pole[0, 0] = new Tower(Pole[0, 0].GetX(), Pole[0, 0].GetY(), 1, 0, 0);
            Pole[0, 1] = new Horse(Pole[0, 1].GetX(), Pole[0, 1].GetY(), 1, 0, 1);
            Pole[0, 2] = new Elephant(Pole[0, 2].GetX(), Pole[0, 2].GetY(), 1, 0, 2);
            Pole[0, 3] = new Queen(Pole[0, 3].GetX(), Pole[0, 3].GetY(), 1, 0, 3);
            Pole[0, 4] = new King(Pole[0, 4].GetX(), Pole[0, 4].GetY(), 1, 0, 4);
            Pole[0, 5] = new Elephant(Pole[0, 5].GetX(), Pole[0, 5].GetY(), 1, 0, 5);
            Pole[0, 6] = new Horse(Pole[0, 6].GetX(), Pole[0, 6].GetY(), 1, 0, 6);
            Pole[0, 7] = new Tower(Pole[0, 7].GetX(), Pole[0, 7].GetY(), 1, 0, 7);

            for (int i = 0; i < 8; i++)
                Pole[1, i] = new Pawn(Pole[1, i].GetX(), Pole[1, i].GetY(), 1, 0, 1, i);
            for (int i = 0; i < 8; i++)
                Pole[6, i] = new Pawn(Pole[6, i].GetX(), Pole[6, i].GetY(), 0, 0, 6, i);

            Pole[7, 0] = new Tower(Pole[7, 0].GetX(), Pole[7, 0].GetY(), 0, 7, 0);
            Pole[7, 1] = new Horse(Pole[7, 1].GetX(), Pole[7, 1].GetY(), 0, 7, 1);
            Pole[7, 2] = new Elephant(Pole[7, 2].GetX(), Pole[7, 2].GetY(), 0, 7, 2);
            Pole[7, 3] = new Queen(Pole[7, 3].GetX(), Pole[7, 3].GetY(), 0, 7, 3);
            Pole[7, 4] = new King(Pole[7, 4].GetX(), Pole[7, 4].GetY(), 0, 7, 4);
            Pole[7, 5] = new Elephant(Pole[7, 5].GetX(), Pole[7, 5].GetY(), 0, 7, 5);
            Pole[7, 6] = new Horse(Pole[7, 6].GetX(), Pole[7, 6].GetY(), 0, 7, 6);
            Pole[7, 7] = new Tower(Pole[7, 7].GetX(), Pole[7, 7].GetY(), 0, 7, 7);

            zapolnPole(g);

        }
      

        [Serializable]
        public class Kletka  // класс клетки на поле
        {
            protected int pi; // координаты на поле 
            protected int pj; // координаты на поле 
            protected int x; // координата х
            protected int y; // координата у
            protected int CheChe; // есть ли шахмата
            protected int fenemy;
            public Kletka(int x, int y, int i, int j)
            {
                this.x = x;
                this.y = y;
                this.pi = i;
                this.pj = j;
            }

            virtual public int movechek(int x, int y, int curi, int curj, Graphics g)
            {
                return 1;
            }
            virtual public int eatchek(int x, int y, int curi, int curj, Graphics g)
            {
                return 1;
            }
            virtual public int Chechek()
            {
                return 0;
            }
            public int GetX()
            {
                return this.x;
            }
            public int GetY()
            {
                return this.y;
            }
            public int GetEnemy()
            {
                return this.fenemy;
            }
            public void setij(int i, int j)
            {
                this.pi = i;
                this.pj = j;
            }

            public void chekall(Graphics g, Kletka[,] field)
            {
                Kletka buf = DeepCopy(this);
                for (int i = 0; i < 8; i++)
                    for (int j = 0; j < 8; j++)
                    {
                        if (buf.movechek(field[i, j].GetX(), field[i, j].GetY(), i, j, g) != 0 && field[i, j].Chechek() == 0)
                            field[i, j].selected(g);
                        else
                            if (buf.eatchek(field[i, j].GetX(), field[i, j].GetY(), i, j, g) != 0 && field[i, j].GetEnemy() != field[pi, pj].GetEnemy() && field[i, j].Chechek() != 0)
                            field[i, j].selected(g);
                    }
            }

            virtual public void Show(Graphics g)
            {

            }

            public void selected(Graphics g)
            {
                Pen GreenPen = new Pen(Color.Green, 3);
                g.DrawRectangle(GreenPen, this.x - n1 * 40, this.y - n1 * 40, n1 * 80, n1 * 80);
            }
            public void Handler1()
            {
                MessageBox.Show("Игра окончена. Белые победили!!");
            }
            public void Handler2()
            {
                MessageBox.Show("Игра окончена. Чёрные победили!!");
            }
        }


        [Serializable]    //наследование ФИГУРЫ от КЛЕТКИ
        class Fugyra : Kletka
        {
            public Fugyra(int x, int y, int fenemy, int i, int j) : base(x, y, i, j)
            {
                this.fenemy = fenemy;
                this.CheChe = 1;

            }
            public override int movechek(int x, int y, int curi, int curj, Graphics g)
            {
                return 1;
            }
            public override int eatchek(int x, int y, int curi, int curj, Graphics g)
            {
                return 1;
            }
            public override void Show(Graphics g)
            {
                SolidBrush mySolidBrush;
                if (this.fenemy == 1) // черные
                {
                    mySolidBrush = new SolidBrush(Color.Black);
                }
                else // белые
                {
                    mySolidBrush = new SolidBrush(Color.White);
                }
                g.FillEllipse(mySolidBrush, this.x - n1 * 40, this.y - n1 * 40, n1 * 80, n1 * 80);
                g.DrawString(Convert.ToString(this.CheChe), new Font("Times New Roman", 14), Brushes.Black, this.x - 10, this.y - 10);
            }
            public override int Chechek()
            {
                return CheChe;
            }
        }


        [Serializable]
        class King : Fugyra        //КОРОЛЬ
        {
            Bitmap b = new Bitmap("Image\\KB.png");
            Bitmap b1 = new Bitmap("Image\\KW.png");

            public King(int x, int y, int fenemy, int i, int j) : base(x, y, fenemy, i, j)
            {
                this.fenemy = fenemy;
                this.CheChe = 2;
                b.MakeTransparent();
            }

            public override int movechek(int x, int y, int curi, int curj, Graphics g)
            {
                if (Math.Abs(this.x - x) < 160 && Math.Abs(this.y - y) < 160)
                    return 1;
                else
                    return 0;
            }

            public override int eatchek(int x, int y, int curi, int curj, Graphics g)
            {
                if (Math.Abs(this.x - x) < 160 && Math.Abs(this.y - y) < 160)
                    return 1;
                else
                    return 0;
            }

            public override void Show(Graphics g)
            {
                if (this.fenemy == 1) // черные
                {
                    g.DrawImage(this.b, this.x - 40, this.y - 40, 80, 80);
                }
                else // белые
                {
                    g.DrawImage(this.b1, this.x - 40, this.y - 40, 80, 80);
                }

            }

            public override int Chechek()
            {
                return CheChe;
            }
        }


        [Serializable]
        class Horse : Fugyra       //КОНЬ
        {
            Bitmap b = new Bitmap("Image\\HB.png");
            Bitmap b1 = new Bitmap("Image\\HW.png");

            public Horse(int x, int y, int fenemy, int i, int j) : base(x, y, fenemy, i, j)
            {
                this.fenemy = fenemy;
                this.CheChe = 3;

            }

            public override int movechek(int x, int y, int curi, int curj, Graphics g)
            {
                if (((Math.Abs(pi - curi) + Math.Abs(pj - curj)) == 3) && (Math.Abs(pi - curi) != 0) && (Math.Abs(pj - curj) != 0))
                    return 1;
                else
                    return 0;

            }

            public override int eatchek(int x, int y, int curi, int curj, Graphics g)
            {
                if (((Math.Abs(pi - curi) + Math.Abs(pj - curj)) == 3) && (Math.Abs(pi - curi) != 0) && (Math.Abs(pj - curj) != 0))
                    return 1;
                else
                    return 0;
            }

            public override void Show(Graphics g)
            {
                if (this.fenemy == 1) // черные
                {
                    g.DrawImage(this.b, this.x - 40, this.y - 40, 80, 80);
                }
                else // белые
                {
                    g.DrawImage(this.b1, this.x - 40, this.y - 40, 80, 80);
                }
            }

            public override int Chechek()
            {
                return CheChe;
            }
        }


        [Serializable]
        class Queen : Fugyra         //КОРОЛЕВА
        {
            Bitmap b = new Bitmap("Image\\QB.png");
            Bitmap b1 = new Bitmap("Image\\QW.png");

            public Queen(int x, int y, int fenemy, int i, int j) : base(x, y, fenemy, i, j)
            {
                this.fenemy = fenemy;
                this.CheChe = 6;

            }

            public override int movechek(int x, int y, int curi, int curj, Graphics g)
            {
                if (((Math.Abs(this.x - x) == 0 && Math.Abs(this.y - y) != Math.Abs(this.x - x)) || (Math.Abs(this.y - y) == 0 && Math.Abs(this.y - y) != Math.Abs(this.x - x))) || (Math.Abs(this.x - x) == Math.Abs(this.y - y)))
                {
                    if (pi > curi && pj > curj) // слева сверху
                    {
                        for (int i = pi - 1; i > curi; i--)
                            for (int j = pj - 1; j > curj; j--)
                            {
                                if (i - curi == j - curj)
                                {

                                    if (Pole[i, j].Chechek() != 0)
                                        return 0;
                                }
                            }
                        return 1;
                    }
                    else if (pi < curi && pj > curj) // слева снизу
                    {
                        for (int i = pi + 1; i < curi; i++)
                            for (int j = pj - 1; j > curj; j--)
                            {
                                if (Math.Abs(i - curi) == Math.Abs(j - curj))
                                {

                                    if (Pole[i, j].Chechek() != 0)
                                        return 0;
                                }
                            }
                        return 1;
                    }
                    else if (pi < curi && pj < curj) // справа снизу
                    {
                        for (int i = pi + 1; i < curi; i++)
                            for (int j = pj + 1; j < curj; j++)
                            {
                                if (Math.Abs(i - curi) == Math.Abs(j - curj))
                                {

                                    if (Pole[i, j].Chechek() != 0)
                                        return 0;
                                }
                            }
                        return 1;
                    }
                    else if (pi > curi && pj < curj) // справа снизу
                    {
                        for (int i = pi - 1; i > curi; i--)
                            for (int j = pj + 1; j < curj; j++)
                            {
                                if (Math.Abs(i - curi) == Math.Abs(j - curj))
                                {

                                    if (Pole[i, j].Chechek() != 0)
                                        return 0;
                                }
                            }
                        return 1;
                    }
                    else if ((Math.Abs(this.x - x) == 0 && Math.Abs(this.y - y) != 0))
                    {
                        if (pi > curi)
                        {
                            for (int i = pi - 1; i > curi; i--)
                            {
                                if (Pole[i, pj].Chechek() != 0)
                                    return 0;
                            }
                            return 1;
                        }
                        else
                        {
                            for (int i = pi + 1; i < curi; i++)
                            {

                                if (Pole[i, pj].Chechek() != 0)
                                    return 0;
                            }
                            return 1;
                        }
                    }
                    else
                    {
                        if (pj > curj)
                        {
                            for (int j = pj - 1; j > curj; j--)
                            {

                                if (Pole[pi, j].Chechek() != 0)
                                    return 0;
                            }
                            return 1;
                        }
                        else
                        {
                            for (int j = pj + 1; j < curj; j++)
                            {
                                if (Pole[pi, j].Chechek() != 0)
                                    return 0;
                            }
                            return 1;
                        }
                    }
                }
                else
                    return 0;

            }

            public override int eatchek(int x, int y, int curi, int curj, Graphics g)
            {
                {
                    if (((Math.Abs(this.x - x) == 0 && Math.Abs(this.y - y) != Math.Abs(this.x - x)) || (Math.Abs(this.y - y) == 0 && Math.Abs(this.y - y) != Math.Abs(this.x - x))) || (Math.Abs(this.x - x) == Math.Abs(this.y - y)))
                    {
                        if (pi > curi && pj > curj) // слева сверху
                        {
                            for (int i = pi - 1; i > curi; i--)
                                for (int j = pj - 1; j > curj; j--)
                                {
                                    if (i - curi == j - curj)
                                    {

                                        if (Pole[i, j].Chechek() != 0)
                                            return 0;
                                    }
                                }
                            return 1;
                        }
                        else if (pi < curi && pj > curj) // слева снизу
                        {
                            for (int i = pi + 1; i < curi; i++)
                                for (int j = pj - 1; j > curj; j--)
                                {
                                    if (Math.Abs(i - curi) == Math.Abs(j - curj))
                                    {

                                        if (Pole[i, j].Chechek() != 0)
                                            return 0;
                                    }
                                }
                            return 1;
                        }
                        else if (pi < curi && pj < curj) // справа снизу
                        {
                            for (int i = pi + 1; i < curi; i++)
                                for (int j = pj + 1; j < curj; j++)
                                {
                                    if (Math.Abs(i - curi) == Math.Abs(j - curj))
                                    {

                                        if (Pole[i, j].Chechek() != 0)
                                            return 0;
                                    }
                                }
                            return 1;
                        }
                        else if (pi > curi && pj < curj) // справа снизу
                        {
                            for (int i = pi - 1; i > curi; i--)
                                for (int j = pj + 1; j < curj; j++)
                                {
                                    if (Math.Abs(i - curi) == Math.Abs(j - curj))
                                    {

                                        if (Pole[i, j].Chechek() != 0)
                                            return 0;
                                    }
                                }
                            return 1;
                        }
                        else if ((Math.Abs(this.x - x) == 0 && Math.Abs(this.y - y) != 0))
                        {
                            if (pi > curi)
                            {
                                for (int i = pi - 1; i > curi; i--)
                                {
                                    if (Pole[i, pj].Chechek() != 0)
                                        return 0;
                                }
                                return 1;
                            }
                            else
                            {
                                for (int i = pi + 1; i < curi; i++)
                                {

                                    if (Pole[i, pj].Chechek() != 0)
                                        return 0;
                                }
                                return 1;
                            }
                        }
                        else
                        {
                            if (pj > curj)
                            {
                                for (int j = pj - 1; j > curj; j--)
                                {

                                    if (Pole[pi, j].Chechek() != 0)
                                        return 0;
                                }
                                return 1;
                            }
                            else
                            {
                                for (int j = pj + 1; j < curj; j++)
                                {
                                    if (Pole[pi, j].Chechek() != 0)
                                        return 0;
                                }
                                return 1;
                            }
                        }
                    }
                    else
                        return 0;
                }
            }

            public override void Show(Graphics g)
            {
                if (this.fenemy == 1) // черные
                {
                    g.DrawImage(this.b, this.x - 40, this.y - 40, 80, 80);
                }
                else // белые
                {
                    g.DrawImage(this.b1, this.x - 40, this.y - 40, 80, 80);
                }
            }

            public override int Chechek()
            {
                return CheChe;
            }

        }


        [Serializable]
        class Elephant : Fugyra        //СЛОН
        {
            Bitmap b = new Bitmap("Image\\EB.png");
            Bitmap b1 = new Bitmap("Image\\EW.png");

            public Elephant(int x, int y, int fenemy, int i, int j) : base(x, y, fenemy, i, j)
            {
                this.fenemy = fenemy;
                this.CheChe = 5;

            }

            public override int movechek(int x, int y, int curi, int curj, Graphics g)
            {
                if (Math.Abs(this.x - x) == Math.Abs(this.y - y))
                {
                    if (pi > curi && pj > curj) // слева сверху
                    {
                        for (int i = pi - 1; i > curi; i--)
                            for (int j = pj - 1; j > curj; j--)
                            {
                                if (i - curi == j - curj)
                                {

                                    if (Pole[i, j].Chechek() != 0)
                                        return 0;
                                }
                            }
                        return 1;
                    }
                    else if (pi < curi && pj > curj) // слева снизу
                    {
                        for (int i = pi + 1; i < curi; i++)
                            for (int j = pj - 1; j > curj; j--)
                            {
                                if (Math.Abs(i - curi) == Math.Abs(j - curj))
                                {

                                    if (Pole[i, j].Chechek() != 0)
                                        return 0;
                                }
                            }
                        return 1;
                    }
                    else if (pi < curi && pj < curj) // справа снизу
                    {
                        for (int i = pi + 1; i < curi; i++)
                            for (int j = pj + 1; j < curj; j++)
                            {
                                if (Math.Abs(i - curi) == Math.Abs(j - curj))
                                {

                                    if (Pole[i, j].Chechek() != 0)
                                        return 0;
                                }
                            }
                        return 1;
                    }
                    else if (pi > curi && pj < curj) // справа снизу
                    {
                        for (int i = pi - 1; i > curi; i--)
                            for (int j = pj + 1; j < curj; j++)
                            {
                                if (Math.Abs(i - curi) == Math.Abs(j - curj))
                                {

                                    if (Pole[i, j].Chechek() != 0)
                                        return 0;
                                }
                            }
                        return 1;
                    }
                    else return 0;
                }
                else
                    return 0;
            }

            public override int eatchek(int x, int y, int curi, int curj, Graphics g)
            {
                if (Math.Abs(this.x - x) == Math.Abs(this.y - y))
                {
                    if (pi > curi && pj > curj) // слева сверху
                    {
                        for (int i = pi - 1; i > curi; i--)
                            for (int j = pj - 1; j > curj; j--)
                            {
                                if (i - curi == j - curj)
                                {

                                    if (Pole[i, j].Chechek() != 0)
                                        return 0;
                                }
                            }
                        return 1;
                    }
                    else if (pi < curi && pj > curj) // слева снизу
                    {
                        for (int i = pi + 1; i < curi; i++)
                            for (int j = pj - 1; j > curj; j--)
                            {
                                if (Math.Abs(i - curi) == Math.Abs(j - curj))
                                {

                                    if (Pole[i, j].Chechek() != 0)
                                        return 0;
                                }
                            }
                        return 1;
                    }
                    else if (pi < curi && pj < curj) // справа снизу
                    {
                        for (int i = pi + 1; i < curi; i++)
                            for (int j = pj + 1; j < curj; j++)
                            {
                                if (Math.Abs(i - curi) == Math.Abs(j - curj))
                                {

                                    if (Pole[i, j].Chechek() != 0)
                                        return 0;
                                }
                            }
                        return 1;
                    }
                    else if (pi > curi && pj < curj) // справа снизу
                    {
                        for (int i = pi - 1; i > curi; i--)
                            for (int j = pj + 1; j < curj; j++)
                            {
                                if (Math.Abs(i - curi) == Math.Abs(j - curj))
                                {

                                    if (Pole[i, j].Chechek() != 0)
                                        return 0;
                                }
                            }
                        return 1;
                    }
                    else return 0;
                }
                else
                    return 0;
            }

            public override void Show(Graphics g)
            {
                if (this.fenemy == 1) // черные
                {
                    g.DrawImage(this.b, this.x - 40, this.y - 40, 80, 80);
                }
                else // белые
                {
                    g.DrawImage(this.b1, this.x - 40, this.y - 40, 80, 80);
                }
            }

            public override int Chechek()
            {
                return CheChe;
            }
        }


        [Serializable]
        class Tower : Fugyra      //БАШНИ
        {
            Bitmap b = new Bitmap("Image\\TB.png");
            Bitmap b1 = new Bitmap("Image\\TW.png");

            public Tower(int x, int y, int fenemy, int i, int j) : base(x, y, fenemy, i, j)
            {
                this.fenemy = fenemy;
                this.CheChe = 7;

            }

            public override int movechek(int x, int y, int curi, int curj, Graphics g)
            {

                if ((Math.Abs(this.x - x) == 0 && Math.Abs(this.y - y) != Math.Abs(this.x - x)) || (Math.Abs(this.y - y) == 0 && Math.Abs(this.y - y) != Math.Abs(this.x - x)))
                {
                    if ((Math.Abs(this.x - x) == 0 && Math.Abs(this.y - y) != 0))
                    {
                        if (pi > curi)
                        {
                            for (int i = pi - 1; i > curi; i--)
                            {

                                if (Pole[i, pj].Chechek() != 0)
                                    return 0;
                            }
                            return 1;
                        }
                        else
                        {
                            for (int i = pi + 1; i < curi; i++)
                            {
                                if (Pole[i, pj].Chechek() != 0)
                                    return 0;
                            }
                            return 1;
                        }
                    }
                    else
                    {
                        if (pj > curj)
                        {
                            for (int j = pj - 1; j > curj; j--)
                            {
                                if (Pole[pi, j].Chechek() != 0)
                                    return 0;
                            }
                            return 1;
                        }
                        else
                        {
                            for (int j = pj + 1; j < curj; j++)
                            {
                                if (Pole[pi, j].Chechek() != 0)
                                    return 0;
                            }
                            return 1;
                        }
                    }
                }
                else
                    return 0;
            }

            public override int eatchek(int x, int y, int curi, int curj, Graphics g)
            {
                if ((Math.Abs(this.x - x) == 0 && Math.Abs(this.y - y) != Math.Abs(this.x - x)) || (Math.Abs(this.y - y) == 0 && Math.Abs(this.y - y) != Math.Abs(this.x - x)))
                {
                    if ((Math.Abs(this.x - x) == 0 && Math.Abs(this.y - y) != 0))
                    {
                        if (pi > curi)
                        {
                            for (int i = pi - 1; i > curi; i--)
                            {

                                if (Pole[i, pj].Chechek() != 0)
                                    return 0;
                            }
                            return 1;
                        }
                        else
                        {
                            for (int i = pi + 1; i < curi; i++)
                            {
                                if (Pole[i, pj].Chechek() != 0)
                                    return 0;
                            }
                            return 1;
                        }
                    }
                    else
                    {
                        if (pj > curj)
                        {
                            for (int j = pj - 1; j > curj; j--)
                            {
                                if (Pole[pi, j].Chechek() != 0)
                                    return 0;
                            }
                            return 1;
                        }
                        else
                        {
                            for (int j = pj + 1; j < curj; j++)
                            {
                                if (Pole[pi, j].Chechek() != 0)
                                    return 0;
                            }
                            return 1;
                        }
                    }
                }
                else
                    return 0;
            }

            public override void Show(Graphics g)
            {
                if (this.fenemy == 1) // черные
                {
                    g.DrawImage(this.b, this.x - 40, this.y - 40, 80, 80);
                }
                else // белые
                {
                    g.DrawImage(this.b1, this.x - 40, this.y - 40, 80, 80);
                }
            }

            public override int Chechek()
            {
                return CheChe;
            }
        }


        [Serializable]
        class Pawn : Fugyra       //ПЕШКА
        {
            int first;
            Bitmap b = new Bitmap("Image\\PB.png");
            Bitmap b1 = new Bitmap("Image\\PW.png");

            public Pawn(int x, int y, int fenemy, int first, int i, int j) : base(x, y, fenemy, i, j)
            {
                this.fenemy = fenemy;
                this.CheChe = 4;
                this.first = first; //0
            }

            public override int movechek(int x, int y, int curi, int curj, Graphics g)
            {
                if (this.fenemy == 0)
                {
                    if (this.first == 0 && Pole[pi - 1, pj].Chechek() == 0)
                    {
                        if (Math.Abs(this.y - y) <= 160 && Math.Abs(this.x) == x && this.y > y) // первый ход
                        {
                            this.first = 1;
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else
                    if (Math.Abs(this.y - y) <= 80 && Math.Abs(this.x) == x && this.y > y)
                    {
                        this.first = 1;
                        return 1;
                    }
                    else
                        return 0;
                }
                else
                {
                    if (this.first == 0 && Pole[pi + 1, pj].Chechek() == 0)
                    {
                        if (Math.Abs(this.y - y) <= 160 && Math.Abs(this.x) == x && this.y < y) // первый ход
                        {
                            this.first = 0;
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }

                    }
                    else
                        if (Math.Abs(this.y - y) <= 80 && Math.Abs(this.x) == x && this.y < y)
                    {
                        this.first = 1;
                        return 1;
                    }
                    else
                        return 0;
                }
            }

            public override int eatchek(int x, int y, int curi, int curj, Graphics g)
            {
                if (this.fenemy == 0)
                {
                    {
                        if (((Math.Abs(this.x - x) == Math.Abs(this.y - y)) && Math.Abs(this.x - x) <= 80 && Math.Abs(this.y - y) <= 80) && this.y > y)
                            return 1;
                        else
                            return 0;
                    };
                }
                else
                {
                    {
                        {
                            if (((Math.Abs(this.x - x) == Math.Abs(this.y - y)) && Math.Abs(this.x - x) <= 80 && Math.Abs(this.y - y) <= 80) && this.y < y)
                                return 1;
                            else
                                return 0;
                        };
                    }
                }
            }

            public override void Show(Graphics g)
            {
                if (this.fenemy == 1) // черные
                {
                    g.DrawImage(this.b, this.x - 40, this.y - 40, 80, 80);
                }
                else // белые
                {
                    g.DrawImage(this.b1, this.x - 40, this.y - 40, 80, 80);
                }
            }

            public override int Chechek()
            {
                return CheChe;
            }
        }


        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        public static void zapolnPole(Graphics g)    //рисование и заполнение доски
        {
            Pen myPen = new Pen(Color.Black, 1);
            Pen myPen2 = new Pen(Color.Black, 1);
            SolidBrush mySolidBrush1 = new SolidBrush(Color.DimGray);
            SolidBrush mySolidBrush2 = new SolidBrush(Color.White);

            int first = 0; // рисуем поле
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (first == 0)
                    {
                        if (Pole[i, j].Chechek() == 0)
                        {
                            g.FillRectangle(mySolidBrush1, Pole[i, j].GetX() - 40, Pole[i, j].GetY() - 40, 80, 80);
                        }
                        else
                        {
                            g.FillRectangle(mySolidBrush1, Pole[i, j].GetX() - 40, Pole[i, j].GetY() - 40, 80, 80);
                            Pole[i, j].Show(g);
                        }
                        first = 1;
                    }
                    else
                    {
                        if (Pole[i, j].Chechek() == 0)
                        {
                            g.FillRectangle(mySolidBrush2, Pole[i, j].GetX() - 40, Pole[i, j].GetY() - 40, 80, 80);
                        }
                        else
                        {
                            g.FillRectangle(mySolidBrush2, Pole[i, j].GetX() - 40, Pole[i, j].GetY() - 40, 80, 80);
                            Pole[i, j].Show(g);
                        }
                        first = 0;
                    }
                }
                if (first == 0)
                    first = 1;
                else
                    first = 0;
            }

        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s = 59;
            m = 59;
            минБелых.Text = "59";
            секБелых.Text = "59";
            минЧёрных.Text = "59";
            секЧёрных.Text = "59";
            turn = 0;

            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            int x = n1 * 40;
            int y = n1 * 40;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Pole[i, j] = new Kletka(n1 * x, n1 * y, i, j);
                    x += n1 * 80;
                }
                x = n1 * 40;
                y += n1 * 80;
            }

            Pole[0, 0] = new Tower(Pole[0, 0].GetX(), Pole[0, 0].GetY(), 1, 0, 0);
            Pole[0, 1] = new Horse(Pole[0, 1].GetX(), Pole[0, 1].GetY(), 1, 0, 1);
            Pole[0, 2] = new Elephant(Pole[0, 2].GetX(), Pole[0, 2].GetY(), 1, 0, 2);
            Pole[0, 3] = new Queen(Pole[0, 3].GetX(), Pole[0, 3].GetY(), 1, 0, 3);
            Pole[0, 4] = new King(Pole[0, 4].GetX(), Pole[0, 4].GetY(), 1, 0, 4);
            Pole[0, 5] = new Elephant(Pole[0, 5].GetX(), Pole[0, 5].GetY(), 1, 0, 5);
            Pole[0, 6] = new Horse(Pole[0, 6].GetX(), Pole[0, 6].GetY(), 1, 0, 6);
            Pole[0, 7] = new Tower(Pole[0, 7].GetX(), Pole[0, 7].GetY(), 1, 0, 7);

            for (int i = 0; i < 8; i++)
                Pole[1, i] = new Pawn(Pole[1, i].GetX(), Pole[1, i].GetY(), 1, 0, 1, i);
            for (int i = 0; i < 8; i++)
                Pole[6, i] = new Pawn(Pole[6, i].GetX(), Pole[6, i].GetY(), 0, 0, 6, i);

            Pole[7, 0] = new Tower(Pole[7, 0].GetX(), Pole[7, 0].GetY(), 0, 7, 0);
            Pole[7, 1] = new Horse(Pole[7, 1].GetX(), Pole[7, 1].GetY(), 0, 7, 1);
            Pole[7, 2] = new Elephant(Pole[7, 2].GetX(), Pole[7, 2].GetY(), 0, 7, 2);
            Pole[7, 3] = new Queen(Pole[7, 3].GetX(), Pole[7, 3].GetY(), 0, 7, 3);
            Pole[7, 4] = new King(Pole[7, 4].GetX(), Pole[7, 4].GetY(), 0, 7, 4);
            Pole[7, 5] = new Elephant(Pole[7, 5].GetX(), Pole[7, 5].GetY(), 0, 7, 5);
            Pole[7, 6] = new Horse(Pole[7, 6].GetX(), Pole[7, 6].GetY(), 0, 7, 6);
            Pole[7, 7] = new Tower(Pole[7, 7].GetX(), Pole[7, 7].GetY(), 0, 7, 7);

            zapolnPole(g);
        }


        int selectedI = -1;
        int selectedJ = -1;
        int turn = 0;


        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            Event my = new Event();
            my.whiteWin += Pole[0, 0].Handler1;  //для сообщения 
            my.whiteWin += Handler3;
            my.blackWin += Pole[0, 0].Handler2;  //для сообщения 
            my.blackWin += Handler3;
            if (e.Button == MouseButtons.Left) // ищем фигуру на поле
            {
                int x = 0;
                int y = 0;
                int curci = 0;
                int curcj = 0;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (e.X > x && e.X < x + n1 * 80 && e.Y > y && e.Y < y + n1 * 80)
                        {
                            curci = i;
                            curcj = j;
                            break;
                        }
                        x += n1 * 80;
                    }
                    x = 0;
                    y += n1 * 80;
                }

                Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
                Pen myPen = new Pen(Color.Black, 1);
                if (selectedI == -1 && selectedJ == -1) // фигура не выбрана
                {
                    if (Pole[curci, curcj].Chechek() != 0 && Pole[curci, curcj].GetEnemy() == turn) // выбрать фи
                    {
                        Pole[curci, curcj].selected(g);
                        Pole[curci, curcj].chekall(g, Pole);
                        selectedI = curci;
                        selectedJ = curcj;
                        if (turn == 0)
                            turn = 1;
                        else
                            turn = 0;
                    }
                }
                else
                {
                    if (Pole[curci, curcj].Chechek() == 0) // если поле свободное
                    {
                        if (Pole[selectedI, selectedJ].movechek(Pole[curci, curcj].GetX(), Pole[curci, curcj].GetY(), curci, curcj, g) == 1)
                        {
                            if (Pole[selectedI, selectedJ].Chechek() == 1)
                                Pole[curci, curcj] = new Fugyra(Pole[curci, curcj].GetX(), Pole[curci, curcj].GetY(), Pole[selectedI, selectedJ].GetEnemy(), curci, curcj);
                            if (Pole[selectedI, selectedJ].Chechek() == 2)
                                Pole[curci, curcj] = new King(Pole[curci, curcj].GetX(), Pole[curci, curcj].GetY(), Pole[selectedI, selectedJ].GetEnemy(), curci, curcj);
                            if (Pole[selectedI, selectedJ].Chechek() == 3)
                                Pole[curci, curcj] = new Horse(Pole[curci, curcj].GetX(), Pole[curci, curcj].GetY(), Pole[selectedI, selectedJ].GetEnemy(), curci, curcj);
                            if (Pole[selectedI, selectedJ].Chechek() == 4)
                                Pole[curci, curcj] = new Pawn(Pole[curci, curcj].GetX(), Pole[curci, curcj].GetY(), Pole[selectedI, selectedJ].GetEnemy(), 1, curci, curcj);
                            if (Pole[selectedI, selectedJ].Chechek() == 5)
                                Pole[curci, curcj] = new Elephant(Pole[curci, curcj].GetX(), Pole[curci, curcj].GetY(), Pole[selectedI, selectedJ].GetEnemy(), curci, curcj);
                            if (Pole[selectedI, selectedJ].Chechek() == 6)
                                Pole[curci, curcj] = new Queen(Pole[curci, curcj].GetX(), Pole[curci, curcj].GetY(), Pole[selectedI, selectedJ].GetEnemy(), curci, curcj);
                            if (Pole[selectedI, selectedJ].Chechek() == 7)
                                Pole[curci, curcj] = new Tower(Pole[curci, curcj].GetX(), Pole[curci, curcj].GetY(), Pole[selectedI, selectedJ].GetEnemy(), curci, curcj);

                            Pole[selectedI, selectedJ] = new Kletka(Pole[selectedI, selectedJ].GetX(), Pole[selectedI, selectedJ].GetY(), selectedI, selectedJ);
                            zapolnPole(g);
                            selectedI = -1;
                            selectedJ = -1;
                            if (ech == 1)
                            {
                                if (turn == 0)
                                    turn = 1;
                                else
                                    turn = 0;
                            }
                        }
                    }
                    else
                    {
                        if (Pole[selectedI, selectedJ].eatchek(Pole[curci, curcj].GetX(), Pole[curci, curcj].GetY(), curci, curcj, g) == 1 && Pole[selectedI, selectedJ].GetEnemy() != Pole[curci, curcj].GetEnemy())
                        {
                            if (Pole[selectedI, selectedJ].Chechek() == 1)
                                Pole[curci, curcj] = new Fugyra(Pole[curci, curcj].GetX(), Pole[curci, curcj].GetY(), Pole[selectedI, selectedJ].GetEnemy(), curci, curcj);
                            if (Pole[selectedI, selectedJ].Chechek() == 2)
                                Pole[curci, curcj] = new King(Pole[curci, curcj].GetX(), Pole[curci, curcj].GetY(), Pole[selectedI, selectedJ].GetEnemy(), curci, curcj);
                            if (Pole[selectedI, selectedJ].Chechek() == 3)
                                Pole[curci, curcj] = new Horse(Pole[curci, curcj].GetX(), Pole[curci, curcj].GetY(), Pole[selectedI, selectedJ].GetEnemy(), curci, curcj);
                            if (Pole[selectedI, selectedJ].Chechek() == 4)
                                Pole[curci, curcj] = new Pawn(Pole[curci, curcj].GetX(), Pole[curci, curcj].GetY(), Pole[selectedI, selectedJ].GetEnemy(), 1, curci, curcj);
                            if (Pole[selectedI, selectedJ].Chechek() == 5)
                                Pole[curci, curcj] = new Elephant(Pole[curci, curcj].GetX(), Pole[curci, curcj].GetY(), Pole[selectedI, selectedJ].GetEnemy(), curci, curcj);
                            if (Pole[selectedI, selectedJ].Chechek() == 6)
                                Pole[curci, curcj] = new Queen(Pole[curci, curcj].GetX(), Pole[curci, curcj].GetY(), Pole[selectedI, selectedJ].GetEnemy(), curci, curcj);
                            if (Pole[selectedI, selectedJ].Chechek() == 7)
                                Pole[curci, curcj] = new Tower(Pole[curci, curcj].GetX(), Pole[curci, curcj].GetY(), Pole[selectedI, selectedJ].GetEnemy(), curci, curcj);

                            Pole[selectedI, selectedJ] = new Kletka(Pole[selectedI, selectedJ].GetX(), Pole[selectedI, selectedJ].GetY(), selectedI, selectedJ);
                            zapolnPole(g);
                            selectedI = -1;
                            selectedJ = -1;
                            if (ech == 1)
                            {
                                if (turn == 0)
                                    turn = 1;
                                else
                                    turn = 0;
                            }
                        }
                    }

                }
            }
            else
            if (e.Button == MouseButtons.Right && selectedI != -1)     //ПРИ НАЖАТИИ НА ПРАВУЮ КНОПКУ отменить выделение 
            {
                Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
                zapolnPole(g);
                selectedI = -1;
                selectedJ = -1;
                if (turn == 0)
                    turn = 1;
                else
                    turn = 0;
                zapolnPole(g);
            }

            int k1 = 0, k2 = 0;
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if (Pole[i, j].Chechek() == 2 && Pole[i, j].GetEnemy() == 0)
                        k1++;
                    if (Pole[i, j].Chechek() == 2 && Pole[i, j].GetEnemy() == 1)
                        k2++;
                }
            if (k1 == 0)
                my.OnBlackEvent();   //выиграл черный

            else
                if (k2 == 0)
                my.OnWhiteEvent();    //выиграл белый

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form2 = new Forma_Pravila();
            Form2.ShowDialog();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form3 = new Forma_Spravka();
            Form3.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form4 = new Forma_Infa();
            Form4.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       

        private void вклToolStripMenuItem_Click(object sender, EventArgs e)
        {
            пауза.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label5.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            минБелых.Visible = true;
            секБелых.Visible = true;
            минЧёрных.Visible = true;
            секЧёрных.Visible = true;
            точкиБ.Visible = true;
            точкиЧ.Visible = true;
            pictureBox1.Visible = false;
            pictureBox1.Visible = true;
        }

        private void выклToolStripMenuItem_Click(object sender, EventArgs e)
        {
            пауза.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label5.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            минБелых.Visible = false;
            секБелых.Visible = false;
            минЧёрных.Visible = false;
            секЧёрных.Visible = false;
            точкиБ.Visible = false;
            точкиЧ.Visible = false;
            pictureBox1.Visible = false;
            pictureBox1.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Stop")
            {
                button2.Text = "Start";
                timer1.Enabled = false;
                button3.Text = "Stop";
                timer2.Enabled = true;

            }
            else
            {
                button2.Text = "Stop";
                timer1.Enabled = true;
                button3.Text = "Start";
                timer2.Enabled = false;
            }
        }

        private void минБелых_Click(object sender, EventArgs e)
        {

        }

        private void секБелых_Click(object sender, EventArgs e)
        {

        }

        private void минЧёрных_Click(object sender, EventArgs e)
        {

        }

        private void секЧёрных_Click(object sender, EventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Stop")
            {
                button3.Text = "Start";
                timer2.Enabled = false;
                button2.Text = "Stop";
                timer1.Enabled = true;
            }
            else
            {
                button3.Text = "Stop";
                timer2.Enabled = true;
                button2.Text = "Start";
                timer1.Enabled = false;
            }
        }

        private void пауза_Click(object sender, EventArgs e)
        {
            button2.Text = "Start";
            button3.Text = "Start";
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (s > 0)
            {
                s--;
                if (s < 10)
                    секБелых.Text = "0" + s.ToString();
                else
                    секБелых.Text = s.ToString();
            }
            else
            {
                if ((m > 0) & (s == 0))
                {
                    m--;
                    if (m < 10)
                        минБелых.Text = "0" + m.ToString();
                    else
                        минБелых.Text = m.ToString();
                    s = 59;
                    минБелых.Text = "59";
                }
            }

            if ((m == 0) & (s == 0))
            {
                MessageBox.Show("Игра окончена. Чёрные победили!!");
            }
        }

        private void таймерToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (s > 0)
            {
                s--;
                if (s < 10)
                    секЧёрных.Text = "0" + s.ToString();
                else
                    секЧёрных.Text = s.ToString();
            }
            else
            {
                if ((m > 0) & (s == 0))
                {
                    m--;
                    if (m < 10)
                        минЧёрных.Text = "0" + m.ToString();
                    else
                        минЧёрных.Text = m.ToString();
                    s = 59;
                    минЧёрных.Text = "59";
                }
            }

            if ((m == 0) & (s == 0))
            {
                MessageBox.Show("Игра окончена. Белые победили!!");
            }
        }

    }
}