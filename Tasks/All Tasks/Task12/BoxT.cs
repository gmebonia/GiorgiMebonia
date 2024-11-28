

using System.Threading.Channels;

namespace Task12
{
    internal class Box<T>
    {
        private T Value;
        public void setvalue(T value) 
        {
            Value = value;
        }
        public T getvalue() 
        { 
            return Value;
        }        
    }
}
