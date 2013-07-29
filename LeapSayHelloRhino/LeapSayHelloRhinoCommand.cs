using Rhino;
using Rhino.Commands;
using Leap;
using Rhino.Input;

namespace LeapSayHelloRhino
{
  [System.Runtime.InteropServices.Guid("58495a90-f621-4dfe-8630-4c60791aca03")]
    
  public class LeapSayHelloRhinoCommand : Command
  {

    private SimpleLeapListener LeapListener { get; set; }
    private Controller LeapController { get; set; } 

    public LeapSayHelloRhinoCommand()
    {
      // Rhino only creates one instance of each command class defined in a
      // plug-in, so it is safe to store a refence in a static property.
      LeapListener = new SimpleLeapListener();
      LeapController = new Controller();
      Instance = this;
    }
     
    ///<summary>The only instance of this command.</summary>
    public static LeapSayHelloRhinoCommand Instance
    { 
      get;
      private set;
    }

    ///<returns>The command name as it appears on the Rhino command line.</returns>
    public override string EnglishName { get { return "LeapSayHelloRhino"; } }
    
    /// <summary>
    /// This extremely simple demo logs some Leap info to the Rhino command line
    /// from a background thread.  Note that the listener is not being removed from
    /// the controller.
    /// </summary>
    protected override Result RunCommand(RhinoDoc doc, RunMode mode)
    {
      RhinoApp.WriteLine("Started listening to Leap...");   
      LeapListener.ShouldLog = true;
      LeapController.AddListener(LeapListener);

      bool user_response = false;   
      var rc = RhinoGet.GetBool("Stop logging from Leap?", false, "Yes", "No", ref user_response);
      LeapListener.ShouldLog = user_response;

      return Result.Success;
    }

  }
}
