using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace TeamDigitalJB.Properties
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
	internal class Resources
	{
		private static ResourceManager resourceMan;

		private static CultureInfo resourceCulture;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("TeamDigitalJB.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		internal static Bitmap about
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("about", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap azure
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("azure", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap cert
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("cert", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap cert2
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("cert2", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap dashboards
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("dashboards", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap downloads
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("downloads", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap hover
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("hover", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap log
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("log", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap microsoft
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("microsoft", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap nsg
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("nsg", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap offline
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("offline", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap rdp
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("rdp", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap script
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("script", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap security
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("security", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap serverup
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("serverup", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap service
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("service", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap services
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("services", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap sql
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("sql", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap team
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("team", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal Resources()
		{
		}
	}
}
