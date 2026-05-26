using System.ComponentModel.DataAnnotations;

namespace Pedidos.Models;

public class Usuario
{
    public int Id { get; set; }

    [Required, MaxLength(100)]
    public string Nombre { get; set; } = string.Empty;

    [Required, MaxLength(150)]
    public string Email { get; set; } = string.Empty;

    [MaxLength(20)]
    public string? Telefono { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navegación
    public ICollection<Pedido> Pedidos { get; set; } = [];
    public ICollection<Direccion> Direcciones { get; set; } = [];
}
