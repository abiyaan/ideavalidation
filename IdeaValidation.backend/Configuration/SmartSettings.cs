using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdeaValidation.backend.Configuration
{
    /// <summary>
    ///     Contains settings that apply to the SmartAdmin themed application.
    /// </summary>
    public class SmartSettings
    {
        /// <summary>
        ///     Defines the password of the demo user that can be used to authenticate with.
        /// </summary>
        public static readonly string DemoPassword = "admin";

        /// <summary>
        ///     Defines the username (email address) of the demo user that can be used to authenticate with.
        /// </summary>
        public static readonly string DemoUsername = "admin@demo.com";

        /// <summary>
        ///     Indicates which type of environment the application is hosted on.
        /// </summary>
        public string Environment { get; set; } = EnvironmentName.Development;

        /// <summary>
        ///     Indicates whether the application should render the shortcuts container.
        /// </summary>
        public bool UseShortcuts { get; set; }
    }
}
