using NameGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NameGame.Services
{
    public static class QuestionFactory
    {
        public static async Task CreateQuestion(this Question question, string questionType)
        {
            int tryCount = 0;
            NameGameService gameService = new NameGameService();
            Profile[] allProfiles = await gameService.GetProfiles();

            question.DisplayedProfiles = new Profile[5];
            Random numGenerator = new Random();
            Profile toAdd;
            int curr = 0;
            //Filter profiles out of Displayed based on question type
            if(questionType.Equals("standard") || questionType.Equals("reverse"))
            {
                while (curr != 5)
                {
                    toAdd = allProfiles[numGenerator.Next(allProfiles.Length)];

                    if (!question.DisplayedProfiles.Contains(toAdd) && toAdd.Headshot.Url != null)
                    {
                        //valid headshot and person isn't in list
                        //add to list
                        question.DisplayedProfiles[curr] = toAdd;
                        curr++;
                    }
                }
                //Randomly Select Correct Profile
                question.correctProfile = question.DisplayedProfiles[numGenerator.Next(question.DisplayedProfiles.Length)];
            }
            else if(questionType.Equals("Team"))
            {
                while (curr != 5)
                {
                    toAdd = allProfiles[numGenerator.Next(allProfiles.Length)];

                    if (!question.DisplayedProfiles.Contains(toAdd) && toAdd.Headshot.Url != null && toAdd.JobTitle != null)
                    {
                        //valid headshot and person isn't in list
                        //add to list
                        question.DisplayedProfiles[curr] = toAdd;
                        curr++;
                    }
                }
                //Randomly Select Correct Profile
                question.correctProfile = question.DisplayedProfiles[numGenerator.Next(question.DisplayedProfiles.Length)];
            }
            else if(questionType.Equals("Mat"))
            {
                while (curr != 5)
                {
                    toAdd = allProfiles[numGenerator.Next(allProfiles.Length)];

                    if (!question.DisplayedProfiles.Contains(toAdd) && toAdd.Headshot.Url != null && toAdd.FirstName.StartsWith("Mat"))
                    {
                        //valid headshot and person isn't in list
                        //add to list
                        question.DisplayedProfiles[curr] = toAdd;
                        curr++;
                    }
                }
                //Randomly Select Correct Profile
                question.correctProfile = question.DisplayedProfiles[numGenerator.Next(question.DisplayedProfiles.Length)];
            }
        }
    }
}
