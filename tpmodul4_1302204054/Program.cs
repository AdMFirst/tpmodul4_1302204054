
namespace com.kpl.tp.modul4
{
    public class HaloGeneric
    {
        public void SapaUser<T>(ref T x)
        {
            Console.WriteLine("Halo user " + x);
        }
    }




    class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);

        }
    }

    class main
    {
        public static void Main()
        {
            String nama = "Aditya Mardi Pratama";
            HaloGeneric h = new HaloGeneric();
            h.SapaUser(ref nama);
            DataGeneric<String> Data = new DataGeneric<String>("1302204054");
            Data.PrintData();
        }
    }
}
