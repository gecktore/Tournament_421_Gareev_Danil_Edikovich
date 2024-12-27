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
    /// Логика взаимодействия для AddEditTournamentPage.xaml
    /// </summary>
    public partial class AddEditTournamentPage : Page
    {
        Tournament tournament;
        public AddEditTournamentPage(Tournament _tournament)
        {
            InitializeComponent();
            tournament = _tournament;
            this.DataContext = tournament;
        }
    }
}
