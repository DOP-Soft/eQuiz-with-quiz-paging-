using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eQuiz.Entities;

namespace eQuiz.Repositories
{
    public class SqlQuestionTypeRepository : IQuestionTypeRepository
    {
        public IEnumerable<QuestionType> GetAllQuestionTypes()
        {
            List<QuestionType> result;
            using (var context = new eQuizEntities())
            {
                //context.Configuration.ProxyCreationEnabled = false;

                var query = from questionType in context.QuestionTypes
                            select questionType;

                result = query.ToList();
            }

            return result;
        }
    }
}
