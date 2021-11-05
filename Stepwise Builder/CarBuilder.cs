﻿using System;

namespace Stepwise_Builder
{
    public class CarBuilder
    {
        private class Impl :
            ISpecifyCarType,
            ISpecifyWheelSize,
            IBuildCar
        {
            private readonly Car _car = new Car();
            public ISpecifyWheelSize OfType(CarType type)
            {
                _car.Type = type;
                return this;
            }

            public IBuildCar WithWheels(int size)
            {
                switch (_car.Type)
                {
                    case CarType.Crossover when size < 17 || size > 20:
                    case CarType.Sedan when size < 15 || size > 17:
                        throw new ArgumentException($"Wrong size of wheel for {_car.Type}.");
                }

                _car.WheelSize = size;
                return this;
            }

            public Car Build()
            {
                return _car;
            }
        }

        public static ISpecifyCarType Create()
        {
            return new Impl();
        }
    }
}