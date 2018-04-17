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
    public class TeamModeModel : PageModel
    {
        public Question TeamQuestion { get; set; }
        
        public async Task OnGetAsync()
        {
            TeamQuestion = new Question();
            await TeamQuestion.CreateQuestion("Team");
        }
    }
}