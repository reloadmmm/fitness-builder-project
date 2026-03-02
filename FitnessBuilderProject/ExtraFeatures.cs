using System;

namespace FitnessBuilderProject
{
    public static class ExtraFeatures
    {
        public static double CalculateBmi(double weightKg, double heightMeters)
        {
            if (weightKg <= 0) throw new ArgumentException(""Вес должен быть больше 0"");
            if (heightMeters <= 0) throw new ArgumentException(""Рост должен быть больше 0"");
            return weightKg / (heightMeters * heightMeters);
        }

        public static int CalculateCaloriesBurned(int minutes, int caloriesPerMinute)
        {
            if (minutes <= 0) throw new ArgumentException(""Минуты должны быть больше 0"");
            if (caloriesPerMinute <= 0) throw new ArgumentException(""Калории/мин должны быть больше 0"");
            return minutes * caloriesPerMinute;
        }

        public static int CalculateHeartRateZone(int age)
        {
            if (age <= 0) throw new ArgumentException(""Возраст должен быть больше 0"");
            return 220 - age; // максимальный пульс (простая формула)
        }
    }
}
