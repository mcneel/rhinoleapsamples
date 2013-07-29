using System;
using Leap;
using Rhino;

namespace LeapSayHelloRhino
{ 
  class SimpleLeapListener : Listener 
  {
    private readonly Object m_lock = new Object();
    
    public bool ShouldLog { get; set; }

    private void RhinoWriteLine(String line)
    {
      if (ShouldLog)
      {
        lock (m_lock)
          RhinoApp.WriteLine(line);
      } 
    }

    public override void OnInit(Controller controller)
    {     
      RhinoWriteLine("Hello Rhino!");
    }

    public override void OnConnect(Controller controller)
    {   
      RhinoWriteLine("Connected to Leap Controller");
    }

    public override void OnDisconnect(Controller controller) 
    {
      RhinoWriteLine("Disconnected from Leap Controller");
    }
  
    public override void OnFrame(Controller controller)
    {    
      Frame frame = controller.Frame();

      if (!frame.Hands.Empty)     
      {   
        Hand hand = frame.Hands[0];
        
        FingerList fingers = hand.Fingers;
             
        if (!fingers.Empty)    
        {
          Vector avg_pos = Vector.Zero;
                  
          foreach (Finger finger in fingers)
            avg_pos += finger.TipPosition;
          
          avg_pos /= fingers.Count;

          RhinoWriteLine("Hand has " + fingers.Count + " fingers, average finger tip position: " + avg_pos);
        }
      }
 
    }  
  }
}