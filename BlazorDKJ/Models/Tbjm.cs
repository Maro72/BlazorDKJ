// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BlazorDKJ.Models
{
    public partial class Tbjm
    {
        public Tbjm()
        {
            Tbtowar = new HashSet<Tbtowar>();
        }

        public int Idjm { get; set; }
        public string Jm { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<Tbtowar> Tbtowar { get; set; }
    }
}