﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSR.LST.ConferenceXP.ArchiveService {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ArchiveWindowsService.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to You must be an Administrator to uninstall Archive Service..
        /// </summary>
        internal static string AdministratorPrivilegesRequiredText {
            get {
                return ResourceManager.GetString("AdministratorPrivilegesRequiredText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Administrator Privileges Required.
        /// </summary>
        internal static string AdministratorPrivilegesRequiredTitle {
            get {
                return ResourceManager.GetString("AdministratorPrivilegesRequiredTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ConferenceXP Archive Service.
        /// </summary>
        internal static string ConferenceXPArchiveService {
            get {
                return ResourceManager.GetString("ConferenceXPArchiveService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Application configuration file customization failed..
        /// </summary>
        internal static string ConfigurationFileCustomizationFailed {
            get {
                return ResourceManager.GetString("ConfigurationFileCustomizationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CXPArchiver.
        /// </summary>
        internal static string CXPArchiver {
            get {
                return ResourceManager.GetString("CXPArchiver", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Database initialization complete..
        /// </summary>
        internal static string DatabaseInitializationComplete {
            get {
                return ResourceManager.GetString("DatabaseInitializationComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create the ArchiveService database.  Run AddDatabase.sql using your database tools (osql.exe, in the tools directory) to complete the operation. 
        ///
        ///Exception: 
        ///{0}.
        /// </summary>
        internal static string DatabaseOperationFailedText {
            get {
                return ResourceManager.GetString("DatabaseOperationFailedText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Database Operation Failed.
        /// </summary>
        internal static string DatabaseOperationFailedTitle {
            get {
                return ResourceManager.GetString("DatabaseOperationFailedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Would you like to delete the ArchiveService database?  This action will delete all recordings to date..
        /// </summary>
        internal static string DeleteDatabaseText {
            get {
                return ResourceManager.GetString("DeleteDatabaseText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete Database.
        /// </summary>
        internal static string DeleteDatabaseTitle {
            get {
                return ResourceManager.GetString("DeleteDatabaseTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error adding this application to your firewall&apos;s exception list.  Please add the application manually to your firewall.
        ///
        ///
        ///Exception error message: {0}.
        /// </summary>
        internal static string FirewallExceptionAddingText {
            get {
                return ResourceManager.GetString("FirewallExceptionAddingText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Firewall Exception Failed.
        /// </summary>
        internal static string FirewallExceptionFailedTitle {
            get {
                return ResourceManager.GetString("FirewallExceptionFailedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error removing this application from your firewall&apos;s exception list.  Please remove the application manually to your firewall.
        ///
        ///
        ///Exception error message: {0}.
        /// </summary>
        internal static string FirewallExceptionRemovingText {
            get {
                return ResourceManager.GetString("FirewallExceptionRemovingText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installation will now add this application to your Windows Firewall Exceptions list..
        /// </summary>
        internal static string FirewallText {
            get {
                return ResourceManager.GetString("FirewallText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Firewall.
        /// </summary>
        internal static string FirewallTitle {
            get {
                return ResourceManager.GetString("FirewallTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Would you like to initialize the ArchiveService database? If you already have an ArchiveService database set up, this action will CLEAR it. If you do not have the database, you must initialize it for Archive Service to work properly.
        ///    .
        /// </summary>
        internal static string InitializeDatabaseText {
            get {
                return ResourceManager.GetString("InitializeDatabaseText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initialize Database.
        /// </summary>
        internal static string InitializeDatabaseTitle {
            get {
                return ResourceManager.GetString("InitializeDatabaseTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OSQL.exe failed to run properly on the file specified with the current user&apos;s permissions..
        /// </summary>
        internal static string OSQLEXEFailed {
            get {
                return ResourceManager.GetString("OSQLEXEFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please wait while the database initializes.  This may take several minutes....
        /// </summary>
        internal static string PleaseWaitDatabase {
            get {
                return ResourceManager.GetString("PleaseWaitDatabase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please wait while the stored procedures are created....
        /// </summary>
        internal static string PleaseWaitStoredProcedures {
            get {
                return ResourceManager.GetString("PleaseWaitStoredProcedures", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to drop Archive Service database.  Please run DropDatabase.sql using your database tools (osql.exe, in the tools directory).  Exception:
        ///{0}.
        /// </summary>
        internal static string RunDropDatabaseSQL {
            get {
                return ResourceManager.GetString("RunDropDatabaseSQL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service was installed successfully, but the service could not be started.  Make sure SQL Server is installed and running. 
        ///
        ///Exception:
        ///{0}.
        /// </summary>
        internal static string ServiceStartFailureText {
            get {
                return ResourceManager.GetString("ServiceStartFailureText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service Start Failure.
        /// </summary>
        internal static string ServiceStartFailureTitle {
            get {
                return ResourceManager.GetString("ServiceStartFailureTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The SQL Server data directory could not be found..
        /// </summary>
        internal static string SQLDataDirectoryError {
            get {
                return ResourceManager.GetString("SQLDataDirectoryError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft SQL Server was not detected on this computer. Be sure to create the database by executing AddDatabase.sql and AddSPs.sql. You must edit the SqlConnectionString in the ArchiveWindowsService.exe.config file and restart the service. Be advised that connecting Archive Service to SQL Server on another server will adversely affect performance..
        /// </summary>
        internal static string SqlServerNotFoundText {
            get {
                return ResourceManager.GetString("SqlServerNotFoundText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SQL Server Not Found.
        /// </summary>
        internal static string SqlServerNotFoundTitle {
            get {
                return ResourceManager.GetString("SqlServerNotFoundTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stored procedure creation complete..
        /// </summary>
        internal static string StoredProcedureCreationComplete {
            get {
                return ResourceManager.GetString("StoredProcedureCreationComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to add the stored procedures to the database. Run AddSPs.sql using your database tools (osql.exe, in the tools directory) to complete the operation.
        ///
        ///Exception:
        ///{0}.
        /// </summary>
        internal static string StoredProceduresAddFailed {
            get {
                return ResourceManager.GetString("StoredProceduresAddFailed", resourceCulture);
            }
        }
    }
}