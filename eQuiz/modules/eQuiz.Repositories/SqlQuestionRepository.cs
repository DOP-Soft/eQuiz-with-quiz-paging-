using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eQuiz.Entities;

namespace eQuiz.Repositories
{
    public class SqlQuestionRepository : IQuestionRepository
    {
        public IEnumerable<Question> GetAllQuestions()
        {
            List<Question> result;
            using (var context = new eQuizEntities())
            {
                //context.Configuration.ProxyCreationEnabled = false;

                var query = from question in context.Questions.Include("QuestionAnswers")
                            select question;

                result = query.ToList();
            }

            return result;
        }
    }
}
