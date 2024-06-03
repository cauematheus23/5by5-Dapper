using Dapper;
using Microsoft.Data.SqlClient;
using Models;

namespace Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private string Conn { get; set; }
        public PedidoRepository()
        {
            Conn = "Data Source=127.0.0.1; Initial Catalog=Restaurante; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=true;";
        }

        public bool Inserir(Pedido pedido)
        {
            var status = false;
            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                db.Execute("INSERT INTO TB_PEDIDO (Descricao,Mesa) Values (@Descricao,@Mesa)",pedido);
                status = true;
            }
            return status;
        }
    }
}
