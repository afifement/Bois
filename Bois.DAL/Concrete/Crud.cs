using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Data.Entity.Validation;

namespace Bois.DAL
{
    public class Crud<T> : ICrud<T> where T : class
    {
       public DbContext context ;

        public Crud()
        {
            context = GetContext();
        }
         

        public IEnumerable<T> GetAll()
        {
            if (context == null) context = GetContext(); 
            return context.Set<T>().ToList();
        }

        public bool AddNew(params T[] items)
        {
            if (context == null) context = GetContext();
            try
            {
                foreach (T item in items)
                {
                    context.Entry(item).State = System.Data.Entity.EntityState.Added;
                }
                context.SaveChanges();
                return true;


            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (DbEntityValidationResult entityErr in dbEx.EntityValidationErrors)
                {
                    foreach (DbValidationError error in entityErr.ValidationErrors)
                    {
                        Debug.WriteLine("Error Property Name {0} : Error Message: {1}",
                                            error.PropertyName, error.ErrorMessage);
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }  
        }




        public bool Delete(params T[] items)
        {
            if (context == null) context = GetContext();
            try
            {
                foreach (T item in items)
                {
                    context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                }
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }


        }

        public bool Update(params T[] items)
        {
            if (context == null) context = GetContext();
            try
            {
                foreach (T item in items)
                {

                    context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                }
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }




        public bool Archive(params T[] items)
        {
            if (context == null) context = GetContext();
            try
            {
             
                foreach (T item in items)
                {
                     
                    context.Entry(item).Property("deletion_date").CurrentValue = DateTime.Now; 
                    context.SaveChanges();
                }
                
                return true;
            }

            catch (Exception ex) { return false; }

        }



        public DbContext GetContext()
        {
            DbContext context = new bdsocofebEntities1();
            context.Configuration.LazyLoadingEnabled = true;
            return context;
        }

      
    }
}
