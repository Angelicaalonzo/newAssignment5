abstract class Payment
{
double amount; // amount of this payment
string paymentDate; // date of this payment

public Payment(double a, string p)
{
    this.amount = a; 
    this.paymentDate = p;

}

public double getAmount()
{
    return amount; 

}

public string getPaymentDate()
{
    return paymentDate; 
}

public virtual bool verify()
{
    
    //return "Payment Verified";
    return "";


}

public virtual string getPaymentType(){
        return "";
    }
}
