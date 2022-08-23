using System;

namespace Domain.Model
{
    public class TR_Api_Hit_Log
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Thread { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public string TimeSpan { get; set; }
    }
}
