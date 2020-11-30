using System;
using System.Data;
using GE_FitnessClasses.Business_Layer;
using Oracle.ManagedDataAccess.Client;

namespace GE_FitnessClasses.Database_Layer
{
    public class Databases
    {

        public static DataSet GetClasses()
        {
            //define Sql Query
            String strSQL = "SELECT * FROM Classes";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(OracleDB.oradb);
            conn.Open();
            Console.Write("Connected to Oracle" + conn.ServerVersion);

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "Classes");

            //Close database connection
            conn.Close();

            return ds;
        }
        public static int GetNextMemID()
        {
            int last;
            OracleConnection conn = new OracleConnection(OracleDB.oradb);
            conn.Open();

            //define SQL query
            String strSQL = "SELECT MAX(memberID) FROM Members";
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr[0] == DBNull.Value) 
                last = 1;
            else
                last = Convert.ToInt32(dr[0]) + 1;

            conn.Close();
            return last;
        }
        public static int GetNextBookingID()
        {
            int last;
            OracleConnection conn = new OracleConnection(OracleDB.oradb);
            conn.Open();

            String strSQL = "SELECT MAX(bookingID) FROM Bookings";
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr[0] == DBNull.Value) 
                last = 1;
            else
                last = Convert.ToInt32(dr[0]) + 1;
            
            conn.Close();
            return last;
        }
    
        public static bool ValidateEmail(string email)
        {
            bool valid;

            string emailpattern = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                    + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                    + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                    + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";



            if (!string.IsNullOrEmpty(email) && System.Text.RegularExpressions.Regex.IsMatch(email, emailpattern))
            {
                valid = true;
            }
            else
            {
                valid = false;
            }
            return valid;
        }

        public static int GetAge(DateTime bornDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - bornDate.Year;
            if (bornDate > today.AddYears(-age))
                age--;

            return age;
        }
        public static bool ValidateAge(int age)
        {
            Boolean isValid;
            int valid = 18;
            if (age < valid)
                isValid = false;
            else
                isValid = true;
                
            return isValid;

        }
        public void AddMember(int id, String name, String surname,  String dob, String email, int phone, char status) 
        {
           
               //Define Oracle Connection
               OracleConnection conn = new OracleConnection(OracleDB.oradb);
               conn.Open();

               //Define SQL Query
               String strSQL = "INSERT INTO Members VALUES (" + id + ", '" + name + "' , '" + surname +
                   "', date '" + String.Format("{0:yyyy-MM-dd}", dob) + "', '" + email + "', " + phone + ", '" + status + "')";


               OracleCommand cmd = new OracleCommand(strSQL, conn);
               cmd.ExecuteNonQuery();

               //close DB
               conn.Close();
            
        }

        public void UpdateMember(int id, char status)
        {
            //Define an Oracle Connection
            OracleConnection conn = new OracleConnection(OracleDB.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "UPDATE Members SET Status = '" + status + "' WHERE MemberID = " + id;

            //Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute the query
            cmd.ExecuteNonQuery();

            //Close Database Connection
            conn.Close();
        }

        public void MakeActiveMembership(int id, int memID, DateTime start)
        {

            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(OracleDB.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "INSERT INTO ActiveMemberships VALUES (" + memID + ", " + id + ", date '" + String.Format("{0:yyyy-MM-dd}", start) + "')";


            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DB
            conn.Close();



        }
        public void MakeBooking(int id, int classID, int memID)
        {

            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(OracleDB.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "INSERT INTO Bookings VALUES (" + id + ", " + classID + "," + memID + ")";


            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DB
            conn.Close();
        }

        public void CancelBooking(int bookingID)
        {
            //Define an Oracle Connection
            OracleConnection conn = new OracleConnection(OracleDB.oradb);
            conn.Open();

            String strSQL = "DELETE FROM Bookings WHERE BookingID = " + bookingID;

           
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute the query
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataSet GetSummaryClasses()
        {
            
            String strSQL = "SELECT classID, className AS Name FROM Classes WHERE Status" +
                " = 'A' ORDER BY classID";

            
            OracleConnection conn = new OracleConnection(OracleDB.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "SummaryClasses");

            //Close database connection
            conn.Close();

            return ds;
        }
      

        //Get all Members from Members Table
        public static DataSet GetMembers()
        {
            //Define SQL Query
            String strSQL = "SELECT * FROM Members ORDER BY MemberID";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(OracleDB.oradb);
            conn.Open();

            //Declare Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an OracleAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "Members");

            //Close Database Connection
            conn.Close();

            return ds;
        }

        public static DataSet GetMemberBookings(int memberID)
        {
            //Define SQL Query
            String strSQL = "SELECT BookingID, ClassName FROM Bookings B, Classes C " +
                "WHERE B.ClassID = C.ClassID AND B.MemberID = " + memberID + " ORDER BY C.ClassID";

            //Define an Oracle Connection
            OracleConnection conn = new OracleConnection(OracleDB.oradb);
            conn.Open();

            //Declare Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an OracleAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "Bookings");

            //Close Database Connection
            conn.Close();

            return ds;
        }

        //Gets a single Member Item from Members Table
        public void GetAMember(int memberID)
        {
            //Define an Oracle Connection
            OracleConnection conn = new OracleConnection(OracleDB.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM Members WHERE MemberID = " + memberID;

            //Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute the query using a DataReader
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            Member member = new Member();

            //Instantiate object variables
            member.setMemberID(dr.GetInt32(0));
            member.setName(dr.GetString(1));
            member.setSurname(dr.GetString(2));
            member.setDOB(dr.GetDateTime(3));
            member.setEmail(dr.GetString(4));
            member.setPhone(dr.GetInt32(5));
            member.setMemStatus('A');

            //Close Database connection
            conn.Close();
        }

        public static DataSet GetSummaryMembers()
        {
            //Define SQL Query
            String strSQL = "SELECT MemberID, MemName, MemSurname, Status FROM Members ORDER BY MemberID";

            //Define an Oracle Connection
            OracleConnection conn = new OracleConnection(OracleDB.oradb);
            conn.Open();

            //Declare Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an OracleAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "Members");

            //Close Database Connection
            conn.Close();

            return ds;
        }

        public static DataSet GetPayments()
        {
            //define Sql Query
            String strSQL = "SELECT * FROM Payments";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(OracleDB.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "Payments");

            //Close database connection
            conn.Close();

            return ds;
        }

        public static DataSet GetMemberships()
        {
            //define Sql Query
            String strSQL = "SELECT * FROM Memberships";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(OracleDB.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "Memberships");

            //Close database connection
            conn.Close();

            return ds;
        }

        //Gets a single Member Item from Members Table
        public void GetABooking(int bookingID)
        {
            //Define an Oracle Connection
            OracleConnection conn = new OracleConnection(OracleDB.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM Bookings WHERE BookingID = " + bookingID;

            //Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute the query using a DataReader
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            Booking booking = new Booking();

            //Instantiate object variables
            booking.setBookingID(dr.GetInt32(0));
            booking.setClassID(dr.GetInt32(1));
            booking.setMemID(dr.GetInt32(2));

            //Close Database Connection
            conn.Close();
        }

        public static DataSet ValidUser(int id)
        {


            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(OracleDB.oradb);
            conn.Open();

            //define Sql Query
            String strSQL = "SELECT * FROM Members WHERE MemberID = " + id ;

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "Members");

            //Close database connection
            conn.Close();

            return ds;


        }
        public void CancelMembership(int id)
        {
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(OracleDB.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "DELETE FROM ActiveMemberships WHERE MemberID =" + id;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //close DB
            conn.Close();
        }
        public static DataSet CheckEmail(String email)
        {


            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(OracleDB.oradb);
            conn.Open();

            //define Sql Query
            String strSQL = "SELECT * FROM Members WHERE Email = '" + email + "'";

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "emails");

            //Close database connection
            conn.Close();

            return ds;


        }

        public static int GetCapacity(int classID)
        {
            int capacity;
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(OracleDB.oradb);
            conn.Open();

            //Define SQL Query. Only 1 record can be returned as Id is unique
            String strSQL = "SELECT ClassCapacity FROM Classes WHERE classID = " + classID;
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute query
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read(); 
            capacity = Convert.ToInt32(dr[0]);
            //close DB
            conn.Close();
            return capacity;
        }
        public static bool CheckIfFull(int classID, int capacity)
        {
            Boolean result;
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(OracleDB.oradb);
            conn.Open();
            String strSQL = "SELECT COUNT(*) FROM Bookings WHERE classID = " + classID;
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > capacity)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            //Close database connection
            conn.Close();

            return result;


        }
        public static bool CheckValidMember(int classID, int mem)
        {
            Boolean result;
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(OracleDB.oradb);
            conn.Open();
            String strSQL = "SELECT COUNT(*) FROM Bookings WHERE classID = " + classID + " AND memberID = " + mem;
            OracleCommand cmd = new OracleCommand(strSQL, conn);


            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            //Close database connection
            conn.Close();

            return result;


        }
        public static DataSet CheckIfActive(int memId)
        {


            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(OracleDB.oradb);
            conn.Open();

            //define Sql Query
            String strSQL = "SELECT * FROM Members WHERE MemberID = " + memId + " AND Status = 'A'";
            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "Active");

            //Close database connection
            conn.Close();

            return ds;


        }
        public static DataSet GetBookings(int bookingId)
        {
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(OracleDB.oradb);
            conn.Open();

            //define Sql Query
            String strSQL = "SELECT * FROM Bookings WHERE BookingID = " + bookingId;
            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "Bookings");

            //Close database connection
            conn.Close();

            return ds;


        }

    }
}
