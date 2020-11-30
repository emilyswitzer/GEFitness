using System;


namespace GE_FitnessClasses.Business_Layer
{
    class Class
        {
            private int classID;
            private String className;
            private int capacity;
            private char status;

        public Class()
            {
                classID = 000;
                className = "";
                capacity = 0;
                status = '\x0000';
            }
            //getters
            public int getClassID()
            {
            return classID;
            }
            public void setClassID(int ClassID)
            {
                classID = ClassID;
            }
            public String getClassName()
            {
                return className;
            }
            public void setClassName(String name)
            {
                className = name;
            }
            public int getCapacity()
            {
                return capacity;
            }
            public void setCapacity(int Capacity)
            {
                capacity = Capacity;
            }
            public char getStatus()
            {
                return status;
            }
            public void setStatus(char Status)
            {
                status = Status;
            }



    }
    }
