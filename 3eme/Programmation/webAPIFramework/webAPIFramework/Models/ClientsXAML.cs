//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webAPIFramework.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientsXAML
    {
        public System.Guid clientID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string NomRue { get; set; }
        public string Numero { get; set; }
        public string CodePostal { get; set; }
        public string Localite { get; set; }
        public byte[] Image { get; set; }
    }
}
