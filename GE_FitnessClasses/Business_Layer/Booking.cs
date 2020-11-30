using System;

namespace GE_FitnessClasses.Business_Layer
{
    class Booking
    {
        private int bookingID;
        private int classID;
        private int memberID;
        private int classTime;
        private DateTime classDate;

        public Booking()
        {
            bookingID = 000;
            memberID = 000;
            classID = 000;
            classTime = 000;
            classDate = DateTime.MinValue;
           
        }
        //getters
        public int getBookingID()
        {
            return bookingID;
        }
        public void setBookingID(int BookingID)
        {
            bookingID = BookingID;
        }
        public int getMemID()
        {
            return memberID;
        }
        public void setMemID(int MemID)
        {
            memberID = MemID;
        }
        public int getClassID()
        {
            return classID;
        }
        public void setClassID(int ClassID)
        {
            classID = ClassID;
        }
        public int getTime()
        {
            return classTime;
        }
        public void setClassTime(int ClassTime)
        {
            classTime = ClassTime;
        }
        public DateTime getClassDate()
        {
            return classDate;
        }
        public void setClassDate(DateTime date)
        {
           classDate = date;
        }
    }
}
