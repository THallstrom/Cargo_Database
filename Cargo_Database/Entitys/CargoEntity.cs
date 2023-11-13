namespace Cargo_Database.Entitys
{
    internal class CargoEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = null!;
        public int ProductVolym {  get; set; }

        public int CisternId {  get; set; }
        public CisternEntity Cistern { get; set; } = null!;

        public int VesselId { get; set; }
        public VesselEntity Vessel { get; set; } = null!;
    }
}
