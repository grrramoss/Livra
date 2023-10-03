using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Livra.Models
{
    public class LivrosModel
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Genero { get; set; }
        [Range(1, 100, ErrorMessage = "A quantidade mínima é 1")]
        public int Estoque { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Preço { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime Data { get; set; }

        public IEnumerable<LivrosModel> TodosOsLivros()
        {
            var retorno = new Collection<LivrosModel>
            {
                new LivrosModel
                {
                    Titulo = "Flores de alvenaria",
                    Autor = "Sergio Vaz",
                    Genero ="Poesia brasileira",
                    Estoque =3,
                    Preço ="R$34,00",
                    Data = new DateTime(2023,3,1)
                },

                new LivrosModel
                {
                    Titulo = "Maravilhosa obra do acaso",
                    Autor = "Wim Kayser",
                    Genero ="Teoria do conhecimento",
                    Estoque =4,
                    Preço ="R$78,00",
                    Data = new DateTime(2023,4,9)
                },

                new LivrosModel
                {
                    Titulo = "Gandhi",
                    Autor = "Louis Fischer",
                    Genero ="Biografia",
                    Estoque =3,
                    Preço ="R$79,00",
                    Data = new DateTime(2023,7,9)
                },

                new LivrosModel
                {
                    Titulo = "Ensinando a transgredir",
                    Autor = "Bell Hooks",
                    Genero ="Ensino",
                    Estoque =8,
                    Preço ="R$83,00",
                    Data = new DateTime(2023,4,4)
                },

                new LivrosModel
                {
                    Titulo = "Literatura pão e poesia",
                    Autor = "Sergio Vaz",
                    Genero ="Crônicas brasileira",
                    Estoque =2,
                    Preço ="R$34,00",
                    Data = new DateTime(2022,8,9)
                },

                new LivrosModel
                {
                    Titulo = "Ervas aromáticas e plantas medicinais",
                    Autor = "Cândida Correia",
                    Genero ="Guia prático",
                    Estoque =1,
                    Preço ="R$29,00",
                    Data = new DateTime(2023,4,2)
                },

                new LivrosModel
                {
                    Titulo = "Madame Bovary",
                    Autor = "Gustave Flaubert",
                    Genero ="Romance",
                    Estoque =2,
                    Preço ="R$32,00",
                    Data = new DateTime(2023,3,4)
                },
            };
            return retorno;
        }


    }
}

