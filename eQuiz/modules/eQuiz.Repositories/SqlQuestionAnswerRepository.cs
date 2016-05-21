using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eQuiz.Entities;

namespace eQuiz.Repositories
{
    public class SqlQuestionAnswerRepository : IQuestionAnswerRepository
    {
        public IEnumerable<QuestionAnswer> GetAllQuestionAnswers()
        {
            List<QuestionAnswer> result;
            using (var context = new eQuizEntities())
            {
                context.Configuration.ProxyCreationEnabled = false;

                var query = from question in context.QuestionAnswers
                            select question;

                result = query.ToList();
            }

            return result;
        }
    }
}
