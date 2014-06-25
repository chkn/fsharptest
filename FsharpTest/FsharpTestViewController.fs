namespace FsharpTest

open System
open System.Drawing

open MonoTouch.UIKit
open MonoTouch.Foundation

[<Register ("FsharpTestViewController")>]
type FsharpTestViewController =
    inherit UIViewController

    new ()  = { inherit UIViewController() } 
    new (handle:nativeint) = { inherit UIViewController(handle) }

// Pretend the above decl was created more like:
// type FsharpTestViewController = designable<"UIViewController">

type FsharpTestViewController with

    // Perform any additional setup after loading the view, typically from a nib.
    override this.ViewDidLoad () =
        Console.WriteLine ("hi!")
 
    // Return true for supported orientations
    override this.ShouldAutorotateToInterfaceOrientation (orientation) =
        orientation <> UIInterfaceOrientation.PortraitUpsideDown

 