﻿using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdeaValidation.backend.Configuration
{
    /// <summary>
    /// Provides strong-typed access to the the application settings that are loaded through the 'appSettings.json' file.
    /// </summary>
    [UsedImplicitly]
    public class AppSettings
    {
        /// <summary>Contains the ConnectionString that determines how to connect to the targeted database engine.</summary>
        /// <remarks>Note: The value is stored unprotected and should be kept secured outside of development!</remarks>
        public string ConnectionString { get; set; } = "IdeaValidationContext";

        /// <summary>Indicates which SQL Server based database engine is used to host the application data.</summary>
        public DatabaseServer Database { get; set; } = DatabaseServer.SqlServer;
    }
}
