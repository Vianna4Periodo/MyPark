using MyPark.Model.DataBase;
using MyPark.Model.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Mypark.WebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://myparklivros.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Livro> ListaLivros()
        {
            return DbFactory.Instance.LivroRepository.FindAll().ToList();
        }

        [WebMethod]
        public Livro CadastroLivro(Livro livro)
        {
            livro = DbFactory.Instance.LivroRepository.Save(livro);
            return livro;
        }

        [WebMethod]
        public Livro AtualizarLivro(Livro livro)
        {
            livro = DbFactory.Instance.LivroRepository.SaveOrUpdate(livro);
            return livro;
        }

        [WebMethod]
        public bool RemoverLivro(Guid id)
        {
            var livro = DbFactory.Instance.LivroRepository.FindFirstById(id);

            if (livro == null)
                return false;
            
            DbFactory.Instance.LivroRepository.Delete(livro);

            return true;
        }

    }
}
