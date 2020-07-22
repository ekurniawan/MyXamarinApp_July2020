using System;
using System.Collections.Generic;
using System.Text;

namespace MyXamarinApp
{
    public class Global
    {
        private static Global _instance;
        public static Global Instance
        {
            get { 
                if(_instance == null)
                {
                    _instance = new Global();
                }
                return _instance;
            }
        }

        public string Name { get; set; }
        public string Address { get; set; }
    }
}
