using mvcIntro.Entities.Shared;

namespace mvcIntro.Entities
{
    public class Survey : ISurvey
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}