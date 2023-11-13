namespace Cargo_Database.Entitys
{
    internal class CisternMeasureEntity
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public int Volym {  get; set; }
        public int Ullage { get; set; }
        public int CisternId { get; set; }
        public CisternEntity Cistern { get; set; } = null!;
    }
}
