﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace hotel
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static class Pole
        {
            public static string pole { get; set; } 
            public static string pass { get; set; }
            public static int id { get; set; }
            public static int id2 { get; set; }
        }
    }
}
