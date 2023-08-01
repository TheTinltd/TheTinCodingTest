using TheTinTest.Models;

namespace TheTinTest.Repositories.Interfaces
{
    public interface IQuestionRepository
    {
        IEnumerable<Question> GetQuestions();
    }
}