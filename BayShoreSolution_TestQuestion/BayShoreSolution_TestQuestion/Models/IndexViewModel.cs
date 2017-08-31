using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.ComponentModel;

namespace BayShoreSolution_TestQuestion.Models
{
    public class IndexViewModel
    {
        /// <summary>
        /// Get input number
        /// </summary>
        [Required]
        [Display (Name = "Input Number")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int InputNumber { get; set; }

        /// <summary>
        /// Result:if a given input is palidrome or not.
        /// </summary>
        [DefaultValue("") ]
       public string IsPalindrome { get; set; }
    }
}