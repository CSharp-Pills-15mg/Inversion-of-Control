using IocDemo.Ports.DataAccess;

namespace IocDemo.Business.UseCases.PresentUsers;

internal static class GenderExtensions
{
    public static GenderResponse ToResponse(this Gender gender)
    {
        return gender switch
        {
            Gender.Male => GenderResponse.Male,
            Gender.Female => GenderResponse.Female,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}