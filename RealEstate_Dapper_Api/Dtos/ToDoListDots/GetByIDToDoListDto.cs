namespace RealEstate_Dapper_Api.Dtos.ToDoListDots
{
    public class GetByIDToDoListDto
    {
        public int ToDoListID { get; set; }
        public string Description { get; set; }
        public bool ToDoListStatus { get; set; }
    }
}
