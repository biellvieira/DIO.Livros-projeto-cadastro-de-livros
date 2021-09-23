using System;

namespace DIO.Livros
{
    public class Livro : EntidadeBase
    {
        // Atributos
		private Genero Genero { get; set; }
		private string Titulo { get; set; }
		private string Descricao { get; set; }
	    private string Autor { get; set;}
        private string Editora {get; set;}
        private int NumeroDePaginas {get; set;}
        private bool Excluido {get; set;}

        // Métodos
		public Livro(int id, Genero genero, string titulo, string descricao, string autor, string editora, int numero_de_paginas)
		{
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = descricao;
			this.Autor = autor;
            this.Editora = editora;
            this.NumeroDePaginas = numero_de_paginas;
            this.Excluido = false;
		}

        public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Autor: " + this.Autor + Environment.NewLine;
            retorno += "Editora: " + this.Editora + Environment.NewLine;
            retorno += "Número de Páginas: " + this.NumeroDePaginas + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

        public string retornaTitulo()
		{
			return this.Titulo;
		}

		public int retornaId()
		{
			return this.Id;
		}
        public bool retornaExcluido()
		{
			return this.Excluido;
		}
        public void Excluir() {
            this.Excluido = true;
        }
    }
}