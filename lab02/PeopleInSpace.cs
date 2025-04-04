using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("GUI")]


namespace lab02
{
    public class peopleInSpace
    {
        public int Id { get; set; }
        public string? message { get; set; }
        public int? number { get; set; }
        public List<personInSpace>? people { get; set; }

        public override string ToString()
        {
            StringBuilder response = new StringBuilder();
            response.AppendLine($"Message: {message}");
            response.AppendLine($"Number of people in space: {number}");
            for (int i = 0; i < number; ++i)
            {
                response.AppendLine($"{i + 1}: {people[i].name} craft: {people[i].craft}");
            }
            return response.ToString();
        }
    }
}
