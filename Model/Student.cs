class Student: Person {
    private string age;
    private string level;
    private string allergy;
    private string religion;
    private string school;
    
    public Student(string titleName, string firstName, string lastName,
    string age, string level, string allergy, string religion, string school)
    : base(titleName, firstName, lastName) {
        this.age = age;
        this.level = level;
        this.allergy = allergy;
        this.religion = religion;
        this.school = school;
    }

    public string GetAge() {
        return this.age;
    }

    public string GetLevel() {
        return this.level;
    }
    public string GetAllergy() {
        return this.allergy;
    }

    public string GetReligion() {
        return this.religion;
    }

    public string GetSchool() {
        return this.school;
    }

}