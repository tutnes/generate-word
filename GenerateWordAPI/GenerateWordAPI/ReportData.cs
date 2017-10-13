using System.Collections.Generic;

namespace GenerateWordAPI
{
    public class Breaches
    {
    }

    public class Server
    {
        public string ID { get; set; }
        public double availability { get; set; }
        public int availabilityOffPeakTarget { get; set; }
        public int availabilityTarget { get; set; }
        public Breaches breaches { get; set; }
        public double down { get; set; }
        public double downtime { get; set; }
        public string name { get; set; }
    }

    public class Transactions
    {
    }

    public class Service
    {
        public string ID { get; set; }
        public double availability { get; set; }
        public int availabilityOffPeakTarget { get; set; }
        public int availabilityTarget { get; set; }
        public double down { get; set; }
        public string name { get; set; }
        public List<Server> servers { get; set; }
        public Transactions transactions { get; set; }
    }

    public class ReportData
    {
        public string ID { get; set; }
        public long fromDate { get; set; }
        public bool includeApp { get; set; }
        public string name { get; set; }
        public List<Service> services { get; set; }
        public long toDate { get; set; }
    }
}
