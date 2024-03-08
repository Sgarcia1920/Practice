using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
	internal class NamePerson
	{
		protected string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		protected string paternalsurname;

		public string Paternalsurname
		{
			get { return paternalsurname; }
			set { paternalsurname = value; }
		}

		protected string mothersurname;

		public string Mothersurname
		{
			get { return mothersurname; }
			set { mothersurname = value; }
		}
		public NamePerson()
		{
			name = "";
			paternalsurname = "";
			mothersurname = "";

		}

		public NamePerson(string name, string paternalname, string mothersurname)
		{
			this.name = name;
			this.paternalsurname = paternalname;
			this.mothersurname = mothersurname;
		}
		public override string ToString()
		{
			return "Student Name: " + name+" "+paternalsurname+" "+mothersurname ;
		}


	}
}
