using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for PatientForm.xaml
    /// </summary>
    public partial class PatientForm : Window
    {
        PatientFormViewModel pfvm;
        public PatientForm()
        {
            InitializeComponent();
            pfvm = new PatientFormViewModel();
            DataContext = pfvm;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            {
                if (((PatientFormViewModel)DataContext).Validate())
                    Close();
                else
                    MessageBox.Show("Hiba! A beteg neve legalább 4 karakter hosszú, a születési hely 2 karakter hosszú, a TAJ szám 9 számjegy kell hogy legyen!");
            }


        }


        public void AddPatient()
        {

        }

        private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = ((PatientFormViewModel)DataContext).OnWindowClosing();
            if ((((PatientFormViewModel)DataContext).OnWindowClosing() == true))
                MessageBox.Show("Hiba! A beteg neve legalább 4 karakter hosszú, a születési hely 2 karakter hosszú, a TAJ szám 9 számjegy kell hogy legyen!");
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
