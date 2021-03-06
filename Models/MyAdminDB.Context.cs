﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MyDBEntities : DbContext
    {
        public MyDBEntities()
            : base("name=MyDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Departmenttbl> Departmenttbls { get; set; }
        public virtual DbSet<Facultytbl> Facultytbls { get; set; }
        public virtual DbSet<User> Users { get; set; }
    
        public virtual int AddEditDeleteDepartment(Nullable<int> dID, string dName, string dHOD, Nullable<int> optType)
        {
            var dIDParameter = dID.HasValue ?
                new ObjectParameter("DID", dID) :
                new ObjectParameter("DID", typeof(int));
    
            var dNameParameter = dName != null ?
                new ObjectParameter("DName", dName) :
                new ObjectParameter("DName", typeof(string));
    
            var dHODParameter = dHOD != null ?
                new ObjectParameter("DHOD", dHOD) :
                new ObjectParameter("DHOD", typeof(string));
    
            var optTypeParameter = optType.HasValue ?
                new ObjectParameter("OptType", optType) :
                new ObjectParameter("OptType", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddEditDeleteDepartment", dIDParameter, dNameParameter, dHODParameter, optTypeParameter);
        }
    
        public virtual ObjectResult<GetAllDepartment_Result> GetAllDepartment()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllDepartment_Result>("GetAllDepartment");
        }
    }
}
