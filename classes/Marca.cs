using System;
using System.Collections.Generic;

namespace Projeto_de_Produtos_POO.classes
{
    public class Marca
    {
        //ATRIBUTOS
        int Codigo { get; set; }
        public string NomeMarca { get; set; }
        DateTime DataCadastro { get; set; }
        
        //LISTA DAS MARCAS
        List<Marca> Marcas = new List<Marca>();

        //MÉTODO PARA CADASTRAR AS MARCAS
        public Marca CadastrarMarca(){

            Marca novaMarca = new Marca();
            
            System.Console.Write("CÓDIGO DA MARCA: ");
            novaMarca.Codigo = int.Parse(Console.ReadLine());

            System.Console.Write("NOME DA MARCA: ");
            novaMarca.NomeMarca = Console.ReadLine();

            novaMarca.DataCadastro = DateTime.UtcNow;

            Marcas.Add(novaMarca);

            return novaMarca;
        }


        //MÉTODO PARA LISTAR AS MARCAS CADASTRADOS
        public void Listar(){

            foreach (Marca item in Marcas) //LEITURA DE TODOS ITENS DENTRO DA LISTA
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine($"CÓDIGO: {item.Codigo}");
                System.Console.WriteLine($"MARCA: {item.NomeMarca}");  
                System.Console.WriteLine($"DATA DO CADASTRO: {item.DataCadastro}");
                Console.ResetColor();
            }

        }
        
        //MÉTODO PARA DELETAR ALGUMA MARCA
        public void Deletar(int cod){

           Marca marcaDelete = Marcas.Find(m => m.Codigo == cod);
           Marcas.Remove(marcaDelete);
        }
       
    }
}