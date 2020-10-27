﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQLAzureMWBatchUpload.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SQLAzureMWBatchUpload.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, error opening output file {0}.  Error: {1}.
        /// </summary>
        internal static string ErrorOpeningFile {
            get {
                return ResourceManager.GetString("ErrorOpeningFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry database edition {0} is invalid. Please enter web or business..
        /// </summary>
        internal static string InvalidDatabaseEdition {
            get {
                return ResourceManager.GetString("InvalidDatabaseEdition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, but the database size you specified ({0}) is invalid.
        ///
        ///For web edition, please enter 1 or 5.  For business edition please enter 10, 20, 30, 40, or 50..
        /// </summary>
        internal static string InvalidDatabaseEditionSize {
            get {
                return ResourceManager.GetString("InvalidDatabaseEditionSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, but database size can only be (web = 1 or 5) or (busienss = 10, 20, 30, 40, 50, 100, or 150)..
        /// </summary>
        internal static string InvalidDatabaseSize {
            get {
                return ResourceManager.GetString("InvalidDatabaseSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All parameters for SQLAzureMWBatchUpload can be found in the config file.
        ///
        ///If you want, you can override the config file by specifying the parameters you want to override.
        ///
        ///usage: SQLAzureMWBatchUpload -S server -U username -P password -D Northwind -d true -s 1
        ///
        ///[-S target server name]
        ///[-U username]
        ///[-P password]
        ///[-D target database name]
        ///[-c database collation]
        ///[-i TSQL input file]
        ///[-o output file]
        ///[-e Edition (web or business)
        ///[-s database size in GBs (web = 1 or 5) (business = 10, 20, 30, 40, 50, 100 or  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ProgramArgs {
            get {
                return ResourceManager.GetString("ProgramArgs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}, Version {1}.
        /// </summary>
        internal static string ProgramVersion {
            get {
                return ResourceManager.GetString("ProgramVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to true.
        /// </summary>
        internal static string True {
            get {
                return ResourceManager.GetString("True", resourceCulture);
            }
        }
    }
}
