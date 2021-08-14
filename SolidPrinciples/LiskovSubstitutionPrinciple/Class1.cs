using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    //violates LSP as orange is not sunstitute for apple

    //public class Apple
    //{
    //    public virtual string GetColor()
    //    {
    //        return "Red";
    //    }
    //}
    //public class Orange : Apple
    //{
    //    public override string GetColor()
    //    {
    //        return "Orange";
    //    }
    //}

    //solution
    public abstract class Fruit
    {
        public abstract string GetColor();
    }
    public class Apple : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
