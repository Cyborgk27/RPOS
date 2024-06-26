﻿using RPOS.Infrastructure.Commons.Bases.Request;

namespace RPOS.Infrastructure.Helpers
{
    public static class QueryableHelpers
    {
        public static IQueryable<T> Paginate<T>(this IQueryable<T> queryable, BasePaginationRequest request)
        {
            return queryable.Skip((request.NumPage - 1) * request.Records).Take(request.Records);
        }
    }
}
