using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Stock;
using api.Models;
namespace api.Mappers
{
    public static class StockMapper
    {
        public static StockDto ToStockDto(this Stock stockModel)
        {
            return new StockDto
            {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Price = stockModel.Price,
                LastDiv = stockModel.LastDiv,
                Industy = stockModel.Industy,
                MarketCap = stockModel.MarketCap,
                Comments = stockModel.Comments.Select(c => c.ToCommentDto()).ToList()
            };
        }
    public static Stock ToStockFromCreateDTO(this CreateStockRequestDto stockDto)
    {
        return new Stock
        {
            Symbol = stockDto.Symbol,
            CompanyName = stockDto.CompanyName,
            Price = stockDto.Price,
            LastDiv = stockDto.LastDiv,
            Industy = stockDto.Industy,
            MarketCap = (long)stockDto.MarketCap,
        };
    }
}
}