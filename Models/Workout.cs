using SquatAI.Data;

namespace SquatAI.Models
{
    public class Workout
    {
        public int Id { get; set; }
        
        
        public required string UserId { get; set; }
        public ApplicationUser? User { get; set; }

        public DateTime StartedAt { get; set; }
        public string? Notes { get; set; }
        public ICollection<WorkoutExercise> WorkoutExercises { get; set; } = [];
    }
}