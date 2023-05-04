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
        public ProducctWithTypesAndBrandsSpecification(int id) : base(x => x.Id == id)
        {
            AddIncludes(x => x.ProductType);
            AddIncludes(x => x.ProductBrand);
        }
    }
}
