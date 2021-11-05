namespace Stepwise_Builder
{
    public class Car
    {
        public CarType Type;
        public int WheelSize;

        public override string ToString()
        {
            return $"{nameof(CarType)} is {Type} and {nameof(WheelSize)} is {WheelSize}";
        }
    }
}