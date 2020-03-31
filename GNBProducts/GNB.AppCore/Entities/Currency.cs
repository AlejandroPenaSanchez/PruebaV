using GNB.AppCore.Interfaces;

namespace GNB.AppCore.Entities
{
    public class Currency : BaseEntity, ICurrency
    {
        public string Name { get; set; }
    }
}
