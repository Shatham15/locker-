namespace lockerSystem.Models
{
    public class tblLockerState
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public bool IsDeleted { get; set; }
        public string stateAr { get; set; }
        public string stateEn { get; set; }
        public ICollection<tblLocker> State { get; set; }
    }
}
