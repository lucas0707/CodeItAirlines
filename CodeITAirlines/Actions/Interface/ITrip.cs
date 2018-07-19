using CodeITAirlines.Context;

namespace CodeITAirlines.Actions.Interface
{
    public interface ITrip
    {
        void WriteAirport(Airport airport);
        void WriteAirplane(Airplane airplane);

    }
}
