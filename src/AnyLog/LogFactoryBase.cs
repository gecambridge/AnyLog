﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace AnyLog
{
    /// <summary>
    /// LogFactory Base class
    /// </summary>
    public abstract class LogFactoryBase : ILogFactory
    {
        /// <summary>
        /// Gets the config file file path.
        /// </summary>
        protected string ConfigFile { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogFactoryBase"/> class.
        /// </summary>
        /// <param name="configFile">The config file.</param>
        protected LogFactoryBase(string configFile)
        {
            if (Path.IsPathRooted(configFile))
            {
                ConfigFile = configFile;
            }
            else
            {
                ConfigFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, configFile);
            }
        }

        /// <summary>
        /// Gets the log by name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public abstract ILog GetLog(string name);
    }
}
