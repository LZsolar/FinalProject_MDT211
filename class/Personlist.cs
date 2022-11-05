using System.Collections.Generic;
using System;
class PersonList {
    private List<Person> personList;

    public PersonList() {
        this.personList = new List<Person>();
    }

    public void AddNewPerson(Person person) {
        this.personList.Add(person);
    }

    public bool findPersonName(string title,string name,string surname){
        foreach(Person person in this.personList) {
            if(person.GetTitle()==title&&person.GetName()==name&&person.GetSurame()==surname){
                return true;
            }
        }
        return false;
    }
  
}