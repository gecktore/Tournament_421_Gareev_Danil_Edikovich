using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Tournament_421_Gareev_Danil_Edikovich.Database;

namespace Tournament_421_Gareev_Danil_Edikovich
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static TournamentDB_421_Gareev_Danil_EdikovichEntities4 db = new TournamentDB_421_Gareev_Danil_EdikovichEntities4();
        public static string UserType;
    }
}
