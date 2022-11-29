public class Student {
    private string username;
    private string password;
    private List<Subject> subjectList;
    public Student(string username,string password) {
        this.subjectList = new List<Subject>();
        this.username = username;
        this.password = password;
    }

    public string getUser(){
        return this.username;
    }
    public string getPassword(){
        return this.password;
    }

    public void addSubject(Subject a){
        this.subjectList.Add(a);
    }

    public void printSubject(){
        Console.WriteLine("***** Register Subject List *****");
        foreach(Subject subject in this.subjectList) {
            Console.WriteLine("ID: "+subject.getID()+"  Name: "+subject.GetName());
        }
    }

}