using RealEstate_Dapper_Api.Dtos.ProductDetailDtos;
using RealEstate_Dapper_Api.Dtos.ProductImageDtos;

namespace RealEstate_Dapper_Api.Repositories.ProductImageRepositories
{
    public interface IProductImageRepository
    {
        Task<List<GetProductImageByProductIdDto>> GetProductImageByProductId(int id);
    }
}
