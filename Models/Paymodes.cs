namespace SupermarketWEB.Models
{
    public class Paymodes
    {
        public int Id { get; set; } //Será la llave primaria
        public string? Method { get; set; } //Metodos de pago como: Efectivo, Tarjeta, Cheque.
        public string? Description { get; set; }
    }
}
