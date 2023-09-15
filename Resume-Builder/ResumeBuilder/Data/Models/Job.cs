namespace ResumeBuilder.Data.Models
{
    public class Job
    {
        public int JobEntries_PK { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Summary { get; set; }
        public string Role { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<JobExperience> Skills { get; set; }
    }
}
