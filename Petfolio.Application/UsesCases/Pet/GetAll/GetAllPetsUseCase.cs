using Petfolio.Communication.Responses;

namespace Petfolio.Application.UsesCases.Pet.GetAll;
public class GetAllPetsUseCase
{
    public ResponseAllPetJson Execute()
    {
      return new ResponseAllPetJson 
      { 
        Pets = new List<ResponseShortPetJson>
        { 
          new ResponseShortPetJson
          {
               Id = 1,
               Name = "Pipoca",
               Type = Communication.Enums.PetType.Dog
          }
        }

      };

    }
}
