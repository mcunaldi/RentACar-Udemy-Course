﻿using Core.Persistence.Repositories;
using RentACar.Domain.Entities;

namespace RentACar.Application.Services.Repositories;
public interface IBrandRepository : IAsyncRepository<Brand, Guid>, IRepository<Brand, Guid>
{
}

