// See https://aka.ms/new-console-template for more information
namespace com.kpl.tp.modul4.addclass {
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
            DataGeneric<String> Data = new DataGeneric<String>("1302204054");
            Data.PrintData();
        }
    }
}
