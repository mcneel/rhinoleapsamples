using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rhino.PlugIns;


// Plug-in Description Attributes - all of these are optional
// These will show in Rhino's option dialog, in the tab Plug-ins
[assembly: PlugInDescription(DescriptionType.Address, "3670 Woodland Park Ave N, Seattle, WA")]
[assembly: PlugInDescription(DescriptionType.Country, "USA")]
[assembly: PlugInDescription(DescriptionType.Email, "dan@mcneel.com")]
[assembly: PlugInDescription(DescriptionType.Phone, "(206) 545-7000")]
[assembly: PlugInDescription(DescriptionType.Fax, "(206) 545-7321")]
[assembly: PlugInDescription(DescriptionType.Organization, "Robert McNeel and Associates")]
[assembly: PlugInDescription(DescriptionType.UpdateUrl, "-")]
[assembly: PlugInDescription(DescriptionType.WebSite, "http://www.rhino3d.com")]


// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("LeapSayHelloRhino")] // Plug-In title is extracted from this
[assembly: AssemblyDescription("A simple example of using Leap Motion device in Rhino")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Robert McNeel and Associates")]
[assembly: AssemblyProduct("LeapSayHelloRhino")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("fa2f9a64-a265-4c64-b4bd-2776c0ed3278")] // This will also be the Guid of the Rhino plug-in

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
