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
    /// Логика взаимодействия для NavigationPage.xaml
    /// </summary>
    public partial class NavigationPage : Page
    {
        public NavigationPage()
        {
            InitializeComponent();
        }

        private void RegBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }


        private void PlayerEnterBt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Player user = App.db.Player.FirstOrDefault(x => x.Login == LoginTb.Text && x.Password == PasswordPb.Password);
                if (user != null)
                {
                    NavigationService.Navigate(new TornnamentListPage());
                    App.UserType = "Участник";
                    MessageBox.Show("Вы успешно вошли!");
                }
                else
                    MessageBox.Show("Неверный пароль или логин!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void OrganizerEnterBt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Organizer user = App.db.Organizer.FirstOrDefault(x => x.Login == LoginTb.Text && x.Password == PasswordPb.Password);
                if (user != null)
                {
                    NavigationService.Navigate(new TornnamentListPage());
                    App.UserType = "Организатор";
                    MessageBox.Show("Вы успешно вошли!");
                }
                else
                    MessageBox.Show("Неверный пароль или логин!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
