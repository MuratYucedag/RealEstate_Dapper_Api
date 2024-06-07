using RealEstate_Dapper_Api.Dtos.ToDoListDots;

namespace RealEstate_Dapper_Api.Repositories.ToDoListRepositories
{
    public interface IToDoListRepository
    {
        Task<List<ResultToDoListDto>> GetAllToDoList();
        Task CreateToDoList(CreateToDoListDto ToDoListDto);
        Task DeleteToDoList(int id);
        Task UpdateToDoList(UpdateToDoListDto ToDoListDto);
        Task<GetByIDToDoListDto> GetToDoList(int id);
    }
}
