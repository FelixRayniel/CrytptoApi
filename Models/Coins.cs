using System.ComponentModel.DataAnnotations;

public class Coins{

    [Key]
    public int MonedaId { get; set; }   
    public String? Descripcion { get; set; }
    public double? Valor { get; set; }
    public String? ImageUrl { get; set; }        
}