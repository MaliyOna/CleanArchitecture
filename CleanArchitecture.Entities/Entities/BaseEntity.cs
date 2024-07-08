﻿using CleanArchitecture.Enterprise.Abstractions;

namespace CleanArchitecture.Enterprise.Entities;

public class BaseEntity : IBaseEntity
{
    public Guid Id { get; set; }
}
