namespace lockerSystem.Models
{
    public class tblBookingState
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public bool IsDeleted { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public ICollection<tblBooking> Booking { get; set; }
    }
}
