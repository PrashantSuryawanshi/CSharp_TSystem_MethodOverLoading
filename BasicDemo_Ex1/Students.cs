using System;


namespace BasicDemo_Ex1
{
    internal class Students
    {
       private int sid,did;
       private string sName,sadd,dname;
       private float percent;

        public Students()
        {
            sid = 121;
            sName = "Ram";
            sadd = "Pune";
            percent = 88.23f;

        }
        public Students(int Id,string Name,string add,float mark)
        {
            sid = Id;
            sName = Name;
            sadd = add;
            percent = mark;
        }
        public void Dept(int dId,string dName)
        {
            did = dId;
            dname = dName;
        }
        public string DisplayDetials()
        {
            return "Students Detials ::" + "\n    Name ::" + sName + "\n    ID ::" + sid + "\n    Address ::" + sadd + "\n    Marks ::" + percent + " %";
                 
        }
        public string MethodDisplay()
        {
            return "\nDepartment Detials ::" + "\n    DeptId ::" + did + "\n    DeptName ::" + dname;
        }

    }
}
