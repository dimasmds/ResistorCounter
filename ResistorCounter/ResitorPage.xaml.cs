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

namespace ResistorCounter
{
    /// <summary>
    /// Interaction logic for ResitorPage.xaml
    /// </summary>
    public partial class ResitorPage : Page
    {
        static readonly string[] SizeSuffixes =
                   { "", "K", "M", "G", "T", "P", "E", "Z", "Y" };

        public ResitorPage()
        {
            InitializeComponent();
        }

        private void BtnG1_1_Click(object sender, RoutedEventArgs e)
        {
            Button foo = sender as Button;
            StackPanelG1.Background = foo.Background;
            TextBlockResult.Text = ResistorCalc((SolidColorBrush)StackPanelG1.Background, (SolidColorBrush)StackPanelG2.Background,
               (SolidColorBrush)StackPanelG3.Background, (SolidColorBrush)StackPanelG4.Background);
        }

        private void BtnG2_1_Click(object sender, RoutedEventArgs e)
        {
            Button foo = sender as Button;
            StackPanelG2.Background = foo.Background;
            TextBlockResult.Text = ResistorCalc((SolidColorBrush)StackPanelG1.Background, (SolidColorBrush)StackPanelG2.Background,
                (SolidColorBrush)StackPanelG3.Background, (SolidColorBrush)StackPanelG4.Background);

        }

        private void BtnG3_1_Click(object sender, RoutedEventArgs e)
        {
            Button foo = sender as Button;
            StackPanelG3.Background = foo.Background;
            TextBlockResult.Text = ResistorCalc((SolidColorBrush)StackPanelG1.Background, (SolidColorBrush)StackPanelG2.Background,
                (SolidColorBrush)StackPanelG3.Background, (SolidColorBrush)StackPanelG4.Background);

        }

        private void BtnG4_1_Click(object sender, RoutedEventArgs e)
        {
            Button foo = sender as Button;
            StackPanelG4.Background = foo.Background;
            TextBlockResult.Text = ResistorCalc((SolidColorBrush)StackPanelG1.Background, (SolidColorBrush)StackPanelG2.Background,
               (SolidColorBrush)StackPanelG3.Background, (SolidColorBrush)StackPanelG4.Background);

        }

