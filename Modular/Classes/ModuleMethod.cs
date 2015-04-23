﻿/*
    The MIT License (MIT)

    Copyright (c) 2015  The Modular Project (https://bitbucket.org/juanshaf/modular)

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modular
{
    public class ModuleMethod
    {
        /// <summary>
        /// The identifier used when calling the method using the RunMethod function in the module host.
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// Usage details explaining how to use this method, eg. if the method accepts a Json encoded Dictionary or some other string encoded object, explain this here.
        /// </summary>
        public readonly string Usage;


        public ModuleMethod(string name, string usage)
        {
            this.Name = name;
            this.Usage = usage;
        }

        public override bool Equals(object obj)
        {
            ModuleMethod other = obj as ModuleMethod;

            if (other != null && other.Name.Equals(this.Name, StringComparison.InvariantCultureIgnoreCase))
                return true;

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
