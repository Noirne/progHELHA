﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace essaiExam.MVVM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Info2020Entities : DbContext
    {
        public Info2020Entities()
            : base("name=Info2020Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<getEvalFromRestauId_Result> getEvalFromRestauId(Nullable<System.Guid> restauID)
        {
            var restauIDParameter = restauID.HasValue ?
                new ObjectParameter("RestauID", restauID) :
                new ObjectParameter("RestauID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getEvalFromRestauId_Result>("getEvalFromRestauId", restauIDParameter);
        }
    
        public virtual ObjectResult<getRestauCategories_Result> getRestauCategories()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getRestauCategories_Result>("getRestauCategories");
        }
    
        public virtual ObjectResult<getRestauFromCatId_Result> getRestauFromCatId(Nullable<System.Guid> catID)
        {
            var catIDParameter = catID.HasValue ?
                new ObjectParameter("catID", catID) :
                new ObjectParameter("catID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getRestauFromCatId_Result>("getRestauFromCatId", catIDParameter);
        }
    
        public virtual ObjectResult<getRestaurants_Result> getRestaurants()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getRestaurants_Result>("getRestaurants");
        }
    
        public virtual ObjectResult<getCommentsByRestoId_Result> getCommentsByRestoId(Nullable<System.Guid> restoId)
        {
            var restoIdParameter = restoId.HasValue ?
                new ObjectParameter("RestoId", restoId) :
                new ObjectParameter("RestoId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getCommentsByRestoId_Result>("getCommentsByRestoId", restoIdParameter);
        }
    
        public virtual ObjectResult<getUserNameByUserId_Result> getUserNameByUserId(Nullable<System.Guid> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getUserNameByUserId_Result>("getUserNameByUserId", userIdParameter);
        }
    }
}