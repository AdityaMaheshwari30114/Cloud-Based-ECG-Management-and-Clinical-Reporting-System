using System;

namespace ECG.Models
{
    public class Report
    {
        public int report_id { get; set; }
        public int patient_id { get; set; }
        public int device_id { get; set; }
        public string status { get; set; }
        public DateTime report_date { get; set; }
    }
}
