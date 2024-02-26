﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOneISP21
{
    internal class Scenes
    {
        int _number;
        string _name;
        string _description;
        public Scenes()
        { 

        }
      /// <summary>
      /// создание новой <b>сцены</b>.
      /// </summary>
      /// <param name="numb">номер сцены</param>
      /// <param name="name">имя сцены</param>
        public Scenes(int numb , string name)
        {
            _number = numb;
            _name = name;
        }



        
        /// <summary>
        /// имя сцены.
        /// </summary>
        public string Name { 
            get {return _name;} 
            set { _name = value;} 
        }

        public int Number { 
            get { return _number;} 
            set { _number = value;} 
        }

        public string Desc { get {
                _description = $"#{_number} - name: {_name}";
                return _description;
            } }

        /// <summary>
        /// отображает данные о сцене.
        /// </summary>
        public void Show()
        {
            Console.WriteLine(this.Desc);
        }

    }
}
