using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBuilderProject
{
    public class TrainingPlan
    {
        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Название плана не может быть пустым");
                _title = value;
            }
        }

        private int _durationMinutes;
        public int DurationMinutes
        {
            get => _durationMinutes;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Длительность должна быть больше 0");
                _durationMinutes = value;
            }
        }

        private int _daysPerWeek;
        public int DaysPerWeek
        {
            get => _daysPerWeek;
            set
            {
                if (value <= 0 || value > 7)
                    throw new ArgumentException("Количество дней должно быть от 1 до 7");
                _daysPerWeek = value;
            }
        }
        public List<string> Exercises { get; set; }
        public int DurationMinutes { get; set; }
        public string Equipment { get; set; }

        public TrainingPlan()
        {
            Exercises = new List<string>();
        }

        public void DisplayPlan()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Название: {Title}");
            sb.AppendLine($"Длительность (мин): {DurationMinutes}");
            sb.AppendLine($"Дней в неделю: {DaysPerWeek}");

            Console.WriteLine(sb.ToString());
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
