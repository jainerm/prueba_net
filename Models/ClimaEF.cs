using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.ComponentModel.DataAnnotations;


namespace paginamaestra.Models
{
    public class ClimaEF : DbContext
    {
        public DbSet<Ciudades> Ciudades { get; set; }
        public DbSet<Clima> Clima { get; set; }
    }

        
    public class Ciudades
    {
       [Key]
       [ScaffoldColumn(false)]
       public int IdCiudad { get; set; }
       [Required, StringLength(40), Display(Name="Ciudad")]
       public string NomCiudad { get; set; }
       [Required, StringLength(40), Display(Name = "Nombre Imagen")]
       public string NomImagen { get; set; }
    }

    public class Clima
    {
        [Key]
        [ScaffoldColumn(false)]
        public int IdClima { get; set; }
        public int IdCiudad { get; set; }
        [EnumDataType(typeof(DiasDeLaSemana)), Display(Name = "Dia de la seman")]
        public DiasDeLaSemana DiaSemana { get; set; }
        [Required]
        public int Temperatura { get; set; }

        public static implicit operator Clima(ClimaEF v)
        {
            throw new NotImplementedException();
        }
    }

    public enum DiasDeLaSemana
    {
        Lunes,
        Martes,
        Miercoles,
        Jueves,
        Viernes,
        Sabado,
        Domingo
    }
    /* public class List<Ciudades> ListarTodo()
    {
        ClimaEF db = new ClimaEF();
        List<Ciudades> query = db.Ciudades.ToList();
        return query;
    }*/

}
