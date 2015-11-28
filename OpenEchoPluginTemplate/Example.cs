/*
    OpenEcho is a program to automate basic tasks at home all while being handsfree.
    Copyright (C) 2015 Gregory Morgan

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Xml;
using System.Collections.Generic;
using PluginContracts;

namespace OpenEchoPluginTemplate
{
    public class Example : IPlugin
    {
        public string Name
        {
            get
            {
                return "Plugin Name";
            }
        }

        public List<string> Actions
        {
            get
            {
                List<string> actions = new List<string>();
                actions.Add("trigger phrases");
                actions.Add("trigger words");
                return actions;
            }
        }


        public string Go(string input)
        {
            return "string to be returned.";
 
        }
    }
}