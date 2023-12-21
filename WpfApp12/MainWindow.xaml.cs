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

namespace WpfApp12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<BitmapImage> Images { get; set; }
        public List<BitmapImage> Odsloniete { get; set; }
        public int IleOdslonietych { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            IleOdslonietych = 0;
            Odsloniete = new List<BitmapImage>();
            Images = new List<BitmapImage>();
            Images.Add(new BitmapImage(new Uri("grafika/rys1.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys1.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys2.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys2.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys3.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys3.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys4.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys4.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys5.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys5.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys6.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys6.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys7.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys7.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys8.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys8.jpg",UriKind.Relative)));
            Images = Images.OrderBy(x => Random.Shared.Next()).ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IleOdslonietych++;
            Button button = sender as Button;
            if (button.Equals(btn1)) {
                rys1.Source = Images[0];
                Odsloniete.Add(Images[0]);

            }
            else if (button.Equals(btn2)) { 
                    rys2.Source = Images[1];
                Odsloniete.Add(Images[1]);
            }
            else if (button.Equals(btn3))
            {
                rys3.Source = Images[2];
                Odsloniete.Add(Images[2]);
            }
            else if (button.Equals(btn4))
            {
                rys4.Source = Images[3];
                Odsloniete.Add(Images[3]);
            }
            else if (button.Equals(btn5))
            {
                rys5.Source = Images[4];
                Odsloniete.Add(Images[4]);
            }
            else if (button.Equals(btn6))
            {
                rys6.Source = Images[5];
                Odsloniete.Add(Images[5]);
            }
            else if (button.Equals(btn7))
            {
                rys7.Source = Images[6];
                Odsloniete.Add(Images[6]);
            }
            else if (button.Equals(btn8))
            {
                rys8.Source = Images[7];
                Odsloniete.Add(Images[7]);
            }
            else if (button.Equals(btn9))
            {
                rys9.Source = Images[8];
                Odsloniete.Add(Images[8]);
            }
            else if (button.Equals(btn10))
            {
                rys10.Source = Images[9];
                Odsloniete.Add(Images[9]);
            }
            else if (button.Equals(btn11))
            {
                rys11.Source = Images[10];
                Odsloniete.Add(Images[10]);
            }
            else if (button.Equals(btn12))
            {
                rys12.Source = Images[11];
                Odsloniete.Add(Images[11]);
            }
            else if (button.Equals(btn13))
            {
                rys13.Source = Images[12];
                Odsloniete.Add(Images[12]);
            }
            else if (button.Equals(btn14))
            {
                rys14.Source = Images[13];
                Odsloniete.Add(Images[13]);
            }
            else if (button.Equals(btn15))
            {
                rys15.Source = Images[14];
                Odsloniete.Add(Images[14]);
            }
            else if (button.Equals(btn16))
            {
                rys16.Source = Images[15];
                Odsloniete.Add(Images[15]);
            }
            if(IleOdslonietych == 2)
            {
                MessageBox.Show("Odslonieto " + IleOdslonietych);
                IleOdslonietych = 0;
                if (Odsloniete[0].UriSource.Equals(Odsloniete[1].UriSource))
                {
                    MessageBox.Show("Para");
                }
                Odsloniete.Clear();
            }
        }
        
    }
}
