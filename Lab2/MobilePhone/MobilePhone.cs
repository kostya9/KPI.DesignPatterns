using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.MobilePhone
{
    public class MobilePhone
    {
        private Alarm _alarm;
        private Camera _camera;
        private Light _light;
        private Player _player;
        private Radio _radio;

        public MobilePhone()
        {
            _alarm = new Alarm(1);
            _camera = new Camera();
            _light = new Light();
            _player = new Player();
            _radio = new Radio();
            _alarm.Trigger += AlarmTrigger;
        }

        private void AlarmTrigger(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("DZhhhhhh! Alarm!");
        }

        public void SetAlarmForOneSecond()
        {
            _alarm.Start();
        }

        public void BlinkLight()
        {
            _light.Start();
            _light.Stop();
        }

        public void TakeShot()
        {
            _camera.Shoot();
        }

        public void PlayMusic()
        {
            _player.Play();
        }

        public void PlayRadio()
        {
            _radio.Play();
        }
    }
}
