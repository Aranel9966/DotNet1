using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet1.Models.ViewModels
{
    public class LessonViewModel
    {
        public string? Title { get; set; }
        public TimeSpan Duration { get; set; }
    }
}