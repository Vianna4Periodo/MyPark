using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPark.Model.DataBase.Models
{
    public class Livro
    {
        public virtual Guid Id { get; set; }
        public virtual String Titulo { get; set; }
        public virtual String Autor { get; set; }
        public virtual String ISBN { get; set; }
        public virtual String Editora { get; set; }
    }

    public class LivroMap: ClassMapping<Livro>
    {
        public LivroMap() {
            Id(x => x.Id, m => m.Generator(Generators.Guid));

            Property(x => x.Titulo);
            Property(x => x.Autor);
            Property(x => x.ISBN);
            Property(x => x.Editora);
        }
    }

}
