﻿using TwoOneHomes.Domain.Entities;

namespace TwoOneHomes.Domain.Repositories;

public interface IContactRepository
{
    Task<List<Contact>> GetAllContactAsync(CancellationToken cancellationToken = default);
    Task<Contact?> GetByIdAsync(Ulid Id, CancellationToken cancellationToken = default);
    void Add(Contact contact);
    void Delete(Contact contact);
    void Update(Contact contact);
}
