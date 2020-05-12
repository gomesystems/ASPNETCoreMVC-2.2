using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Reposytories.Contracts
{
    public interface INewsLetterRepository
    {
        void cadastrar(NewsLetterEmail newsletter);
        IEnumerable<NewsLetterEmail> ObterTodasNewsLetter();
    }
}
