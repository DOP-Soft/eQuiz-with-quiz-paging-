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

        private List<Quiz> quizzesList = new List<Quiz>()
        {
            new Quiz() { Id = 1, QuizTypeId = 2, Name = "Quiz1: C# basics", Description = "Quiz for EPAM It Lab .Net students", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays((int) new Random().Next(1, 5)), TimeLimitMinutes = 120, InternetAccess = true },
            new Quiz() { Id = 2, QuizTypeId = 2, Name = "Quiz2: C# basics", Description = "Quiz for EPAM It Lab .Net students", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays((int) new Random().Next(1, 5)), TimeLimitMinutes = 120, InternetAccess = true },
            new Quiz() { Id = 3, QuizTypeId = 2, Name = "Quiz3: C# basics", Description = "Quiz for EPAM It Lab .Net students", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays((int) new Random().Next(1, 5)), TimeLimitMinutes = 120, InternetAccess = true },
            new Quiz() { Id = 4, QuizTypeId = 2, Name = "Quiz4: C# basics", Description = "Quiz for EPAM It Lab .Net students", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays((int) new Random().Next(1, 5)), TimeLimitMinutes = 120, InternetAccess = true },
            new Quiz() { Id = 5, QuizTypeId = 2, Name = "Quiz5: C# basics", Description = "Quiz for EPAM It Lab .Net students", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays((int) new Random().Next(1, 5)), TimeLimitMinutes = 120, InternetAccess = false },
            new Quiz() { Id = 6, QuizTypeId = 2, Name = "Quiz6: C# basics", Description = "Quiz for EPAM It Lab .Net students", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays((int) new Random().Next(1, 5)), TimeLimitMinutes = 120, InternetAccess = false },
            new Quiz() { Id = 7, QuizTypeId = 2, Name = "Quiz7: C# basics", Description = "Quiz for EPAM It Lab .Net students", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays((int) new Random().Next(1, 5)), TimeLimitMinutes = 120, InternetAccess = false },
            new Quiz() { Id = 8, QuizTypeId = 2, Name = "Quiz8: C# basics", Description = "Quiz for EPAM It Lab .Net students", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays((int) new Random().Next(1, 5)), TimeLimitMinutes = 120, InternetAccess = false },
            new Quiz() { Id = 9, QuizTypeId = 2, Name = "Quiz9: C# basics", Description = "Quiz for EPAM It Lab .Net students", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays((int) new Random().Next(1, 5)), TimeLimitMinutes = 120, InternetAccess = true },
            new Quiz() { Id = 10, QuizTypeId = 2, Name = "Quiz10: C# basics", Description = "Quiz for EPAM It Lab .Net students", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays((int) new Random().Next(1, 5)), TimeLimitMinutes = 120, InternetAccess = true },
            new Quiz() { Id = 11, QuizTypeId = 2, Name = "Quiz11: C# basics", Description = "Quiz for EPAM It Lab .Net students", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays((int) new Random().Next(1, 5)), TimeLimitMinutes = 120, InternetAccess = true },
            new Quiz() { Id = 12, QuizTypeId = 2, Name = "Quiz12: C# basics", Description = "Quiz for EPAM It Lab .Net students", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays((int) new Random().Next(1, 5)), TimeLimitMinutes = 120, InternetAccess = false },
            new Quiz() { Id = 13, QuizTypeId = 2, Name = "Quiz13: C# basics", Description = "Quiz for EPAM It Lab .Net students", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays((int) new Random().Next(1, 5)), TimeLimitMinutes = 120, InternetAccess = true },
            new Quiz() { Id = 14, QuizTypeId = 2, Name = "Quiz14: C# basics", Description = "Quiz for EPAM It Lab .Net students", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays((int) new Random().Next(1, 5)), TimeLimitMinutes = 120, InternetAccess = false }
        };

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

            //using (var context = new eQuizEntities())
            //{
            //    context.Configuration.ProxyCreationEnabled = false;

            //    var query = from quiz in context.Quizs
            //                select quiz;

            //    var queryPaged = query.OrderBy(q => q.Id).Skip(currPage * currPageSize)
            //                    .Take(currPageSize)
            //                    .ToArray();

            //    result = queryPaged.ToList();
            //}

            result = quizzesList.GetRange(currPage * currPageSize, (currPage * currPageSize + currPageSize < quizzesList.Count) ? currPageSize : quizzesList.Count - currPage * currPageSize);

            return result;
        }

        public int GetQuizzesCount()
        {
            var result = 0;
            //using (var context = new eQuizEntities())
            //{
            //    result = context.Quizs.Count();
            //}
            result = quizzesList.Count;

            return result;
        }
    }
}
