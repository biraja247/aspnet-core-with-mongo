using Catalog.Dtos;
using Catalog.Entities;

namespace Catalog
{
    public static class Extension
    {
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto
             {
                Id = item.Id,
                Price = item.Price,
                Name = item.Name,
                CreatedDate = item.CreatedDate
            };
        }
    }
}