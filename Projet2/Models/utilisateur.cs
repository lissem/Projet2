//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projet2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class utilisateur
    {
        public int id_utilisateur { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public int id_genre { get; set; }
        public System.DateTime date_naissance { get; set; }
        public string adresse { get; set; }
        public int id_ville { get; set; }
        public string num_telephone { get; set; }
        public string email { get; set; }
        public System.DateTime date_inscription { get; set; }
        public Nullable<System.DateTime> date_desinscription { get; set; }
        public Nullable<int> id_motif_desinscription { get; set; }
    }
}
