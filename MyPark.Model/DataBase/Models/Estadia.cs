using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPark.Model.DataBase.Models
{
    public class Estadia
    {
        public virtual Guid Id { get; set; }
        public virtual DateTime DtEntrada { get; set; }
        public virtual DateTime HoraEntrada { get; set; }
        public virtual DateTime DtSaida { get; set; }
        public virtual DateTime HoraSaida { get; set; }
        public virtual String Observacao { get; set; }
        public virtual Double TotalAPagar { get; set; }
    }

    public class EstadiaMap : ClassMapping<Estadia>
    {
        public EstadiaMap()
        {
            Id(x => x.Id, m => m.Generator(Generators.Guid));

            Property(x => x.DtEntrada);
            Property(x => x.HoraEntrada);
            Property(x => x.DtSaida);
            Property(x => x.HoraSaida);
            Property(x => x.Observacao);
            Property(x => x.TotalAPagar);
        }
    }
}
