using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
    /// Logique d'interaction pour Inscription.xaml
    /// </summary>
    public partial class Inscription : Window
    {
        public Inscription()
        {
            InitializeComponent();
        }

      

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //ecrire une requette sql pour recuperer les lit qui ne sont pas occupés

            var requette =

            from l in MainWindow.db.Lit1
            where (l.Occupe == "non")
            select new {l.NumeroLit };
          
            comb2.ItemsSource = requette.ToList();
            txtOccup.Text = "non";
            
            dateAd1.ItemsSource = MainWindow.db.DossierAdmissions.ToList();
            comb1.DataContext = MainWindow.db.Patients.ToList();
            dateConge.IsEnabled = false;
            txtOccup.IsEnabled = false;
        }
        
        private void comb2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e) // ajoutter une admission
        {

            try
            {
                DossierAdmission p1 = new DossierAdmission();
                
                p1.ChirurgieProgramme = txtChirurgie.Text;
                p1.DateAdmission = dateAd.SelectedDate;
                p1.DateChirurgie = dateChirurgie.SelectedDate;
               
            
                p1.IdPatient = Convert.ToInt32(comb1.Text);
                p1.NumeroLit= Convert.ToInt32(comb2.Text);

                Lit1 x = comb2.SelectedItem as Lit1;
                int nr = Convert.ToInt32(comb2.Text);
                var rez = MainWindow.db.Lit1.Where(w => w.NumeroLit == nr).FirstOrDefault();
                rez.Occupe = "Oui";
                if (checkCommodite.IsChecked == true)
                {
                    p1.Commodite = "oui";
                }
                else
                {
                    p1.Commodite = "non";
                }
                MainWindow.db.DossierAdmissions.Add(p1);        
                MainWindow.db.SaveChanges();
                dateAd1.ItemsSource = MainWindow.db.DossierAdmissions.ToList();
                txtOccup.Text = rez.Occupe;
               
                txtChirurgie.Text = "";
                MessageBox.Show("Dossier Admission ajouté avec Success", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            catch (DbEntityValidationException ex)
            {
                Console.WriteLine(ex.ToString());
               // MessageBox.Show("Ajout de dossier impossible!", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void dateAd1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cbNumType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }

        private void combDepartement_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            // int nr = Convert.ToInt32(d1.IdDepartement);
            // var rez = MainWindow.db.Lit1.Where(w => w.IdDepartament== nr).FirstOrDefault();
            // comb2.DataContext = MainWindow.db.Lit1.ToList();

        }

        private void txtOccup_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
