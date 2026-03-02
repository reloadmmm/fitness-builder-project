using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBuilderProject
{
    public class CardioTrainingBuilder : ITrainingPlanBuilder
    {
        private TrainingPlan _plan;

        public CardioTrainingBuilder()
        {
            _plan = new TrainingPlan();
        }

        public void Reset()
        {
            _plan = new TrainingPlan();
        }

        public void SetTitle()
        {
            _plan.Title = "Кардио программа для похудения";
        }

        public void SetDifficulty()
        {
            _plan.Difficulty = "Лёгкая-Средняя";
        }

        public void AddExercises()
        {
            _plan.Exercises.Add("Бег на дорожке - 20 мин");
            _plan.Exercises.Add("Велотренажёр - 15 мин");
            _plan.Exercises.Add("Эллиптический тренажёр - 15 мин");
            _plan.Exercises.Add("Скакалка - 10 мин");
            _plan.Exercises.Add("Бёрпи - 5 мин");
        }

        public void SetDuration()
        {
            _plan.DurationMinutes = 65;
        }

        public void SetFrequency()
        {
            _plan.DaysPerWeek = 5;
        }

        public void SetEquipment()
        {
            _plan.Equipment = "Беговая дорожка, велотренажёр, скакалка";
        }

        public TrainingPlan GetPlan()
        {
            return _plan;
        }
    }
}
