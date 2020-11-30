using System;


namespace GE_FitnessClasses.Business_Layer
{
    class ActiveMembership
    {
        private int memberID;
        private int membershipID;
        private DateTime startDate;

        public ActiveMembership()
        {
            memberID = 000;
            membershipID = 000;
            startDate = new DateTime();
        }
        //getters
        public int getMemberID()
        {
            return memberID;
        }
        public void setMemberID(int MemberID)
        {
            memberID = MemberID;
        }
        public int getMembershipID()
        {
            return membershipID;
        }
        public void setMembershipID(int MembershipID)
        {
            membershipID = MembershipID;
        }
        public DateTime getStartDate()
        {
            return startDate;
        }
        public void setStartDate(DateTime StartDate)
        {
            startDate = StartDate;
        }
    }
}
