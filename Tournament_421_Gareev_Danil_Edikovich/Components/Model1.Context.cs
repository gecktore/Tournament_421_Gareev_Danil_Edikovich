﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tournament_421_Gareev_Danil_Edikovich.Components
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TournamentDB_421_Gareev_Danil_EdikovichEntities2 : DbContext
    {
        public TournamentDB_421_Gareev_Danil_EdikovichEntities2()
            : base("name=TournamentDB_421_Gareev_Danil_EdikovichEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Game> Game { get; set; }
        public virtual DbSet<Match> Match { get; set; }
        public virtual DbSet<MatchTeam> MatchTeam { get; set; }
        public virtual DbSet<Organizer> Organizer { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<PlayerMatch> PlayerMatch { get; set; }
        public virtual DbSet<PlayerTeam> PlayerTeam { get; set; }
        public virtual DbSet<PlayFormat> PlayFormat { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<Tournament> Tournament { get; set; }
        public virtual DbSet<Type> Type { get; set; }
        public virtual DbSet<Viewer> Viewer { get; set; }
    }
}
