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

        public ProducctWithTypesAndBrandsSpecification(string sort, int? brandId, int? typeId) :
            base(x =>
                        (brandId.HasValue || x.ProductBrandId == brandId) &&
                        (typeId.HasValue || x.ProductTypeId == typeId)
                )
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
        public ProducctWithTypesAndBrandsSpecification(ProductSpecParams productParams) :
            base(x =>
            (string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search)) &&
            (productParams.BrandId.HasValue || x.ProductBrandId == productParams.BrandId) &&
            (productParams.BrandId.HasValue || x.ProductTypeId == productParams.BrandId)
                )
        {
            AddIncludes(a => a.ProductType);
            AddIncludes(a => a.ProductBrand);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1), productParams.PageSize);
            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
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
    }
}
