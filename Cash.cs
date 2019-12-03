class Cash : Payment
{
double tenderdCash; // cash provided by customer, e.g. $200
double change;

public Cash(double tenderdCash, string paymentDate, double amount) : base (amount, paymentDate)
{
this.tenderdCash = tenderdCash; 
 

}

// public double calcChange()
// {
//    // return (change == tenderdCash - getAmount);

// }

    public override string getPaymentType()
{
    return "Credit Card";
}



}