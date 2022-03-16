
namespace com.kpl.tp.modul4.halo
{
    public class HaloGeneric
    {
        public void SapaUser<T>(ref T x)
        {
            Console.WriteLine("Halo user "+x);
        }
    }

    public class main
    {
        public static void Main()
        {
            String nama = "Aditya Mardi Pratama";
            HaloGeneric h = new HaloGeneric();
            h.SapaUser(ref nama);
        }
    }
}
