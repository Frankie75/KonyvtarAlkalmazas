﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KonyvtarAlkalmazas.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("KonyvtarAlkalmazas.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to create table konyvek (
        ///isbn		int				primary key,
        ///szerzo		varchar(50),
        ///cim			varchar(100)	not null,
        ///megjelenes	date			not null
        ///);
        ///
        ///create table kolcsonzesek (
        ///id			int				primary key identity,
        ///kolcsonzo	varchar(50)		not null,
        ///konyv		int,
        ///hatarido	date,
        ///foreign key (konyv) references konyvek
        ///);
        ///
        ///
        ///.
        /// </summary>
        internal static string sqlDatabaseCreator {
            get {
                return ResourceManager.GetString("sqlDatabaseCreator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 	insert into konyvek values
        ///	(9780394600284,&apos;Gustave Flaubert&apos;,&apos;Madame Bovary&apos;,&apos;1856&apos;),
        ///	(9783736411050,&apos;Leo Tolstoy &apos;,&apos;War and Peace&apos;,&apos;1867&apos;),
        ///	(9781471229015,&apos;F. Scott Fitzgerald &apos;,&apos;The Great Gatsby&apos;,&apos;1925&apos;),
        ///	(9789630786935,&apos;Vladimir Nabokov &apos;,&apos;Lolita&apos;,&apos;1955&apos;),
        ///	(9781495379086,&apos;Marcel Proust &apos;,&apos;In Search of Lost Time &apos;,&apos;1908&apos;);
        ///
        ///
        ///	insert into kolcsonzesek values
        ///	(&apos;Gipsz Elek&apos;,9780394600284,&apos;2018-10-20&apos;),
        ///	(&apos;Gipsz Elek&apos;,9783736411050,&apos;2018-10-20&apos;),
        ///	(&apos;Szure Tibor&apos;,9789630786935,&apos;2018-12-20&apos;),
        /// </summary>
        internal static string sqlDatabaseInserter {
            get {
                return ResourceManager.GetString("sqlDatabaseInserter", resourceCulture);
            }
        }
    }
}