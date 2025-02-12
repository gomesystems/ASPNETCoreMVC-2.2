﻿using LojaVirtual.Database;
using LojaVirtual.Models;
using LojaVirtual.Reposytories.Contracts;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace LojaVirtual.Reposytories
{
    public class ClienteRepository : IClienteRepository
    {
        //injeta o banco do contexto
        private IConfiguration _conf;
        private LojaVirtualContext _banco;

        public ClienteRepository(LojaVirtualContext banco, IConfiguration conf )
        {
            _banco = banco;
            _conf = conf;

        }

        public void Atualizar(Cliente cliente)
        {
            _banco.Update(cliente);
            _banco.SaveChanges();
        }

        public void Cadastrar(Cliente cliente)
        {
            //TODO - Grava no banco
            _banco.Add(cliente);
            _banco.SaveChanges();
        }

        public void Excluir(int Id)
        {
            Cliente cliente = ObterCliente(Id);            
            _banco.Remove(cliente);
            _banco.SaveChanges();
        }

        public Cliente Login(string Email, string Senha)
        {
          Cliente cliente =  _banco.Clientes.Where(m => m.Email == Email && m.Senha == Senha).FirstOrDefault();
            return cliente;
        }

        public Cliente ObterCliente(int Id)
        {
          return  _banco.Clientes.Find(Id);
        }
       
        // paginação
        public IPagedList<Cliente> ObterTodosClientes(int? pagina, string pesquisa)
        {
            int RegistroPorPagina = _conf.GetValue<int>("RegistroPorPagina");

            int NumeroPagina = pagina ?? 1;

            var bancoCliente = _banco.Clientes.AsQueryable();

            if (!string.IsNullOrEmpty(pesquisa))
            {
                //não esta vazio
                bancoCliente = bancoCliente.Where(a => a.Nome.Contains(pesquisa.Trim()) || a.Email.Contains(pesquisa.Trim()));
            }
            
            return bancoCliente.ToPagedList<Cliente>(NumeroPagina, RegistroPorPagina);
        }
    }
}
