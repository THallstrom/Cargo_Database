namespace Cargo_Database.Entitys
{
    internal class CisternEntity
    {
        public int Id { get; set; }
        public string CisternName { get; set; } = null!;
        public string ProductDescription { get; set; } = null!;
        public string CisternLocation { get; set; } = null!;
        public int MaxVolym {  get; set; }
        public int MaxUllage { get; set; }
    }
}
