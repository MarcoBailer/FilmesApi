﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O titulo do filme eh obrigatorio")]
    [MaxLength(50, ErrorMessage = "O Titulo nao pode exceder 50 caracteres")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O Diretor do filme eh obrigatorio")]
    [MaxLength(30, ErrorMessage = "O Diretor nao pode exceder 30 caracteres")]
    public string Diretor { get; set; }

    [Required(ErrorMessage = "O Genero do filme eh obrigatorio")]
    [MaxLength(20, ErrorMessage = "O Genero nao pode exceder 20 caracteres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A Duracao do filme eh obrigatorio")]
    [Range(70, 600, ErrorMessage = "A duracao deve ter no minimo 70 e no maximo 600 minutos")]
    public int Duracao { get; set; }
}
