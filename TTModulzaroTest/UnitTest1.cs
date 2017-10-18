using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TTModulzaro;

namespace TTModulzaroTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NewPatientTestRight()
        {
            var pfvm = new PatientFormViewModel();
            pfvm.Patient = new Patient();
            pfvm.Patient.TAJ = "123456789";
            pfvm.Patient.Name = "Tatai Sándor";
            pfvm.Patient.BornPlace = "Budapest";
            bool result = pfvm.Validate();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NewPatientTestWrong()
        {
            var pfvm = new PatientFormViewModel();
            pfvm.Patient = new Patient();
            pfvm.Patient.TAJ = "1";
            pfvm.Patient.Name = "x";
            pfvm.Patient.Born = "x";
            bool result = pfvm.Validate();
            Assert.IsFalse(result);
        }
    }
}
