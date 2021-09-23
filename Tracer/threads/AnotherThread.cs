﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Tracer
{
    [Serializable]
    public class AnotherThread
    {
        private int _id;
        private int _time;
        private List <Method> _methods = new List<Method>();
        [XmlIgnore]
        private Stack<Method> _methodStack = new Stack<Method>();

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public int Time
        {
            get
            {
                return _time;
            }

            set
            {
                _time = value;
            }
        }

        public List<Method> Methods
        {
            get
            {
                return _methods;
            }

            set
            {
                _methods = value;
            }
        }
        [XmlIgnore]
        public Stack<Method> MethodStack
        {
            get
            {
                return _methodStack;
            }

            set 
            {
            }
        }

    }
}
