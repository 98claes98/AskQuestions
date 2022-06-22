using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Form
    {
        public Form()
        {
            Questions = new HashSet<Question>();
        }

        public Guid Id { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}
