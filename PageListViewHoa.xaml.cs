using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BT2
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListViewHoa : ContentPage
    {
        public IList<LoaiHoa> ds { get; set; }

        public PageListViewHoa()
        {
            InitializeComponent();

            List<LoaiHoa> l = new List<LoaiHoa>
            {
                new LoaiHoa ("Hoa Cúc")
                {
                    new Hoa { TenHoa = "Đón Xuân", Gia = 50000, Hinh = "HoaCuc1.jpg", MoTa = "Hoa cúc các màu: trắng, vàng, cam" },
                    new Hoa { TenHoa = "Hồn Nhiên", Gia = 60000, Hinh = "HoaCuc2.jpg", MoTa = "Hoa cúc vàng, cam. Lá măng" },
                    new Hoa { TenHoa = "Tím Thuỷ Chung", Gia = 45000, Hinh = "HoaCuc3.jpg", MoTa = "Hoa cúc tím" }
                },

                new LoaiHoa("Hoa Cưới")
                {
                    new Hoa { TenHoa = "Dây tơ hồng", Gia = 250000, Hinh = "HoaCuc3.jpg", MoTa = "Hoa hồng màu đậm, hoa hồng xanh, các loại lá măng" },
                    new Hoa { TenHoa = "Cầu thuỷ tinh", Gia = 220000, Hinh = "HoaCuc1.jpg", MoTa = "Hoa hồng và hoa thuỷ tiên trắng" },
                    new Hoa { TenHoa = "Duyên thầm", Gia = 260000, Hinh = "HoaCuc2.jpg", MoTa = "Hoa cúc trắng, baby, lá măng" }
                }
            };
            ds = l;
            BindingContext = this;
        }
    }
    public class Hoa
    {
        public string TenHoa { get; set; }
        public string Hinh { get; set; }
        public double Gia { get; set; }
        public string MoTa { get; set; }
    }

    public class LoaiHoa : List<Hoa>
    {
        public string TenLoai { get; set; }
        public IList<LoaiHoa> LoaiHoas { get; set; }
        public LoaiHoa(string tenloai)
        {
            TenLoai = tenloai;
        }


        public LoaiHoa()
        {

        }
    }
}