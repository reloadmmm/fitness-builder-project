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
            Console.WriteLine("ПРИЛОЖЕНИЕ ДЛЯ ФИТНЕСА (Строитель)\n");

            var strengthBuilder = new StrengthTrainingBuilder();
            var cardioBuilder = new CardioTrainingBuilder();

            var director = new TrainingPlanDirector(strengthBuilder);

            Console.WriteLine("1. Полная силовая программа:");
            var strengthPlan = director.BuildFullPlan();
            strengthPlan.DisplayPlan();

            Console.WriteLine("\n2. Полная кардио программа:");
            director.ChangeBuilder(cardioBuilder);
            var cardioPlan = director.BuildFullPlan();
            cardioPlan.DisplayPlan();

            Console.WriteLine("\n3. Быстрая силовая программа (без оборудования):");
            director.ChangeBuilder(strengthBuilder);
            var quickPlan = director.BuildCustomPlan(
                withTitle: true,
                withExercises: true,
                withDuration: true,
                withFrequency: false
            );
            quickPlan.DisplayPlan();

            Console.WriteLine("\n4. Ручное создание плана без директора:");
            var manualBuilder = new StrengthTrainingBuilder();
            manualBuilder.Reset();
            manualBuilder.SetTitle();
            manualBuilder.SetDifficulty();
            manualBuilder.AddExercises();
            var manualPlan = manualBuilder.GetPlan();
            Console.WriteLine(manualPlan.GetSummary());

            Console.WriteLine("\nВСЕ ПЛАНЫ СОЗДАНЫ");
            Console.WriteLine("Использованы паттерны: Builder (Строитель)");
        }
    }
}
