﻿using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetById;
public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "Hulk",
            Type = Communication.Enums.PetType.Dog,
            Birthday = new DateTime(year: 2024, month: 04, day: 14)
        };
    }
}
