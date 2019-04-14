using System.Linq;
using NUnit.Framework;
using NFluent;
using Training.Model;

namespace Tests
{
    public class Tests
    {

        [Test]
        public void AddExercise_should_add_new_excercise_to_the_list()
        {
            var session = new Session();
            
            session.AddExcise(ExerciseType.Squat, 0, 0);
            
            Check.That(session.Exercises.Count()).IsEqualTo(1);
        }
    }
}