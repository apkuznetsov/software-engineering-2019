namespace GasStationMs.App.DistributionLaws
{
    public interface IDistributionLaw
    {
        int MinValue { get; }

        int MaxValue { get; }

        int GetRandomNumber();
    }
}
