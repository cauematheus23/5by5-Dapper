// See https://aka.ms/new-console-template for more information
using Controllers;
using Models;

Console.WriteLine("Inicio...");

Pedido pedido = new Pedido  
{
    Id = 2,
    Descricao = "Quero tudo4",
    Mesa = 10,
    Item = new Item { Descricao = "Coca" }
};
if(new PedidoController().Inserir(pedido))
{
    Console.WriteLine("Inserido com sucesso");
}
else
{
    Console.WriteLine("Erro");
}


