using System;

namespace GroupAssignment3
{

    public class StudentList: IStudentList

    {
        const int MaxNrOfStudents = 50;
        string[] students;

        private int _NrOfStudents = 0;
        private int _NrOfGroups = 0;
        private int _NrOfStudentsInGroup = 0;
        private int _NrOfStudentsNotInGroup = 0;
        public int NrOfStudents
        {
            get
            {
                return _NrOfStudents;
            }
        }


        public int NrOfGroups 
        { 
            get
            {
                return _NrOfGroups;
            }
            set
            {
                _NrOfGroups = value;
                _NrOfStudentsInGroup = _NrOfStudents / _NrOfGroups; //how many students in each group and how many groups.
                _NrOfStudentsNotInGroup = _NrOfStudents % _NrOfGroups;//how many remaining students after setting the groups.
            } 
        }

        public int NrStudentsInGroup 
        {
            get
            {
                return _NrOfStudentsInGroup;
            }
        }

        public int NrStudentsNotInGroup
        {
            get
            {
                return _NrOfStudentsNotInGroup;
            }
        }

        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < _NrOfStudents; i++)
            {
                sRet += $"{students[i],-15}";
                if ((i + 1) % 5 == 0)
                    sRet += "\n";
            }
            return sRet;
        }

        public void CreateOOP1dotNet5()
        {
            students = new string[MaxNrOfStudents];
            students[0] = "Sahar";
            students[1] = "Jennifer";
            students[2] = "Shohruh";
            students[3] = "Jonathan";
            students[4] = "Leo";
            students[5] = "Jenny";
            students[6] = "Mohamed";
            students[7] = "Ferri";
            students[8] = "Alexandra F";
            students[9] = "Vidar";
            students[10] = "Kamran";
            students[11] = "Pontus";
            students[12] = "Kaveh";
            students[13] = "Maria";
            students[14] = "Adam";
            students[15] = "Sophie";
            students[16] = "Louise";
            students[17] = "Fredric";
            students[18] = "Carl-Henrik";
            students[19] = "Frans";
            students[20] = "Sam";
            students[21] = "Alexandra S";
            students[22] = "Alperen";
            students[23] = "Josefine";
            students[24] = "Ghasem";
            students[25] = "Hanna";
            students[26] = "Finan";
            students[27] = "Niklas";
            students[28] = "Hector";
            students[29] = "Fredrik";
            students[30] = "Adrian";
            students[31] = "Teodor";

            _NrOfStudents = 30;
        }

        public void sortStrings()
        {
            String temp;

            // Sorting strings using bubble sort
            for (int j = 0; j < _NrOfStudents - 1; j++)
            {
                for (int i = j + 1; i < _NrOfStudents; i++)
                {


                    if (students[j].CompareTo(students[i]) > 0)
                    {
                        temp = students[j];
                        students[j] = students[i];
                        students[i] = temp;
                    }
                }
            }

        }
    }

}
