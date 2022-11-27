using System.Collections.Generic;
using System;
class TeacherList {
    private List<Teacher> teacherList;

    public TeacherList() {
        this.teacherList = new List<Teacher>();
    }

    public void AddNewPerson(Teacher teacher) {
        this.teacherList.Add(teacher);
    }

     public bool findAccount(string username,string password){
        foreach(Teacher teacher in this.teacherList) {
            if(teacher.getUser()==username&&teacher.getPassword()==password){
                return true;
            }
        }
        return false;
    }
  
}