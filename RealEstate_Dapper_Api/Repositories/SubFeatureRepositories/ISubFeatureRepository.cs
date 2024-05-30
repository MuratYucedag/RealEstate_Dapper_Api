using RealEstate_Dapper_Api.Dtos.SubFeatureDtos;

namespace RealEstate_Dapper_Api.Repositories.SubFeatureRepositories
{
    public interface ISubFeatureRepository
    {
        Task<List<ResultSubFeatureDto>> GetAllSubFeatureAsync();
    }
}
