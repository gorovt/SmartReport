﻿/*   SmartReport License
*******************************************************************************
*                                                                             *
*    Copyright (c) 2023 Luciano Gorosito <lucianogorosito@hotmail.com>        *
*                                                                             *
*    This file is part of SmartReport                                         *
*                                                                             *
*    SamrtReport is free software: you can redistribute it and/or modify      *
*    it under the terms of the GNU General Public License as published by     *
*    the Free Software Foundation, either version 3 of the License, or        *
*    (at your option) any later version.                                      *
*                                                                             *
*    SmartReport is distributed in the hope that it will be useful,           *
*    but WITHOUT ANY WARRANTY; without even the implied warranty of           *
*    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the            *
*    GNU General Public License for more details.                             *
*                                                                             *
*    You should have received a copy of the GNU General Public License        *
*    along with this program.  If not, see <https://www.gnu.org/licenses/>.   *
*                                                                             *
*******************************************************************************
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;

namespace SmartReport
{
    public class TreeItem
    {
        public string name { get; set; }
        public string text { get; set; }
        public string parentName { get; set; }
        public List<Element> elements { get; set; }

        public TreeItem()
        {
            this.name = string.Empty;
            this.text = string.Empty;
            this.parentName = string.Empty;
            this.elements = new List<Element>();
        }

        public TreeItem(string name, string text, string parentName)
        {
            this.name = name;
            this.text = text;
            this.parentName = parentName;
            this.elements = new List<Element>();
        }

    }
}
