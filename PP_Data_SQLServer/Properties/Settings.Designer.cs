﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PP_Data_SQLServer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=\"sql.tihub.be, 15975\";Initial Catalog=AD4_PenguinPlanner;Persist Secu" +
            "rity Info=True;User ID=AD4;Password=A123456);Connection Timeout=16")]
        public string AD4_PenguinPlannerConnectionString {
            get {
                return ((string)(this["AD4_PenguinPlannerConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=\"sql.tihub.be\";Initial Catalog=AD4_PenguinPlanner;Persist Security In" +
            "fo=True;User ID=AD4;Password=A123456);Connection Timeout=16")]
        public string AD4_PenguinPlannerConnectionString_WithoutPort {
            get {
                return ((string)(this["AD4_PenguinPlannerConnectionString_WithoutPort"]));
            }
        }
    }
}
