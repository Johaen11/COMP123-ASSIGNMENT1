﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Author's Name: Johaen Gnanakumar
 * Author's Student#:300880309
 * Date Last Modified:05/28/2016
 * Program Description:
 * Revision History: Version 0.0.6
 */ 
namespace COMP123_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Johaen");
            hero.Show();
            hero.Fight();
        }
    }
}
