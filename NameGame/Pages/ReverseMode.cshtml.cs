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
    public class ReverseModeModel : PageModel
    {
        public Profile[] ProfileList;
        private NameGameService GameService;
        public Profile[] DisplayedProfiles { get; set; }
        public string matchThisName { get; set; }
        public int correctIndex { get; set; }

        public async Task OnGetAsync()
        {
            GameService = new NameGameService();

            try
            {
                ProfileList = await GameService.GetProfiles();
            }
            catch(Exception)
            {
                RedirectToPage("/Error");
            }

            DisplayedProfiles = new Profile[5];
            Random randomIndex = new Random();
            Profile toAdd;
            int curr = 0;
            while (curr != 5)
            {
                toAdd = ProfileList[randomIndex.Next(ProfileList.Length)];

                if (!DisplayedProfiles.Contains(toAdd) && toAdd.Headshot.Url != null)
                {
                    //valid headshot and person isn't in list
                    //add to list
                    DisplayedProfiles[curr] = toAdd;
                    curr++;
                }
            }
        }
    }
}