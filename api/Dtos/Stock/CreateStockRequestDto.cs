using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol must not be more than 10 characters long")]
        public string Symbol { get; set; }  = string.Empty;
        [Required]
        [MaxLength(10, ErrorMessage = "Company must not be more than 10 characters long")]
        public string CompanyName { get; set; } = string.Empty;
        [Required]
        [Range(0, 1000000000, ErrorMessage = "Price must be between 0 and 1000000000")]
        public decimal Price { get; set; }
        [Required]
        [Range(0.001, 100)]
        public decimal LastDiv { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "Industry must not be more than 10 characters long")]
        public string Industy { get; set; } = string.Empty;
        [Required]
        [Range(0, 5000000000, ErrorMessage = "Market cap must be between 0 and 5000000000")]
        public decimal MarketCap { get; set; }
    }
}