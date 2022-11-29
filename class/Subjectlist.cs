using System.Collections.Generic;
using System;
class SubjectList {
    private List<Subject> subjectList;

    public SubjectList() {
        this.subjectList = new List<Subject>();
    }

    public void AddNewSubject(Subject subject) {
        this.subjectList.Add(subject);
    }

    public void printSubject(){
        Console.WriteLine("***** Avelible Subject List *****");
        foreach(Subject subject in this.subjectList) {
            Console.WriteLine("ID: "+subject.getID()+"  Name: "+subject.GetName());
        }
    }
}