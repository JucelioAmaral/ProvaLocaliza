﻿using DesafioTecEngLocaliza.Domain;
using System;

namespace DesafioTecEngLocaliza.Application.Dtos
{
    public class VeiculoDto
    {        
        public string Placa { get; set; }        
        public MarcaDto Marca { get; set; }        
        public ModeloDto Modelo { get; set; }
        public int? Ano { get; set; }
        public double ValorHora { get; set; }
        public string Combustivel { get; set; }
        public int LimitePortaMalas { get; set; }
        public string Categoria { get; set; }
    }
}
