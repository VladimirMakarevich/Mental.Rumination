namespace Mental.Rumination.Models {
    public class RuminationQuestion {
        public long RuminationQuestionId { get; set; }
        public string QuestionText { get; set; }
        public RuminationAnswer RuminationAnswer { get; set; }
    }
}