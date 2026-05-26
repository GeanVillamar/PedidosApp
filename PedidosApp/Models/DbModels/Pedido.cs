using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pedidos.Models;

public class Pedido
{
    public int Id { get; set; }

    public int UsuarioId { get; set; }
    public int DireccionId { get; set; }
    public int EstadoId { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Total { get; set; }

    public DateTime FechaPedido { get; set; } = DateTime.UtcNow;

    // Navegación
    public Usuario Usuario { get; set; } = null!;
    public Direccion Direccion { get; set; } = null!;
    public EstadoPedido Estado { get; set; } = null!;
    public ICollection<DetallePedido> Detalles { get; set; } = [];
}
