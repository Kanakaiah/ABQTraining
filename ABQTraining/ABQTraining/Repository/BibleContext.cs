using ABQTraining.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace ABQTraining.Repository
{
    public class BibleContext
    {
        Bible bible;
        private readonly string _path;
        public BibleContext(string appEnvironment)
        {
            _path = appEnvironment+ "\\wwwroot\\data\\ephesians5_6.json";
            bible = new Bible();
        }

        public Book GetBook(string bookname)
        {

            using (StreamReader sr = new StreamReader(_path))
            {
                var json = sr.ReadToEnd();

                var book=JsonConvert.DeserializeObject<Bible>(json);

                return book.Book.Where(c => c.Name == bookname).FirstOrDefault();
            }
        }

    }
}
