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
using Tournament_421_Gareev_Danil_Edikovich.Database;

namespace Tournament_421_Gareev_Danil_Edikovich.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        Organizer organizer;
        public RegistrationPage()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void ExitBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void SaveBt_Click(object sender, RoutedEventArgs e)
        {
            App.db.Organizer.Add(new Organizer { Login = LoginTb.Text, Password = PasswordPb.Text });
            App.db.SaveChanges();
            NavigationService.Navigate(new NavigationPage());
        }
    }
}
