using System;

namespace Winforms.ModelBinder
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int EngineTypeId { get; set; }
        public bool IsDiesel { get; set; }

        private static int _cnt;

        public Car()
        {
            Id = ++_cnt;
        }

        public override string ToString()
        {
            return String.Format("Car > {0};{1};{2}", Name, Manufacturer, IsDiesel);
        }
    }
}
