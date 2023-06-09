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
    public class UbParam
    {
        public enum ParamType
        {
            Parameter,
            Property
        }
        public int id { get; set; }
        public string name { get; set; }
        public ParamType paramType { get; set; }
        public Parameter parameter { get; set; }

        public UbParam()
        {
            this.id = 0;
            this.name = string.Empty;
            this.paramType = ParamType.Parameter;
            this.parameter = null;
        }

        public UbParam(int id, string name, ParamType paramType, Parameter param)
        {
            this.id = id;
            this.name = name;
            this.paramType = paramType;
            this.parameter = param;
        }

        public Element GetElement()
        {
            return this.parameter.Element;
        }
    }
}
