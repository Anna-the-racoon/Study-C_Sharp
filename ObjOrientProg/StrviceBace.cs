using System.Collections.Generic;

namespace ObjOrientProg
{
    public abstract class StrviceBace<T,Y> 
        where T : class, new() 
        where Y : struct
    {

        public StrviceBace()
        {

        }

        public List<T> Get() 
        {
            return new List<T>();
        }

        public void Create<U>(U id) where U : struct
        {
        }
        
        public T Update(Y id) 
        {
            return new T();
        }

        public abstract void Delete(int id);

        public virtual string DeleteAll(int id)
        {
            return "A";        
        }

    }
}
