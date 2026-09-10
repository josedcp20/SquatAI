namespace SquatAI.Models
{
    public class ExerciseSet
    {
        public int Id { get; set; }

        public int WorkoutExerciseId { get; set; }
        public WorkoutExercise? WorkoutExercise { get; set; }

        public int SetNumber { get; set; }
        public int Repetitions { get; set; }
        public double Weight { get; set; }
        public int? Rir { get; set; } // Reps in Reserve, optional
    }
}