using StudentAdminPortal.API.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllStudentsAsync();
        Task<Student> GetStudentAsync(Guid studentId);
        Task<List<Gender>> GetAllGendersAsync();
        Task<bool> ExistsStudent(Guid studentId);
        Task<Student> UpdatedStudentAsync(Guid studentId, Student student);
        Task<Student> DeleteStudent(Guid studentId);
        Task<Student> AddStudent(Student request);
    }
}
