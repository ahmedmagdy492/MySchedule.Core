using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchedule.Core.Models
{
    public class Task : BaseModel
    {
        public string Content { get; set; }
        public bool IsCompleted { get; set; }
        [ForeignKey(nameof(Schedule))]
        public int DayId { get; set; }
        public Schedule Schedule { get; set; }
    }
}
