using Microsoft.AspNetCore.Mvc;

namespace EFBlog.Controllers
{
    public class ArticleController : Controller
    {
        [HttpGet("Article/{id}")]
        public async Task<IActionResult> Index(long id)
        {
            return View();
        }

        [HttpGet("CreateArticle")]
        public IActionResult CreateArticle()
        { 
            return View(); 
        }

        [HttpGet("GetArticleList")]
        public async Task<IActionResult> GetArticleList()
        {
            return View();
        }

        [HttpGet("UpdateArticle/{id}")]
        public async Task<IActionResult> UpdateArticle(long id)
        {
            return View();
        }
    }
}
