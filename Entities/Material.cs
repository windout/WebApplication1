using System.ComponentModel;

namespace WebApplication1.Entities
{
    public class Material
    {
        [DisplayName("Mã HH")]
        public int Id { get; set; }
        [DisplayName("Tên HH")]
        public string ProductName { get; set; }
        [DisplayName("Quy cách")]
        public string Standard { get; set; } 
        [DisplayName("HSD(trước mở bao)")]
        public string DateOn { get; set; }
        [DisplayName("HSD(sau mở bao)")]
        public string DateOff { get; set; }
        [DisplayName("Thông tin thêm")]
        public string Note { get; set; }
        public string ID_Consumption { get; set; }
    }
}
