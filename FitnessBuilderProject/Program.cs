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
            Console.WriteLine("\n=== Extra features ===");
            Console.WriteLine($"BMI (70kg, 1.75m): {ExtraFeatures.CalculateBmi(70, 1.75):F2}");
            Console.WriteLine($"Calories burned (30 min, 8 cal/min): {ExtraFeatures.CalculateCaloriesBurned(30, 8)}");
            Console.WriteLine($"Max HR (age 20): {ExtraFeatures.CalculateHeartRateZone(20)}");
        }
    }
}
