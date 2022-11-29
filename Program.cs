//ที่นี้หนอนยึด หยั่มมายุ่ง//
using System;
using System.Collections.Generic;

class Program
{
    static StudentList studentList;
    static TeacherList teacherList;
    static SubjectList subjectList;
    public static void Main(string[] args)
    {
        Console.Clear();
        Program.studentList = new StudentList();
        Program.teacherList = new TeacherList();
        Program.subjectList = new SubjectList();
    }
    //-----------------------------------------MENU ZONE---------------
    public static void noLoginMenu(){
        Console.Clear();
        Console.WriteLine("Welcome");
        Console.WriteLine("What you would like to do?");
        Console.WriteLine("1 for Register");
        Console.WriteLine("2 for Log in as Student");
        Console.WriteLine("3 for Log in as Teacher");
        Console.WriteLine("4 for Exit");

        int x = int.Parse(Console.ReadLine());
        switch(x){
            case 1: {Console.Clear();registerMenu();break;}
            case 2: {Console.Clear(); break;} 
            case 3: {Console.Clear(); break;} 
            case 4: break;
            default:{Console.WriteLine("Error Command not found. Press Enter to continue."); Console.Read();noLoginMenu();break;}
        }
    }

//register
 public static void registerMenu(){
        Console.Clear();
        Console.WriteLine("Please choose your type");
        Console.WriteLine("1 for Student");
        Console.WriteLine("2 for Teacher");

        int x = int.Parse(Console.ReadLine());
        if(x==1){InputNewStudent();}
        if(x==2){InputNewTeacher();}
}
static void InputNewStudent() {
    Console.WriteLine("Register new Student");
    Console.WriteLine("***************************");
    string name = inputName();
    string password = inputPassword();
    Student student = new Student(name,password);

    Program.studentList.AddNewPerson(student);
}
static void InputNewTeacher() {
    Console.WriteLine("Register new Student");
    Console.WriteLine("***************************");
    string name = inputName();
    string password = inputPassword();
    Teacher teacher = new Teacher(name,password);

    Program.teacherList.AddNewPerson(teacher);
}

static string inputName(){Console.Write("Please input your username: "); return Console.ReadLine();}
static string inputPassword(){Console.Write("Please input your password: "); return Console.ReadLine();}

//log in
public static void inputLoginMenu(){
        Console.WriteLine("Welcome to Student log in menu.");
        Console.WriteLine("You can type | exit | for return to main menu.");
        string user = inputName();
        if(user =="exit"){return;}
        string pass = inputPassword();

        if(!teacherList.findAccount(user,pass)){
            Console.WriteLine("************************");
            Console.WriteLine("Incorrect email or password. Please try again.\n");
            Console.WriteLine("************************");
            inputLoginMenu();
            return;
        }

    }
    public static void logoutMenu(){

    }
//STUDENT
//เข้ามาดูรายชื่อวิชาตอนนี้
//กดลงทะเบียน
//ดูวิชาที่ตัวเองลงได้

//TEACHER
//Addวิชาได้
}