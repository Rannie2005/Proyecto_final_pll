using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Domain.Entities
{
    public class Session
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EngineerId { get; set; }
        public int ServiceId { get; set; }
        public DateTime Date { get; set; }

        public Client? Client { get; set; }
        public Engineer? Engineer { get; set; }
        public Service? Service { get; set; }
    }
}
