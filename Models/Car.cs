using SystemIdentity.Areas.Identity.Data;

namespace SystemIdentity.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public SystemUser? User { get; set; } //otaznik podporuje hodnotu nula
        public string? UserId {  get; set; }
    }
}
