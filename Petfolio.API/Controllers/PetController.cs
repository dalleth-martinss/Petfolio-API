﻿using Microsoft.AspNetCore.Mvc;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;
using Petfolio.Application.UsesCases.Pet.Register;
using Petfolio.Application.UsesCases.Pet.Update;
using Petfolio.Application.UsesCases.Pet.GetAll;
using Petfolio.Application.UsesCases.Pet.GetById;
using Petfolio.Application.UsesCases.Pet.Delete;



namespace Petfolio.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
    [HttpPost]
    //para mostrar no swagger precisamos fazer:
    [ProducesResponseType(typeof(ResponseRegisteredPetJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestPetJson request)
    {
        var useCase = new RegisterPetUseCase();

        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }



    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestPetJson request)
    {
        var useCase = new UpdatePetUseCase();
        useCase.Execute(id, request);

        return NoContent();
    }



    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllPetJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllPetsUseCase();

        var response = useCase.Execute();

        if (response.Pets.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }


    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponsePetJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult Get(int id)
    {
        var useCase = new GetPetByIdUseCase();
        var response = useCase.Execute(id);

        return Ok(response);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent) ]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]

    public IActionResult Delete(int id)
    {
        var useCase = new DeletePetByIdUseCase();
       useCase.Execute(id);

        return NoContent();
    }


}
