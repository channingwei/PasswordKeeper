﻿using System;
using UIKit;
using iOS.Corelib.Utils;

namespace RekTec.App.Std
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main (string [] args)
		{
			try {
				UIApplication.Main (args, null, "AppDelegate");
			} catch (Exception ex) {
				LoggingUtil.Exception (ex);
			}
		}
	}
}
