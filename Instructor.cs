namespace StudentExercises
{
  public class Instructor
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SlackHandle { get; set; }
    public Cohort Cohort { get; set; }
    public string Specialty { get; set; }

    // A method to assign an exercise to a student
    public void AssignExercise(Student student, Exercise exercise)
    {
      student.Exercises.Add(exercise);
    }
  }
}