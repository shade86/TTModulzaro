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
using System.Windows.Shapes;

namespace TTModulzaro
{
    /// <summary>
    /// Interaction logic for Threatment.xaml
    /// </summary>
    public partial class Threatment : Window
    {
        ThreatmentViewModel tvm;
        public Patient Patient { get; set; }
        public BNO BNO { get; set; }
        public object SelectedBNO { get; set; }

        public Threatment()
        {
            InitializeComponent();
            tvm = new ThreatmentViewModel();
            DataContext = tvm;
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Label_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {

        }

        private void Label_GotFocus(object sender, RoutedEventArgs e)
        {
            var SelectedBNO = ((ThreatmentViewModel)DataContext).SelectedBNO;
            JegyzetTextBox.Text = SelectedBNO.Jegyzet;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var SelectedBNO = ((ThreatmentViewModel)DataContext).SelectedBNO;
            JegyzetTextBox.Text = SelectedBNO.Jegyzet;
        }
    }
}
