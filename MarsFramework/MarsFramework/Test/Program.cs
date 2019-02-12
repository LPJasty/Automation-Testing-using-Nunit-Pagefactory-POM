using MarsFramework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework
{
    public class Program
    {
		[TestFixture]
		[Category("Sprint1")]
		class Profile : Global.Base
		{

			[Test]
			public void EditProfile()
			{
				// Creates a toggle for the given test, adds all log events under it    
				test = extent.StartTest("Search for a Property");

				// Create an class and object to call the method
				MarsFramework.Profile obj = new MarsFramework.Profile();
				obj.EditProfile();

			}


			[Test]
			public void AddShareSkills()
			{
				// Creates a toggle for the given test, adds all log events under it    
				test = extent.StartTest("Search for a ShareSkills Button ");

				// Create an class and object to call the method
				ManageListingsPage obj1 = new ManageListingsPage();
				obj1.AddShareSkills();
				Thread.Sleep(1000);
				obj1.ValidateAddSkills();
			}


			[Test]
			public void EditSkills()
			{
				// Creates a toggle for the given test, adds all log events under it    
				test = extent.StartTest("Search for a Edit Button ");

				// Create an class and object to call the method
				ManageListingsPage obj2 = new ManageListingsPage();
				obj2.EditSkills();



			}
			[Test]
			public void DeleteSkills()
			{
				// Creates a toggle for the given test, adds all log events under it    
				test = extent.StartTest("Search for a Delete Button ");

				// Create an class and object to call the method
				ManageListingsPage obj3 = new ManageListingsPage();
				obj3.DeleteSkills();
				
			}
			[Test]
			public void ViewDetails()
			{
				// Creates a toggle for the given test, adds all log events under it    
				test = extent.StartTest("Search for a View Button ");

				// Create an class and object to call the method
				ManageListingsPage obj3 = new ManageListingsPage();
				obj3.ViewDetails();
			}
		}
	}
}