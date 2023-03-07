using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using ProjetoFinal.Web.Blazor.Shared.Utilities;
using ProjetoFinal.Models.Provider;
using ProjetoFinal.Web.Blazor.Identity;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using ProjetoFinal.Migrations;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace ProjetoFinal.Web.Blazor.Data
{
    public class SampleDataController : Controller
    {
        HttpClient mainHttpClient;
        IConfiguration _configuration;
        private PfaDbContext dbContext = default!;

        public SampleDataController(HttpUtilities httpUtilities, IConfiguration configuration, IDbContextFactory<PfaDbContext> dbFactory)
        {
            mainHttpClient = httpUtilities.CreateUserClient("Main");
            _configuration = configuration;
            dbContext = dbFactory.CreateDbContext();
        }

        [HttpPost("api/profiles/{profileId}/pictures/Save")]
        public async Task<IActionResult> Save(string profileId, IList<IFormFile> UploadFiles)
        {
            Picture picture = new(profileId);

            try
            {
                foreach (var files in UploadFiles)
                {
                    // Create picture in the database and get the response.
                    //HttpResponseMessage response = await mainHttpClient.PostAsync($"/providers/profiles/pictures", null);

                    await dbContext.Pictures.AddAsync(picture);

                    try
                    {
                        await dbContext.SaveChangesAsync();
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                    // Upload file with the ID that was created.
                    BlobContainerClient container = new BlobContainerClient(_configuration.GetConnectionString("MainAzureBlobStorage"), "providers");

                    // Create a new Blob client.
                    BlobClient blob = container.GetBlobClient($"pictures/{profileId}/{picture.Id}");

                    // If a blob with the same name exists, then delete the Blob and its snapshots.
                    await blob.DeleteIfExistsAsync(DeleteSnapshotsOption.IncludeSnapshots);

                    // Create a file stream and  upload the Blob.
                    using Stream? fileStream = files.OpenReadStream();
                    await blob.UploadAsync(fileStream, new BlobHttpHeaders { ContentType = files.ContentType });
                    await fileStream.DisposeAsync();
                }
            }
            catch (Exception e)
            {
                // As the upload failed, delete the created Picture from the database.
                await mainHttpClient.DeleteAsync($"/providers/profiles/pictures?pictureId={picture.Id}");

                return Problem(title: "File failed to upload.", detail: e.Message);
            }

            return NoContent();
        }
    }
}