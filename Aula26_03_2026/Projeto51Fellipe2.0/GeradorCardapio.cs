using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto51Fellipe2._0
{
    public class GeradorCardapio
    {
        public CardapioDia Gerar(int limiteCalorias,
            List<Receita> cafes,
            List<Receita> almocos,
            List<Receita> jantares)
        {
            CardapioDia melhor = null;
            int melhorTotal = 0;

            foreach (var cafe in cafes)
            {
                foreach (var almoco in almocos)
                {
                    foreach (var jantar in jantares)
                    {
                        int total = cafe.Calorias + almoco.Calorias + jantar.Calorias;

                        if (total <= limiteCalorias && total > melhorTotal)
                        {
                            melhorTotal = total;

                            melhor = new CardapioDia
                            {
                                Cafe = cafe,
                                Almoco = almoco,
                                Jantar = jantar,
                                TotalCalorias = total
                            };
                        }
                    }
                }
            }

            return melhor;
        }
    }
}
