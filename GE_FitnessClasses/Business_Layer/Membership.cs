using System;


namespace GE_FitnessClasses.Business_Layer
{
    class Membership
    {
        private int membershipID;
        private String memType;
       

        public Membership()
        {
            membershipID = 000;
            memType = "";
        }
        //getters
        public int getMemberShipID()
        {
            return membershipID;
        }
        public void setMemberShipID(int MemberShipID)
        {
            membershipID = MemberShipID;
        }
        public String getMemberShipType()
        {
            return memType;
        }
        public void setMemberShipType(String MemType)
        {
            this.memType = MemType;
        }
    }
}
