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
    public class MatModeModel : PageModel
    {
        public Question MatQuestion { get; set; }

        public async Task OnGetAsync()
        {
            MatQuestion = new Question();

            try
            {
                await MatQuestion.CreateQuestion(Question.Type.Mat);
            }
            catch(InvalidOperationException)
            {
                RedirectToPage("./Error");
            }
            
        }
    }
}