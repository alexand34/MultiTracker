﻿namespace MongoDB.Extensions.Repository.Configuration
{
    public class MongoConfiguration
    {
        /// <summary>
        /// Gets or sets the MongoDB connection string.
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the collection naming convention.
        /// Defaults to <see cref="NamingConvention.Snake"/>.
        /// </summary>
        public NamingConvention CollectionNamingConvention { get; set; } = NamingConvention.Snake;

        /// <summary>
        /// Gets or sets a value indicating whether to pluralize collection names.
        /// Defaults to <c>true</c>.
        /// </summary>
        public bool PluralizeCollectionNames { get; set; } = true;
    }
}
