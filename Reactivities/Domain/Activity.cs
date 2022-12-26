using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Activity
    {
        public Guid id {get; set;}
        
        public string title {get; set;}

        public DateTime date {get; set;}
    
        public string description {get; set;}

        public string category {get; set;}

        public string city {get; set;}

        public string venue {get; set;}
    }
}