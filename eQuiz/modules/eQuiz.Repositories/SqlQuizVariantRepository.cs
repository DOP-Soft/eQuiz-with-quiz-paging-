using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eQuiz.Entities;

namespace eQuiz.Repositories
{
    public class SqlQuizVariantRepository : IQuizVariant
    {
        public IEnumerable<QuizVariant> GetAllVariants()
        {
            List<QuizVariant> result;
            using (var context = new eQuizEntities())
            {
                //context.Configuration.ProxyCreationEnabled = false;

                var query = from variant in context.QuizVariants
                            select variant;

                result = query.ToList();
            }

            return result;
        }
    }
}
