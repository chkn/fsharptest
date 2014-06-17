namespace FsharpTest

open System
open MonoTouch.UIKit
open MonoTouch.Foundation

[<Register ("AppDelegate")>]
type AppDelegate () =
    inherit UIApplicationDelegate ()

    let mutable window = null
    override this.Window
        with get () = window
        and set value = window <- value

    // This method is invoked when the application is ready to run.
    override this.FinishedLaunching (app, options) =
        this.Window.MakeKeyAndVisible ()
        true

module Main =
    [<EntryPoint>]
    let main args =
        UIApplication.Main (args, null, "AppDelegate")
        0

