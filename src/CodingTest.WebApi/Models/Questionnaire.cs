using System.Collections.Generic;

namespace CodingTest.WebApi.Models
{
    public class Questionnaire
    {
        public string QuestionnaireTitle { get; set; }
        public IList<string> QuestionsText { get; set; }
    }
}
