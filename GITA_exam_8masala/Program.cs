Console.WriteLine("Summani kiriting: ");
float E,S=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Foizni kiriting: ");
float B=0,p=Convert.ToInt32(Console.ReadLine());
E = 2 * S;
int cout = 0;
while (E>B)
{   cout++;
    S = S * ((100 + p) / 100);
    B = S;
}
Console.WriteLine(Convert.ToString(cout) + " Oyda " + Convert.ToString(B) + " so'm" );

