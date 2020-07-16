using VehicleInsuranceCalculator.Domain.Entities;
using VehicleInsuranceCalculator.Infra.Data.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace VehicleInsuranceCalculator.Infra.Data.Context
{
    public class ModelProjectContext : DbContext
    {
        public ModelProjectContext()
            :base("VehicleInsuranceCalculator")
        {

        }

        public DbSet<Assured> Assured { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Insurance> Insurance { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties() //Toda vez que tiver AssuredId, VehicleId, InsuranceId, etc será identificado como Chave Primária
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>() //Para de criar nvarchar e cria varchar
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>() //Para de criar tamanho MAX para quando não for estipulado tamanho e cria tamnho = 100
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new AssuredConfiguration());
            modelBuilder.Configurations.Add(new VehicleConfiguration());
            modelBuilder.Configurations.Add(new InsuranceConfiguration());
        }

        public override int SaveChanges()
        {
            //foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("RegistrationDate")!=null))
            //{
            //    if(entry.State == EntityState.Added) //Se estou adicionando o registro, configuro RegistrationDate = DateTime.Now
            //    {
            //        entry.Property("RegistrationDate").CurrentValue = DateTime.Now;
            //    }

            //    if(entry.State == EntityState.Modified) //Se estou modificando registro já incluso, não modifico RegistrationDate
            //    {
            //        entry.Property("RegistrationDate").IsModified = false;
            //    }
            //}
            return base.SaveChanges();
        }

        public void FixEfProviderServicesProblem()
        {
            //The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            //for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
            //Make sure the provider assembly is available to the running application. 
            //See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.

            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }
}
