// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(BuyingSupplies(2,16,1));
/// <summary>
/// 
/// </summary>
/// <param name="n">Max Number of Supplies you can buy in one day</param>
/// <param name="s">Number of days that you used the supplies to survive</param>
/// <param name="m">Number of Supplies that you need in one day to survive</param>
static int BuyingSupplies(int n,int s,int m){
    int mustBuyed = s*m;
    int buyed = 0;
    int daysBuyed = 0;
    int counter = 0 ;
    do
    {
        counter += 1;
        if (counter == 7)
        {
            counter = 0;
            daysBuyed+=1;
            continue;
        }
        daysBuyed += 1;
        buyed += n;
        if(buyed >= mustBuyed){
            return daysBuyed;
        }
    } while (daysBuyed <= s);

    return -1;

}