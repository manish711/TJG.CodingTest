using CodingTest.WebApi.Interfaces;
using CodingTest.WebApi.Repositories;
using Xunit;

namespace CodingTest.Unit.Tests.Repository
{
    public class QuestionRepositoryShould
    {
        private readonly IQuestionRepository questionRepository;


        public QuestionRepositoryShould()
        {
            questionRepository = new QuestionRepository();
        }

        [Fact]
        public void Get_Expected_Questionnaire()
        {
            var questionnaire = questionRepository.GetQuestionnaire();

            Assert.Equal("Geography Questions", questionnaire.QuestionnaireTitle);
            Assert.Equal("What is the capital of Italy?", questionnaire.QuestionsText[0]);
            Assert.Equal("What is the capital of France?", questionnaire.QuestionsText[1]);
            Assert.Equal("What is the capital of UK?", questionnaire.QuestionsText[2]);
            Assert.Equal("What is the capital of Germany?", questionnaire.QuestionsText[3]);
        }
    }
}
