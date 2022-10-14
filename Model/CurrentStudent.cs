class CurrentStudent: Person {
    private string studentID;
    private string age;
    private string allergy;
    private string religion;
    private string email;
    private string password;

    public CurrentStudent(string titleName, string firstName, string lastName,
    string studentID, string age, string allergy, string religion, string email, string password)
    : base(titleName, firstName, lastName) {
        this.studentID = studentID;
        this.age = age;
        this.allergy = allergy;
        this.religion = religion;
        this.email = email;
        this.password = password;
    }

    public string GetStudentID() {
        return this.studentID;
    }

    public string GetAge() {
        return this.age;
    }

    public string GetAllergy() {
        return this.allergy;
    }

    public string GetReligion() {
        return this.religion;
    }

    public string GetEmail() {
        return this.email;
    }

    public string GetPassword() {
        return this.password;
    }

}