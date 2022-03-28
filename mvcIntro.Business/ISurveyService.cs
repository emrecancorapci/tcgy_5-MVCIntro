using mvcIntro.Entities.Shared;

namespace mvcIntro.Business
{
    public interface ISurveyService
    {
        ISurvey GetSurvey();
        int GetCount();
        void AddCount();
    }
}