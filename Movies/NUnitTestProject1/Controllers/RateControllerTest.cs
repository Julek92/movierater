using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Movies.Controllers;
using Movies.Repositories;
using NUnitTestProject1.FakeRepository;

namespace NUnitTestProject1.Controllers
{
    [TestClass]
    public class RateControllerTest
    {
        [TestMethod]
        public void ControllerTest()
        {
            IRateRepository fakeRepository = new FakeRepository.FakeRepository();
            RateController shirtController = new RateController(fakeRepository, );
            ViewResult viewResult = shirtController.Index() as ViewResult;
            List<Shirt> shirts = viewResult.Model as List<Shirt>;
            Assert.AreEqual(shirts.Count, 3);
        }

    }
}
