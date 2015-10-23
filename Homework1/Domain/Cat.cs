using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Cat
    {
        public Cat(int age)
        {
            _health = 5;
            _age = age;
            Color = new CatColor();
        }

        private string _name;
        private int _age;
        private int _health;
        public CatColor Color { set; get; }

        public string CurrentColor;

        public string Name
        {
            get { return _name; }
            set
            {
                if (null == _name)
                {
                    _name = value;
                }
            } 
        }

        public int GetCatAge()
        {
            return _age;
        }

        public void Feed()
        {
            _health++;
        }

        public void Punish()
        {
            _health--;
        }

        public string ToKnowColor()
        {
            return (_health >= 5) ? Color.HealthyColor : Color.SickColor;
        }
    }

    public class CatColor
    {
        public string HealthyColor { set; get; } = "White";

        public string SickColor { set; get; } = "Green";
    }
}
