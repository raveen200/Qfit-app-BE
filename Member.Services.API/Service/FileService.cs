namespace MemberQfit.Services.API.Service;
public class FileService : IFileService
{
    private readonly IWebHostEnvironment _webHostEnvironment;

    public FileService(IWebHostEnvironment webHostEnvironment)
    {
        _webHostEnvironment = webHostEnvironment;
    }

    public async Task<string> SaveFile(IFormFile file, string directory, string[] allowedExtensions)
    {
        var wwwpath = _webHostEnvironment.WebRootPath;
        var path = Path.Combine(wwwpath, directory);
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        var extension = Path.GetExtension(file.FileName);
        if (!allowedExtensions.Contains(extension))
        {
            throw new InvalidOperationException($"Only {string.Join(",", allowedExtensions)}extensions are not allowed");
        }

        var newFileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

        var filePath = Path.Combine(path, newFileName);

        using (var fileStream = new FileStream(filePath, FileMode.Create))

            await file.CopyToAsync(fileStream);

        return newFileName;
    }


    public void DeleteFile(string fileName, string directory)
    {
        var fullPath = Path.Combine(_webHostEnvironment.WebRootPath, directory, fileName);
        if (!Path.Exists(fullPath))
        {
            throw new FileNotFoundException($"File {fileName} does not exists");
        }
        File.Delete(fullPath);
    }

}

