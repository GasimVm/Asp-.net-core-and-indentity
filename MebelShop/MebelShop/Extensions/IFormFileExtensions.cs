using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MebelShop.Extensions
{
    public static class IFormFileExtensions
    {
        public static bool IsImages( this IFormFile file)
        {

            return file.ContentType == "image/jpg" ||
                 file.ContentType == "image/gif" ||
                 file.ContentType == "image/png" ||
                 file.ContentType == "image/jpeg";
        }
        public async static Task<string >SaveImagesAsync(this IFormFile image,string root,string subFolder)
        {
            string fullname = Path.Combine(subFolder, Guid.NewGuid().ToString() + Path.GetFileName(image.FileName));
            string pathfile = Path.Combine(root,"images",fullname);
            using (var steam=new FileStream(pathfile, FileMode.Create))
            {
                await image.CopyToAsync(steam);
            }
                return fullname;
        }
    }
}
