using System.Collections.Generic;

namespace Domain
{
    public class Threat
    {
        public int ThreatId { get; set; }
        public string Name { get; set; }
        public string BName { get; set; }

        public ICollection<Vulnerability> Vulnerabilities { get; set; }
        public ICollection<Consequence> Consequences { get; set; }

        public Threat()
        {
            Vulnerabilities = new List<Vulnerability>();
            Consequences = new List<Consequence>();
        }
    }
}