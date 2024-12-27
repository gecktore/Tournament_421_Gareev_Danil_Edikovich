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
    /// Логика взаимодействия для TornnamentListPage.xaml
    /// </summary>
    public partial class TornnamentListPage : Page
    {
        public TornnamentListPage()
        {
            InitializeComponent();
            TournamentLV.ItemsSource = App.db.Tournament.ToList();
        }
        public void Refresh()
        {
            TournamentLV.ItemsSource = null;
            IEnumerable<Tournament> TLS = App.db.Tournament;
            if (StatusCb.SelectedIndex == 0)
            {
                TLS = TLS.Where(x => x.StatusID == 1);
            }
            if (StatusCb.SelectedIndex == 1)
            {
                TLS = TLS.Where(x => x.StatusID == 2);
            }
            if (StatusCb.SelectedIndex == 2)
            {
                TLS = TLS.Where(x => x.StatusID == 3);
            }
            if (SearchTb != null)
            {
                try
                {
                    TLS = TLS.Where(x => x.Game.Title.ToLower().Contains(SearchTb.Text.ToLower())
                    || x.PlayFormat.Title.ToLower().Contains(SearchTb.Text.ToLower())
                    || x.Date.ToString().Contains(SearchTb.Text.ToLower())
                    || x.Status.Title.ToLower().Contains(SearchTb.Text.ToLower())
                    || x.PrizePool.Contains(SearchTb.Text.ToLower()));
                }
                catch { }
            }
            TournamentLV.ItemsSource = TLS;
        }

        private void StatusCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void AddBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditTournamentPage(new Tournament()));
        }

        private void DelBt_Click(object sender, RoutedEventArgs e)
        {
            var selItem = TournamentLV.SelectedItem as Tournament;
            App.db.Tournament.Remove(selItem);
            App.db.SaveChanges();
        }
    }
}
