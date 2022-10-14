class Teacher: Person {
    private string age;
    private string position;
    private string allergy;
    private string religion;
    private string carNumber;
    private string email;
    private string password;

    public Teacher(string titleName, string firstName, string lastName,
    string age, string position, string allergy, string religion,string carNumber, string email, string password)
    : base(titleName, firstName, lastName) {
        this.age = age;
        this.position = position;
        this.allergy = allergy;
        this.religion = religion;
        this.carNumber = carNumber;
        this.email = email;
        this.password = password;
    }

    public string GetAge() {
        return this.age;
    }

    public string GetPosition() {
        return this.position;
    }

    public string GetAllergy() {
        return this.allergy;
    }

    public string GetReligion() {
        return this.religion;
    }

    public string GetCarNumber() {
        return this.carNumber;
    }

    public string GetEmail() {
        return this.email;
    }

    public string GetPassword() {
        return this.password;
    }

}