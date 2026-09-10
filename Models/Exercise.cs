namespace SquatAI.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public MuscleGroup MuscleGroup { get; set; }
        public Equipment Equipment { get; set; }
        public required string Instructions { get; set; }

        public ICollection<WorkoutExercise> WorkoutExercises { get; set; } = [];
    }
}