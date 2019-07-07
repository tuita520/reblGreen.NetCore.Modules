﻿/*
    The MIT License (MIT)

    Copyright (c) 2019 reblGreen Software Ltd. (https://reblgreen.com/)
    Repository Url: https://bitbucket.org/reblgreen/reblgreen.netcore.modules/

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in
    all copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
    THE SOFTWARE.
 */

namespace reblGreen.NetCore.Modules.Interfaces
{
    /// <summary>
    /// An interface which allows you to inspect an instance of IEvent before it starts processing.
    /// </summary>
    public interface IEventPreHandler<E> : IEventPreHandler
        where E : IEvent
    {
        ///// <summary>
        ///// This should be invoked by IModuleHost before its implementing IEventHandler handles an IEvent.
        ///// </summary>
        ///// <param name="e"></param>
        //void OnBeforeHandle(IEvent e);
    }

    /// <summary>
    /// This interface should be used with a generic type argument which tells the module system what type of event you wish to monitor
    /// for pre-handle. Implementing this interface will not function correctly without a generic identifier.
    /// </summary>
    public interface IEventPreHandler
    {
        /// <summary>
        /// This should be invoked by IModuleHost before its implementing IEventHandler handles an IEvent.
        /// </summary>
        /// <param name="e"></param>
        void OnBeforeHandle(IEvent e);
    }
}
