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
            if (string.IsNullOrWhiteSpace(Title))
                throw new InvalidOperationException("План не инициализирован корректно");
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
