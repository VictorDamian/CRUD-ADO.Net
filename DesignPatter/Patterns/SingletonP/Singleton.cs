namespace Patterns.SingletonP
{
    public class Singleton
    {
        private static Singleton instance;
        public string Msg = "";
        private Singleton(){
            Msg = "Hola mundo";
        }   
        public static Singleton GetInstance
        {
            get {
                if(instance==null)
                return instance = new Singleton();
            return instance;
            }
        }
    }
}