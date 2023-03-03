using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    // Data layer
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
