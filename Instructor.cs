namespace StudentExercises
{
  public class Instructor
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SlackHandle { get; set; }
    public string Cohort { get; set; }
    public string Specialty { get; set; }

    // A method to assign an exercise to a student
    public void AssignExercise(Exercise exercise, Student student)
    {

    }
  }
}