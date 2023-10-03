using Microsoft.VisualStudio.TestTools.UnitTesting;
using VolunteersMVC5.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using VolunteersMVC5.Models;

namespace VolunteersMVC5.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        

        [TestMethod()]
        public void TestSignUp()
        {
          HomeController controller = new HomeController();
            // Act
          ViewResult result = controller.SignUpVolunteer() as ViewResult;
          string[] items = controller.GetAllCities();
          Array.Sort(items);

          Assert.AreNotEqual(null, result.ViewBag.CitiesList as SelectList);
          CollectionAssert.AreEqual(items, (result.ViewBag.CitiesList as SelectList).Items as string[]);
           
        }
        [TestMethod()]
        public void TestSignUpPost()
        {
            HomeController controller = new HomeController();
            VolunteerModelView us = new VolunteerModelView()
            {
                user = new User()
                {
                  strFirstName = "יוסף",
                  strLastName = "בן עטר",
                  strAddress = "הלוחם",
                  Age = 19,
                  DateRegistration = DateTime.Now,
                  strCity = "נתניה",
                  strTZ = "204066011",
                  Password = "990990123",
                  strEmail = "yosi55@dfdi.com"
                , strPhone = "0504227091",
                }

            };
            us.volunteer.VendorAssistancesForDays[0]=new VendorAssistanceViewModel() { Checked = true, Value = 1 };
        //In case all the fields have been entered in full
        ViewResult result = controller.SignUpVolunteer(us) as ViewResult;
            Assert.IsNotNull(result);

            //In case of failure no fully entered field
            us = new  VolunteerModelView();
            result = controller.SignUpVolunteer(us) as ViewResult;
            Assert.IsNull(result);

        }
     
        

        //[TestMethod()]
        //public void Index()
        //{

        //}

        //[TestMethod()]
        //public void AboutTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void ContactTest()
        //{
        //    Assert.Fail();
        //}
    }
}