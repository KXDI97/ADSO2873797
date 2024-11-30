using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace practica.Models
{
    public class Usuarios
    {

        [Key]// llave//
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//identity aunto incremental//
        public int Id {  get; set; }
        [Required(AllowEmptyStrings =false)] //requerido sin espacios//
        [StringLength(50)] //numero de caracteres//
        public string Username { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }

    }
}