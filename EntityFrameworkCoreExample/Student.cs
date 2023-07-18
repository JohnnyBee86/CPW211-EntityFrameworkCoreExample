using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreExample
{
	public class Student
	{
		[Key] // "annotates" the next element the primary key
		public int Id { get; private set; }

		public string FullName { get; set; }

		public DateTime DateOfBirth { get; set; }

		public string EmailAddress { get; set; }
	}
}
