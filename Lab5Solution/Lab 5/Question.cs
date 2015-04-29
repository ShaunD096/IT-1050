﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Question
    {
        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////

        public static string AskForString(string prompt)
        {
            Console.Write(formatPrompt(prompt));
            return Console.ReadLine();
        }

        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////

        public static int AskForInteger(string prompt)
        {
            return int.Parse(AskForString(prompt));
        }

        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////

        public static bool AskForBoolean(string prompt)
        {
            return AskForString(prompt).ToUpper().StartsWith("Y");
        }
        
        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////

        private static string Prefix;

        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////

        public static void SetPromptPrefix(string prefix)
        {
            Question.Prefix = prefix;
        }

        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////

        private static string formatPrompt(string prompt)
        {
            if (!string.IsNullOrEmpty(Prefix))
            {
                prompt = Prefix + " " + prompt;
            }

            prompt = prompt.PadRight(25);

            prompt += ": ";

            return prompt;
        }

        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////

        public static double AskForDouble(string prompt)
        {
            return double.Parse(AskForString(prompt));
        }

        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////

    
    }
}