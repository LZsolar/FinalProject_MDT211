using System;
using System.Collections.Generic;

class Program
{
    static StudentList studentList;
    static TeacherList teacherList;
    static SubjectList subjectList;
    static int loginStatus = 0;
    static string currentLogin ="";
    public static void Main(string[] args)
    {
        Console.Clear();
        Program.studentList = new StudentList();
        Program.teacherList = new TeacherList();
        Program.subjectList = new SubjectList();
        checkLoginStatus();
    }
    //-----------------------------------------MENU ZONE---------------
    public static void checkLoginStatus(){
        switch(loginStatus){
            case 0: noLoginMenu(); break;
            case 1: studentMenu(); break;
            case 2: teacherMenu(); break;
            default: break;
        }
    }
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
            case 2: {Console.Clear();studentLoginMenu(); break;} 
            case 3: {Console.Clear();teacherLoginMenu(); break;} 
            case 4: break;
            default:{Console.WriteLine("Error Command not found. Press Enter to continue."); Console.Read();noLoginMenu();break;}
        }
    }
    public static void studentMenu(){
        Console.Clear();
        Console.WriteLine("Welcome to student menu "+currentLogin+" !");
        Console.WriteLine("What you would like to do?");
        Console.WriteLine("1 for Show Avalible subject.");
        Console.WriteLine("2 for Show your Subject.");
        Console.WriteLine("3 for Enroll in new subject.");
        Console.WriteLine("4 for log out");

        int x = int.Parse(Console.ReadLine());
        switch(x){
            case 1: {Console.Clear();showAvalibleSubject();break;}
            case 2: {Console.Clear();ShowEnrollSubject(); break;} 
            case 3: {Console.Clear();enrollSubject(); break;} 
            case 4: {logoutMenu(); break;}
            default:{Console.WriteLine("Error Command not found. Press Enter to continue."); Console.Read();checkLoginStatus();break;}
        }
    }
    public static void teacherMenu(){
        Console.Clear();
        Console.WriteLine("Welcome to Teacher menu "+currentLogin+" !");
        Console.WriteLine("What you would like to do?");
        Console.WriteLine("1 for Show Avalible subject.");
        Console.WriteLine("2 for Add new Subject.");
        Console.WriteLine("3 for log out");

        int x = int.Parse(Console.ReadLine());
        switch(x){
            case 1: {Console.Clear();showAvalibleSubject(); break;}
            case 2: {Console.Clear();AddSubject(); break;} 
            case 3: {logoutMenu(); break;}
            default:{Console.WriteLine("Error Command not found. Press Enter to continue."); Console.Read();checkLoginStatus();break;}
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
        else if(x==2){InputNewTeacher();}
        else {Console.WriteLine("Command Not found. return to menu");Console.ReadLine(); checkLoginStatus();}
}
static void InputNewStudent() {
    Console.WriteLine("Register new Student");
    Console.WriteLine("***************************");
    string name = inputName();
    string password = inputPassword();
    if(studentList.findAccountForRegister(name)){
        Console.WriteLine("Username used. Press Enter to continue."); Console.ReadLine();InputNewStudent();return;
    }
    Student student = new Student(name,password);

    Program.studentList.AddNewPerson(student);
    checkLoginStatus();
}
static void InputNewTeacher() {
    Console.WriteLine("Register new Teacher");
    Console.WriteLine("***************************");
    string name = inputName();
    string password = inputPassword();
    if(teacherList.findAccountForRegister(name)){
        Console.WriteLine("Username used. Press Enter to continue."); Console.ReadLine();InputNewTeacher();return;
    }
    Teacher teacher = new Teacher(name,password);

    Program.teacherList.AddNewPerson(teacher);
    checkLoginStatus();
}

static string inputName(){Console.Write("Please input your username: "); return Console.ReadLine();}
static string inputPassword(){Console.Write("Please input your password: "); return Console.ReadLine();}

//log in
public static void studentLoginMenu(){
        Console.WriteLine("Welcome to Student log in menu.");
        Console.WriteLine("You can type | exit | for return to main menu.");
        string user = inputName();
        if(user =="exit"){checkLoginStatus(); return;}
        string pass = inputPassword();

        if(!studentList.findAccount(user,pass)){
            Console.WriteLine("************************");
            Console.WriteLine("Incorrect email or password. Please try again.\n");
            Console.WriteLine("************************");
            Console.ReadLine();
            studentLoginMenu();
            return;
        }
        loginStatus=1; currentLogin=user;
        checkLoginStatus();
    }
    public static void teacherLoginMenu(){
        Console.WriteLine("Welcome to Teacher log in menu.");
        Console.WriteLine("You can type | exit | for return to main menu.");
        string user = inputName();
        if(user =="exit"){checkLoginStatus(); return;}
        string pass = inputPassword();

        if(!teacherList.findAccount(user,pass)){
            Console.WriteLine("************************");
            Console.WriteLine("Incorrect email or password. Please try again.\n");
            Console.WriteLine("************************");
            Console.ReadLine();
            teacherLoginMenu();
            return;
        }
        loginStatus=2; currentLogin = user;
        checkLoginStatus();
    }
    public static void logoutMenu(){
        loginStatus =0; currentLogin="";
        checkLoginStatus();
    }

    //เข้ามาดูรายชื่อวิชาตอนนี้
    static void showAvalibleSubject(){
        subjectList.printSubject();
        Console.Write("Press Enter to continue.");
        Console.ReadLine();
        checkLoginStatus();
    }

    //TEACHER
    //Addวิชาได้
    static void AddSubject(){
        Console.WriteLine("Welcome to AddSubject Menu");
        string id = inputSID();
        string name = inputSName();
        int maxStu = inputMax();
        if(subjectList.findSubject(id)){
            Console.WriteLine("Subject ID unavalible. Please Try again."); Console.Read();checkLoginStatus();return;
        }
        Subject newSubject = new Subject(id,name,maxStu);
        Program.subjectList.AddNewSubject(newSubject);

        Console.WriteLine("Add complete. Press Enter to continue");
        Console.ReadLine();
        checkLoginStatus();
    }
static string inputSID(){Console.Write("Please input Subject ID: "); return Console.ReadLine();}
static string inputSName(){Console.Write("Please input your Subject Name: "); return Console.ReadLine();}
static int inputMax(){Console.Write("Please input your Subject Max student: "); return int.Parse(Console.ReadLine());}


    //STUDENT
    //กดลงทะเบียน
    static void enrollSubject(){
        Console.WriteLine("Welcome to Enroll menu");
        Console.Write("Please input subject ID: ");
        string id = Console.ReadLine();
        if(!subjectList.findSubject(id)){
            Console.WriteLine("Subject not found. Please try again.");
            Console.ReadLine();
            Console.Clear();
            enrollSubject(); return;
        }
        Console.Write("Are you sure to enroll in " + subjectList.getSubjectName(id)+" ? (Y/N)");
        string temp = Console.ReadLine();
        if(temp!="Y"){Console.Write("Register cancel. Back to menu."); checkLoginStatus(); return;}

        Subject newSubject = new Subject(id,subjectList.getSubjectName(id),99);
        studentList.addSubject(currentLogin,newSubject);
        Console.Write("Register Complete. Press Enter to continue");
        Console.ReadLine();
        checkLoginStatus();
    }
    //ดูวิชาที่ตัวเองลงได้
    static void ShowEnrollSubject(){
        studentList.ShowEnroll(currentLogin);
        Console.Write("Press Enter to continue");
        Console.ReadLine();
        checkLoginStatus();
    }

}