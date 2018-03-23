using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPark.Model.DataBase.Models
{
    public class User
    {
        public virtual Guid Id { get; set; }
        public virtual String Login { get; set; }
        public virtual String Senha { get; set; }
        public virtual Operador Operador { get; set; }
        // public virtual Cliente Cliente { get; set; }
    }

    public class UserMap : ClassMapping<User>
    {
        public UserMap()
        {
            Id(x => x.Id, m => m.Generator(Generators.Guid));

            Property(x => x.Login);
            Property(x => x.Senha);

            OneToOne(x => x.Operador, m =>
            {
                m.PropertyReference(typeof(Operador).GetProperty("Usuario"));
                m.Lazy(LazyRelation.NoLazy);
                m.Cascade(Cascade.Persist);
            });

            //OneToOne(x => x.Cliente, m =>
            //{
            //    m.PropertyReference(typeof(Cliente).GetProperty("Usuario"));
            //    m.Lazy(LazyRelation.NoLazy);
            //});
        }
    }
}
