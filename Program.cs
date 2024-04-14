internal class Program
{
    private static void Main(string[] args)
    {
       int[] a = {1,2,3,4,5,6,7,8};

       Console.WriteLine("Nhap gia tri phan tu can chen");

       int x = Convert.ToInt32(Console.ReadLine());
       
       int index = 0;
       for(int i = 0; i < a.Length ; i++)
       {
        if(x == a[i])
        {
            index = i;
        }
       }
        
        //Xoa Phan tu mang
        
        for(int i = index; i < a.Length - 1; i++)
        {
            a[i] = a[i+1];
        }

        Console.WriteLine("In gia tri mang ");
        for(int i =0; i < a.Length ; i++)
        {
               Console.Write(a[i] + " , ");
        }
      


    }
}