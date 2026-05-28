using System.ComponentModel.DataAnnotations.Schema;

namespace Pedidos.Models;

public class DetallePedido
{
    public int Id { get; set; }

    public int PedidoId { get; set; }
    public int ProductoId { get; set; }

    public int Cantidad { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal PrecioUnitario { get; set; }  // Precio al momento de compra

    // Navegación
    public Pedido Pedido { get; set; } = null!;
    public Producto Producto { get; set; } = null!;
}
