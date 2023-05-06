using Core.Entities;

namespace Core.Specifications
{
    public class ProducctWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProducctWithTypesAndBrandsSpecification()
        {
            AddIncludes(a => a.ProductType);
            AddIncludes(a => a.ProductBrand);
            AddOrderBy(x => x.Name);
        }
        public ProducctWithTypesAndBrandsSpecification(string sort)
        {
            AddIncludes(a => a.ProductType);
            AddIncludes(a => a.ProductBrand);

            if (!string.IsNullOrEmpty(sort))
            {
                switch (sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(p => p.Name);
                        break;
                }
            }
        }

        public ProducctWithTypesAndBrandsSpecification(int id) : base(x => x.Id == id)
        {
            AddIncludes(x => x.ProductType);
            AddIncludes(x => x.ProductBrand);
        }
    }
}
