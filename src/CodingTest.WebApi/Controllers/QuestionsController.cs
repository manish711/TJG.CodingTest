using System;
using CodingTest.WebApi.Interfaces;
using CodingTest.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CodingTest.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionsController : ControllerBase
    {
        private readonly ILogger<QuestionsController> _logger;
        private readonly IQuestionRepository _questionRepository;

        public QuestionsController(ILogger<QuestionsController> logger, IQuestionRepository questionRepository)
        {
            _logger = logger;
            _questionRepository = questionRepository ?? throw new ArgumentNullException(nameof(questionRepository));
        }

        // GET api/questions
        [HttpGet]
        public Questionnaire Get()
        {
            _logger.LogInformation("Request received to get the list of questions via GET endpoint.");
            return _questionRepository.GetQuestionnaire();
        }

        // POST api/questions
        [HttpPost]
        public void Post([FromBody] string value)
        {
            try
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                _logger.LogInformation($"Answer received: {value} via POST endpoint");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while handling message in Questions Controller");
                throw;
            }
        }
    }
}
