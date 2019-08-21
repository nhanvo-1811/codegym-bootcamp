using System;
using System.Collections;
using System.Text;
using Example.BT4_Java.Models;
namespace Example.BT4_Java
{
    public class StudentMark : IStudentMark
    {
        private string fullName;
        private int id;
        private string _class;
        private int semester;
        private float averageMark;
        public int[] subjectMark = new int[5];
    
        public string FullName { get => fullName; set => fullName = value; }
        public int Id { get => id; set => id = value; }
        public string Class { get => _class; set => _class = value; }
        public int Semester { get => semester; set => semester = value; }
        public float AverageMark { get => averageMark; }

        public string Display()
        {
            //return string.Format("{0}{1}{2}{3}{4}" , fullName, id, _class, semester, averageMark) ;
            return $"Full name: { fullName} ID: { id}  Class: { _class}  " +
                    $"Semester: { semester} AverageMark: { averageMark}";
          
        }

        public void AveCal()
        {
            var total = 0;
            for (int i = 0; i < subjectMark.Length; i++)
            {
                total += (int)subjectMark[i];
            }
            averageMark = total / subjectMark.Length;
        }

    }
}
