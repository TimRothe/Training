using System.Collections;
using System.Collections.Generic;

namespace Training.Model
{
    public class Session
    {
        private readonly IList<Exercise> _exercises;
        
        public Session()
        {
            _exercises = new List<Exercise>();
        }

        public IEnumerable<Exercise> Exercises => _exercises;

        public void AddExcise(ExerciseType type, int repetition, decimal rateOfPerceivedExertion)
        {
            _exercises.Add(new Exercise(type, repetition, rateOfPerceivedExertion));
        }
    }
}