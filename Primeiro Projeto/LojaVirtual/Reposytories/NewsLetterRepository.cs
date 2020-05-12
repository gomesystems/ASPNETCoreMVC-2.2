using LojaVirtual.Database;
using LojaVirtual.Models;
using LojaVirtual.Reposytories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Reposytories
{
    public class NewsLetterRepository : INewsLetterRepository
    {

        private LojaVirtualContext _banco;
        public NewsLetterRepository( LojaVirtualContext banco)
        {
            _banco = banco;
        }


        public void cadastrar(NewsLetterEmail newsletter)
        {
            _banco.NewsLetterEmails.Add(newsletter);
            _banco.SaveChanges();
        }

        public IEnumerable<NewsLetterEmail> ObterTodasNewsLetter()
        {
            return _banco.NewsLetterEmails.ToList();
        }
    }
}
