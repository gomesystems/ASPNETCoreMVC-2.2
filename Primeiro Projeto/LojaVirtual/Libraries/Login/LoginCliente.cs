using LojaVirtual.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Login
{     //carrega o cliente na sessão
    public class LoginCliente
    {
        private string Key = "Login.cliente";
        private Sessao.Sessao _sessao;


        public LoginCliente(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }


        public void Login(Cliente cliente)
        {   //Serializar

            string clienteJsonString = JsonConvert.SerializeObject(cliente);

            _sessao.Cadastrar(Key, clienteJsonString);
        }


        public Cliente GetCliente()
        {
            //Deserializar
            if (_sessao.Existe(Key))
            {
                string clienteJsonString = _sessao.Consultar(Key);
                return JsonConvert.DeserializeObject<Cliente>(clienteJsonString);
            }
            else
            {
                return null;
            }
        }

        public void Logout()
        {
            _sessao.RemoverTodos();
        }
    }
}
