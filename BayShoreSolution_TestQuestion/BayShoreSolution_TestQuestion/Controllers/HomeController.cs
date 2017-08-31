using BayShoreSolution_TestQuestion.Models;
using System;
using System.Web.Mvc;

namespace BayShoreSolution_TestQuestion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IndexViewModel viewmodel = new IndexViewModel();
            return View(viewmodel);
        }
        /// <summary>
        /// Checks if the given input is palindrome or not?
        /// </summary>
        /// <param name="inputNumber"></param>
        /// <returns></returns>
        public ActionResult IsPalindrome(IndexViewModel viewmodel)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", viewmodel);
            }

            try
            {

                int reminder = 0;
                int reversedInput = 0;
                int tempNumber = 0;
                tempNumber = viewmodel.InputNumber;
                viewmodel.IsPalindrome = "Give Input Number " + viewmodel.InputNumber + " is not Palindrome";


                while (tempNumber > 0)
                {
                    reminder = tempNumber % 10;
                    tempNumber = tempNumber / 10;
                    reversedInput = reversedInput * 10 + reminder;
                    /*
                    This is another way to implement above code:
                    tempNumber = Math.DivRem(tempNumber, 10, out reminder);
                    reversedInput = reversedInput * 10 + reminder;
                    */
                }

                if (viewmodel.InputNumber == reversedInput)
                {
                    viewmodel.IsPalindrome = "Give Input Number " + viewmodel.InputNumber + " is Palindrome";
                }


            }
            catch (Exception ex)
            {

                viewmodel.IsPalindrome = "Sorry something went wrong!";
            }

            return View("Index", viewmodel);
        }
    }
}