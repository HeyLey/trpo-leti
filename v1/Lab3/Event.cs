using System;

namespace Lab3
{
    public class Event
    {
        public delegate void MethodContainer(); 
    
        public event MethodContainer OnE;
        public event MethodContainer OnR;
        public event MethodContainer OnS;
        public event MethodContainer OnP;
        public event MethodContainer OnC;
    
        public void start(string s)
        {
            if (s.Equals("r+"))
            {
                OnR();
            } 
            if (s.Equals("s+"))
            {
                OnS();
            } 
            if (s.Equals("e+"))
            {
                OnE();
            } 
            if (s.Equals("p+"))
            {
                OnP();
            } 
            if (s.Equals("c+"))
            {
                OnC();
            } 
        }
    }
}