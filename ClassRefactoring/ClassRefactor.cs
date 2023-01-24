using System;

namespace DeveloperSample.ClassRefactoring
{
    public enum SwallowType
    {
        African, European
    }

    public enum SwallowLoad
    {
        None, Coconut
    }

    public class SwallowFactory
    {
        public Swallow GetSwallow(SwallowType swallowType) => new Swallow(swallowType);
    }

    public class Swallow
    {
        public SwallowType Type { get; }
        public SwallowLoad Load { get; private set; }

        public Swallow(SwallowType swallowType)
        {
            Type = swallowType;
        }

        public void ApplyLoad(SwallowLoad load)
        {
            Load = load;
        }

        public double GetAirspeedVelocity()
        {
            return Type switch
            {
                SwallowType.African => Load switch
                {
                    SwallowLoad.None => 22,
                    SwallowLoad.Coconut => 18,
                    _ => throw new InvalidOperationException(),
                },
                SwallowType.European => Load switch
                {
                    SwallowLoad.None => 20,
                    SwallowLoad.Coconut => 16,
                    _ => throw new InvalidOperationException(),
                },
                _ => throw new InvalidOperationException(),
            };
        }
    }
}