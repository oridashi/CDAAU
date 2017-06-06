﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nehta.VendorLibrary.Common.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Nehta.VendorLibrary.Common.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to XmlDocument must have a valid XmlDocument.
        /// </summary>
        internal static string InvalidDocument {
            get {
                return ResourceManager.GetString("InvalidDocument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to XmlDocument must have a valid DocumentAttribute.
        /// </summary>
        internal static string InvalidDocumentAttribute {
            get {
                return ResourceManager.GetString("InvalidDocumentAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one of these fields must be specified.
        /// </summary>
        internal static string ParameterAtLeastOneRequired {
            get {
                return ResourceManager.GetString("ParameterAtLeastOneRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument must be a set date.
        /// </summary>
        internal static string ParameterDateRequired {
            get {
                return ResourceManager.GetString("ParameterDateRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value must be greater than {0}.
        /// </summary>
        internal static string ParameterGreaterThan {
            get {
                return ResourceManager.GetString("ParameterGreaterThan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument must be a qualified HPII starting with {0}.
        /// </summary>
        internal static string ParameterInvalidHPII {
            get {
                return ResourceManager.GetString("ParameterInvalidHPII", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument must be a qualified HPIO starting with {0}.
        /// </summary>
        internal static string ParameterInvalidHPIO {
            get {
                return ResourceManager.GetString("ParameterInvalidHPIO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument must be a qualified IHI starting with {0}.
        /// </summary>
        internal static string ParameterInvalidIHI {
            get {
                return ResourceManager.GetString("ParameterInvalidIHI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument should be a UUID starting with &apos;urn:uuid:&apos;.
        /// </summary>
        internal static string ParameterInvalidUUID {
            get {
                return ResourceManager.GetString("ParameterInvalidUUID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value must be less than {0}.
        /// </summary>
        internal static string ParameterLessThan {
            get {
                return ResourceManager.GetString("ParameterLessThan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument must not be specified.
        /// </summary>
        internal static string ParameterNotAllowed {
            get {
                return ResourceManager.GetString("ParameterNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument must be a time in the past.
        /// </summary>
        internal static string ParameterPastDate {
            get {
                return ResourceManager.GetString("ParameterPastDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument must be specified.
        /// </summary>
        internal static string ParameterRequired {
            get {
                return ResourceManager.GetString("ParameterRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to String must have a length of {0}.
        /// </summary>
        internal static string ParameterStringLength {
            get {
                return ResourceManager.GetString("ParameterStringLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument must be a valid URL.
        /// </summary>
        internal static string ParameterURLRequired {
            get {
                return ResourceManager.GetString("ParameterURLRequired", resourceCulture);
            }
        }
    }
}