﻿namespace AlphaTab.Core.EcmaScript

{
    public class Error : System.Exception
    {
        public Error(string message) : base(message)
        {
        }
        public Error(string message, System.Exception inner) : base(message, inner)
        {
        }
    }
}
