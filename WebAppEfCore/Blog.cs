using System;
using System.ComponentModel.DataAnnotations;

namespace EfCoreExperiment
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedTimestamp { get; set; }

    }
}