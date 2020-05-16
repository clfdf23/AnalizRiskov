using System.Collections.Generic;

namespace Domain
{
    public class Consequence
    {
        public int ConsequenceId { get; set; }
        public string Name { get; set; }
        public string BName { get; set; }

        public ICollection<Threat> Threats { get; set; }
        public ICollection<Asset> Assets { get; set; }

        public Consequence()
        {
            Threats = new List<Threat>();
            Assets = new List<Asset>();
        }
    }
}