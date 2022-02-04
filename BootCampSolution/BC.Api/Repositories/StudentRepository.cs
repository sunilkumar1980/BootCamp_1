using BC.Api.Helper;
using BC.Api.RepositoryContracts;
using BC.Api.ViewModels;

namespace BC.Api.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        AppDBContext dbContext;
       
        public StudentRepository(AppDBContext context)
        {
            this.dbContext = context;
         
        }

        public int AddRecord(StudentViewModel record)
        {
            dbContext.Students?.Add(new StudentModel
            {
                Category = record.Category,
                DateofBirth = record.DateofBirth,
                FirstName = record.FirstName,
                Gender = record.Gender,
                LastName = record.LastName,
                MiddleName = record.MiddleName
            });
            return dbContext.SaveChanges();
        }

        public int DeleteRecord(int id)
        {
            var student = dbContext.Students?.Where(x => x.StudentId == id).FirstOrDefault();
            int result = 0;
            if (student != null)
            {
                dbContext.Students?.Remove(student);
                result = dbContext.SaveChanges();
            }
            return result;

        }

        public List<StudentViewModel> GetAll()
        {
            var students = dbContext.Students;
            List<StudentViewModel> lst = (from student in students
                                          select new StudentViewModel
                                          {
                                              StudentId = student.StudentId,
                                              FirstName = student.FirstName,
                                              LastName = student.LastName,
                                              Gender = student.Gender,
                                              MiddleName = student.MiddleName,
                                              Category = student.Category,
                                              DateofBirth = student.DateofBirth
                                          }).ToList();

            return lst;
        }

        public StudentViewModel GetById(int id)
        {
            var student = dbContext.Students?.Where(x => x.StudentId == id).FirstOrDefault();
            if (student != null)
            {
                return new StudentViewModel
                {
                    StudentId = student.StudentId,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Gender = student.Gender,
                    MiddleName = student.MiddleName,
                    Category = student.Category,
                    DateofBirth = student.DateofBirth,
                };
            }
            else
            {
                return new StudentViewModel();
            }
        }

        public int UpdateRecord(StudentViewModel record)
        {
            var student = dbContext.Students?.Where(x => x.StudentId == record.StudentId).FirstOrDefault();
            if (student != null)
            {
                student.Category = record.Category;
                student.DateofBirth = record.DateofBirth;
                student.FirstName = record.FirstName;
                student.Gender = record.Gender;
                student.LastName = record.LastName;
                student.MiddleName = record.MiddleName;
                return dbContext.SaveChanges();
            }
            else
            {
                return 0;
            }
        }
    }
}
