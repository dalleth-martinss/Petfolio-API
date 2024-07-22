using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UsesCases.Pet.Register;

public class RegisterPetUseCase
{
    public ResponseRegisteredPetJson Execute(RequestPetJson request)
    {
        return new ResponseRegisteredPetJson
        {
            Id = 9,
            Name = request.Name,
        };
    }
}
