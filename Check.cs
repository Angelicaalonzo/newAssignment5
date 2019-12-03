class Check : Payment
{
string Bank; // bank name
string custName; // customer/client name
string accNum; // account number

public override bool verify()
{
    Console.WriteLine("Signature and account Balance verified");
    return true; 

}
     public override string GetPaymentType(){
        return "Check";
        }


}