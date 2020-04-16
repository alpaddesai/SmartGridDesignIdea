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

namespace SmartGridTechnology
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

        private void Smart_Grid_Meter_Click(object sender, RoutedEventArgs e)
        {
            SmartMeter Smart_Grid_MeterObject = new SmartMeter();
            Smart_Grid_MeterObject.Show();

        }

        private void Wireless_Test_Instrument_Click(object sender, RoutedEventArgs e)
        {
            RF_Test_Instrument Wireless_Test_InstrumentObject = new RF_Test_Instrument();
            Wireless_Test_InstrumentObject.Show();
        }

        private void Algorithms_Meter_Click(object sender, RoutedEventArgs e)
        {
            AlgorithmsMeter AlgorithmsMeterObject = new AlgorithmsMeter();
            AlgorithmsMeterObject.Show();

        }

        private void ZigBee_SoC_Click(object sender, RoutedEventArgs e)
        {
            ZigBeeRadio ZigBeeRadioObject = new ZigBeeRadio();
            ZigBeeRadioObject.Show();
        }
    }
}
