public class Student {
    private string username;
    private string password;
    private List<string> subjectList;
    public Student(string username,string password) {
        this.subjectList = new List<String>();
        this.username = username;
        this.password = password;
    }

    public string getUser(){
        return this.username;
    }
    public string getPassword(){
        return this.password;
    }

    public void addSubject(string a){
        this.subjectList.Add(a);
    }
}