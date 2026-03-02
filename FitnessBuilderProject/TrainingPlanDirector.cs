using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBuilderProject
{
    public class TrainingPlanDirector
    {
        private ITrainingPlanBuilder _builder;

        public TrainingPlanDirector(ITrainingPlanBuilder builder)
        {
            _builder = builder;
        }

        public void ChangeBuilder(ITrainingPlanBuilder builder)
        {
            _builder = builder;
        }

        public TrainingPlan BuildFullPlan()
        {
            _builder.Reset();
            _builder.SetTitle();
            _builder.SetDifficulty();
            _builder.AddExercises();
            _builder.SetDuration();
            _builder.SetFrequency();
            _builder.SetEquipment();

            return _builder.GetPlan();
        }

        public TrainingPlan BuildQuickPlan()
        {
            _builder.Reset();
            _builder.SetTitle();
            _builder.SetDifficulty();
            _builder.AddExercises();
            _builder.SetDuration();

            return _builder.GetPlan();
        }

        public TrainingPlan BuildCustomPlan(bool withTitle, bool withExercises, bool withDuration, bool withFrequency)
        {
            _builder.Reset();

            if (withTitle) _builder.SetTitle();
            if (withExercises) _builder.AddExercises();
            if (withDuration) _builder.SetDuration();
            if (withFrequency) _builder.SetFrequency();

            return _builder.GetPlan();
        }
    }
}
