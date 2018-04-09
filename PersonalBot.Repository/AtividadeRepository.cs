using PersonalBot.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBot.Repository
{
    public class AtividadeRepository : IAtividadeRepository
    {

        public List<Atividade> GetAtividades()
        {
            List<Atividade> lista_atividades = new List<Atividade>();
            AparelhoRepository ap = new AparelhoRepository();

            //Frango
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Supino", TipoAtividade.Frango, ap.getAparelho(1), "Bla bla bla bla bla bla " + System.Environment.NewLine + " bla bla bla bla bla"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Remada", TipoAtividade.Frango, ap.getAparelho(2), "Bla bla bla bla bla bla " + System.Environment.NewLine + " bla bla bla bla bla"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Cadeira Flexora", TipoAtividade.Frango, ap.getAparelho(3), "Bla bla bla bla bla bla " + System.Environment.NewLine + " bla bla bla bla bla"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Abdominal supra reto", TipoAtividade.Frango, ap.getAparelho(4), "Bla bla bla bla bla bla " + System.Environment.NewLine + " bla bla bla bla bla"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Lombar", TipoAtividade.Frango, ap.getAparelho(5), "Bla bla bla bla bla bla " + System.Environment.NewLine + " bla bla bla bla bla"));

            //Moderado
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Puxada", TipoAtividade.Moderado, ap.getAparelho(6), "Bla bla bla bla bla bla " + System.Environment.NewLine + " bla bla bla bla bla"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Remada", TipoAtividade.Moderado, ap.getAparelho(2), "Bla bla bla bla bla bla " + System.Environment.NewLine + " bla bla bla bla bla"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Supino", TipoAtividade.Moderado, ap.getAparelho(1), "Bla bla bla bla bla bla " + System.Environment.NewLine + " bla bla bla bla bla"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Leg press 45", TipoAtividade.Moderado, ap.getAparelho(7), "Bla bla bla bla bla bla " + System.Environment.NewLine + " bla bla bla bla bla"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Cadeira Flexora", TipoAtividade.Moderado, ap.getAparelho(3), "Bla bla bla bla bla bla " + System.Environment.NewLine + " bla bla bla bla bla"));


            //Monstro
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Supino", TipoAtividade.Monstro, ap.getAparelho(1), "Bla bla bla bla bla bla " + System.Environment.NewLine + " bla bla bla bla bla"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Lombar", TipoAtividade.Monstro, ap.getAparelho(5), "Bla bla bla bla bla bla " + System.Environment.NewLine + " bla bla bla bla bla"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Remada", TipoAtividade.Monstro, ap.getAparelho(2), "Bla bla bla bla bla bla " + System.Environment.NewLine + " bla bla bla bla bla"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Leg press 45", TipoAtividade.Monstro, ap.getAparelho(7), "Bla bla bla bla bla bla " + System.Environment.NewLine + " bla bla bla bla bla"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Cadeira Flexora", TipoAtividade.Monstro, ap.getAparelho(3), "Bla bla bla bla bla bla " + System.Environment.NewLine + " bla bla bla bla bla"));

            return lista_atividades;

        }

    }
}
