namespace ECG.Models
{
    public class Patient
    {
        public int patient_id { get; set; }
        public string patient_name { get; set; }
        public int age { get; set; }
        public int managed_by { get; set; }
    }
}
