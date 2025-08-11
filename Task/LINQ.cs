//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Task.LINQ
//{
//    // 1️⃣ Course Class
//    class Course
//    {
//        public int CourseId { get; set; }
//        public string CourseName { get; set; }
//    }

//    // 2️⃣ Student Class
//    class Student
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int Age { get; set; }
//        public Course Course { get; set; } // Student enrolled course
//    }

//    // 3️⃣ Course Manager
//    class CourseManager
//    {
//        public List<Course> Courses { get; set; } = new List<Course>();

//        public void AddCourse(Course course)
//        {
//            Courses.Add(course);
//            Console.WriteLine($"✅ Course '{course.CourseName}' added.");
//        }

//        public void ViewCourses()
//        {
//            Console.WriteLine("\n📚 List of Courses:");
//            foreach (var course in Courses)
//            {
//                Console.WriteLine($"ID: {course.CourseId}, Name: {course.CourseName}");
//            }
//        }
//    }

//    // 4️⃣ Student Manager
//    class StudentManager
//    {
//        public List<Student> StudentsList { get; set; } = new List<Student>();

//        public void AddStudent(Student student)
//        {
//            StudentsList.Add(student);
//            Console.WriteLine($"✅ Student '{student.Name}' added.");
//        }

//        public void ViewStudents()
//        {
//            Console.WriteLine("\n👨‍🎓 List of Students:");
//            foreach (var student in StudentsList)
//            {
//                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Course: {student.Course.CourseName}");
//            }
//        }

//        public void UpdateStudent(int id, string newName, int newAge, Course newCourse)
//        {
//            var student = StudentsList.FirstOrDefault(s => s.Id == id);
//            if (student != null)
//            {
//                student.Name = newName;
//                student.Age = newAge;
//                student.Course = newCourse;
//                Console.WriteLine($"✏️ Student ID {id} updated.");
//            }
//            else
//            {
//                Console.WriteLine("❌ Student not found.");
//            }
//        }

//        public void DeleteStudent(int id)
//        {
//            var student = StudentsList.FirstOrDefault(s => s.Id == id);
//            if (student != null)
//            {
//                StudentsList.Remove(student);
//                Console.WriteLine($"🗑️ Student ID {id} deleted.");
//            }
//            else
//            {
//                Console.WriteLine("❌ Student not found.");
//            }
//        }

//        // 🔍 LINQ: Find students above certain age
//        public void FindStudentsAboveAge(int age)
//        {
//            var result = StudentsList.Where(s => s.Age > age).ToList();
//            Console.WriteLine($"\n👴 Students above age {age}:");
//            foreach (var s in result)
//            {
//                Console.WriteLine($"{s.Name} ({s.Age} years)");
//            }
//        }

//        // 🔍 LINQ: Find students in a specific course
//        public void FindStudentsInCourse(string courseName)
//        {
//            var result = StudentsList.Where(s => s.Course.CourseName.Equals(courseName, StringComparison.OrdinalIgnoreCase)).ToList();
//            Console.WriteLine($"\n📖 Students in course '{courseName}':");
//            foreach (var s in result)
//            {
//                Console.WriteLine($"{s.Name} ({s.Course.CourseName})");
//            }
//        }
//    }

//    // 5️⃣ Program (Main)
//    class Program
//    {
//        static void Main()
//        {
//            CourseManager courseManager = new CourseManager();
//            StudentManager studentManager = new StudentManager();

//            // Add some courses
//            var c1 = new Course { CourseId = 1, CourseName = "Computer Science" };
//            var c2 = new Course { CourseId = 2, CourseName = "Mathematics" };
//            courseManager.AddCourse(c1);
//            courseManager.AddCourse(c2);

//            // View courses
//            courseManager.ViewCourses();

//            // Add students
//            studentManager.AddStudent(new Student { Id = 1, Name = "Ravi", Age = 21, Course = c1 });
//            studentManager.AddStudent(new Student { Id = 2, Name = "Anita", Age = 19, Course = c2 });
//            studentManager.AddStudent(new Student { Id = 3, Name = "Meera", Age = 23, Course = c1 });

//            // View students
//            studentManager.ViewStudents();

//            // Update student
//            studentManager.UpdateStudent(2, "Anita Sharma", 20, c1);

//            // Delete student
//            studentManager.DeleteStudent(1);

//            // View updated list
//            studentManager.ViewStudents();

//            // LINQ Queries
//            studentManager.FindStudentsAboveAge(20);
//            studentManager.FindStudentsInCourse("Computer Science");
//        }
//    }
//}
