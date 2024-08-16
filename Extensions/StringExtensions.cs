using MauiTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MauiTest.Extensions
{
    public static class StringExtensions
    {
        public static IList<FormattedText> GetFormattedMessage(this string message)
        {
            List<FormattedText> Result = new List<FormattedText>();
            string pat = @"\*([^\*]*)\*|([^*]+)";
            Match match = Regex.Match(message, pat);
            while (match.Success)
            {
                if (match.Groups[1].Success)
                {
                    Result.Add(new FormattedText() { Text = match.Groups[1].Value, FontAttributes = FontAttributes.Bold });
                }
                if (match.Groups[2].Success)
                {
                    Result.Add(new FormattedText() { Text = match.Groups[2].Value, FontAttributes = FontAttributes.None });
                }
                match = match.NextMatch();
            }
            return Result;
        }
    }
}