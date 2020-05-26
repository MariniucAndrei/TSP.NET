using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class Medias
    {
        public int Id
        {
            get;
            set;
        }
        public string ZoneId { get; set; }
        public string PeopleGroupsId { get; set; }
        public string EventsId { get; set; }
        public string NamePhoto { get; set; }
        public string Date { get; set; }
        public string Path { get; set; }
        public string isDeleted { get; set; }
    }
}
