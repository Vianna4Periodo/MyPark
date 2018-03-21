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
    /// Summary description for WebserviceMyPark
    /// </summary>
    [WebService(Namespace = "http://mypark.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebserviceMyPark : System.Web.Services.WebService
    {

        [WebMethod]
        public Cliente CadastroUsuario(Cliente cliente)
        {
            cliente = DbFactory.Instance.ClienteRepository.Save(cliente);
            return cliente;
        }

        [WebMethod]
        public List<Cliente> ListaClientes()
        {
            return DbFactory.Instance.ClienteRepository.FindAll().ToList();
        }

        [WebMethod]
        public Veiculo CadastroUsuario(Veiculo veiculo)
        {
            veiculo = DbFactory.Instance.VeiculoRepository.Save(veiculo);
            return veiculo;
        }

        [WebMethod]
        public List<Veiculo> ListaVeiculos()
        {
            return DbFactory.Instance.VeiculoRepository.FindAll().ToList();
        }
    }
}
