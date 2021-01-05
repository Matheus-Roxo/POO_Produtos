using System;
using System.Collections.Generic;

namespace Projeto_de_Produtos_POO.classes
{
    public class Produto
    {
        //ATRIBUTOS
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public Usuario CadastradoPor { get; set; }

        //LISTA DOS PRODUTOS
        public List<Produto> ListaDeProdutos = new List<Produto>();
        
        //METODOS
        public void Cadastrar(){

            Produto novoProduto = new Produto();
            
            System.Console.Write("CÓDIGO DO PRODUTO: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            System.Console.Write("NOME DO PRODUTO: ");
            novoProduto.NomeProduto = Console.ReadLine();

            System.Console.Write("PREÇO DO PRODUTO: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            novoProduto.DataCadastro = DateTime.UtcNow;

            novoProduto.Marca = Marca.CadastrarMarca();

            novoProduto.CadastradoPor = new Usuario(); 

            ListaDeProdutos.Add(novoProduto);
           
        }

        //MÉTODO PARA LISTAR OS ITENS DA ARMAZENADOS NA LISTA
        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in ListaDeProdutos)
            {
                System.Console.WriteLine($"CÓDIGO: {item.Codigo}");
                System.Console.WriteLine($"PRODUTO: {item.NomeProduto}");
                System.Console.WriteLine($"PREÇO: {item.Preco}");
                System.Console.WriteLine($"DATA DE CADASTRO: {item.DataCadastro}");
                System.Console.WriteLine($"MARCA: {item.Marca.NomeMarca}");
                System.Console.WriteLine($"CADASTRADO POR: {item.CadastradoPor.Nome}");
                System.Console.WriteLine();
            }
            Console.ResetColor();
        }

        //MÉTODO PARA DELETAR ALGUM PRODUTO CADASTRADO
        public void Deletar(int cod){
            Produto prodDelete = ListaDeProdutos.Find(p => p.Codigo == cod);
            ListaDeProdutos.Remove(prodDelete);
        }
    }
}