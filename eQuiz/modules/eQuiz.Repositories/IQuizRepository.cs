using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eQuiz.Entities;

namespace eQuiz.Repositories
{
    public interface IQuizRepository
    {
        IEnumerable<Quiz> GetAllQuizzes();
        IEnumerable<Quiz> GetQuizzes(int? page, int? pageSize);
        int GetQuizzesCount();
    }
}
