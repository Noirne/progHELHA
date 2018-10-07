﻿namespace Entity_Framework_Code_First
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class Database : DbContext
    {
        // Votre contexte a été configuré pour utiliser une chaîne de connexion « Database » du fichier 
        // de configuration de votre application (App.config ou Web.config). Par défaut, cette chaîne de connexion cible 
        // la base de données « Entity_Framework_Code_First.Database » sur votre instance LocalDb. 
        // 
        // Pour cibler une autre base de données et/ou un autre fournisseur de base de données, modifiez 
        // la chaîne de connexion « Database » dans le fichier de configuration de l'application.
        public Database()
            : base("name=Database")
        {
        }

        // Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
        // sur la configuration et l'utilisation du modèle Code First, consultez http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

    public class Article
    {
        [Key]
        public int IdArticle { get; set; }
        [StringLength(50)]
        public string Nom { get; set; }
        public string Prenom { get; set; }
    }
}