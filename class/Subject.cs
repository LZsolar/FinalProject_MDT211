public class Subject {
    private string subjectID;
    private string subjectName;
    public Subject(string subjectID,string subjectName) {
        this.subjectID = subjectID;
        this.subjectName = subjectName;
    }

    public string getID(){
        return this.subjectID;
    }
    public string GetName(){
        return this.subjectName;
    }
}