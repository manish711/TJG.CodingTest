using System.Collections.Generic;
using CodingTest.WebApi.Interfaces;
using CodingTest.WebApi.Models;

namespace CodingTest.WebApi.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        public Questionnaire GetQuestionnaire()
        {
            return new Questionnaire
            {
                QuestionnaireTitle = "Geography Questions",
                QuestionsText = new List<string>
                {
                    "What is the capital of Italy?",
                    "What is the capital of France?",
                    "What is the capital of UK?",
                    "What is the capital of Germany?"
                }
            };
        }
    }
}
