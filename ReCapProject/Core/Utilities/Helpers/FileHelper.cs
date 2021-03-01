using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        public static IResult Add(string filePath, IFormFile file)
        {
            var tempPath = Path.GetTempFileName();
            if (file.Length > 0)
            {
                using (var stream = new FileStream(tempPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            File.Move(tempPath, filePath);
            if (!File.Exists(filePath))
            {
                return new ErrorResult("Dosya bulunamadı");
            }
            return new SuccessResult();

        }
        public static IResult Delete(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new ErrorResult("Dosya bulunamadı");
            }
            File.Delete(filePath);
            return new SuccessResult();
        }

        public static string CreateFileName(IFormFile file, int length)
        {
            return Guid.NewGuid().ToString()+new FileInfo(file.FileName).Extension;
        }

        public static IResult CheckIfFileType(IFormFile file, string[] extensions)
        {
            var extension=new FileInfo(file.FileName).Extension;
            foreach (var exten in extensions)
            {
                if (exten==extension)
                {
                    return new SuccessResult();
                }
            }
            return new ErrorResult($"Desteklenmeyen dosya formatı:{extension}");
        }

     
    }
}
