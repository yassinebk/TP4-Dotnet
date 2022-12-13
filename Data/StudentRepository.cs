using TP4.Data;
using TP4.Models;

class StudentRepository
{
    public List<Student>? AllStudents()
    {
        // Get all students from database
        var universityContext = UniversityContext.Instance;

        var student1 = universityContext.Student;
        if (student1 == null)
        {
            return new List<Student>();
        }
        else return student1.ToList();
    }

    public List<string?> AllCourses()
    {
        var universityContext = UniversityContext.Instance;

        var student1 = universityContext.Student;
        if (student1 == null) return new List<string?>();

        var courses = student1.ToList().Select(s => s.course).Distinct().ToList();

        return courses;
    }

    public Student? GetStudent(int id)
    {
        // Get student from database
        var universityContext = UniversityContext.Instance;

        var student1 = universityContext.Student;
        if (student1 == null)
        {
            return null;
        }
        else return student1.Find(id);
    }


    public List<Student> FindStudentByCourse(string course)
    {
        // Get student from database
        var universityContext = UniversityContext.Instance;

        var student1 = universityContext.Student;
        if (student1 == null)
        {
            return new List<Student>();
        }
        else return student1.Where(s => s.course == course).ToList();
    }

}