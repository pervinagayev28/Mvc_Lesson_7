using Microsoft.AspNetCore.Mvc;

namespace Mvc_Lesson_7.Components
{
    public class NewsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var news = new List<String>();

            for (int i = 1; i <= 10; i++)
                news.Add("my news "+i.ToString());

            return View("News", news);
        }
    }
}
