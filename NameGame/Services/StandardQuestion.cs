using NameGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//TODO: Explore Factory option further
namespace NameGame.Services
{
    public class StandardQuestion
    {

        private NameGameService creator { get; set; }
        private Profile[] ProfileList { get; set; }
        public String[] profiles { get; set; }
        public int correctIndex { get; set; }

        public StandardQuestion()
        {
            creator = new NameGameService();
            profiles = new String[5];
            Random random = new Random();
            correctIndex = random.Next(5);
        }

        //private async Task<Profile[]> GetProfiles()
        //{
        //    try
        //    {
        //        ProfileList = await creator.GetProfiles();
        //    }
        //    catch (Exception)
        //    {
        //        //TODO: Better Error Handling
        //        return null;
        //    }

        //    Profile[] ProfilesToDisplay = new Profile[5];
        //    Random randomIndex = new Random();
        //    Profile toAdd;
        //    int curr = 0;
        //    while (curr != 5)
        //    {
        //        toAdd = ProfileList[randomIndex.Next(ProfileList.Length)];

        //        if (!ProfilesToDisplay.Contains(toAdd) && toAdd.Headshot.Url != null)
        //        {
        //            //valid headshot and person isn't in list
        //            //add to list
        //            ProfilesToDisplay[curr] = toAdd;
        //            curr++;
        //        }
        //    }
        //}
    }
}
