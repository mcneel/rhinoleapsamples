Rhino Leap Motion SDK Samples
=============================

This is a repo of sample projects using the Leap Motion device in Rhino.

Compiling the Source
--------------------
Prerequisites:

* Leap Motion Device (http://www.leapmotion.com/)
* The latest Rhino 5 (http://www.rhino3d.com/)
* Leap Motion SDK (http://www.leapmotion.com/developers)
* Visual Studio 2010 (or better) with C# (http://www.microsoft.com/visualstudio/eng)

Steps:

* Verify that you have all the above prerequisites.
* Get the source code here by downloading everything as a zip or using git to branch, clone, or fork.
* Open one of the sample project files and add references to the Leap SDK.  The crucial libraries are: LeapCSharp.NET4.0.dll, Leap.dll, and LeapCSharp.dll.  Make sure all these files are set to Copy always (File Properties > Copy to Output Directory).
* Build and run.  Load the sample plugin in Rhino (PlugInManager > Install > Navigate to sample .rhp file).  Run the sample command.

Legal Stuff
-----------

Copyright (c) 2013 Robert McNeel & Associates. All Rights Reserved.

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to use,
copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the
Software.

THIS SOFTWARE IS PROVIDED "AS IS" WITHOUT EXPRESS OR IMPLIED WARRANTY. ALL IMPLIED
WARRANTIES OF FITNESS FOR ANY PARTICULAR PURPOSE AND OF MERCHANTABILITY ARE HEREBY
DISCLAIMED.

Rhinoceros is a registered trademark of Robert McNeel & Associates.

Leap Motion is a trademark of Leap Motion, Inc.
