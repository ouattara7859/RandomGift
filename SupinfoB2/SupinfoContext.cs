namespace SupinfoB2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CustomerContext : DbContext
    {
        public CustomerContext()
            : base("name=SupinfoContext")
        {
        }
        public DbSet<Customer> SupCustomer { get; set; }

       
    }
}
