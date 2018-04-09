using PersonalBot.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBot.Repository
{
    public class AparelhoRepository: IAparelhoRepository
    {
        public AparelhoRepository()
        {
          
        }

        public List<Aparelho> getAparelhos()
        {
            List<Aparelho> lista_Aparelhos = new List<Aparelho>();
            lista_Aparelhos.Add(new Aparelho(1, "Supino", "Supino.jpg"));
            lista_Aparelhos.Add(new Aparelho(2, "Remada", "Remada.jpg"));
            lista_Aparelhos.Add(new Aparelho(3, "Cadeira Flexora", "Cadeira.jpg"));
            lista_Aparelhos.Add(new Aparelho(4, "Abdominal supra reto", "Abdominal.jpg"));
            lista_Aparelhos.Add(new Aparelho(5, "Lombar", "Lombar.jpg"));
            lista_Aparelhos.Add(new Aparelho(6, "Puxada", "Puxada.jpg"));
            lista_Aparelhos.Add(new Aparelho(7, "Leg press 45", "Leg.jpg"));

            return lista_Aparelhos;


        }

        internal Aparelho getAparelho(int id)
        {
            return getAparelhos().Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
