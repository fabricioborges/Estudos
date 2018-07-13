using Projeto_Pizzaria.Dominio;
using Projeto_Pizzaria.Dominio.Features.Produtos;
using System.Collections.Generic;

namespace Projeto_Pizzaria.ComumTeste.Features
{
    public static partial class ObjectMother
    {
        public static Bebida Bebida
        {
            get
            {
                return new Bebida
                {
                    Nome = "Refri",
                    Valor = 2.35
                };
            }
        }

        public static Pizza Pizza
        {
            get
            {
                return new Pizza
                {
                    Nome = "Bacon",
                    Valor = 42.35,
                    TamanhoEnum = TamanhoEnum.Medio,
                    TipoPizzaEnum = TipoPizzaEnum.Salgado,
                    ValorGrande = 3,
                    ValorMedio = 42.35,
                    ValorPequeno = 1
                    
                   
                };
            }
        }

        public static Pizza PizzaValorMaior
        {
            get
            {
                return new Pizza
                {
                    Nome = "Calabresa",
                    Valor = 43.75,
                    TamanhoEnum = TamanhoEnum.Medio,
                    TipoPizzaEnum = TipoPizzaEnum.Salgado,
                    ValorGrande = 3,
                    ValorMedio = 43.75,
                    ValorPequeno = 1

                };
            }
        }


        public static Calzone Calzone
        {
            get
            {
                return new Calzone
                {
                    Nome = "Calzone",
                    Valor = 42.35                    

                };
            }
        }

        public static Adicional Adicional
        {
            get
            {
                return new Adicional
                {
                    Nome = "Borda Catupiri",
                    Valor = 1.75,
                    TamanhoEnum = TamanhoEnum.Medio                    

                };
            }
        }

        public static Adicional AdicionalCheddar
        {
            get
            {
                return new Adicional
                {
                    Nome = "Borda Chedar",
                    Valor = 1.50,
                    TamanhoEnum = TamanhoEnum.Medio

                };
            }
        }

        public static List<Produto> ListaPizzas
        {
            get
            {
                return new List<Produto>
                {
                    Pizza
                };
            }
        }
        public static List<Produto> ListaAdicionais
        {
            get
            {
                return new List<Produto>
                {
                    Adicional,
                    AdicionalCheddar
                    
                };
            }
        }

        public static List<Produto> ListaProduto
        {
            get
            {
                return new List<Produto>
                {
                    Pizza,
                    Bebida,
                    Calzone,
                    Adicional
                };
            }
        }

        public static List<Produto> ListaBebida
        {
            get
            {
                return new List<Produto>
                {
                    Bebida
                };
            }
        }

        public static List<Produto> ListaCalzone
        {
            get
            {
                return new List<Produto>
                {
                    Calzone
                };
            }
        }
    }
}
