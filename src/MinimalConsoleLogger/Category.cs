using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CodehulkNET.MSBuild.Loggers.MinimalConsoleLogger
{
    /// <summary>
    /// Defines a configurable category.
    /// </summary>
    [Serializable]
    public class Category
    {
        #region Properties

        /// <summary>
        /// Gets or sets the console color used for this category.
        /// </summary>
        /// <value>
        /// The color.
        /// </value>
        [XmlAttribute("Color")]
        public ConsoleColor Color
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [XmlAttribute("Description")]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the warnings.
        /// </summary>
        /// <value>
        /// The warnings.
        /// </value>
        [XmlElement("Warning")]
        public HashSet<string> Warnings
        {
            get;
            set;
        }

        #endregion Properties
    }
}