namespace Iterator
{

	// Collection
	public interface ISchool
	{
		IStudentIterator CreateIterator();
	}

	// Concrete Collection
	public class StudentSchool : ISchool
	{
		private List<Student> students = new List<Student>();

		public void Add(Student student)
		{
			students.Add(student);
		}
		// Method chính để trả về Concrete Iterator
		public IStudentIterator CreateIterator()
		{
			return new StudentIterator(this);
		}

		// Dùng để trả về phần tử tại vị trí index
		public Student GetStudentAt(int index)
		{
			if (index >= 0 && index < students.Count)
			{
				return students[index];
			} else
			{
				throw new IndexOutOfRangeException("------------Invalid index.");
			}
		}

		// Đếm số lượng phần tử trong cấu trúc
		public int Count => students.Count;
	}
}
