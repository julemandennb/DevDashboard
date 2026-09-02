namespace Timers.Dto
{
    public class PomodoroSettings
    {
        public int WorkMinutes { get; set; } = 25;

        public int ShortBreakMinutes { get; set; } = 5;

        public int LongBreakMinutes { get; set; } = 15;

        public int PomodorosBeforeLongBreak { get; set; } = 4;
    }
}