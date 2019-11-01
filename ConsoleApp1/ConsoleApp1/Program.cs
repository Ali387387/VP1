using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ConsoleApp1
{
    class Student
    {
        private string _id;
        private string _name;
        private double _gpa;
        private string _department;
        private double _semester;
        private string _universityName;
        private bool _attendance;

        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public double gpa
        {
            get
            {
                return _gpa;
            }
            set
            {
                _gpa = value;
            }
        }
        public string department
        {
            get
            {
                return _department;
            }
            set
            {
                _department = value;
            }
        }
        public double semester
        {
            get
            {
                return _semester;
            }
            set
            {
                _semester = value;
            }
        }
        public string university
        {
            get
            {
                return _universityName;
            }
            set
            {
                _universityName = value;
            }
        }
        public bool attendance
        {
            get
            {
                return _attendance;
            }
            set
            {
                _attendance = value;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            char menuchoice;
            int choice, ch;
            string searchbyname, searchbyID, markAttendance;
            do
            {
                Console.WriteLine("Press 1 to enter student data : ");
                Console.WriteLine("Press 2 to search student : ");
                Console.WriteLine("Press 3 to Delete student record : ");
                Console.WriteLine("Press 4 to List top 3 students of the class : ");
                Console.WriteLine("Press 5 to Mark student attendance : ");
                Console.WriteLine("Press 6 to view attendance : ");

                Console.WriteLine("Enter choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (choice == 1)
                {
                    Student s = new Student();


                    Console.WriteLine("Enter student Name :");
                    s.name = Console.ReadLine();
                    Console.WriteLine("Enter Enrollment number : ");
                    s.id = Console.ReadLine();
                    Console.WriteLine("Enter GPA : ");
                    s.gpa = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Department :");
                    s.department = Console.ReadLine();
                   
                    Console.WriteLine("Enter Semester : ");
                    s.semester = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter University name : ");
                    s.university = Console.ReadLine();

                    StreamWriter writter = new StreamWriter(@"C:\\Users\Ali\\Desktop\\VP1.txt", append: true);
                    writter.WriteLine(s.name);
                    writter.WriteLine(s.id);
                    writter.WriteLine(s.gpa);
                    writter.WriteLine(s.department);
                    writter.WriteLine(s.semester);
                    writter.WriteLine(s.university);
                    writter.WriteLine(s.attendance);

                    writter.Close();
                    writter.Dispose();

                    Console.Clear();
                    Console.WriteLine("Record successfully saved .");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter 1 to search student by Name : ");
                    Console.WriteLine("Enter 2 to search student by enrollment : ");
                    Console.WriteLine("Press 3 to Display list of all students : ");
                    ch = Convert.ToInt32(Console.ReadLine());
                    if (ch == 1)
                    {
                        StreamReader reader = new StreamReader(@"C:\\Users\Ali\\Desktop\\VP1.txt");
                        List<Student> _list = new List<Student>();

                        while (reader.EndOfStream != true)
                        {
                            int i = 0;
                            Student stu = new Student();

                            stu.name = reader.ReadLine();
                            stu.id = reader.ReadLine();
                            stu.gpa = Convert.ToDouble(reader.ReadLine());
                            stu.department = reader.ReadLine();
                            stu.semester = Convert.ToDouble(reader.ReadLine());
                            stu.university = reader.ReadLine();
                            stu.attendance = Convert.ToBoolean(reader.ReadLine());
                            _list.Add(stu);
                            
                            i++;

                        }
                        reader.Close();
                        Console.WriteLine("Enter name ");
                        searchbyname = Console.ReadLine();
                        for (int x = 0; x <= _list.Count-1; x++)
                        {
                            try
                            {
                                if (_list[x].name == searchbyname)
                                {
                                    Console.WriteLine("Name : "+_list[x].name);
                                    Console.WriteLine("ID : "+_list[x].id);
                                    Console.WriteLine("GPA : "+_list[x].gpa);
                                    Console.WriteLine("Department : "+_list[x].department);
                                    Console.WriteLine("Semester : "+_list[x].semester);
                                    Console.WriteLine("University : "+_list[x].university);

                                }
                            }
                            catch
                            {
                                
                                continue;
                            }
                        }
                    }
                    else if (ch == 2)
                    {
                        StreamReader reader = new StreamReader(@"C:\\Users\Ali\\Desktop\\VP1.txt");
                        List<Student> _list = new List<Student>();

                        while (reader.EndOfStream != true)
                        {
                            int i = 0;
                            Student stu = new Student();

                            stu.name = reader.ReadLine();
                            stu.id = reader.ReadLine();
                            stu.gpa = Convert.ToDouble(reader.ReadLine());
                            stu.department = reader.ReadLine();
                            stu.semester = Convert.ToDouble(reader.ReadLine());
                            stu.university = reader.ReadLine();
                            stu.attendance = Convert.ToBoolean(reader.ReadLine());
                            _list.Add(stu);
                            
                            i++;

                        }
                        reader.Close();
                        Console.WriteLine("Enter Enrollment ");
                        searchbyID = Console.ReadLine();

                        for (int x = 0; x <= _list.Count-1; x++)
                        {
                            try
                            {
                                if (_list[x].id == searchbyID)
                                {
                                    Console.WriteLine("Name : "+_list[x].name);
                                    Console.WriteLine("ID : "+_list[x].id);
                                    Console.WriteLine("GPA : "+_list[x].gpa);
                                    Console.WriteLine("Department : "+_list[x].department);
                                    Console.WriteLine("Semester : "+_list[x].semester);
                                    Console.WriteLine("University : "+_list[x].university);
                                }
                            }
                            catch
                            {
                                Console.WriteLine("You entered wrong record / press wrong button");
                                continue;
                            }
                        }

                    }
                    else if (ch == 3)
                    {
                        //display all students
                        StreamReader reader = new StreamReader(@"C:\\Users\Ali\\Desktop\\VP1.txt");
                        List<Student> _list = new List<Student>();

                        while (reader.EndOfStream != true)
                        {
                            int i = 0;
                            Student stu = new Student();

                            stu.name = reader.ReadLine();
                            stu.id = reader.ReadLine();
                            stu.gpa = Convert.ToDouble(reader.ReadLine());
                            stu.department = reader.ReadLine();
                            stu.semester = Convert.ToDouble(reader.ReadLine());
                            stu.university = reader.ReadLine();
                            stu.attendance = Convert.ToBoolean(reader.ReadLine());

                            _list.Add(stu);
                           
                            i++;

                        }
                        reader.Close();
                        for (int x = 0; x <= _list.Count-1; x++)
                        {
                            Console.WriteLine("Name : "+_list[x].name);
                            Console.WriteLine("ID : "+_list[x].id);
                            Console.WriteLine("GPA : "+_list[x].gpa);
                            Console.WriteLine("Department : "+_list[x].department);
                            Console.WriteLine("Semester : "+_list[x].semester);
                            Console.WriteLine("University : "+_list[x].university);
                        }
                    }
                }
                else if (choice == 3)
                {
                    StreamReader reader = new StreamReader(@"C:\\Users\Ali\\Desktop\\VP1.txt");
                    List<Student> _list = new List<Student>();

                    while (reader.EndOfStream != true)
                    {
                        int i = 0;
                        Student stu = new Student();

                        stu.name = reader.ReadLine();
                        stu.id = reader.ReadLine();
                        stu.gpa = Convert.ToDouble(reader.ReadLine());
                        stu.department = reader.ReadLine();
                        stu.semester = Convert.ToDouble(reader.ReadLine());
                        stu.university = reader.ReadLine();
                        stu.attendance = Convert.ToBoolean(reader.ReadLine());
                        
                        _list.Add(stu);

                        i++;

                    }
                    reader.Close();
                    Console.WriteLine("Enter enrollment : ");
                    string deletebyID = Console.ReadLine();
                    //delete data
                    for(int j=0;j<=_list.Count-1;j++)
                    {
                        if(_list[j].id==deletebyID)
                        {
                            _list.RemoveAt(j);
                        }
                    }
                    
                    StreamWriter wri = new StreamWriter(@"C:\\Users\Ali\\Desktop\\VP1.txt");
                    wri.Write("");
                    for(int k=0;k<=_list.Count-1;k++)
                    {
                        wri.WriteLine(_list[k].name);
                        wri.WriteLine(_list[k].id);
                        wri.WriteLine(_list[k].gpa);
                        wri.WriteLine(_list[k].department);
                        wri.WriteLine(_list[k].semester);
                        wri.WriteLine(_list[k].university);
                        wri.WriteLine(_list[k].attendance);
                    }

                    wri.Close();
                }

                else if (choice == 4)
                {
                    //Console.WriteLine("Top 3 student of the class ");
                    StreamReader reader = new StreamReader(@"C:\\Users\Ali\\Desktop\\VP1.txt");
                    List<Student> _list = new List<Student>();

                    while (reader.EndOfStream != true)
                    {
                        int i = 0;
                        Student stu = new Student();

                        stu.name = reader.ReadLine();
                        stu.id = reader.ReadLine();
                        stu.gpa = Convert.ToDouble(reader.ReadLine());
                        stu.department = reader.ReadLine();
                        stu.semester = Convert.ToDouble(reader.ReadLine());
                        stu.university = reader.ReadLine();
                        stu.attendance = Convert.ToBoolean(reader.ReadLine());

                        _list.Add(stu);

                        i++;

                    }
                    reader.Close();
                    }
                }
                else if (choice == 5)
                {
                    StreamReader reader = new StreamReader(@"C:\\Users\Ali\\Desktop\\VP1.txt");
                    List<Student> _list = new List<Student>();
                    
                    while (reader.EndOfStream != true)
                    {
                        int i = 0;
                        Student stu = new Student();

                        stu.name = reader.ReadLine();
                        stu.id = reader.ReadLine();
                        stu.gpa = Convert.ToDouble(reader.ReadLine());
                        stu.department = reader.ReadLine();
                        stu.semester = Convert.ToDouble(reader.ReadLine());
                        stu.university = reader.ReadLine();
                        stu.attendance = Convert.ToBoolean(reader.ReadLine());

                        _list.Add(stu);

                        i++;

                    }
                    reader.Close();
                    for(int j=0;j<=_list.Count-1;j++)
                    {
                        Console.WriteLine(_list[j].name);
                        Console.WriteLine(_list[j].id);
                        Console.WriteLine(_list[j].gpa);
                        Console.WriteLine(_list[j].department);
                        Console.WriteLine(_list[j].semester);
                        Console.WriteLine(_list[j].university);
                        Console.WriteLine("Mark attendance of student : ");
                        markAttendance =Console.ReadLine();
                        if(markAttendance.ToLower()=="present")
                        {
                            _list[j].attendance = true;
                        }
                        else if (markAttendance.ToLower()=="absent")
                        {
                            _list[j].attendance = false;
                        }
                        StreamWriter wri = new StreamWriter(@"C:\\Users\Ali\\Desktop\\VP1.txt");
                        wri.Write("");
                        for (int k = 0; k <= _list.Count - 1; k++)
                        {
                            wri.WriteLine(_list[k].name);
                            wri.WriteLine(_list[k].id);
                            wri.WriteLine(_list[k].gpa);
                            wri.WriteLine(_list[k].department);
                            wri.WriteLine(_list[k].semester);
                            wri.WriteLine(_list[k].university);
                            wri.WriteLine(_list[k].attendance);
                        }
                        wri.Close();
                    }

                    
                }
                else if (choice == 6)
                {
                    Console.WriteLine("View Attendance : ");
                    //View attendance..
                    StreamReader reader = new StreamReader(@"C:\\Users\Ali\\Desktop\\VP1.txt");
                    List<Student> _list = new List<Student>();

                    while (reader.EndOfStream != true)
                    {
                        int i = 0;
                        Student stu = new Student();

                        stu.name = reader.ReadLine();
                        stu.id = reader.ReadLine();
                        stu.gpa = Convert.ToDouble(reader.ReadLine());
                        stu.department = reader.ReadLine();
                        stu.semester = Convert.ToDouble(reader.ReadLine());
                        stu.university = reader.ReadLine();
                        stu.attendance = Convert.ToBoolean(reader.ReadLine());

                        _list.Add(stu);

                        i++;

                    }
                    reader.Close();
                    for(int j=0;j<=_list.Count-1;j++)
                    {

                        Console.WriteLine(_list[j].name);
                        Console.WriteLine(_list[j].id);
                        Console.WriteLine(_list[j].gpa);
                        Console.WriteLine(_list[j].department);
                        Console.WriteLine(_list[j].semester);
                        Console.WriteLine(_list[j].university);
                        if(_list[j].attendance==true)
                        {
                            Console.WriteLine("PRESENT");
                        }
                        else if(_list[j].attendance==false)
                        {
                            Console.WriteLine("ABSENT");
                        }
                        
                    }
                }

                Console.WriteLine("Return to main menu Y/N");
                menuchoice = Convert.ToChar(Console.ReadLine());

            }
            while (menuchoice == 'Y' || menuchoice == 'y');
            
        }
    }

}