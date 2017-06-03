﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace App2
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::App2.App2_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::App2.App2_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.String fullName)
        {
            if(_provider == null)
            {
                _provider = new global::App2.App2_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace App2.App2_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            string standardName;
            global::Windows.UI.Xaml.Markup.IXamlType xamlType = null;
            if(_xamlTypeToStandardName.TryGetValue(type, out standardName))
            {
                xamlType = GetXamlTypeByName(standardName);
            }
            else
            {
                xamlType = GetXamlTypeByName(type.FullName);
            }
            if(xamlType == null)
            {
                xamlType = CheckOtherMetadataProvidersForType(type);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (global::System.String.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypes.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            xamlType = CreateXamlType(typeName);
            if (xamlType == null)
            {
                xamlType = CheckOtherMetadataProvidersForName(typeName);
            }
            if (xamlType != null)
            {
                _xamlTypes.Add(typeName, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (global::System.String.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType> _xamlTypes = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();
        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember> _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();
        global::System.Collections.Generic.Dictionary<global::System.Type, string> _xamlTypeToStandardName = new global::System.Collections.Generic.Dictionary<global::System.Type, string>();

        private void AddToMapOfTypeToStandardName(global::System.Type t, global::System.String str)
        {
            if(!_xamlTypeToStandardName.ContainsKey(t))
            {
                _xamlTypeToStandardName.Add(t, str);
            }
        }

        private object Activate_0_LayoutAwarePage() { return new global::App2.Common.LayoutAwarePage(); }

        private object Activate_1_Singers() { return new global::App2.Singers(); }

        private object Activate_2_Songs() { return new global::App2.Songs(); }

        private object Activate_3_Tweets() { return new global::App2.Tweets(); }

        private object Activate_4_SingersInfo() { return new global::App2.SingersInfo(); }

        private object Activate_6_MainPage() { return new global::App2.MainPage(); }

        private object Activate_7__TweetsPage() { return new global::App2._TweetsPage(); }

        private object Activate_8_UserTweetsViewModel() { return new global::App2.ViewModels.UserTweetsViewModel(); }


        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(string typeName)
        {
            global::App2.App2_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::App2.App2_XamlTypeInfo.XamlUserType userType;

            switch (typeName)
            {
            case "Windows.UI.Xaml.Controls.Page":
                xamlType = new global::App2.App2_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::Windows.UI.Xaml.Controls.Page));
                break;

            case "Windows.UI.Xaml.Controls.UserControl":
                xamlType = new global::App2.App2_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::Windows.UI.Xaml.Controls.UserControl));
                break;

            case "Windows.UI.Xaml.DependencyObject":
                xamlType = new global::App2.App2_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::Windows.UI.Xaml.DependencyObject));
                break;

            case "Boolean":
                xamlType = new global::App2.App2_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::System.Boolean));
                break;

            case "Object":
                xamlType = new global::App2.App2_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::System.Object));
                break;

            case "App2.Common.LayoutAwarePage":
                userType = new global::App2.App2_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::App2.Common.LayoutAwarePage), GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_0_LayoutAwarePage;
                xamlType = userType;
                break;

            case "App2.Singers":
                userType = new global::App2.App2_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::App2.Singers), GetXamlTypeByName("App2.Common.LayoutAwarePage"));
                userType.Activator = Activate_1_Singers;
                xamlType = userType;
                break;

            case "App2.Songs":
                userType = new global::App2.App2_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::App2.Songs), GetXamlTypeByName("App2.Common.LayoutAwarePage"));
                userType.Activator = Activate_2_Songs;
                xamlType = userType;
                break;

            case "App2.Tweets":
                userType = new global::App2.App2_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::App2.Tweets), GetXamlTypeByName("App2.Common.LayoutAwarePage"));
                userType.Activator = Activate_3_Tweets;
                xamlType = userType;
                break;

            case "App2.SingersInfo":
                userType = new global::App2.App2_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::App2.SingersInfo), GetXamlTypeByName("App2.Common.LayoutAwarePage"));
                userType.Activator = Activate_4_SingersInfo;
                xamlType = userType;
                break;

            case "Callisto.Effects.Tilt":
                userType = new global::App2.App2_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::Callisto.Effects.Tilt), GetXamlTypeByName("Windows.UI.Xaml.DependencyObject"));
                userType.AddMemberName("IsTiltEnabled");
                AddToMapOfTypeToStandardName(typeof(global::System.Boolean),
                                                   "Boolean");
                userType.AddMemberName("SuppressTilt");
                AddToMapOfTypeToStandardName(typeof(global::System.Boolean),
                                                   "Boolean");
                xamlType = userType;
                break;

            case "App2.MainPage":
                userType = new global::App2.App2_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::App2.MainPage), GetXamlTypeByName("App2.Common.LayoutAwarePage"));
                userType.Activator = Activate_6_MainPage;
                xamlType = userType;
                break;

            case "App2._TweetsPage":
                userType = new global::App2.App2_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::App2._TweetsPage), GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_7__TweetsPage;
                userType.AddMemberName("UserTweetsWidget");
                xamlType = userType;
                break;

            case "App2.ViewModels.UserTweetsViewModel":
                userType = new global::App2.App2_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::App2.ViewModels.UserTweetsViewModel), GetXamlTypeByName("Object"));
                userType.Activator = Activate_8_UserTweetsViewModel;
                xamlType = userType;
                break;

            }
            return xamlType;
        }

        private global::System.Collections.Generic.List<global::Windows.UI.Xaml.Markup.IXamlMetadataProvider> _otherProviders;
        private global::System.Collections.Generic.List<global::Windows.UI.Xaml.Markup.IXamlMetadataProvider> OtherProviders
        {
            get
            {
                if(_otherProviders == null)
                {
                    _otherProviders = new global::System.Collections.Generic.List<global::Windows.UI.Xaml.Markup.IXamlMetadataProvider>();
                    global::Windows.UI.Xaml.Markup.IXamlMetadataProvider provider;
                    provider = new global::Callisto.Callisto_XamlTypeInfo.XamlMetaDataProvider() as global::Windows.UI.Xaml.Markup.IXamlMetadataProvider;
                    _otherProviders.Add(provider); 
                }
                return _otherProviders;
            }
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CheckOtherMetadataProvidersForName(string typeName)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType = null;
            foreach(global::Windows.UI.Xaml.Markup.IXamlMetadataProvider xmp in OtherProviders)
            {
                xamlType = xmp.GetXamlType(typeName);
                if(xamlType != null)
                {
                    return xamlType;
                }
            }
            return null;
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CheckOtherMetadataProvidersForType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType = null;
            foreach(global::Windows.UI.Xaml.Markup.IXamlMetadataProvider xmp in OtherProviders)
            {
                xamlType = xmp.GetXamlType(type);
                if(xamlType != null)
                {
                    return xamlType;
                }
            }
            return null;
        }

        private object get_0_Tilt_IsTiltEnabled(object instance)
        {
            return global::Callisto.Effects.Tilt.GetIsTiltEnabled((global::Windows.UI.Xaml.DependencyObject)instance);
        }
        private void set_0_Tilt_IsTiltEnabled(object instance, object Value)
        {
            global::Callisto.Effects.Tilt.SetIsTiltEnabled((global::Windows.UI.Xaml.DependencyObject)instance, (System.Boolean)Value);
                    }
        private object get_1_Tilt_SuppressTilt(object instance)
        {
            return global::Callisto.Effects.Tilt.GetSuppressTilt((global::Windows.UI.Xaml.DependencyObject)instance);
        }
        private void set_1_Tilt_SuppressTilt(object instance, object Value)
        {
            global::Callisto.Effects.Tilt.SetSuppressTilt((global::Windows.UI.Xaml.DependencyObject)instance, (System.Boolean)Value);
                    }
        private object get_2__TweetsPage_UserTweetsWidget(object instance)
        {
            var that = (global::App2._TweetsPage)instance;
            return that.UserTweetsWidget;
        }
        private void set_2__TweetsPage_UserTweetsWidget(object instance, object Value)
        {
            var that = (global::App2._TweetsPage)instance;
            that.UserTweetsWidget = (global::App2.ViewModels.UserTweetsViewModel)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::App2.App2_XamlTypeInfo.XamlMember xamlMember = null;
            global::App2.App2_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "Callisto.Effects.Tilt.IsTiltEnabled":
                userType = (global::App2.App2_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Callisto.Effects.Tilt");
                xamlMember = new global::App2.App2_XamlTypeInfo.XamlMember(this, "IsTiltEnabled", "Boolean");
                xamlMember.SetTargetTypeName("Windows.UI.Xaml.DependencyObject");
                xamlMember.SetIsDependencyProperty();
                xamlMember.SetIsAttachable();
                xamlMember.Getter = get_0_Tilt_IsTiltEnabled;
                xamlMember.Setter = set_0_Tilt_IsTiltEnabled;
                break;
            case "Callisto.Effects.Tilt.SuppressTilt":
                userType = (global::App2.App2_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Callisto.Effects.Tilt");
                xamlMember = new global::App2.App2_XamlTypeInfo.XamlMember(this, "SuppressTilt", "Boolean");
                xamlMember.SetTargetTypeName("Windows.UI.Xaml.DependencyObject");
                xamlMember.SetIsAttachable();
                xamlMember.Getter = get_1_Tilt_SuppressTilt;
                xamlMember.Setter = set_1_Tilt_SuppressTilt;
                break;
            case "App2._TweetsPage.UserTweetsWidget":
                userType = (global::App2.App2_XamlTypeInfo.XamlUserType)GetXamlTypeByName("App2._TweetsPage");
                xamlMember = new global::App2.App2_XamlTypeInfo.XamlMember(this, "UserTweetsWidget", "App2.ViewModels.UserTweetsViewModel");
                xamlMember.Getter = get_2__TweetsPage_UserTweetsWidget;
                xamlMember.Setter = set_2__TweetsPage_UserTweetsWidget;
                break;
            }
            return xamlMember;
        }

    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(global::System.String input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::App2.App2_XamlTypeInfo.XamlSystemBaseType
    {
        global::App2.App2_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::App2.App2_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public global::System.Object CreateFromString(global::System.String input)
        {
            if (_enumValues != null)
            {
                global::System.Int32 value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    global::System.Int32 enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( global::System.String.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::App2.App2_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::App2.App2_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(global::System.String targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}


