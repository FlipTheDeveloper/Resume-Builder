namespace ResumeBuilder.Data.Models
{
    public class Contact
    {
        public int Contacts_PK { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public virtual Job AssociatedJob { get; set; }
        public bool WasSupervisor { get; set; }
    }
}
