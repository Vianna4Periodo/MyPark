using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPark.Model.DataBase.Models
{
    public class Veiculo
    {
        public virtual Guid Id { get; set; }
        public virtual String Placa { get; set; }
        public virtual String Marca { get; set; }
        public virtual String Modelo { get; set; }
        public virtual String Cor { get; set; }
    }

    public class VeiculoMap : ClassMapping<Veiculo>
    {
        public VeiculoMap()
        {
            Id(x => x.Id, m => m.Generator(Generators.Guid));

            Property(x => x.Placa);
            Property(x => x.Marca);
            Property(x => x.Modelo);
            Property(x => x.Cor);
        }
    }
}
