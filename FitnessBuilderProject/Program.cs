using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBuilderProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("=== Создание силового плана ===");

                var strengthBuilder = new StrengthTrainingBuilder();
                var director = new TrainingPlanDirector(strengthBuilder);
                director.BuildPlan();

                var strengthPlan = strengthBuilder.GetPlan();
                strengthPlan.DisplayPlan();

                Console.WriteLine("\n=== Создание кардио плана ===");

                var cardioBuilder = new CardioTrainingBuilder();
                director = new TrainingPlanDirector(cardioBuilder);
                director.BuildPlan();

                var cardioPlan = cardioBuilder.GetPlan();
                cardioPlan.DisplayPlan();

                Console.WriteLine("\nДемонстрация завершена успешно.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
