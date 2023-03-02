using System;
using System.Collections.Generic;

namespace Dictionaries
{
    internal class Program
    {


        //
        static void Main(string[] args)
        {
            //string comparer for case censitive
            //var dictionay = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            //dictionay.Add("movie", "bahubali");
            //dictionay["movie"] = "RRR";
            //dictionay.Add("language", "Csharp");
            //dictionay["language"] = "Java";
            //dictionay.TryAdd("language", "cpp");
            //Console.WriteLine(dictionay.GetType());

            //foreach (var key in dictionay)
            //{
            //    Console.WriteLine($"key: {key.Key} ,value:{key.Value}");
            //}
            //if(dictionay.ContainsKey("movie"))
            //dictionay.Remove("movie");
            //Console.WriteLine("hello");
            //string s = "pwwkew";
            //var data=substring.LengthOfLongestSubstring(s);
            //Console.WriteLine("hello", data);
            //MedianOfTwoArrays.MedianOfTwoArray();

            /////////////////////////////////////////////////////////////////
            //palindromeInaString.LongestPalindrome();
            /////////////////////////////////////////////////////////////////
            //int num = 1534236469;
            //int data= reverseAnumber.Reverse(num);
            //Console.WriteLine(data);
            /////////////////////////////////////////////////////////////////
            //string str = "words and 987"; 
            //int data=FindNumInString.number(str);
            //Console.WriteLine(data);
            /////////////////////////////////////////////////////////////////
            //int data = 1234567899;
            //palindrome.palindromes(data);
            /////////////////////////////////////////////////////////////////
            //int num = 123;
            //string data= IntegersToRomans.romans(num);
            //Console.WriteLine(data);
            /////////////////////////////////////////////////////////////////
            //string[] str = { "reflower","flow","flight" };
            //var st = "vk";
            //str[0].Contains(st);
            //commonStringInArray.commonString(str);
            /////////////////////////////////////////////////////////////////
            //int[] nums = { -1, 0, 1, 2, -1, -4 };
            //int[] nums = { 0, 0, 0, 0 };
            //addingThreenumbersTogetZero.addThreeNum(nums);
            /////////////////////////////////////////////////////////////////
            //BubbleSort.closestNumber();
            /////////////////////////////////////////////////////////////////
            //LetterCombinationofPhoneNumber.LetterCombinations();
            //////////////////////////////////////////////////////////////////
            //anagram.anagramCheck("aacc", "ccac");
            //////////////////////////////////////////////////////////////////
            ///Grouped Anagram
            //GroupAnagrams.GroupAnagram();
            //////////////////////////////////////////////////////////////////
            int[] nums = new int[] { 1, 1, 1, 2, 2, 3 };
            int k = 2;
            TopKFrequentElements.TopKFrequent(nums,k);
        }
    }
}
