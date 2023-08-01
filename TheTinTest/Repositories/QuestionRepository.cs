using TheTinTest.Models;
using TheTinTest.Repositories.Interfaces;

namespace TheTinTest.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        //Db Mock
        public IEnumerable<Question> GetQuestions()
        {
            return new List<Question>
            {
                new Question() { QuestionId = 1, QuestionString = "What is the capital of Cuba?"},
                new Question() { QuestionId = 2, QuestionString = "What is the capital of France?"},
                new Question() { QuestionId = 3, QuestionString = "What is the capital of Poland?"},
                new Question() { QuestionId = 4, QuestionString = "What is the capital of Germany?"}
            };
        }
    }
}
