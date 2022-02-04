using BC.Api.RepositoryContracts;
using BC.Api.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;


namespace BC.Api.Controllers
{
    [Route("Api")]
    [EnableCors]
    public class StudentController : Controller
    {
        IStudentRepository studentRepo;
        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepo = studentRepository;
        }


       [Route("AllStudents")]
       [HttpGet]
       public List<StudentViewModel> GetAllStudents()
        {
           var allStudents= studentRepo.GetAll();
            return allStudents;

        }

        [Route("StudentById")]
        [HttpGet]
        public StudentViewModel GetStudentById(int id)
        {
            return studentRepo.GetById(id);
        }

        [HttpPut]
        [Route("AddStudent")]
        public int AddStudent(StudentViewModel student)
        {
            return studentRepo.AddRecord(student);
        }


        [HttpPut]
        [Route("UpdateStudent")]
        public int UpdateStudent(StudentViewModel student)
        {
            return studentRepo.UpdateRecord(student);
        }

        [HttpPost]
        [Route("DeleteStudent")]
        public int DeleteStudent(int id)
        {
            return studentRepo.DeleteRecord(id);
        }

        
    }
}
