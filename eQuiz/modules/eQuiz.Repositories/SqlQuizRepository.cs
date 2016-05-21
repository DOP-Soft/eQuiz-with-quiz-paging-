using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eQuiz.Entities;


namespace eQuiz.Repositories
{
    public class SqlQuizRepository : IQuizRepository
    {

        public IEnumerable<Quiz> GetAllQuizzes()
        {
            List<Quiz> result;
            using (var context = new eQuizEntities())
            {
                //context.Configuration.ProxyCreationEnabled = false;

                var query = from quiz in context.Quizs
                            select quiz;

                result = query.ToList();
            }

            return result;
        }

        public IEnumerable<Quiz> GetQuizzes(int? page, int? pageSize)
        {
            List<Quiz> result;
            var currPage = page ?? 0;
            var currPageSize = pageSize ?? 10;

            using (var context = new eQuizEntities())
            {
                context.Configuration.ProxyCreationEnabled = false;

                var query = from quiz in context.Quizs
                            select quiz;

                var queryPaged = query.OrderBy(q => q.Id).Skip(currPage * currPageSize)
                                .Take(currPageSize)
                                .ToArray();

                result = queryPaged.ToList();
            }

            return result;
        }

        public int GetQuizzesCount()
        {
            var result = 0;
            using (var context = new eQuizEntities())
            {
                result = context.Quizs.Count();
            }

            return result;
        }
    }
}
