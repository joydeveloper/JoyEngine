using System;
using System.Collections.Generic;
namespace JoyEngine
{
    public class LifeHuman : FactoryProduct
    {
    }
    class Director
    {
        Builder builder;
        public Director(Builder builder)
        {
            this.builder = builder;
        }
        public Director()
            {
            
            }
        public void SetBuilder(Builder builder)
        {
            this.builder = builder;

        }
        public virtual void Construct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }
    }
   public abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();      
    }
    public abstract class ConstructedProduct
    {
        List<object> parts = new List<object>();
        public void Add(object part)
        {
            parts.Add(part);
        }
    }
    class ConcreteBuilder : Builder
    {
        LifeHuman lf = new LifeHuman();
        public override void BuildPartA()
        {

        }
        public override void BuildPartB()
        {

        }
        public override void BuildPartC()
        {

        }       
    } 
    public abstract class MethodsBuilder : Builder
    {
        public abstract void Execute(MDelegate meth);
        public abstract void Composite(HandlerManager handman);
    }
    public class TestMethods : MethodsBuilder
    {
        public override void BuildPartA()
        {
            throw new NotImplementedException();
        }
        public override void BuildPartB()
        {
            throw new NotImplementedException();
        }
        public override void BuildPartC()
        {
            throw new NotImplementedException();
        }
        public override void Composite(HandlerManager handman)
        {

        }
        public override void Execute(MDelegate meth)
        {
            //  meth.Instantiate(); 
        }
    }
    public class MovedBuilder : MethodsBuilder
    {
        public override void BuildPartA()
        {
            throw new NotImplementedException();
        }
        public override void BuildPartB()
        {
            throw new NotImplementedException();
        }
        public override void BuildPartC()
        {
            throw new NotImplementedException();
        }
        public override void Composite(HandlerManager handman)
        {

        }
        public override void Execute(MDelegate meth)
        {

        }
    }
}
