﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManager.App;

namespace BookManager
{
    class Program
    {
        static void Main(string[] args)
        {
            AppBookManager app = new AppBookManager();
            app.run();
        }
    }
}
