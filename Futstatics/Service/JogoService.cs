using Core.Models;
using Core.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class JogoService : IJogoService
    {
        private readonly FutstaticsContext context;

        public JogoService(FutstaticsContext context)
        {
            this.context = context;
        }

        public IEnumerable<Jogo> GetAll()
        {
            return context.Jogos.AsNoTracking();
        }
    }
}
