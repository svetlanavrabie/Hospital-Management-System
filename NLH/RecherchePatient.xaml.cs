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

namespace NLH
{
    /// <summary>
    /// Logique d'interaction pour RecherchePatient.xaml
    /// </summary>
    public partial class RecherchePatient : Window
    {
        NHLEntities db = new NHLEntities();


        public RecherchePatient()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnRech_Click(object sender, RoutedEventArgs e)
        {

            string nr = txtNSS.Text;
            List<Patient> lst = new List<Patient>();

            foreach (Patient item in db.Patients.ToList())
            {
                if (item.NSS == nr)
                {
                    lst.Add(item);


                }
            }
            if (lst.Count == 0)
            {
                MessageBox.Show("NSS n'existe pas!", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                listegride.ItemsSource = lst;
            }
        }
    }
}
