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
    /// Logique d'interaction pour MedicinPage.xaml
    /// </summary>
    public partial class MedicinPage : Window
    {

       // NHLEntities db = new NHLEntities();
        public MedicinPage()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            comb1.DataContext = MainWindow.db.DossierAdmissions.ToList();
            dateAd1.ItemsSource = MainWindow.db.DossierAdmissions.ToList();
            textDateAd.IsEnabled = false;
            txtOcupp.IsEnabled = false;
        }

        private void comb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
       
            DossierAdmission d1 =comb1.SelectedItem as DossierAdmission;
            textDateAd.Text = d1.DateAdmission.ToString();
            
            dateCong.SelectedDate = d1.DateConge;
            txtNumLit.Text = d1.NumeroLit.ToString();
            int nr = Convert.ToInt32(txtNumLit.Text);
            var rez = MainWindow.db.Lit1.Where(w => w.NumeroLit == nr).FirstOrDefault();
            txtOcupp.Text= rez.Occupe;

        }

        private void btnDon_Click(object sender, RoutedEventArgs e)//le medecin donne conge au patient
        {
            // id admission se trouvent dans comb1
            DossierAdmission d1 = (DossierAdmission)comb1.SelectedItem;

            //date du congé est insérée a la table dossier admission a partir de datecong.selectedDate
            d1.DateConge = dateCong.SelectedDate;

            //on affiche dans le datagrid
            dateAd1.ItemsSource = MainWindow.db.DossierAdmissions.ToList();

            //on accede au lit du patient a partir de son dossier et  on met a non le champs occupé
            var rez = MainWindow.db.Lit1.Where(w => w.NumeroLit == d1.NumeroLit).FirstOrDefault();

            //on met le champs occupé a non recuperer a partir du text box, on peut affecter tout simplement non sans passer par le text box
            rez.Occupe = "non";
            
            MainWindow.db.SaveChanges();
            if(d1.DateConge==null)
            {
                MessageBox.Show("Veuillez introduire la date du congé", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            
            {
                txtOcupp.Text = rez.Occupe;
                MessageBox.Show("Congé ajouté avec Success, et le lit est libéré", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
