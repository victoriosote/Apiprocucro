namespace WebProducto.Models
{
    using System.ComponentModel.DataAnnotations;
    public enum MarketType 
    {
        niños=0,
        jovenes=1,
        hombres=2,
        mujeres=3,
        mayores=4,
    }
    public enum CategoryType
    {
        ropa=0,
        electronicos=1,
        cosmeticos=2,
        muebleria=3,
        juegos=4,
        deportes=5,
        bebidas=6,
        alimentos=7,
    }
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        [StringLength(80,ErrorMessage="Nombre entre 5 y 80 choco",MinimumLength=5)]
        public string Name { get; set; }
        [Range(0, 10000, ErrorMessage = "El precio oscila entre 0 a 10000")]
        public double Price { get; set; }
        public MarketType Market  { get; set; }
        public CategoryType Category { get; set; }

    }
}