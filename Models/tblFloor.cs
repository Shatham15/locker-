namespace lockerSystem.Models
{
    public class tblFloor
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public bool IsDeleted { get; set; }
        public int no { get; set; }
        public tblBuilding Building { get; set; }
        public int BuildingId { get; set; }
        public ICollection<tblLocker> Floor { get; }

    }
}
