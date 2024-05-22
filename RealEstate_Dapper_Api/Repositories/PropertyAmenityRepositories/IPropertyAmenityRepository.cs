using RealEstate_Dapper_Api.Dtos.PropertyAmentiyDtos;

namespace RealEstate_Dapper_Api.Repositories.PropertyAmenityRepositories
{
    public interface IPropertyAmenityRepository
    {
        Task<List<ResultPropertyAmenityByStatusTrueDto>> ResultPropertyAmenityByStatusTrue(int id);
    }
}
