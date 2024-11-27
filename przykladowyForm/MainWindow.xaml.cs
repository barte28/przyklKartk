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

namespace przykladowyForm
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
            int obwod;
            int bok;
            if(int.TryParse(bok_textbox.Text, out bok))
            {
                MessageBox.Show(bok.ToString());
                string figura = figura_ComboBox.Text;
                if(figura == "Kwadrat")
                {
                    obwod = bok * 4;
                    MessageBox.Show("Obwód kwadratu wynosi " + obwod.ToString());
                }
                else if(figura == "Trójkąt prostokątny")
                {
                    obwod = bok * 3;
                    MessageBox.Show("Obwód trójkąta prostokątnego wynosi " + obwod.ToString());
                }
                else if(figura == "Pięciokąt")
                {
                    obwod = bok * 5;
                    MessageBox.Show("Obwód pięciokąta wynosi " + bok.ToString());
                }
            }
            else
            {
                MessageBox.Show("To nie jest liczba");
            }
        }
    }
}
