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

    public bool findSubject(string a){
        foreach(Subject subject in this.subjectList) {
            if(a == subject.getID()){return true;}
        }
        return false;
    }
    public string getSubjectName(string id){
        foreach(Subject subject in this.subjectList) {
            if(id == subject.getID()){return subject.GetName();}
        }
        return null;
    }
    public bool isSubjectFull(string id){
        foreach(Subject subject in this.subjectList) {
            if(id == subject.getID()){
                if(subject.GetAvalible()==subject.GetEnrollNumber()){
                    return true;
                }
                else{return false;}
            }
        }
        return true;
    }
    
}