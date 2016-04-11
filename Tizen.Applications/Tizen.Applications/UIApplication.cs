// Copyright 2016 by Samsung Electronics, Inc.,
//
// This software is the confidential and proprietary information
// of Samsung Electronics, Inc. ("Confidential Information"). You
// shall not disclose such Confidential Information and shall use
// it only in accordance with the terms of the license agreement
// you entered into with Samsung.

using System;

namespace Tizen.Applications
{
    /// <summary>
    /// Represents an application that have UI screen. It has additional events for handling 'Resumed' and 'Paused' states.
    /// </summary>
    public class UIApplication : Application
    {
        /// <summary>
        /// Occurs whenever the application is resumed.
        /// </summary>
        public event EventHandler Resumed;

        /// <summary>
        /// Occurs whenever the application is paused.
        /// </summary>
        public event EventHandler Paused;

        /// <summary>
        /// Runs the UI application's main loop.
        /// </summary>
        /// <param name="args">Arguments from commandline.</param>
        public override void Run(string[] args)
        {
            base.Run(args);

            Interop.Application.UIAppLifecycleCallbacks ops;
            ops.OnCreate = (data) =>
            {
                SendCreate();
                return true;
            };
            ops.OnTerminate = (data) =>
            {
                OnTerminate();
            };
            ops.OnAppControl = (appControlHandle, data) =>
            {
                OnAppControlReceived(new AppControlReceivedEventArgs { ReceivedAppControl = new ReceivedAppControl(appControlHandle) });
            };
            ops.OnResume = (data) =>
            {
                OnResume();
            };
            ops.OnPause = (data) =>
            {
                OnPause();
            };

            TizenSynchronizationContext.Initialize();
            Interop.Application.Main(args.Length, args, ref ops, IntPtr.Zero);
        }

        /// <summary>
        /// Exits the main loop of the UI application. 
        /// </summary>
        public override void Exit()
        {
            Interop.Application.Exit();
        }

        /// <summary>
        /// Overrides this method if want to handle behavior when the application is resumed.
        /// If base.OnResume() is not called, the event 'Resumed' will not be emitted.
        /// </summary>
        protected virtual void OnResume()
        {
            EventHandler eh = Resumed;
            if (eh != null)
            {
                eh(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Overrides this method if want to handle behavior when the application is paused.
        /// If base.OnPause() is not called, the event 'Paused' will not be emitted.
        /// </summary>
        protected virtual void OnPause()
        {
            EventHandler eh = Paused;
            if (eh != null)
            {
                eh(this, EventArgs.Empty);
            }
        }
    }
}
