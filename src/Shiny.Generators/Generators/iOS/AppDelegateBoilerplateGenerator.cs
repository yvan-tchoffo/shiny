﻿using System;
using Uno.SourceGeneration;


namespace Shiny.Generators.Generators.iOS
{
    public static class AppDelegateBoilerplateGenerator
    {
        public static void Execute(SourceGeneratorContext context)
        {
            // if application exists, error or override? - could also search for attribute?
            var appDelegateClass = context.Compilation.GetTypeByMetadataName("UIKit.UIApplicationDelegate");
            if (appDelegateClass == null)
                return;

            // find 
        }
    }
}
//public override bool FinishedLaunching(UIApplication app, NSDictionary options)
//{
//    // this needs to be loaded before EVERYTHING
//    this.ShinyFinishedLaunching(new SampleStartup());
//    return base.FinishedLaunching(app, options);
//}


//public override void ReceivedRemoteNotification(UIApplication application, NSDictionary userInfo)
//    => this.ShinyDidReceiveRemoteNotification(userInfo, null);

//public override void DidReceiveRemoteNotification(UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler)
//    => this.ShinyDidReceiveRemoteNotification(userInfo, completionHandler);

//public override void RegisteredForRemoteNotifications(UIApplication application, NSData deviceToken)
//    => this.ShinyRegisteredForRemoteNotifications(deviceToken);

//public override void FailedToRegisterForRemoteNotifications(UIApplication application, NSError error)
//    => this.ShinyFailedToRegisterForRemoteNotifications(error);

//public override void PerformFetch(UIApplication application, Action<UIBackgroundFetchResult> completionHandler)
//    => this.ShinyPerformFetch(completionHandler);

//public override void HandleEventsForBackgroundUrl(UIApplication application, string sessionIdentifier, Action completionHandler)
//    => this.ShinyHandleEventsForBackgroundUrl(sessionIdentifier, completionHandler);