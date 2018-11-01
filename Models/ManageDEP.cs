using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminWeb.Models
{
    public class ManageDEP
    {
        MyDBEntities db = new MyDBEntities();

        public int AddEditDeleteDepartment(Departmenttbl dep, int otptype)
        {
            return db.AddEditDeleteDepartment(dep.DID,dep.DName_,dep.DHOD, otptype ); 
        }

        public List<Departmenttbl>  GetDepartments()
        {
            return db.Departmenttbls.ToList();
        }
        public Departmenttbl GetDepartmentbyID(int DID)
        {
            return db.Departmenttbls.Find(DID);
        }


    }
}