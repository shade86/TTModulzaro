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

namespace TTModulzaro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel main;

        public Patient Patient { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            main = new MainViewModel();
            DataContext = main;
        }

        private void NewPatient_Click(object sender, RoutedEventArgs e)
        {
            var pfvm = new PatientFormViewModel
            {
                Patient = new Patient()
            };
            var form = new PatientForm()
            {
                DataContext = pfvm
            };
            form.ShowDialog();
            if (pfvm.Validate())
                ((MainViewModel)DataContext).Patients.Add(pfvm.Patient);
        }

        private void EditPatient_Click(object sender, RoutedEventArgs e)
        {
            var SelectedPatient = ((MainViewModel)DataContext).SelectedPatient;
            if (SelectedPatient == null)
            {
                return;
            }
            var pfvm = new PatientFormViewModel

            {
                IsEdit = true,
                Patient = ((MainViewModel)DataContext).SelectedPatient
            };
            var form = new PatientForm()
            {
                DataContext = pfvm
            };
            form.ShowDialog();
        }

        private void Threatment_Click(object sender, RoutedEventArgs e)
        {
            var SelectedPatient = ((MainViewModel)DataContext).SelectedPatient;
            if (SelectedPatient == null)
            {
                return;
            }
            var tvm = new ThreatmentViewModel

            {
                Patient = ((MainViewModel)DataContext).SelectedPatient
            };
            var th = new Threatment()
            {
                DataContext = tvm
            };
            th.ShowDialog();
        }
    }
}
