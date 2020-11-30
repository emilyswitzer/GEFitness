using System;

namespace GE_FitnessClasses.Business_Layer
{
    class Member
    {
       
            private int memberID;
            private String name;
            private String surname;
            private DateTime dob;
            private String email;
            private int phone;
            private char memStatus;

            public Member()
            {
                memberID = 000;
                name = "";
                surname = "";
                email = "";
                dob = DateTime.MinValue;
                phone = 0;
                memStatus = '\x0000';
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
            public String getName()
            {
                return name;
            }
            public void setName(String name)
            {
                this.name = name;
            }
            public String getSurname()
            {
                return surname;
            }
            public void setSurname(String surname)
            {
                this.surname = surname;
            }
            public String getEmail()
            {
                return email;
            }
            public void setEmail(String email)
            {
                this.email = email;
            }
            public DateTime getDOB()
            {
                return dob;
            }
            public void setDOB(DateTime dob)
            {
                this.dob = dob;
            }
            public int getPhone()
            {
                return phone;
            }
            public void setPhone(int phone)
            {
                this.phone = phone;
            }
            public char getMemStatus()
            {
                return memStatus;
            }
            public void setMemStatus(char status)
            {
                memStatus = status;
            }
        
        }
    }
