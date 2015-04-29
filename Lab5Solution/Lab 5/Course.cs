namespace Lab_5
{
    class Course
    {
        public string Name;
        public int ID;
        public Student[] Students;

        public Course()
        {
            this.Name = Question.AskForString("Whats the Course Name?");
            this.ID = Question.AskForInteger("Whats the Course ID?");
            this.Students = new Student[Question.AskForInteger("How many students?")];

            for (int i = 0; i < Students.Length; i++)
            {
                this.Students[i] = new Student();
            }
        }
    }
}