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
using FigureCore;

namespace FigureWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string activeCursor;
        bool activeFigure = false;
        bool selectFigure = false;
        Button btnStart;
        Button btnClear;
        Button btn;
        Warp piece;
        int x;
        int y;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            btn = (Button)sender;
            x = Grid.GetRow(btn);
            y = Grid.GetColumn(btn);
            if (!selectFigure)
            {
                if (activeFigure)
                {
                    btn.Content = Symbol(activeCursor);
                    piece = WarpCreate.Create(activeCursor.ToUpper(), x, y);
                }
                else
                {
                    if (!btn.Content.Equals(""))
                    {
                        piece = WarpCreate.Create(btn.Content.ToString().ToUpper(), x, y);
                        btnStart = btn;
                        selectFigure = true;
                    }
                    else
                    {
                        selectFigure = false;
                    }
                }
            }
            else
            {
                if(piece.Move(x, y))
                {
                    btn.Content = btnStart.Content;
                    btnStart.Content = "";
                }
                else if(btnStart == btn)
                {
                    MessageBox.Show("Delete figure");
                }
                else
                {
                    MessageBox.Show("Can't move");
                    btn.Content = "";
                }
                selectFigure = false;
            }
        }

        private void Button_Click_Select(object sender, RoutedEventArgs e)
        {
            string[] line = sender.ToString().Split(" ");
            activeCursor = line[1];
            if(activeCursor == "Cursor")
            {
                activeFigure = false;
            }
            else
            {
                activeFigure = true;
            }
            TxtBlck.Text = line[1];
        }

        public string Symbol(string figure)
        {
            string pieceCode = figure.ToUpper();
            string symbol;
            switch (pieceCode)
            {
                case "KING":
                case "K":
                    symbol = "♔";
                    break;

                case "QUEEN":
                case "Q":
                    symbol = "♕";
                    break;

                case "BISHOP":
                case "B":
                    symbol = "♗";
                    break;

                case "ROOK":
                case "R":
                    symbol = "♖";
                    break;

                case "KNIGHT":
                case "N":
                    symbol = "♘";
                    break;

                default: throw (new Exception("Bad piece OR Bad location!"));
            }

            return symbol;
        }

        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("To clear, double-click on the shape\nGood luck!");
        }
    }
}
