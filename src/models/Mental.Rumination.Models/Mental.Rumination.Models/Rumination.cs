using System;
using System.Collections.Generic;

namespace Mental.Rumination.Models {
    public class Rumination {
        public long RuminationId { get; set; }
        public ICollection<RuminationQuestion> RuminationQuestions { get; set; }
        public RuminationCategory RuminationCategory { get; set; }
        public RuminationType RuminationType { get; set; }
        public string Text { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}