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

namespace BlackJack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Card card1 = new Card();

            Card card2 = new Card();
            
            cardImg.Source = new BitmapImage(new Uri("https://deckofcardsapi.com/static/img/" + (card1.GetCardValue()) + (card1.GetSuitValue()) + ".png"));

            cardImg2.Source = new BitmapImage(new Uri("https://deckofcardsapi.com/static/img/" + (card2.GetCardValue()) + (card2.GetSuitValue()) + ".png"));



            //MessageBox.Show("https://deckofcardsapi.com/static/img/" + (card1.GetCardValue()) + (card1.GetSuitValue()) + ".png");
            // MessageBox.Show("https://deckofcardsapi.com/static/img/" + (card2.GetCardValue()) + (card2.GetSuitValue()) + ".png");
        }
    }

           
  }

