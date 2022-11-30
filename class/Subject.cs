public class Subject {
    private string subjectID;
    private string subjectName;

    private int enrollNumber;
    private int enrollAvalibleNumber;
    public Subject(string subjectID,string subjectName,int enrollAvalibleNumber) {
        this.subjectID = subjectID;
        this.subjectName = subjectName;
        this.enrollNumber = 0;  
        this.enrollAvalibleNumber = enrollAvalibleNumber;
    }

    public string getID(){
        return this.subjectID;
    }
    public string GetName(){
        return this.subjectName;
    }
    public int GetEnrollNumber(){
        return this.enrollNumber;
    }
    public int GetAvalible(){
        return this.enrollAvalibleNumber;
    }
    public void AddEnrollNumber(){
        this.enrollNumber++;
    }
}