namespace BC.Api.ViewModels
{
    public class StudentViewModel
    {
        
        public int StudentId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DateofBirth { get; set; }
        public int Gender { get; set; }
        public int Category { get; set; }
    }
}
