using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBuilderProject
{
    public class StrengthTrainingBuilder : ITrainingPlanBuilder
    {
        private TrainingPlan _plan;

        public StrengthTrainingBuilder()
        {
            _plan = new TrainingPlan();
        }

        public void Reset()
        {
            _plan = new TrainingPlan();
        }

        public void SetTitle()
        {
            _plan.Title = "Силовая тренировка для набора массы";
        }

        public void SetDifficulty()
        {
            _plan.Difficulty = "Средняя";
        }

        public void AddExercises()
        {
            _plan.Exercises.Add("Приседания со штангой - 4x8");
            _plan.Exercises.Add("Жим лёжа - 4x10");
            _plan.Exercises.Add("Тяга штанги в наклоне - 4x8");
            _plan.Exercises.Add("Армейский жим - 3x10");
            _plan.Exercises.Add("Подтягивания - 3xмакс");
            _plan.Exercises.Add("Бицепс со штангой - 3x12");
            _plan.Exercises.Add("Французский жим - 3x12");
        }

        public void SetDuration()
        {
            _plan.DurationMinutes = 90;
        }

        public void SetFrequency()
        {
            _plan.DaysPerWeek = 4;
        }

        public void SetEquipment()
        {
            _plan.Equipment = "Штанга, гантели, турник";
        }

        public TrainingPlan GetPlan()
        {
            return _plan;
        }
    }
}
