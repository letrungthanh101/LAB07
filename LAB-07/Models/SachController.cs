using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LAB_07.Models
{
    public class SachController : ApiController
    {
        Sach[] sachs = new Sach[]
        {
            new Sach {Id =1, Title = "Tôi thấy ông khuê trên cỏ xanh", AuthorName ="Lê Trung Thành", Price = 1, Content = "Truyện kể tuổi thơ" },
            new Sach {Id =2,Title = "lorem sum ", AuthorName = "toidicodedao", Content = "lorem sum oiuoilj jkljfs rtoiu gdlfkj",Price =375 },
        };
        public IEnumerable<Sach> GetALL()
        {
            return sachs;
        }
        public IHttpActionResult GetSach(int id)
        {
            var sach = sachs.FirstOrDefault((p) => p.Id == id);
            if (sach == null)
            {
                return NotFound();
            }
            return Ok(sach);
        }

    }
}
