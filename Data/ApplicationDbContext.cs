using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SquatAI.Models;

namespace SquatAI.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Exercise> Exercises => Set<Exercise>();
    public DbSet<Workout> Workouts => Set<Workout>();
    public DbSet<WorkoutExercise> WorkoutExercises => Set<WorkoutExercise>();
    public DbSet<ExerciseSet> ExerciseSets => Set<ExerciseSet>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<ExerciseSet>()
            .Property(s => s.Weight)
            .HasPrecision(6, 2);

        builder.Entity<Exercise>()
            .Property(e => e.MuscleGroup)
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.Entity<Exercise>()
            .Property(e => e.Equipment)
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.Entity<WorkoutExercise>()
            .HasOne(we => we.Exercise)
            .WithMany(e => e.WorkoutExercises)
            .HasForeignKey(we => we.ExerciseId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
