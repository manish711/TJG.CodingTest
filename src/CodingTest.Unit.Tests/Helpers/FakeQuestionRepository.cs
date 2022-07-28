using CodingTest.WebApi.Interfaces;
using CodingTest.WebApi.Models;

namespace CodingTest.Unit.Tests.Helpers
{
    public class FakeQuestionRepository : IQuestionRepository
    {
        public Questionnaire ExpectedQuestions { get; set; }
        public Questionnaire GetQuestionnaire()
        {
            return ExpectedQuestions;
        }
    }
}
