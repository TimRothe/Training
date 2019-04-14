namespace Training.Model
{
    public class Exercise
    {
        public Exercise(ExerciseType type, int repetition, decimal rateOfPerceivedExertion)
        {
            Type = type;
            RateOfPerceivedExertion = rateOfPerceivedExertion;
            Repetition = repetition;
        }

        public ExerciseType Type { get; }
        public decimal RateOfPerceivedExertion { get; }
        public int Repetition { get; }
    }
}