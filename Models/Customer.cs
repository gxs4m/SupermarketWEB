﻿namespace SupermarketWEB.Models
{
    public class Customer
    {
        public int Id { get; set; } //Será la llave primaria 
        public string Name { get; set; } 
        public string? Contact { get; set; }
        public string? Email { get; set; }
        
    }
}
