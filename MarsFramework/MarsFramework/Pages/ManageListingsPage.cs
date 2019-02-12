using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using static NUnit.Core.NUnitFramework;
using AutoItX3Lib;

namespace MarsFramework.Pages
{
	class ManageListingsPage
	{
		public ManageListingsPage()
		{
			PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
		}

		#region Initialization

		//Click on ShareSkills
		[FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[1]/div/div[2]/a")]
		private IWebElement Shareskills { get; set; }

		////Click on ManageListings
		//[FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/section[1]/div/a[3]")]
		//private IWebElement ML { get; set; }

		//Click on ManageListings
		[FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[1]/div/a[3]")]
		private IWebElement ML { get; set; }

		////Click on Edit Button
		//[FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/i[2]")]
		//private IWebElement EditBtn { get; set; }

		//Click on Title
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")]
		private IWebElement Title { get; set; }

		//Click on Description
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")]
		private IWebElement Description { get; set; }

		//Click on Category
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select")]
		private IWebElement Category { get; set; }

		//Click on SubCategory
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/select")]
		private IWebElement SubCategory { get; set; }

		//Click on Tags
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")]
		private IWebElement Tags { get; set; }

		//Click on SeviceType 'One-off Service'
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
		private IWebElement ServiceType { get; set; }

		//Click on ServiceType 'Hourly basis service'
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")]
		private IWebElement Servicetype { get; set; }

		//Click on LocationType 'On-Site'
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]
		private IWebElement Locationtype { get; set; }

		//Click on LoacationType 'Online'
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
		private IWebElement LocationType { get; set; }

		//Click on MondayCheckBox
		[FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[3]/div[1]/div[1]/input[1]")]
		private IWebElement MondayCheckBox { get; set; }

		//Click on Monday StartTime
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input")]
		private IWebElement MondayStartTime { get; set; }

		//Click on Monday EndTime
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input")]
		private IWebElement MondayEndTime { get; set; }

		//Click on TuesdayCheckBox
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input")]
		private IWebElement TuesdayCheckBox { get; set; }

		//Click on Tuesday StartTime
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input")]
		private IWebElement TuesdayStartTime { get; set; }

		//Click on Tuesday EndTime
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input")]
		private IWebElement TuesdayEndTime { get; set; }

		//Click on Wednesday CheckBox
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[1]/div/input")]
		private IWebElement Wednesdaycheckbox { get; set; }

		//Click on Wednesday StartTime
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[2]/input")]
		private IWebElement WednesdayStartTime { get; set; }

		//Click on Wednesday Endtime
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[3]/input")]
		private IWebElement WednesdayEndTime { get; set; }

		//Click on ThursdayCheckBox
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[1]/div/input")]
		private IWebElement Thursdaycheckbox { get; set; }

		//Click on Thursday StartTime
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[2]/input")]
		private IWebElement ThursdayStartTime { get; set; }
		
		//Click on Thursday EndTime
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[3]/input")]
		private IWebElement ThursdayEndTime { get; set; }

		//Click on Skill Trade "Skill-exchange"
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input")]
		private IWebElement SkillTrade { get; set; }

		//Click on Skill Trade "Credit"
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input")]
		private IWebElement Skilltrade { get; set; }
        
		//Click on Credit
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input")]
		private IWebElement Credit { get; set; }

		//Click on Skill Exchange
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/input")]
		private IWebElement SkillExchange { get; set; }

		//Click on WorkSamples
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]
		private IWebElement WorkSample { get; set; }

		//Click on Active Radio Button
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input")]
		private IWebElement ActiveBtn { get; set; }

		//Click on Hidden Button
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input")]
		private IWebElement Hidden { get; set; }

		//Click on Save Button
		[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]")]
		private IWebElement SaveBtn { get; set; }
		
		//Click on Delete Button
		[FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[2]/td[8]/i[3]")]
		private IWebElement Delete { get; set; }

		////Click on View Button
		//[FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/i[1]")]
		//private IWebElement ViewBtn { get; set; }
		#endregion


		#region Add Skills

		public void AddShareSkills()
		{
			//Populate the Excel Sheet
			GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkills");
			Thread.Sleep(2000);

			//Click on ShareSkills
			Thread.Sleep(5000);
			Shareskills.Click();

			//Click on Title
			Thread.Sleep(5000);
			Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
			Thread.Sleep(500);

			//Click on Description
			Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
			Base.test.Log(LogStatus.Info, "Description Added Sucessfully");

			//Add Category
			Thread.Sleep(4000);
			//Actions action = new Actions(GlobalDefinitions.driver);
			//action.Click(Category);
			Category.Click();
			//action.MoveToElement(Category).Build().Perform();
			Console.WriteLine("Clicked on the Category");
			Thread.Sleep(2000);
			IList<IWebElement> CategoryList = Category.FindElements(By.TagName("option"));
			int Count = CategoryList.Count;
			Thread.Sleep(500);
			for (int i = 0; i < Count; i++)
			{
				Console.WriteLine("in");

				if(CategoryList[i].Text == GlobalDefinitions.ExcelLib.ReadData(2, "Category").Trim())
				//if (CategoryList[i].Text == " Graphics & Design ".Trim())
				{
					Thread.Sleep(1000);
					CategoryList[i].Click();
					Base.test.Log(LogStatus.Info, " Category Selected");
				}
			}

			//Add SubCategory
			SubCategory.Click();
			Console.WriteLine("Clicked on the SubCategory");
			Thread.Sleep(2000);
			IList<IWebElement> SubCatogeryList = SubCategory.FindElements(By.TagName("option"));
			//int count = SubCatogeryList.Count;
			Thread.Sleep(500);
			for (int i = 0; i < SubCatogeryList.Count; i++)
			{
				if (SubCatogeryList[i].Text == GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory").Trim())
				{
					Thread.Sleep(1000);
					SubCatogeryList[i].Click();
					Base.test.Log(LogStatus.Info, " SubCategory Selected");
				}
			}

			// Add Tags
			AutoItX3 autoIt = new AutoItX3();
			Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
			autoIt.Send("{Enter}");
			Base.test.Log(LogStatus.Info, " Tags Added successfully");

			// Select Service Type
			Thread.Sleep(1000);

			if (GlobalDefinitions.ExcelLib.ReadData(2, "Service Type") == " Hourly badis sevice ")
			{
				Servicetype.Click();
			}
			else
			{
				ServiceType.Click();
			}
			Base.test.Log(LogStatus.Info, "Service type Added successfully");

			//Select Location Type
			Thread.Sleep(1000);
			if (GlobalDefinitions.ExcelLib.ReadData(2, "Location Type") == "On-site")
			{
				Locationtype.Click();
			}
			else
			{
				LocationType.Click();
			}
			Base.test.Log(LogStatus.Info, "Location Type Edited successfully");

			//Monday selection
			MondayCheckBox.Click();
			MondayStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Start Time"));
			Thread.Sleep(1000);
			MondayEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "End Time"));
			Thread.Sleep(1000);

			//Tuesday Selection
			TuesdayCheckBox.Click();
			TuesdayStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Start Time"));
			TuesdayEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "End Time"));

