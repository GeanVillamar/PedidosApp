using System.ComponentModel.DataAnnotations;

namespace Pedidos.Models;

public class EstadoPedido
{
    public int Id { get; set; }

    [Required, MaxLength(50)]
    public string Nombre { get; set; } = string.Empty;

    [MaxLength(200)]
    public string? Descripcion { get; set; }

    // Navegación
    public ICollection<Pedido> Pedidos { get; set; } = [];
}
