namespace AcademyManagment.Domain.Models.BaseModel
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }

        public BaseEntity()
        {
            CreatedDate = DateTime.UtcNow;
        }
    }
}
