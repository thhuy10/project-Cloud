using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DesignWeb_Project.Areas.Admin.Models.DataModel;

namespace DesignWeb_Project.Areas.Admin.Models.BusinessModel
{
    public class InitializerConnectionDB:DropCreateDatabaseIfModelChanges<ConnectionDBContext>
    {
        protected override void Seed(ConnectionDBContext context)
        {
            Md5Encode md5 = new Md5Encode();
            var admin = new User() {
                Username = "huy",
                Phone = "0976016104",
                Email = "tranhoanghuy9@gmail.com",
                Status = true,
                Image= "/Upload/Default/man-avatar.jpg",
                Password = md5.EncodeMd5Encrypt("123456"),
                Address="TĐ",
                Fullname="Hoàng Huy"
            };
            context.User.Add(admin);



            var user01 = new User()
            {
                Username = "Admin",
                Phone = "0976016104",
                Email = "thhuy10@gmail.com",
                Status = true,
                Image = "/Upload/Default/man-avatar.jpg",
                Password = md5.EncodeMd5Encrypt("1234567"),
                Address = "Ha Noi",
                Fullname = "Admin"
            };

            context.User.Add(user01);




            context.SaveChanges();
        }
    }
}