public class Teacher {
    private string username;
    private string password;

    public Teacher(string username,string password) {
        this.username = username;
        this.password = password;
    }

    public string getUser(){
        return this.username;
    }
    public string getPassword(){
        return this.password;
    }

}