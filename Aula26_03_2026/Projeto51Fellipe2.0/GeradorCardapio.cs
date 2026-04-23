using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto51Fellipe2._0
{
    public class GeradorCardapio
    {
        public CardapioDia Gerar(int limite,
            List<Receita> cafes,
            List<Receita> lancheManha,
            List<Receita> almocos,
            List<Receita> lancheTarde,
            List<Receita> jantares,
            List<Receita> ceias)
        {
            CardapioDia melhor = null;
            int melhorTotal = 0;

            foreach (var cafe in cafes)
                foreach (var lm in lancheManha)
                    foreach (var almoco in almocos)
                        foreach (var lt in lancheTarde)
                            foreach (var jantar in jantares)
                                foreach (var ceia in ceias)
                                {
                                    if (cafe == null || lm == null || almoco == null || lt == null || jantar == null || ceia == null)
                                        continue;

                                    int total =
                                        cafe.Calorias +
                                        lm.Calorias +
                                        almoco.Calorias +
                                        lt.Calorias +
                                        jantar.Calorias +
                                        ceia.Calorias;

                                    if (total <= limite && total > melhorTotal)
                                    {
                                        melhorTotal = total;

                                        melhor = new CardapioDia
                                        {
                                            Cafe = cafe,
                                            LancheManha = lm,
                                            Almoco = almoco,
                                            LancheTarde = lt,
                                            Jantar = jantar,
                                            Ceia = ceia,
                                            TotalCalorias = total
                                        };
                                    }
                                }

            return melhor;
        }
    }
}
