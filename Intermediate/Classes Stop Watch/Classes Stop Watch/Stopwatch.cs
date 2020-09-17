using System;

namespace Classes_Stop_Watch
{
    public class Stopwatch
    {
        private TimeSpan _startTime;
        private bool _startTimeSet;
        private bool _stopTimeSet;


        public void Start(TimeSpan startTime)
        {
            if (_startTimeSet == true)
            {
                throw new InvalidOperationException("Start already set");
            }
            else
            {
                _startTime = new TimeSpan();
                _startTime = startTime;
                _startTimeSet = true;
            }
        }


        public TimeSpan Stop()
        {
            _startTimeSet = false;
            var stopTime = DateTime.Now.TimeOfDay - _startTime;

            return stopTime;
        }
    }
}
