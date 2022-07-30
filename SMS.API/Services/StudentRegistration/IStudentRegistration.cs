using SMS.Model.StudentRegistration;

namespace SMS.API.Services.StudentRegistration
{
    public interface IStudentRegistration
    {
        bool SaveStudentRegistration(Student studentData);
        Student GetAllStudents();
        Student GetStudentById(long studentId);
        bool DeleteStudentById(long studentId);
        bool UpdateStudentById(long studentId);
    }
}
