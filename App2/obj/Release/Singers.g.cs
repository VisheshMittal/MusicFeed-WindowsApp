﻿

#pragma checksum "C:\Users\v!shu\Documents\Visual Studio 2012\Projects\App2\App2\Singers.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FA1F55A181AFDB4B2C838F821401D226"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App2
{
    partial class Singers : global::App2.Common.LayoutAwarePage, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 42 "..\..\Singers.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.singer_Tap;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 57 "..\..\Singers.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.singer_Tap;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 67 "..\..\Singers.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.GoBack;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

