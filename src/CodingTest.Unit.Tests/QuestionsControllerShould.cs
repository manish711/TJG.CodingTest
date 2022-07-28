using CodingTest.Unit.Tests.Helpers;
using CodingTest.WebApi.Controllers;
using CodingTest.WebApi.Interfaces;
using CodingTest.WebApi.Models;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using Xunit;

namespace CodingTest.Unit.Tests
{
    public class QuestionsControllerShould
    {
        private const string expectedTitle = "Expected Geography Questions";
        private readonly Mock<ILogger<QuestionsController>> mockLogger;
        private readonly IQuestionRepository fakeQuestionRepository;
        private readonly QuestionsController questionsController;

        public QuestionsControllerShould()
        {
            mockLogger = new Mock<ILogger<QuestionsController>>();

            var expectedQuestions = new Questionnaire() { QuestionnaireTitle = expectedTitle };
            fakeQuestionRepository = new FakeQuestionRepository() { ExpectedQuestions = expectedQuestions };

            questionsController = new QuestionsController(mockLogger.Object, fakeQuestionRepository);
        }

        [Fact]
        public void Get_Questions_Title_When_Valid_Request()
        {
            var questions = questionsController.Get();

            Assert.Equal(expectedTitle, questions.QuestionnaireTitle);
        }

        [Fact]
        public void Post_Throw_ArgumentNull_Exception_When_Value_Is_Null()
        {
            Assert.Throws<ArgumentNullException>(() => questionsController.Post(null));
        }
    }
}
