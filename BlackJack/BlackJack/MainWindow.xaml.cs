using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//@authors: Shawn Pokharel and Manuel Aponte
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

            
            
            //Each BitmapImage is relating to each Card image for both the player and the dealer
            // Create source.
            BitmapImage playerCard1 = new BitmapImage();
            // BitmapImage.UriSource must be in a BeginInit/EndInit block.
            playerCard1.BeginInit();
            //the link used is from the deck of cards api that calls the getcardvalue method and getsuitvalue method from the card class and returns the values into a 0S format. 0S is Ten of spades
            playerCard1.UriSource = new Uri("https://deckofcardsapi.com/static/img/" + (card1.GetCardValue()) + (card1.GetSuitValue()) + ".png", UriKind.RelativeOrAbsolute);
            playerCard1.EndInit();
            // Set the image source.
            Card1Img.Source = playerCard1;

            System.Threading.Thread.Sleep(500); //Need this delay otherwise it messes up lol

            
           

            Card card2 = new Card();
            BitmapImage playerCard2 = new BitmapImage();
            // BitmapImage.UriSource must be in a BeginInit/EndInit block.
            playerCard2.BeginInit();
            playerCard2.UriSource = new Uri("https://deckofcardsapi.com/static/img/" + (card2.GetCardValue()) + (card2.GetSuitValue()) + ".png", UriKind.RelativeOrAbsolute);
            playerCard2.EndInit();
            // Set the image source.
            Card2Img.Source = playerCard2;

            System.Threading.Thread.Sleep(500); //Need this delay otherwise it messes up lol




            Card dealerCard1 = new Card();
            BitmapImage DCard1= new BitmapImage();
            // BitmapImage.UriSource must be in a BeginInit/EndInit block.
            DCard1.BeginInit();
            DCard1.UriSource = new Uri("https://deckofcardsapi.com/static/img/" + (dealerCard1.GetCardValue()) + (dealerCard1.GetSuitValue()) + ".png", UriKind.RelativeOrAbsolute);
            DCard1.EndInit();
            // Set the image source.
            DealerCard1Img.Source = DCard1;

            System.Threading.Thread.Sleep(500); //Need this delay otherwise it messes up lol

            Card dealerCard2 = new Card();
            BitmapImage DCard2 = new BitmapImage();
            // BitmapImage.UriSource must be in a BeginInit/EndInit block.
            DCard2.BeginInit();
            DCard2.UriSource = new Uri("https://deckofcardsapi.com/static/img/" + (dealerCard1.GetCardValue()) + (dealerCard1.GetSuitValue()) + ".png", UriKind.RelativeOrAbsolute);
            DCard2.EndInit();
            // Set the image source.
            DealerCard2Img.Source = DCard2;

            

            /**
             * If (handvalue <= 10)
             * {
             *  A = 11
             * }
             * Else If(handvalue > 10)
             * {
             *  A=1
             * }
             */




        }
    }

           
  }

