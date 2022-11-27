using System.Collections.Generic;
using System;
class SubjectList {
    private List<Subject> subjectList;

    public SubjectList() {
        this.subjectList = new List<Subject>();
    }

    public void AddNewPerson(Subject subject) {
        this.subjectList.Add(subject);
    }

}