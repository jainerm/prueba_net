namespace paginamaestra.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using paginamaestra.Models; 

    internal sealed class Configuration : DbMigrationsConfiguration<ClimaEF>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ClimaEF context)
        {
            context.Ciudades.AddOrUpdate(
                new Ciudades { NomCiudad = "Bogota", NomImagen = "Bogota.png" },
                new Ciudades { NomCiudad = "Barranqilla", NomImagen = "Barranquilla.png" },
                new Ciudades { NomCiudad = "Santamarta", NomImagen = "santamarta.png" },
                new Ciudades { NomCiudad = "Cartagena", NomImagen = "Cartagenaa.png" },
                new Ciudades { NomCiudad = "Medellin", NomImagen = "Medellin.png" },
                new Ciudades { NomCiudad = "Cali", NomImagen = "Cali.png" },
                new Ciudades { NomCiudad = "Neiva", NomImagen = "Neiva.png" },
                new Ciudades { NomCiudad = "Bucaramanga", NomImagen = "Bucaramanga.png" },
                new Ciudades { NomCiudad = "Ibague", NomImagen = "Ibague.png" }
            );
            context.Clima.AddOrUpdate(
                /* BOGOTA */
                new Clima { IdCiudad = 1, DiaSemana = DiasDeLaSemana.Lunes, Temperatura=15 },
                new Clima { IdCiudad = 1, DiaSemana = DiasDeLaSemana.Martes, Temperatura = 15 },
                new Clima { IdCiudad = 1, DiaSemana = DiasDeLaSemana.Miercoles, Temperatura = 16 },
                new Clima { IdCiudad = 1, DiaSemana = DiasDeLaSemana.Jueves, Temperatura = 19 },
                new Clima { IdCiudad = 1, DiaSemana = DiasDeLaSemana.Viernes, Temperatura = 17 },
                new Clima { IdCiudad = 1, DiaSemana = DiasDeLaSemana.Sabado, Temperatura = 16 },
                new Clima { IdCiudad = 1, DiaSemana = DiasDeLaSemana.Domingo, Temperatura = 17 },
                /* BARRANQUILLA */
                new Clima { IdCiudad = 2, DiaSemana = DiasDeLaSemana.Lunes, Temperatura = 30 },
                new Clima { IdCiudad = 2, DiaSemana = DiasDeLaSemana.Martes, Temperatura = 29 },
                new Clima { IdCiudad = 2, DiaSemana = DiasDeLaSemana.Miercoles, Temperatura = 30 },
                new Clima { IdCiudad = 2, DiaSemana = DiasDeLaSemana.Jueves, Temperatura = 29 },
                new Clima { IdCiudad = 2, DiaSemana = DiasDeLaSemana.Viernes, Temperatura = 30 },
                new Clima { IdCiudad = 2, DiaSemana = DiasDeLaSemana.Sabado, Temperatura = 31 },
                new Clima { IdCiudad = 2, DiaSemana = DiasDeLaSemana.Domingo, Temperatura = 31 },
                /* SANTAMARTA */
                new Clima { IdCiudad = 3, DiaSemana = DiasDeLaSemana.Lunes, Temperatura = 30 },
                new Clima { IdCiudad = 3, DiaSemana = DiasDeLaSemana.Martes, Temperatura = 28 },
                new Clima { IdCiudad = 3, DiaSemana = DiasDeLaSemana.Miercoles, Temperatura = 29 },
                new Clima { IdCiudad = 3, DiaSemana = DiasDeLaSemana.Jueves, Temperatura = 30 },
                new Clima { IdCiudad = 3, DiaSemana = DiasDeLaSemana.Viernes, Temperatura = 30 },
                new Clima { IdCiudad = 3, DiaSemana = DiasDeLaSemana.Sabado, Temperatura = 31 },
                new Clima { IdCiudad = 1, DiaSemana = DiasDeLaSemana.Domingo, Temperatura = 31 },
                /* CARTAGENA */
                new Clima { IdCiudad = 4, DiaSemana = DiasDeLaSemana.Lunes, Temperatura = 30 },
                new Clima { IdCiudad = 4, DiaSemana = DiasDeLaSemana.Martes, Temperatura = 30 },
                new Clima { IdCiudad = 4, DiaSemana = DiasDeLaSemana.Miercoles, Temperatura = 29 },
                new Clima { IdCiudad = 4, DiaSemana = DiasDeLaSemana.Jueves, Temperatura = 31 },
                new Clima { IdCiudad = 4, DiaSemana = DiasDeLaSemana.Viernes, Temperatura = 31 },
                new Clima { IdCiudad = 4, DiaSemana = DiasDeLaSemana.Sabado, Temperatura = 32 },
                new Clima { IdCiudad = 4, DiaSemana = DiasDeLaSemana.Domingo, Temperatura = 32 },
                /* MEDELLIN */
                new Clima { IdCiudad = 5, DiaSemana = DiasDeLaSemana.Lunes, Temperatura = 24 },
                new Clima { IdCiudad = 5, DiaSemana = DiasDeLaSemana.Martes, Temperatura = 24 },
                new Clima { IdCiudad = 5, DiaSemana = DiasDeLaSemana.Miercoles, Temperatura = 24 },
                new Clima { IdCiudad = 5, DiaSemana = DiasDeLaSemana.Jueves, Temperatura = 25 },
                new Clima { IdCiudad = 5, DiaSemana = DiasDeLaSemana.Viernes, Temperatura = 26 },
                new Clima { IdCiudad = 5, DiaSemana = DiasDeLaSemana.Sabado, Temperatura = 27},
                new Clima { IdCiudad = 5, DiaSemana = DiasDeLaSemana.Domingo, Temperatura = 27 },
                /* CALI */
                new Clima { IdCiudad = 6, DiaSemana = DiasDeLaSemana.Lunes, Temperatura = 29 },
                new Clima { IdCiudad = 6, DiaSemana = DiasDeLaSemana.Martes, Temperatura = 29 },
                new Clima { IdCiudad = 6, DiaSemana = DiasDeLaSemana.Miercoles, Temperatura = 30 },
                new Clima { IdCiudad = 6, DiaSemana = DiasDeLaSemana.Jueves, Temperatura = 30 },
                new Clima { IdCiudad = 6, DiaSemana = DiasDeLaSemana.Viernes, Temperatura = 32 },
                new Clima { IdCiudad = 6, DiaSemana = DiasDeLaSemana.Sabado, Temperatura = 32 },
                new Clima { IdCiudad = 6, DiaSemana = DiasDeLaSemana.Domingo, Temperatura = 31 },
                /* NEIVA */
                new Clima { IdCiudad = 7, DiaSemana = DiasDeLaSemana.Lunes, Temperatura = 33 },
                new Clima { IdCiudad = 7, DiaSemana = DiasDeLaSemana.Martes, Temperatura = 33 },
                new Clima { IdCiudad = 7, DiaSemana = DiasDeLaSemana.Miercoles, Temperatura = 33 },
                new Clima { IdCiudad = 7, DiaSemana = DiasDeLaSemana.Jueves, Temperatura = 34 },
                new Clima { IdCiudad = 7, DiaSemana = DiasDeLaSemana.Viernes, Temperatura = 35 },
                new Clima { IdCiudad = 7, DiaSemana = DiasDeLaSemana.Sabado, Temperatura = 33 },
                new Clima { IdCiudad = 7, DiaSemana = DiasDeLaSemana.Domingo, Temperatura = 34 },
                /* BUCARAMANGA */
                new Clima { IdCiudad = 8, DiaSemana = DiasDeLaSemana.Lunes },
                new Clima { IdCiudad = 8, DiaSemana = DiasDeLaSemana.Martes },
                new Clima { IdCiudad = 8, DiaSemana = DiasDeLaSemana.Miercoles },
                new Clima { IdCiudad = 8, DiaSemana = DiasDeLaSemana.Jueves },
                new Clima { IdCiudad = 8, DiaSemana = DiasDeLaSemana.Viernes },
                new Clima { IdCiudad = 8, DiaSemana = DiasDeLaSemana.Sabado },
                new Clima { IdCiudad = 8, DiaSemana = DiasDeLaSemana.Domingo },
                /* IBAGUE */
                new Clima { IdCiudad = 9, DiaSemana = DiasDeLaSemana.Lunes },
                new Clima { IdCiudad = 9, DiaSemana = DiasDeLaSemana.Martes },
                new Clima { IdCiudad = 9, DiaSemana = DiasDeLaSemana.Miercoles },
                new Clima { IdCiudad = 9, DiaSemana = DiasDeLaSemana.Jueves },
                new Clima { IdCiudad = 9, DiaSemana = DiasDeLaSemana.Viernes },
                new Clima { IdCiudad = 9, DiaSemana = DiasDeLaSemana.Sabado },
                new Clima { IdCiudad = 9, DiaSemana = DiasDeLaSemana.Domingo }
            );
        }
    }
}
