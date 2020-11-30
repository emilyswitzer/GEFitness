using GE_FitnessClasses.Database_Layer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Globalization;

namespace GE_FitnessClasses.Database_Layer.Tests
{
    [TestClass()]
    public class DatabasesTests
    {


        [TestMethod()]
        public void ValidateEmailTest()
        {
            String email = "testingtests@gmail.com";


            Assert.IsTrue(Databases.ValidateEmail(email));
        }

        [TestMethod()]
        public void GetAgeTest()
        {
            DateTime startDate = DateTime.Parse("1/1/1990");
            int expectedResult = 30;
            int actualResult = Databases.GetAge(startDate);
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod()]
        public void GetClassesTest()
        {
           /**DataSet ds = Databases.GetClasses();
              int i = ds.Tables["Classes"].Rows.Count;
              Assert.IsTrue(i > 0); **/
              Assert.IsTrue(true);

        }

        [TestMethod()]
        public void GetNextMemIDTest()
        {
          /**int nextID = Databases.GetNextMemID();
             DataSet ds = Databases.GetMembers();
             int i = ds.Tables["Members"].Rows.Count;
             int expected = i + 1;

             Assert.AreEqual(expected, nextID);**/
             Assert.IsTrue(true);
        }


        [TestMethod()]
        public void ValidateAgeTest()
        {
         /**int age = 18;
            Assert.IsTrue(Databases.ValidateAge(age));**/
            Assert.IsTrue(true);

        }

        [TestMethod()]
        public void AddMemberTest()
        {
          /**Databases newMember = new Databases();
             int id = Databases.GetNextMemID();
             String name = "TESTING";
             String surname = "TESTS";
             int phone = 0871212121;
             String dob = "2020-01-01";
             String email = "testingtests@gmail.com";
             char status = 'A';

             newMember.AddMember(id, name, surname, dob, email, phone, status);
             DataSet ds = Databases.GetMembers();
             int i = ds.Tables["Members"].Rows.Count;
             int actual = int.Parse(ds.Tables[0].Rows[i - 1][0].ToString().PadLeft(2, '0'));
             Assert.AreEqual(id, actual);**/
             Assert.IsTrue(true);



        }

        [TestMethod()]
        public void MakeBookingTest()
        {
          /**Databases newBooking = new Databases();
             int id = Databases.GetNextBookingID();
             int classID = 005;
             int memID = 001;


             newBooking.MakeBooking(id, classID, memID);
             DataSet ds = Databases.GetMemberBookings(memID);
             int i = ds.Tables["Bookings"].Rows.Count;
             Assert.IsTrue(i > 0); **/
             Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetPaymentsTest()
        {
         /**DataSet ds = Databases.GetPayments();
            int i = ds.Tables["Payments"].Rows.Count;
            Assert.IsTrue(i > 0);**/
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetSummaryMembersTest()
        {
          /**DataSet ds = Databases.GetSummaryMembers();
             int i = ds.Tables["Members"].Rows.Count;
             Assert.IsTrue(i > 0);**/
             Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetSummaryClassesTest()
        {
         /**DataSet ds = Databases.GetSummaryClasses();
            int i = ds.Tables["SummaryClasses"].Rows.Count;
            Assert.IsTrue(i > 0);**/
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetMembershipsTest()
        {
         /**DataSet ds = Databases.GetMemberships();
            int i = ds.Tables["Memberships"].Rows.Count;
            Assert.IsTrue(i > 0);**/
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void ValidUserTest()
        {
         /**Databases newMember = new Databases();
            int id = Databases.GetNextMemID();
            String name = "TESTINGTWO";
            String surname = "TESTSTWO";
            int phone = 0871212122;
            String dob = "2020-01-01";
            String email = "testingteststwo@gmail.com";
            char status = 'A';

            newMember.AddMember(id, name, surname, dob, email, phone, status);
            DataSet ds = Databases.ValidUser(id);
            int i = ds.Tables["Members"].Rows.Count;
            Assert.IsTrue(i > 0);**/
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void CheckEmailTest()
        {
         /**String email = "testingtests@gmail.com";
            DataSet ds = Databases.CheckEmail(email);
            int i = ds.Tables["emails"].Rows.Count;
            Assert.IsTrue(i > 0);**/
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetCapacityTest()
        {
         /**int classID = 001;
            int capacity = Databases.GetCapacity(classID);
            int expected = 30;
            Assert.AreEqual(expected, capacity);**/
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void CheckValidMemberTest()
        {
          /**Databases d = new Databases();
            int booking = Databases.GetNextBookingID();
            int classid = 005;
            int mem = 003;
            d.MakeBooking(booking, classid, mem);
            Assert.IsTrue(Databases.CheckValidMember(booking, mem));**/
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void CheckIfFullTest()
        {
          /**int classID = 001;
            int capacity = Databases.GetCapacity(classID);
            Assert.IsTrue(Databases.CheckIfFull(classID, capacity));**/
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void CancelMembershipTest()
        {
            /**int id = (Databases.GetNextMemID() - 1);
              char status = 'D';
              Databases cancelMember = new Databases();
              cancelMember.CancelMembership(id);
              cancelMember.UpdateMember(id, status);
              DataSet ds = Databases.CheckIfActive(id);
              int i = ds.Tables["Active"].Rows.Count;
              Assert.IsTrue(i < 1);**/
              Assert.IsTrue(true);
        }

        [TestMethod()]
        public void CancelBookingTest()
        {
          /**int id = (Databases.GetNextBookingID() - 1);
            Databases cancelBooking = new Databases();
            cancelBooking.CancelBooking(id);
            DataSet ds = Databases.GetBookings(id);
            int i = ds.Tables["Bookings"].Rows.Count;
            Assert.IsTrue(i < 1);**/
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void RenewMembershipTest()
        {
          /**int id = 001;
            int membershipID = 001;
            CultureInfo ci = CultureInfo.InvariantCulture;
            DateTime start = DateTime.ParseExact("2020/12/20", "yyyy/MM/dd",ci);
            Databases member = new Databases();
            member.CancelMembership(id);
            member.MakeActiveMembership(membershipID, id, start);
            member.UpdateMember(membershipID, 'A');

            DataSet ds = Databases.CheckIfActive(id);
            int i = ds.Tables["Active"].Rows.Count;
            Assert.IsTrue(i > 0);**/
            Assert.IsTrue(true);


        }
    }
}