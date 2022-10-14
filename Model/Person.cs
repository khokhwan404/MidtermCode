public abstract class Person {
    private string titleName;
    private string firstName;
    private string lastName;

    public Person(string titleName, string firstName, string lastName) {
        this.titleName = titleName;
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public string GetTitleName() {
        return this.titleName;
    }

    public string GetFirstName() {
        return this.firstName;
    }

    public string GetLastname() {
        return this.lastName;
    }
}