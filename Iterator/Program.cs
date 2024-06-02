

namespace Iterator
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Initialize the school with students
			StudentSchool school = new StudentSchool();
			school.Add(new Student("Alice", "Mathematics"));
			school.Add(new Student("Bob", "Physics"));
			school.Add(new Student("Charlie", "Chemistry"));

			// Create student iterator
			IStudentIterator studentIterator = school.CreateIterator();

			Console.WriteLine("Iterating over the school:");

			for (Student student = studentIterator.First(); !studentIterator.IsDone; student = studentIterator.Next())
				Console.WriteLine($"Name: {student.Name}, Major: {student.Major}");
		}
	}
}
