namespace Kiwi.Polyphemus.Web.Api.Endpoints;

using Kiwi.Polyphemus.Persistence;
using Kiwi.Polyphemus.Persistence.Model;
using Kiwi.Polyphemus.Web.Models.Dto;

using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

public static class PatientEndpoints
{
  public static IEndpointRouteBuilder MapPatientEndpoints(this IEndpointRouteBuilder app)
  {
    var patients = app
      .MapGroup("api/patient")
      .WithTags("Patients");

    patients.MapPost("", CreatePatient);
    patients.MapGet("{id}", GetPatient)
      .WithName(nameof(GetPatient));

    patients.MapDelete("{id}", DeletePatient);

    return app;
  }

  public static async Task<Results<Ok<PatientDto>, NotFound>> GetPatient(Guid id, PolyphemusDbContext ctx, CancellationToken cancellationToken = default)
  {
    var patient = await ctx.Patients.SingleOrDefaultAsync(x => x.Id == id, cancellationToken);

    if (patient == null)
    {
      return TypedResults.NotFound();
    }

    var result = new PatientDto();

    return TypedResults.Ok(result);
  }

  public static async Task<Results<NoContent,NotFound>> DeletePatient(Guid id)
  {
    return TypedResults.NotFound();
  }

  public static async Task<Results<CreatedAtRoute<PatientDto>, BadRequest>> CreatePatient(PatientCreateDto dto)
  {
    var patient = new Patient();

    var result = new PatientDto();

    return TypedResults.CreatedAtRoute(result, nameof(GetPatient), new { id = patient.Id });
  }
}
