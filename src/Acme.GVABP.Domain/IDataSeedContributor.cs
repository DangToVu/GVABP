using System;
using System.Threading.Tasks;
using Acme.GVABP.GiangViens;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore;

public class GVABPDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<GiangVien, Guid> _giangvienRepository;

    public GVABPDataSeederContributor(IRepository<GiangVien, Guid> giangvienRepository)
    {
        _giangvienRepository = giangvienRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _giangvienRepository.GetCountAsync() <= 0)
        {
            await _giangvienRepository.InsertAsync(
                new GiangVien
                {
                    Name = "Josh Husterson",
                    Type = SubjectType.English,
                    Birthday = new DateTime(1989, 6, 8),
                    Salary = 4900.84f
                },
                autoSave: true
            );

            await _giangvienRepository.InsertAsync(
                new GiangVien
                {
                    Name = "Naruto",
                    Type = SubjectType.Science,
                    Birthday = new DateTime(1995, 9, 27),
                    Salary = 4200.0f
                },
                autoSave: true
            );
        }
    }
}
