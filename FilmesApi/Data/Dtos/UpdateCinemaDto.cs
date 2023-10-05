﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class UpdateCinemaDto
{
    [Required(ErrorMessage = "O campo Nome é obrigatório")]
    public string Nome { get; set; }
}
