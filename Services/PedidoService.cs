using Models;
using Repositories;

namespace Services
{
    public class PedidoService
    {
        private IPedidoRepository _pedidoRepository;
        private IItemRepository _itemRepository;
        public PedidoService()
        {
            _pedidoRepository = new PedidoRepository();
            _itemRepository = new ItemRepository();
        }
        public bool Inserir(Pedido pedido)
        {
            int IdItem = _itemRepository.Inserir(pedido.Item);
            pedido.Item.Id = IdItem;
            return _pedidoRepository.Inserir(pedido);
        }
    }
}
