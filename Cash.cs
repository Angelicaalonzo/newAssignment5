class Cash : Payment
{
double tenderdCash; // cash provided by customer, e.g. $200
double change;

public Cash(double amount, string PaymentDate, double tenderdCash) : base (amount, PaymentDate)
{
this.tenderdCash = tenderdCash; 
this.change = change; 

}

public double calcChange()
{
    return (change = tenderdCash - getAmount);

}

    public override string GetPaymentType(){
        return "Cash";
        }



}