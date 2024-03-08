using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
	internal class Person : NamePerson
	{
		protected DateTime dath_birth;

		public DateTime Dath_birth
		{
			get { return dath_birth; }
			set { dath_birth = value; }
		}
		public Person():base()
		{
			this.dath_birth = DateTime.Now;
		}

		public Person(string name, string paternalname, string mothersurname,DateTime dath_birth) :base(name,paternalname,mothersurname)
		{
			this.dath_birth = dath_birth;
		}

		public override string ToString()
		{
			return base.ToString()  + "\n Date of birth: " + "" + dath_birth;
        }



	}
}
