using System;

namespace CS.Impl._04_Advanced
{
    public class Singleton : IMySingleton
    {
        private Singleton() { }

        private static Singleton _instance;

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        public string Function()
        {
            return "";
        }
    }

    public interface IMySingleton
    {
        string Function();
    }

    public class MySingleton : IMySingleton
    {
        public string Function()
        {
            return "";
        }
    }
}