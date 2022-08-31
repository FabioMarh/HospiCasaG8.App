using Microsoft.EntityFrameworkCore;
using HospiCasa.App.Dominio;

namespace HospiCasa.App.Persistencia
{
    public class AppContext: DbContext
    {
        public DbSet <Persona> Personas {get;set;}
        public DbSet <Paciente> Pacientes {get;set;}
        public DbSet <Medico> Medicos {get;set;}
        public DbSet <Auxiliar> Auxiliares {get;set;}
        public DbSet <Enfermero> Enfermeros {get;set;}
        public DbSet <Familiar> Familiares {get;set;}
        public DbSet <HistoriaMedica> HistoriasMedicas {get;set;}
        public DbSet <PersonalMedico> PersonalMed {get;set;}
        public DbSet <SignoVital> SignosVitales {get;set;}
        public DbSet <SugerenciaCuidado> SugerenciasCuidados {get;set;}
        public DbSet <Genero> Genero {get; set;}
        public DbSet <TipoSigno> TipoSigno {get; set;}
        
   
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog= HospiCasatData");

        }

    }

    }
}