using System.Collections.Generic;
using System;
class StudentList {
    private List<Student> personList;

    public StudentList() {
        this.personList = new List<Student>();
    }

    public void AddNewPerson(Student student) {
        this.personList.Add(student);
    }

    public bool findAccount(string username,string password){
        foreach(Student student in this.personList) {
            if(student.getUser()==username&&student.getPassword()==password){
                return true;
            }
        }
        return false;
    }
    public bool findAccountForRegister(string username){
        foreach(Student student in this.personList) {
            if(student.getUser()==username){
                return true;
            }
        }
        return false;
    }
    public void findStudentAndPrintSubject(string username){
        foreach(Student student in this.personList) {
            if(student.getUser()==username){
                student.printSubject(); break;
            }
        }
    }

    public void addSubject(string user,Subject subject){
        foreach(Student student in this.personList) {
            if(student.getUser()==user){
                student.addSubject(subject); break;
            }
        }
    }

     public void ShowEnroll(string user){
        foreach(Student student in this.personList) {
            if(student.getUser()==user){
                student.printSubject(); break;
            }
        }
    }
  
}