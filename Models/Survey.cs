namespace DojoSurveyWithModel.Models
{
    public class Survey
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Language { get; set; }
        public string Comment { get; set; }

        public Survey(string name, string location, string language, string comment)
        {
            Name = name;
            Location = location;
            Language = language;
            Comment = comment;
        }
    }
}