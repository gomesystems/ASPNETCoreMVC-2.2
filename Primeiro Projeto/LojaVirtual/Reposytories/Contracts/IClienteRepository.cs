﻿using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace LojaVirtual.Reposytories.Contracts
{
    public interface IClienteRepository
    {
        Cliente Login(string Email, string Senha);

        //CRUD - Cliente
        void Cadastrar(Cliente cliente);
        void Atualizar(Cliente cliente);
        void Excluir(int Id);
        Cliente ObterCliente(int Id);
        IPagedList<Cliente> ObterTodosClientes(int? pagina, string pesquisa);
    }
}
