// <autogenerated />
// Xaml Source Generation is using the System Xaml Parser
#pragma warning disable 618 // Ignore obsolete members warnings
#pragma warning disable 105 // Ignore duplicate namespaces
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Uno.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Text;
using Uno.Extensions;
using Uno;
using CommandBarStyleRepro.Droid;

#if __ANDROID__
using _View = Android.Views.View;
#elif __IOS__
using _View = UIKit.UIView;
#elif __MACOS__
using _View = AppKit.NSView;
#elif __WASM__
using _View = Windows.UI.Xaml.UIElement;
#elif NET46
using _View = Windows.UI.Xaml.UIElement;
#endif

namespace CommandBarStyleRepro
{
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0056", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0058", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV1003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0085", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2001", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2004", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2005", Justification="Generated code")]
	public sealed partial class MainPage : Windows.UI.Xaml.Controls.Page
	{
		private void InitializeComponent()
		{
			var nameScope = new global::Windows.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			// Source ..\..\..\..\..\..\..\CommandBarStyleRepro.Shared\MainPage.xaml (Line 1:2)
			Content = 			new global::Windows.UI.Xaml.Controls.Grid
			{
				// Source ..\..\..\..\..\..\..\CommandBarStyleRepro.Shared\MainPage.xaml (Line 10:6)
				Children = 
				{
					new global::Windows.UI.Xaml.Controls.CommandBar
					{
						Content = @"Here Be Content",
						// Source ..\..\..\..\..\..\..\CommandBarStyleRepro.Shared\MainPage.xaml (Line 11:10)
					}
					,
				}
			}
			.MainPage_77aad2f3de5984a2ebbe868c75da0f83_XamlApply((MainPage_77aad2f3de5984a2ebbe868c75da0f83XamlApplyExtensions.XamlApplyHandler1)(c1 => 
			{
				c1.Background = ((Windows.UI.Xaml.Media.Brush)global::Uno.UI.GlobalStaticResources.ApplicationPageBackgroundThemeBrush);
				
			}
			))
			;
			
			this
			.Apply((c2 => 
			{
				// Source C:\Users\pdeco\source\repos\CommandBarStyleRepro\CommandBarStyleRepro\CommandBarStyleRepro.Shared\MainPage.xaml (Line 1:2)
			}
			))
			.Apply((c3 => 
			{
				// Class CommandBarStyleRepro.MainPage
			}
			))
			;
			OnInitializeCompleted();
			InitializeXamlOwner();
		}
		partial void OnInitializeCompleted();
		class StaticResources
		{
		}
		private void InitializeXamlOwner()
		{
		}
	}
}
namespace CommandBarStyleRepro.Droid
{
	static class MainPage_77aad2f3de5984a2ebbe868c75da0f83XamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.CommandBar instance);
		public static global::Windows.UI.Xaml.Controls.CommandBar MainPage_77aad2f3de5984a2ebbe868c75da0f83_XamlApply(this global::Windows.UI.Xaml.Controls.CommandBar instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Windows.UI.Xaml.Controls.Grid instance);
		public static global::Windows.UI.Xaml.Controls.Grid MainPage_77aad2f3de5984a2ebbe868c75da0f83_XamlApply(this global::Windows.UI.Xaml.Controls.Grid instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
	}
}