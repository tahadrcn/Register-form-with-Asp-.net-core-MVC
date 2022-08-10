using System.Collections.Generic;

namespace courseapp.Models
{
    public static class repository
    {
        private static List<StudentsResponse> _students =new List<StudentsResponse>();

        public static List<StudentsResponse> Students{
            get{
                return _students;
            }
        }
        public static void AddStudent(StudentsResponse students){
            _students.Add(students);
        }
        
    }
}