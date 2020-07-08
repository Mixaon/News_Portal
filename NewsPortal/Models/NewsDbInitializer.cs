using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.IO;
using Newtonsoft.Json;

namespace NewsPortal.Models
{
    public class NewsDbInitializer : DropCreateDatabaseAlways<NewsContext>
    {
        protected override void Seed(NewsContext db)
        {
            using (StreamReader r = new StreamReader("./posts.json"))
            {
                string json = r.ReadToEnd();
                List<News> news = JsonConvert.DeserializeObject<List<News>>(json);
                foreach (var item in news)
                {
                    db._News.Add(new News { Title = item.Title, Description = item.Description, NewsImage = item.NewsImage });
                }
                
                base.Seed(db);
            }
        }
    }
}