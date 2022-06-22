using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
        }

        public Guid Id { get; set; }
        public Guid FormId { get; set; }
        public string Title { get; set; } = null!;

        public virtual Form Form { get; set; } = null!;
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