			//Wednesday Selection
			Wednesdaycheckbox.Click();
			WednesdayStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(4, "Start Time"));
			WednesdayEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(4, "End Time"));

			//Selecting Skill Trade
			if (GlobalDefinitions.ExcelLib.ReadData(2, "Skill Trade") == "Credit")
			{
				Thread.Sleep(1000);
				Skilltrade.Click();
			}
			else
			{
				Thread.Sleep(1000);
				SkillTrade.Click();
			}
			Base.test.Log(LogStatus.Info, " Service Listing updated successfully");

			// Enter Credit 
			Thread.Sleep(1000);
			Credit.Clear();
			Credit.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Credit"));
			Thread.Sleep(1000);
			Base.test.Log(LogStatus.Info, " Service Listing updated successfully");
						
			//Upload WorkSample
			Thread.Sleep(3000);
			WorkSample.Click();
			Thread.Sleep(1000);
			AutoItX3 autoit = new AutoItX3();
			autoit.WinActivate("Open");
			autoit.Send(@"c:\users\rajesh jasti\Documents\ProfilePhoto.jpg");
			Thread.Sleep(2000);
			autoit.Send("{Enter}");
			Base.test.Log(LogStatus.Info, "Image Edited successfully");

			//Selecting Active
			Thread.Sleep(4000);
			if (GlobalDefinitions.ExcelLib.ReadData(2, "Active") == "Hidden")
			{
				Hidden.Click();
			}
			else
			{
				ActiveBtn.Click();
			}

			//Click on Save Button
			SaveBtn.Click();



		}

		#endregion Add Skills


		#region Validation Add Skills
		internal void ValidateAddSkills()

		{
			Thread.Sleep(3000);
			while (true)
			{
				var i = 1;

				while (i <= 10)

				{

					// identify 3rd row of table. Then extact the text and assign to a variable
					Thread.Sleep(7000);
					var Title = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[" + i + "]/td[3]")).Text;

					//compare the text with the expected text. QA

					if (Title == "QA")

					{
						Console.WriteLine(" Skill Added Successfully");
						return;

					}

					i++;
				}
				var Nextbtn = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div/button[4]"));
				Nextbtn.Click();
			}

		}

		#endregion Validation Add Skills


		#region EditSkills
		public void EditSkills()
		{

			//Populate the Excel Sheet
			GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
			Thread.Sleep(4000);

			//Click on ManageListings button
			Thread.Sleep(5000);
			Global.GlobalDefinitions.driver.Navigate().Refresh();
			ML.Click();
			Thread.Sleep(4000);

			while (true)

			{
				var j = 1;

				while (j <= 10)

				{
					// identify 2nd row of table. Then extact the text and assign to a variable

					var Category1 =Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[" + j + "]/td[2]")).Text;
					var EditBtn = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[" + j + "]/td[8]/i[2]"));
					//compare the text with the expected text. "Graphics & Design"

					if (Category1 == (Global.GlobalDefinitions.ExcelLib.ReadData(2,"Category1")))

				    {

						//Click on Edit Button
						EditBtn.Click();
						Thread.Sleep(3000);

						// Adding Title
						Title.Clear();
						Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
						Thread.Sleep(500);

						//Add Description
						Description.Clear();
						Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
						Thread.Sleep(3000);
						//SaveBtn.Click();
						Base.test.Log(LogStatus.Info, " Service Listing updated successfully");

						//Add Category
						Thread.Sleep(1500);
						//Actions action = new Actions(GlobalDefinitions.driver);
						//action.Click(Category);
						Category.Click();
						//action.MoveToElement(Category).Build().Perform();
						Console.WriteLine("Clicked on the Category");
						Thread.Sleep(2000);
						IList<IWebElement> CategoryList = Category.FindElements(By.TagName("option"));
						int Count = CategoryList.Count;
						Thread.Sleep(500);
						for (int i = 0; i < Count; i++)
						{
							Console.WriteLine("in");

							if (CategoryList[i].Text == GlobalDefinitions.ExcelLib.ReadData(2, "Category").Trim())
							{
								Thread.Sleep(1000);
								CategoryList[i].Click();
								Base.test.Log(LogStatus.Info, " Category Selected");
							}
						}

						//Add SubCategory
						SubCategory.Click();
						Console.WriteLine("Clicked on the SubCategory");
						Thread.Sleep(2000);
						IList<IWebElement> SubCategoryList = SubCategory.FindElements(By.TagName("option"));
						//int count = SubCatogeryList.Count;
						Thread.Sleep(500);
						for (int i = 0; i < SubCategoryList.Count; i++)
						{
							if (SubCategoryList[i].Text == GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"))
							//if (SubCatogeryList[i].Text == " Other".Trim())
							{
								Thread.Sleep(1000);
								SubCategoryList[i].Click();
								Base.test.Log(LogStatus.Info, " SubCategory Selected");
							}
						}


						// Add Tags
						Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
						Base.test.Log(LogStatus.Info, " Service Listing updated successfully");

						// Select Service Type
						Thread.Sleep(1000);
						if (GlobalDefinitions.ExcelLib.ReadData(2, "Service Type") == "One-off service")
						{
							ServiceType.Click();
						}
						else
						{
							Servicetype.Click();
						}
						Base.test.Log(LogStatus.Info, "Service type Edited successfully");

						//Select Location Type
						Thread.Sleep(1000);
						if (GlobalDefinitions.ExcelLib.ReadData(2, "Location Type") == "Online")
						{
							LocationType.Click();
						}
						else
						{
							Locationtype.Click();
						}
						Base.test.Log(LogStatus.Info, "Location Type Edited successfully");

						//Monday Check Box Selection 
						Thread.Sleep(2000);
						Boolean X = MondayCheckBox.Selected;

						if (X == false)
						{
							MondayCheckBox.Click();
						}

						MondayStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Start Time"));
						Thread.Sleep(1000);
						MondayEndTime.Clear();
						MondayEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "End Time"));
						Thread.Sleep(1000);

						//Tuesday Selection
						//TuesdayCheckBox.Click();
						//TuesdayStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Start Time"));
						//TuesdayEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "End Time"));

						//Days selection
						Thursdaycheckbox.Click();
						Thread.Sleep(2000);
						ThursdayStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Start Time"));
						ThursdayEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "End Time"));

						//Selecting Skill Trade

						if (GlobalDefinitions.ExcelLib.ReadData(2, "Skill Trade") == "Skill-exchange")
						{

							SkillTrade.Click();

						}

						else
						{
							Skilltrade.Click();
						}
						Base.test.Log(LogStatus.Info, " Service Listing updated successfully");

						// Enter Skill Exchange 
						AutoItX3 autoItx = new AutoItX3();
						SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill-Exchange"));
						autoItx.Send("{Enter}");
						Thread.Sleep(3000);
						Base.test.Log(LogStatus.Info, " Service Listing updated successfully");

						//Upload WorkSample
						Thread.Sleep(4000);
						WorkSample.Click();
						Thread.Sleep(1000);
						AutoItX3 autoit = new AutoItX3();
						autoit.WinActivate("Open");
						autoit.Send(@"c:\users\rajesh jasti\Documents\Worksamples.xlsx");
						Thread.Sleep(5000);
						autoit.Send("{Enter}");
						Base.test.Log(LogStatus.Info, "Work Sample Updated successfully");

						// select Active
						Thread.Sleep(1000);
						if (GlobalDefinitions.ExcelLib.ReadData(2, "Active") == "Active")
						{
							ActiveBtn.Click();
						}
						else
						{
							Hidden.Click();
						}

						//Click on Save Button
						SaveBtn.Click();
						Base.test.Log(LogStatus.Info, " Service Listing updated successfully");
						return;
					}
					j++;
				}
				var btnNext = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div/button[4]"));
				btnNext.Click();
			}
			var Title1 = (Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[3]/td[2]")).Text);
			Assert.AreEqual("Test Analyst", Title1);
			Console.WriteLine(" Skills Edited Successfully");
		}

		#endregion Edit Skills


		#region DeleteSkills
		public void DeleteSkills()
		{
			//Click on ManageListings button
			Thread.Sleep(4000);
			ML.Click();
			Thread.Sleep(4000);

			while (true)

			{
				var k = 1;

				while (k <= 10)

				{
					// identify 2nd row of table. Then extact the text and assign to a variable

					var Category1 = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[" + k + "]/td[2]")).Text;
					var DeleteBtn = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[" + k + "]/td[8]/i[2]"));
					//compare the text with the expected text. Music & Audio

					if (Category1 == "Writing & Translation")

					{


						//Click on manageListings
						ML.Click();
			
			           //Click on Delete Button
					   Delete.Click();
						break;
					}
					k++;
				}
				var btnNext = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div/button[4]"));
				btnNext.Click();
			}

		}

		#endregion DeleteSkill

		#region ViewDetails
		public void ViewDetails()

		{
			//Populate the Excel Sheet
			GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
			Thread.Sleep(2000);
			//page Refresh
			Global.GlobalDefinitions.driver.Navigate().Refresh();
			ML.Click();	
			Thread.Sleep(4000);

			while (true)

			{
				var j = 1;

				while (j <= 10)

				{
					// identify 2nd row of table. Then extact the text and assign to a variable
					var Category1 = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[" + j + "]/td[2]")).Text;
					var ViewBtn = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[" + j + "]/td[8]/i[1]"));
					//compare the text with the expected text. "Graphics & Design"

					if (Category1 == (Global.GlobalDefinitions.ExcelLib.ReadData(2, "Category1")))

					{
						//Clickin on View Button
						ViewBtn.Click();
						break;
					}
					j++;
				}
				var btnNext = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div/button[4]"));
				btnNext.Click();
			}

			//Validation for View Button
			var Text = (Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-detail-section']/div[3]/div/div[1]/div/div/div/a[1]")).Text);
			Assert.AreEqual("Graphics & Design ", Text);
			Console.WriteLine(" user can see the details");
			Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, " can view the details");

			//string text = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span")).Text;

			//			if (text == "QA")
			//			{
			//				Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, " can view the details");
			//			}
			//			else
			//			Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, " can't see the details");


		}
		#endregion ViewDetails

	}
}
