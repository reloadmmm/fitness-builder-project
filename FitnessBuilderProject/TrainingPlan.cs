using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBuilderProject
{
    public class TrainingPlan
    {
        public string Title { get; set; }
        public string Difficulty { get; set; }
        public List<string> Exercises { get; set; }
        public int DurationMinutes { get; set; }
        public int DaysPerWeek { get; set; }
        public string Equipment { get; set; }

        public TrainingPlan()
        {
            Exercises = new List<string>();
        }

        public void DisplayPlan()
        {
            Console.WriteLine($"\nПЛАН ТРЕНИРОВОК: {Title.ToUpper()}");
            Console.WriteLine($"Сложность: {Difficulty}");
            Console.WriteLine($"Длительность: {DurationMinutes} минут");
            Console.WriteLine($"Дней в неделю: {DaysPerWeek}");
            Console.WriteLine($"Оборудование: {Equipment}");
            Console.WriteLine("Упражнения:");

            for (int i = 0; i < Exercises.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {Exercises[i]}");
            }

            Console.WriteLine($"\nИтого упражнений: {Exercises.Count}");
        }

        public string GetSummary()
        {
            var summary = new StringBuilder();
            summary.AppendLine($"План: {Title}");
            summary.AppendLine($"Упражнения: {string.Join(", ", Exercises)}");
            summary.AppendLine($"Длительность: {DurationMinutes} мин., {DaysPerWeek} дней/неделю");
            return summary.ToString();
        }
    }
}
