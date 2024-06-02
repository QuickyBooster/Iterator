using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
	public interface IStudentIterator
	{
		Student First();
		Student Next();
		bool IsDone { get; }
		Student CurrentStudent { get; }
	}

	public class StudentIterator : IStudentIterator
	{
		private StudentSchool school;
		private int currentIndex = 0;

		// Đầu vào là Concrete Collection
		public StudentIterator(StudentSchool school)
		{
			this.school = school;
		}

		public Student First()
		{
			currentIndex = 0;
			return school.GetStudentAt(currentIndex);
		}

		public Student Next()
		{
			if (!(currentIndex >= school.Count))
			{
                currentIndex++;
                return school.GetStudentAt(currentIndex);
			} else
			{
				return null;
			}
		}
		// Kiểm tra đã bị duyệt quá mức chưa
		public bool IsDone
		{
			get { return currentIndex >= school.Count; }
		}

		public Student CurrentStudent
		{
			get { return school.GetStudentAt(currentIndex); }
		}
	}

}
