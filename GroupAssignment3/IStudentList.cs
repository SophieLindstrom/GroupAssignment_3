using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment3
{
    interface IStudentList
    {
        const int MaxNrOfStudents = 50;

       
        public int NrOfStudents { get; }

        
        public int NrOfGroups { get; set; }

       
        public int NrStudentsInGroup { get; }

       
        public int NrStudentsNotInGroup { get; }

       
        public void sortStrings()
        {

        }
        public void CreateOOP1dotNet5();
    }
}
