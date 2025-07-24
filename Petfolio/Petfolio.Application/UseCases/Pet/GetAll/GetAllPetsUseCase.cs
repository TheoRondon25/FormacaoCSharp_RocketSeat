using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetAll;
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
                    Name = "Charlie",
                    Type = Communication.Enums.PetType.Dog
                }
            }

        };
    }
}
