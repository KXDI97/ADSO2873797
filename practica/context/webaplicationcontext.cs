using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity; /*agregar*/
using System.Linq;
using System.Web;
using practica.Models; //agregar//

namespace practica.context
{
    public class webaplicationcontext : DbContext
    {
        public webaplicationcontext() : base("name=Prueba")
        {
        }

        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) //modificacion de metodos//
        {
            modelBuilder.Entity<Usuarios>()
             .ToTable("Usuarios")
             .HasKey(p => p.Id);

            modelBuilder.Entity<Usuarios>()  //llamamos tabla y ponesmos atributos//
                .Property(p => p.Id)
                .IsRequired()
                .HasColumnName("Id");

            modelBuilder.Entity<Usuarios>()
                .Property(p => p.Username)
                .IsRequired()
                .HasColumnName("Username")
                .HasMaxLength(50);

            modelBuilder.Entity<Usuarios>()
                .Property(p => p.Password)
                .IsRequired()
                .HasColumnName("Password")
                .HasMaxLength(50);

            base.OnModelCreating(modelBuilder);
        }
    }

}