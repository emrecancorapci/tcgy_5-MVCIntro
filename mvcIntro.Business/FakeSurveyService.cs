using mvcIntro.Entities;
using mvcIntro.Entities.Shared;

namespace mvcIntro.Business
{
    public class FakeSurveyService : ISurveyService
    {
        private int _count = 0;
        private readonly ISurvey _survey;

        public FakeSurveyService()
        {
            _survey = new Survey();
        }
        public ISurvey GetSurvey()
        {
            return _survey;
        }

        public int GetCount() => _count;
        public void AddCount() => _count++;
    }
}