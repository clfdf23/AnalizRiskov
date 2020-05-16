using System.Collections.Generic;

namespace Domain
{
    public class Asset
    {
        public int AssetId { get; set; }
        public string Name { get; set; }
        public string BName { get; set; }

        public ICollection<Asset> Assets { get; set; }
        public ICollection<Vulnerability> Vulnerabilities { get; set; }

        public Asset()
        {
            Assets = new List<Asset>();
            Vulnerabilities = new List<Vulnerability>();
        }
    }
}