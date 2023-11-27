using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dandd.Models;

namespace dandd.ViewModels
{
    internal class RaceViewModel
    {
        public string Raca;
        public int Dano;
        public int Velocidade;
        
        public RaceViewModel() 
        {
           Raca = LoadRaca() 
        }
        public string LoadRaca(int Dano, int Velocidade, string Raca)
        {

            return Raca;
        }
    }
}
