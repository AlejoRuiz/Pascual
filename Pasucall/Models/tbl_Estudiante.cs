//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pasucall.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_Estudiante
    {
        [Required(ErrorMessage = "*Campo Obligatorio")]
        public int documento { get; set; }
        [Required(ErrorMessage = "*Campo Obligatorio")]
        public string nombre_completo { get; set; }
        [Required(ErrorMessage = "*Campo Obligatorio")]
        public string programa { get; set; }
    }
}