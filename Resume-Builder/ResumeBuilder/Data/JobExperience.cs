namespace ResumeBuilder.Data
{
    public class JobExperience
    {
        public int JobExperience_PK { get; set; }
        public string Tag { get; set; }
        public string Experience { get; set; }
        public virtual Job AssociatedJob { get; set; }
    }
}
