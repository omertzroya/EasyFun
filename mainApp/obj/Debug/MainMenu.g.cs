﻿

#pragma checksum "F:\Users\tomer\Documents\Visual Studio 2013\Projects\issieApp\mainApp\mainApp\MainMenu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "880D54761D619510BCEAE675585B15B6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mainApp
{
    partial class MainMenu : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 14 "..\..\MainMenu.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.Simon_OnTapped;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 22 "..\..\MainMenu.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.Balloons_OnTapped;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 30 "..\..\MainMenu.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.Play_OnTapped;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

