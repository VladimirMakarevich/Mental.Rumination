namespace Mental.Rumination.Models {
    public class Client {
        public long ClientId { get; set; }
        public string UserId { get; set; }
        public Rumination Rumination { get; set; }
    }
}