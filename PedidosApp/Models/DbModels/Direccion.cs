using System.ComponentModel.DataAnnotations;

namespace Pedidos.Models;

public class Direccion
{
    public int Id { get; set; }

    public int UsuarioId { get; set; }

    [Required, MaxLength(200)]
    public string Calle { get; set; } = string.Empty;

    [Required, MaxLength(100)]
    public string Ciudad { get; set; } = string.Empty;

    [MaxLength(10)]
    public string? CodigoPostal { get; set; }

    // Navegación
    public Usuario Usuario { get; set; } = null!;
    public ICollection<Pedido> Pedidos { get; set; } = [];
}
