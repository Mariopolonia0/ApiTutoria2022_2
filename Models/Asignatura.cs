using System.ComponentModel.DataAnnotations;

public class Asignatura
{
    [Key]
    public int AsignaturaId { get; set; } = 0;
    public int CarreraId { get; set; } = 0;
    public String Codigo { get; set; } = String.Empty;
    public String Nombre { get; set; } = String.Empty;
    public int Credito { get; set; } = 0;

}