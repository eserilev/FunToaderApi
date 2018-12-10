using System;
using System.Collections.Generic;
using System.Text;

namespace Funtoader.Data.Models.Infrastructure
{
    public abstract class BaseEntity<TId> where TId : struct
    {
        /// <summary>
        /// Gets or sets the pirmary key for this database entity
        /// </summary>
        public TId Id { get; set; }
    }
}
