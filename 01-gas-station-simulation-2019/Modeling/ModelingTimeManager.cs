namespace GasStationMs.App.Modeling
{
    internal static class ModelingTimeManager
    {
        internal const int MillisecondsForTimerTick = 20;
        internal static int TimerTicksCount { get; set; }
        internal static bool IsPaused { get; set; }

        internal static int TicksAfterLastCarSpawning { get; set; }
        internal static double TimeAfterLastCarSpawningInSeconds => TicksAfterLastCarSpawning * (double)MillisecondsForTimerTick / 1000;
        internal static double TimeBetweenCars { get; set; }

    internal static void SetUpModelingTimeManager(System.Windows.Forms.Timer timerModeling)
        {
            timerModeling.Interval = MillisecondsForTimerTick;
            TimerTicksCount = 0;
            IsPaused = false;

            TicksAfterLastCarSpawning = 0;
            TimeBetweenCars = 0;
        }
    }
}
