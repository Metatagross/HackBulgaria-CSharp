using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Student : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string name;
        private int facultyNumber;
        private double grade;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if(name == null)
                {
                    name = value;
                    PropertyChanged(this , new PropertyChangedEventArgs(Name));

                }
                else
                {
                    string newName = value;
                    if(!name.Equals(newName) && PropertyChanged != null)
                    {
                        name = newName;
                        PropertyChanged(this , new PropertyChangedEventArgs(Name));
                    }
                }

            }
        }
        public int FacultyNumber
        {
            get
            {
                return facultyNumber;
            }
            set
            {
                if(facultyNumber == default(int))
                {
                    facultyNumber = value;
                    PropertyChanged(this , new PropertyChangedEventArgs(FacultyNumber.ToString()));

                }
                else
                {
                    int newNumber = value;
                    if(newNumber == facultyNumber && PropertyChanged != null)
                    {
                        facultyNumber = value;
                        PropertyChanged(this , new PropertyChangedEventArgs(FacultyNumber.ToString()));
                    }
                }
            }
        }

        public double Grade
        {
            get
            {
                return grade;
            }

            set
            {
                if(grade == default(int))
                {
                    grade = value;
                    PropertyChanged(this , new PropertyChangedEventArgs(Grade.ToString()));

                }
                else
                {
                    double newGrade = value;
                    if(newGrade == grade && PropertyChanged != null)
                    {
                        grade = value;
                        PropertyChanged(this , new PropertyChangedEventArgs(Grade.ToString()));
                    }
                }

            }
        }
    }
}
