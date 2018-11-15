using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeApi.BusinessLogic
{
    public static class ChallengeSolutions
    {
        public static string StringClean(string str)
        {
            string result = ""; 

            if(str.Length > 0)
            {
                char prev = str[0];
                result += prev; 

                for (int i = 1; i < str.Length; i++)
                {
                    char cur = str[i];
                    if(cur != prev)
                    {
                        result += cur;
                        prev = cur; 
                    }
                }
            }
            return result; 
        }

        public static string LargestBlock(string str)
        {
            int result = 0;
            List<int> results = new List<int>(); 

            if(str.Length > 0)
            {
                char prev = str[0];
                int tmp = 1;
                results.Add(tmp);

                for(int i = 1; i < str.Length; i++)
                {
                    char cur = str[i];
                    if(cur == prev)
                    {
                        tmp++;
                           
                    }else{
                        results.Add(tmp);
                    }

                    prev = cur;
                }

                result = results.Max();
            }

            return result.ToString(); 
        }
    }
}