using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    public static class CommissionStatusExtensions
    {
        public static string ToDisplayString(this CommissionStatus status)
        {
            var member = typeof(CommissionStatus).GetMember(status.ToString());
            if (member.Length > 0)
            {
                var display = member[0].GetCustomAttribute<DisplayAttribute>();
                if (display != null && !string.IsNullOrWhiteSpace(display.Name))
                    return display.Name;
            }

            // Fallback: split PascalCase names into spaced words (e.g., InProgress -> "In Progress")
            return SplitPascal(status.ToString());
        }

        private static string SplitPascal(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            var sb = new StringBuilder();
            sb.Append(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]) && !char.IsWhiteSpace(input[i - 1]))
                    sb.Append(' ');
                sb.Append(input[i]);
            }
            return sb.ToString();
        }
    }
}