﻿using System.ComponentModel.DataAnnotations;

namespace BlazorApp_Forms1.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="O nome deve ser informado")]
        [StringLength(10, ErrorMessage ="O nome não pode exceder 10 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O email deve ser informado")]
        [EmailAddress(ErrorMessage ="Formato do email é inválido")]
        public string Email { get; set; }
        [Range(18,80, ErrorMessage = "A idade deve estar entre 18 e 80")]
        public int Idade { get; set; }
    }
}
