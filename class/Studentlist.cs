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
  
}