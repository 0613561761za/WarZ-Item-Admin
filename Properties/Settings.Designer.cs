﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.18444
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WarZLocal_Admin.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\Server\\Open-WarZ\\source\\bin\\Data")]
        public string dataFolder {
            get {
                return ((string)(this["dataFolder"]));
            }
            set {
                this["dataFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\Server\\Open-WarZ\\source\\bin\\Data\\Weapons\\itemsDB.xml\t")]
        public string itemsDBFile {
            get {
                return ((string)(this["itemsDBFile"]));
            }
            set {
                this["itemsDBFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\Server\\Open-WarZ\\source\\bin\\Data\\Weapons\\shopDB.xml\t")]
        public string shopDBFile {
            get {
                return ((string)(this["shopDBFile"]));
            }
            set {
                this["shopDBFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int itemEditDisplay {
            get {
                return ((int)(this["itemEditDisplay"]));
            }
            set {
                this["itemEditDisplay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool loadShopFromFile {
            get {
                return ((bool)(this["loadShopFromFile"]));
            }
            set {
                this["loadShopFromFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Purple")]
        public global::System.Drawing.Color internalItemsColor {
            get {
                return ((global::System.Drawing.Color)(this["internalItemsColor"]));
            }
            set {
                this["internalItemsColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Gold")]
        public global::System.Drawing.Color wearableItemsColor {
            get {
                return ((global::System.Drawing.Color)(this["wearableItemsColor"]));
            }
            set {
                this["wearableItemsColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DarkBlue")]
        public global::System.Drawing.Color weaponItemsColor {
            get {
                return ((global::System.Drawing.Color)(this["weaponItemsColor"]));
            }
            set {
                this["weaponItemsColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Coral")]
        public global::System.Drawing.Color attachmentItemsColor {
            get {
                return ((global::System.Drawing.Color)(this["attachmentItemsColor"]));
            }
            set {
                this["attachmentItemsColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Cyan")]
        public global::System.Drawing.Color consumableItemsColor {
            get {
                return ((global::System.Drawing.Color)(this["consumableItemsColor"]));
            }
            set {
                this["consumableItemsColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool showColorsEverything {
            get {
                return ((bool)(this["showColorsEverything"]));
            }
            set {
                this["showColorsEverything"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Microsoft Sans Serif, 8.25pt")]
        public global::System.Drawing.Font listFont {
            get {
                return ((global::System.Drawing.Font)(this["listFont"]));
            }
            set {
                this["listFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool populateInUI {
            get {
                return ((bool)(this["populateInUI"]));
            }
            set {
                this["populateInUI"] = value;
            }
        }
    }
}
