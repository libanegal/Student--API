namespace practose1
{
    public interface IStudentsManager 
    {
        public List<Student> GetAll();
        public void AddStudent(Student student);
        public void DeleteStudent(int id);
        public void UpdateStudent(Student studentToChange);
        public Student GetStudent(int id);
    }

    public class StudentsManager : IStudentsManager
    {
        public List<Student> Students;
        public StudentsManager()
        {
            AddStudents();
        }

        private void AddStudents() 
        {
            Students = new List<Student>()
            {
                new Student
            {
                id=1,
                age=17,
                firstName="Liban",
                secondName="Egal",
                Ethnicity="Somali",
                height=178,

            },
            new Student
            {
                id=2,
                age=17,
                firstName="Ted",
                secondName="Harrison",
                Ethnicity="English",
                height=184,

            },
            new Student
            {
                id=3,
                age=14,
                firstName="Marwa",
                secondName="Egal",
                Ethnicity="Somali",
                height=170,

            },
            new Student
            {
                id=4,
                age=23,
                firstName="Mohamed",
                secondName="Egal",
                Ethnicity="Somali",
                height=182,

            },
            new Student
            {
                id=5,
                age=20,
                firstName="Miski",
                secondName="Egal",
                Ethnicity="Somali",
                height=165,

            },
            new Student
            {
                id=6,
                age= 21,
                firstName="Muna",
                secondName="Egal",
                Ethnicity="Somali",
                height=11

            }
            };    
        }

        public List<Student> GetAll() 
        {
            return Students;
        }

        public void AddStudent(Student student) 
        {
            var studentFound = Students.Find(h => h.id == student.id);
            if (studentFound == null)
            {
                Students.Add(student);
            }
            else 
            {
                Console.WriteLine("Student already exists");
            }   
        }

        public void DeleteStudent(int id) 
        {
            var studentFound = Students.Find(h => h.id == id);
            if (studentFound == null) 
            {
                Console.WriteLine("Student you want to delete doesn't exist");
            }
            Students.Remove(studentFound);
        }

        public void UpdateStudent(Student studentToChange) 
        {
            var student=Students.Find(h => h.id == studentToChange.id);
            if (student == null) 
            {
                Console.WriteLine("Student you want to update doesn't exist");
            }
            student = studentToChange;
        }

        public Student GetStudent(int id) 
        {
            var studentFound = Students.Find(h => h.id == id);
            if (studentFound != null)
            {
                Console.WriteLine("Students doesn't exist");
            }
            return studentFound;
        }
    }
}
