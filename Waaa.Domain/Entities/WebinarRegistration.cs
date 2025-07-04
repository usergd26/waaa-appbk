﻿namespace Waaa.Domain.Entities
{
    public class WebinarRegistration
    {
        public int Id { get; set; }
        public int WebinarId { get; set; }
        public Webinar Webinar { get; set; }
        public int UserId { get; set; }
        public AppUser AppUser { get; set; }
        public bool PaymentStatus { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
    }
}
