using System;
using System.Collections.Generic;
using System.Text;

using Lab2.MobilePhone;

namespace KPI.DesignPatterns
{
    class MobilePhoneWorld : World
    {
        private MobilePhone _phone;

        public MobilePhoneWorld()
        {
            _phone = new MobilePhone();
        }

        protected override void RunIteration()
        {
            _phone.SetAlarmForOneSecond();
            _phone.BlinkLight();
            _phone.PlayMusic();
            _phone.PlayRadio();
            _phone.TakeShot();
        }
    }
}
