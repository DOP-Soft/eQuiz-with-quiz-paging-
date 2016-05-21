using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eQuiz.Entities;

namespace eQuiz.Repositories
{
    public interface IQuestionAnswerRepository
    {
        IEnumerable<QuestionAnswer> GetAllQuestionAnswers();
    }
}