        private string ResistorCalc(SolidColorBrush g1, SolidColorBrush g2, SolidColorBrush g3, SolidColorBrush g4)
        {
            string text = "";


            /* Mencari Nilai Gelang satu */

            if(g1.Color == (Color)ColorConverter.ConvertFromString("#FF5B1A04"))
            {
                text += "1";
            }
            else if((g1.Color == (Color)ColorConverter.ConvertFromString("#FFb70f0a")))
            {
                text += "2";
            }
            else if ((g1.Color == (Color)ColorConverter.ConvertFromString("#FFffa834")))
            {
                text += "3";
            }
            else if ((g1.Color == (Color)ColorConverter.ConvertFromString("#FFf4eb49")))
            {
                text += "4";
            }
            else if ((g1.Color == (Color)ColorConverter.ConvertFromString("#FF72bb53")))
            {
                text += "5";
            }
            else if ((g1.Color == (Color)ColorConverter.ConvertFromString("#FF3d8af7")))
            {
                text += "6";
            }
            else if ((g1.Color == (Color)ColorConverter.ConvertFromString("#FFc238eb")))
            {
                text += "7";
            }
            else if ((g1.Color == (Color)ColorConverter.ConvertFromString("#FF929292")))
            {
                text += "8";
            }
            else if ((g1.Color == (Color)ColorConverter.ConvertFromString("#FFffffff")))
            {
                text += "9";
            }


            /* Mencari Nilai Gelang 2 */

            if (g2.Color == (Color)ColorConverter.ConvertFromString("#FF000000"))
            {
                text += "0";
            }

            else if (g2.Color == (Color)ColorConverter.ConvertFromString("#FF5B1A04"))
            {
                text += "1";
            }
            else if ((g2.Color == (Color)ColorConverter.ConvertFromString("#FFb70f0a")))
            {
                text += "2";
            }
            else if ((g2.Color == (Color)ColorConverter.ConvertFromString("#FFffa834")))
            {
                text += "3";
            }
            else if ((g2.Color == (Color)ColorConverter.ConvertFromString("#FFf4eb49")))
            {
                text += "4";
            }
            else if ((g2.Color == (Color)ColorConverter.ConvertFromString("#FF72bb53")))
            {
                text += "5";
            }
            else if ((g2.Color == (Color)ColorConverter.ConvertFromString("#FF3d8af7")))
            {
                text += "6";
            }
            else if ((g2.Color == (Color)ColorConverter.ConvertFromString("#FFc238eb")))
            {
                text += "7";
            }
            else if ((g2.Color == (Color)ColorConverter.ConvertFromString("#FF929292")))
            {
                text += "8";
            }
            else if ((g2.Color == (Color)ColorConverter.ConvertFromString("#FFffffff")))
            {
                text += "9";
            }



            /* Mencari Nilai Gelang 3 */

            if (g3.Color == (Color)ColorConverter.ConvertFromString("#FF000000"))
            {
                text += "";
            }

            else if (g3.Color == (Color)ColorConverter.ConvertFromString("#FF5B1A04"))
            {
                text += "0";
            }
            else if ((g3.Color == (Color)ColorConverter.ConvertFromString("#FFb70f0a")))
            {
                text += "00";
            }
            else if ((g3.Color == (Color)ColorConverter.ConvertFromString("#FFffa834")))
            {
                text += "000";
            }
            else if ((g3.Color == (Color)ColorConverter.ConvertFromString("#FFf4eb49")))
            {
                text += "0000";
            }
            else if ((g3.Color == (Color)ColorConverter.ConvertFromString("#FF72bb53")))
            {
                text += "00000";
            }
            else if ((g3.Color == (Color)ColorConverter.ConvertFromString("#FF3d8af7")))
            {
                text += "000000";
            }
            else if ((g3.Color == (Color)ColorConverter.ConvertFromString("#FFc238eb")))
            {
                text += "0000000";
            }
            else if ((g3.Color == (Color)ColorConverter.ConvertFromString("#FF929292")))
            {
                text += "00000000";
            }
            else if ((g3.Color == (Color)ColorConverter.ConvertFromString("#FFffffff")))
            {
                text += "000000000";
            }

            string tolerant;

            if (g4.Color == (Color)ColorConverter.ConvertFromString("#FF5b1a04"))
            {
                tolerant = "1";
            }
            else if (g4.Color == (Color)ColorConverter.ConvertFromString("#FFb70f0a"))
            {
                tolerant = "2";
            }
            else if (g4.Color == (Color)ColorConverter.ConvertFromString("#FF72bb53"))
            {
                tolerant = "0.5";
            }
            else if (g4.Color == (Color)ColorConverter.ConvertFromString("#FF3d8af7"))
            {
                tolerant = "0.25";
            }
            else if (g4.Color == (Color)ColorConverter.ConvertFromString("#FFc238eb"))
            {
                tolerant = "0.1";
            }
            else if (g4.Color == (Color)ColorConverter.ConvertFromString("#FF929292"))
            {
                tolerant = "0.05";
            }
            else if (g4.Color == (Color)ColorConverter.ConvertFromString("#FFffc957"))
            {
                tolerant = "5";
            }
            else
            {
                tolerant = "10";
            }

            return SizeSuffix(Convert.ToDouble(text)) + " " + "±"+tolerant+"%";
        }

        static string SizeSuffix(double value, int decimalPlaces = 0)
        {
            if (value >= 1000 && value < 999999)
            {
                return (value / 1000).ToString() + " KΩ";
            }
            else if (value >= 1000000 && value < 999999999)
            {
                return (value / 1000000).ToString() + " MΩ";
            }
            else if (value >= 1000000000 && value < 999999999999)
            {
                return (value / 1000000000).ToString() + " GΩ";
            }
            else
                return value.ToString() + " Ω";
        }
    }
}
