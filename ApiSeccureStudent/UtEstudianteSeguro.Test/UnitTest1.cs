using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using ApiSeccureStudent.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UtEstudianteSeguro.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGetStudent()
        {
            //Arrange
            StudentsController studentsController = new StudentsController();

            //Act
            var ListaEstudiantes = studentsController.GetStudents();

            //Assert
            Assert.IsNotNull(ListaEstudiantes);
        }
    }
}
