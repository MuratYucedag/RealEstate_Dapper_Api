namespace RealEstate_Dapper_Api.Dtos.ProductDetailDtos
{
    public class GetProductDetailByIdDto
    {
        public int ProductDetailId { get; set; }
        public int BedRoomCount { get; set; }
        public int ProductSize { get; set; }
        public int BathCount { get; set; }
        public int GarageSize { get; set; }
        public string BuildYear { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public string VideoUrl { get; set; }
        public int ProductId { get; set; }
        public DateTime AdvertisementDate { get; set; }
    }
}
