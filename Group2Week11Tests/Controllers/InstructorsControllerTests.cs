using Microsoft.VisualStudio.TestTools.UnitTesting;
using Group2Week11.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Group2Week11.Controllers.Tests
{
    [TestClass()]
    public class InstructorsControllerTests
    {
        public SqlCommand SqlCommand { get; private set; }

        [TestMethod]
        public void TestID()
        {
            // Create a connection to the database
            string connectionString = "Data Source=ROSS;Initial Catalog=Courses;User ID=sa;Password=SSMS;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT InstructorID From Instructor";

            SqlCommand command = new SqlCommand(query, connection);

            var expectedValue = "I001";

            connection.Open();
            string fieldValue = command.ExecuteScalar().ToString();
            connection.Close();

            Assert.AreEqual(expectedValue, fieldValue);
        }

        [TestMethod]
        public void TestFirstName()
        {
            // Create a connection to the database
            string connectionString = "Data Source=ROSS;Initial Catalog=Courses;User ID=sa;Password=SSMS;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT InstructorFirstName From Instructor";

            SqlCommand command = new SqlCommand(query, connection);

            var expectedValue = "Xander";

            connection.Open();
            string fieldValue = command.ExecuteScalar().ToString();
            connection.Close();

            Assert.AreEqual(expectedValue, fieldValue);
        }

        [TestMethod]
        public void TestLastName()
        {
            // Create a connection to the database
            string connectionString = "Data Source=ROSS;Initial Catalog=Courses;User ID=sa;Password=SSMS;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT InstructorLastName From Instructor";

            SqlCommand command = new SqlCommand(query, connection);

            var expectedValue = "Garza";

            connection.Open();
            string fieldValue = command.ExecuteScalar().ToString();
            connection.Close();

            Assert.AreEqual(expectedValue, fieldValue);
        }

        [TestMethod]
        public void TestPhone()
        {
            // Create a connection to the database
            string connectionString = "Data Source=ROSS;Initial Catalog=Courses;User ID=sa;Password=SSMS;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT InstructorPhone From Instructor";

            SqlCommand command = new SqlCommand(query, connection);

            var expectedValue = "777-1258";

            connection.Open();
            string fieldValue = command.ExecuteScalar().ToString();
            connection.Close();

            Assert.AreEqual(expectedValue, fieldValue);
        }

        [TestMethod]
        public void TestEmail()
        {
            // Create a connection to the database
            string connectionString = "Data Source=ROSS;Initial Catalog=Courses;User ID=sa;Password=SSMS;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT InstructorEmail From Instructor";

            SqlCommand command = new SqlCommand(query, connection);

            var expectedValue = "x.garza@uni.com";

            connection.Open();
            string fieldValue = command.ExecuteScalar().ToString();
            connection.Close();

            Assert.AreEqual(expectedValue, fieldValue);
        }
    }
}

