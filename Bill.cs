class Billing{
string billDate;
string description ;
double amount; // bill total amount

public Billing(string b, string d, double a)
{
    this.billDate = b; 
    this.description = d; 
    this.amount = a; 
}

public string getBillInfo()
{
    return $"{billDate} {description} {amount}";
}

// public double getBalance()
// {
// return (amount - Payment.getBalance);
// }

public bool addPayment()
{
    // if(Payment.verify() == true)
    // {
    //     addPayment; 
    // }


}

}