using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;


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
             int max = 0;
             int count = 1;
             char prev = ' ';

             for(int i = 0; i<str.Length; i++)
             {
                 char cur = str[i];
                 if(cur == prev)
                 {
                     count ++;
                     
                     if(count > max)
                     {
                         max = count;
                     }  
                 }else
                 {
                    count = 1;

                    if(count > max)
                     {
                         max = count;
                     }  
                 }
                 prev = cur;
             }

             return max.ToString(); 

        }

        public static string AscendingArrange(string str)
        {   
            string result = String.Concat(str.OrderBy(c => c));

            return result; 
            
        }

    }
}
