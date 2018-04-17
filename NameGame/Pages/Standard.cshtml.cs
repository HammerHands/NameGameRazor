using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NameGame.Models;
using NameGame.Services;

namespace NameGame.Pages
{
    public class StandardModel : PageModel
    {
        public Question StandardQuestion { get; set; }
        public async Task OnGetAsync()
        {
            StandardQuestion = new Question();
            await StandardQuestion.CreateQuestion("standard");
        }
    }
}