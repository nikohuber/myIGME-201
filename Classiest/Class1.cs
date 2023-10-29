using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classiest
{
    public abstract class HotDrink
    {
        public HotDrink()
        {

        }

        public HotDrink(string brand)
        {

        }


        public bool instant;
        public bool milk;
        public byte sugar;
        public string size;
        public Customer customer;

        public virtual void AddSugar(byte amount)
        {

        }

        public abstract void Steam();

    }

    public interface IMood
    {
        string Mood { get; }
    }

    public interface ITakeOrder
    {
         void TakeOrder();
    
    }

    public class Waiter : IMood
    {
        public string name;
        public  string Mood { get; }
        public void ServeCustomer(HotDrink cup)
        {

        }

    }

    public class Customer :  IMood
    {
        public string name;
        public string creditCardNumber;
        public string Mood { get; }
    }

    public class CupOfCoffee : HotDrink, ITakeOrder
    {
        public CupOfCoffee(string brand) : base(brand)
        {

        }

        public string beanType;
        public  override void  Steam()
        {

        }

        public void TakeOrder()
        {

        }

     }

    public class CupOfTea : HotDrink, ITakeOrder
    {
        public CupOfTea(bool customerIsWealthy)
        {

        }

        public string leafType;

        public override void Steam()
        {

        }

        public void TakeOrder()
        {

        }


    }

    public class CupOfCocoa : HotDrink, ITakeOrder
    {
        public CupOfCocoa(): this(false)
        {

        }

        public CupOfCocoa(bool marshmallows): base ("Expensive Organic Brand")
            {
            
            }


        public static int numCups;
        public bool marshmallows;
        private string source;

        public override void Steam()
        {

        }

        public void TakeOrder()
        {

        }

        public string Source {

            set
            {

            }
        
        }

        public override void AddSugar(byte amount)
        {
            
        }

    }
}

