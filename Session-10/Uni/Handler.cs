using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Uni {
    public class Handler {
        public University University { get; set; }
        private int _amountOfSchedules = 0;

        public Handler() {
            University = new University();
            University.Students = new List<Student>();
            University.Courses = new List<Course>();
            University.Grades = new List<Grade>();
            University.Professors = new List<Professor>();
            University.ScheduledCourses = new List<Schedule>();
        }

        //personal hnalders for returning string / to be refactored later.
        public string GetUniName() {
            return University.Name;
        }
        public List<Student> GetStudents() {
            return University.Students;
        }
        public List<Course> GetCourses() {
            return University.Courses;
        }
        public List<Grade> GetGrades() {
            return University.Grades;
        }

        //to be refactored for later.
        public void SetCourse(Guid courseID, Guid professorID, DateTime datetime) {
            University.ScheduledCourses[_amountOfSchedules++] = new Schedule(courseID, professorID, datetime);
        }

        //Serialization Methods imported from Serializer.cs 
        public void Serialize(object obj) {
            string jsonString = JsonSerializer.Serialize(obj);
        }

        public void SerializeToFile(object obj, string fileName) {

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(obj, options);

            File.WriteAllText(fileName, jsonString);
        }
        public T Deserialize<T>(string fileName) {

            string jsonString = File.ReadAllText(fileName);
            T? obj = JsonSerializer.Deserialize<T>(jsonString);

            return obj;
        }

        // method for populating uni with 2 data of each in each least As default data
        public void PopulateData() {
            Random rnd = new Random();
            University.Courses.Add(new Course("101","Intro to Desktop C#"));
            University.Courses.Add(new Course("102", "Intro to Blazor"));
            University.Professors.Add(new Professor("Fotis Chrysoulas", 44, "1", University.Courses));
            University.Professors.Add(new Professor("Dimitris Raptodimos", 40, "2", University.Courses));
            University.Students.Add(new Student("Stratos Chalkopiadis",26,141023,University.Courses));
            University.Students.Add(new Student("Stratos NotChalkopiadis", 25, 141022, University.Courses));

            for(int i=0;i<University.Courses.Count();i++) {
                University.ScheduledCourses.Add(new Schedule(University.Courses[i].ID, University.Professors[rnd.Next(0,1)].ID, DateTime.Now));
            }
            for (int i = 0; i < University.Courses.Count(); i++) {
                for (int j = 0; j < University.Students.Count(); j++) {
                    
                    University.Grades.Add(new Grade(University.Courses[i].ID, University.Students[i].ID, rnd.Next(5, 10)));
                }
            }
            //potential !!breaking!! here since if added elements need to care for proffessors too.




        }

    }
}
