using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBuilderProject
{
    public interface ITrainingPlanBuilder
    {
        void Reset();
        void SetTitle();
        void SetDifficulty();
        void AddExercises();
        void SetDuration();
        void SetFrequency();
        void SetEquipment();
        TrainingPlan GetPlan();
    }
}
