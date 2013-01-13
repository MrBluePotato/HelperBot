//HelperBot - Copyright (c) Jonty800 and LeChosenOne <2013> (http://forums.au70.net)
//This plugin is open source and designed to be used with 800Craft and LegendCraft server softwares

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//May rename/move when other trigger files are created

namespace HelperBot
{
    public static class MaintenanceTriggers
    {
        static String[] FellTrigger = new String[]
        {
           "i",
           "fell" 
        };
        static String[] FellTrigger2 = new String[]
        {
           "i",
           "am",
           "stuck"
        };

        static String[] FellTrigger3 = new String[]
        {
           "i'm",
           "stuck"
        };
         static String[] WebTrigger = new String[]
        {
           "what",
           "website",
           "this"
        };

        static String[] WebTrigger2 = new String[]
        {
           "what",
           "server",
           "website"
        };

        static String[] ServTrigger = new String[]
        {
           "what",
           "server",
           "name"
        };

        static String[] ServTrigger2 = new String[]
        {
            "what",
           "this",
           "server"
        };
        static String[] TimeTrigger = new String[]
        {
           "what",
           "is",
           "the",
           "time"
        };
      
        public static FileInfo swearFile = new FileInfo("swearwords.txt");
        public static string[] SwearTrigger;
    
        static String[] HoursTrigger = new String[]
        {
           "how",
           "many",
           "hours",
           "have"
        };
        static String[] HoursTrigger2 = new String[]
        {
            "are",
           "my",
           "hours"
        };

        public static String[][] TimeFullTrigger = new String[][]
        {
            TimeTrigger
        };
        public static String[][] SwearFullTrigger = new String[][]
        {
            SwearTrigger
        };
        public static String[][] FellFullTrigger = new String[][]
        {
            FellTrigger,
            FellTrigger2,
            FellTrigger3
        };
        public static String[][] HoursFullTrigger = new String[][]
        {
            HoursTrigger,
            HoursTrigger2,
        };
        public static String[][] WebFullTrigger = new String[][]
        {
            WebTrigger,
            WebTrigger2
        };
        public static String[][] ServFullTrigger = new String[][]
        {
            ServTrigger,
            ServTrigger2
        };
    }
}
