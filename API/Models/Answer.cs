using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Answer
    {
        public Guid Id { get; set; }
        public Guid QuestionId { get; set; }
        public string? Title { get; set; }
        public bool Correct { get; set; }

        public virtual Question Question { get; set; } = null!;
    }
}
