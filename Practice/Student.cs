using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
	internal class Student : Person
	{

		protected string student_enrollment;

		public string Student_enrollment
		{
			get { return student_enrollment; }
			set { student_enrollment = value; }
		}

		protected string university_career;

		public string University_career
		{
			get { return university_career; }
			set { university_career = value; }
		}
		protected double average_rating;

		public double Average_rating
		{
			get { return average_rating; }
			set { average_rating = value; }
		}

		public Student():base()
		{
			student_enrollment = "";
			university_career = "";
			average_rating = 0.0;
		}
		public Student(string name, string paternalname, string mothersurname, DateTime dath_birth,string enrollment,string university_career,double rating) :base(name, paternalname, mothersurname,dath_birth)
		{
			this.student_enrollment = enrollment;
			this.university_career = university_career;
			this.average_rating = rating;
		}

		public override string ToString()
		{ 
			return base.ToString() + "\n Identification number: " + student_enrollment + "\n Career: "+ university_career+" " + "\n Average: "+ " " + average_rating;
		}

	}
}
