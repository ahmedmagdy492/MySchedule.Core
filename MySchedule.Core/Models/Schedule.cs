using MySchedule.WebUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchedule.Core.Models
{
    public class Schedule : BaseModel
    {
        public int DayNumber { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
