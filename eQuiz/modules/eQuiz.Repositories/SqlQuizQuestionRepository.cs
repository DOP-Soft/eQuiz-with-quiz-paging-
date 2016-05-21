using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eQuiz.Entities;

namespace eQuiz.Repositories
{
    public class SqlQuizQuestionRepository : IQuizQuestionRepository
    {
        public IEnumerable<QuizQuestion> GetAllQuizQuestions()
        {
            List<QuizQuestion> result;
            using (var context = new eQuizEntities())
            {
                //context.Configuration.ProxyCreationEnabled = false;

                var query = from quizQuestion in context.QuizQuestions
                            select quizQuestion;

                result = query.ToList();
            }

            return result;
        }
    }
}
