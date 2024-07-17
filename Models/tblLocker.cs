﻿namespace lockerSystem.Models
{
    public class tblLocker
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public bool IsDeleted { get; set; }
        public int no { get; set; }
        public tblFloor Floor { get; set; }
        public int FloorId { get; set; }
        public tblLockerState LockerState { get; set; }
        public int LockerStateId { get; set; }

    }
}
