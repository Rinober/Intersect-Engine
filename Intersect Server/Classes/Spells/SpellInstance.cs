﻿/*
    Intersect Game Engine (Server)
    Copyright (C) 2015  JC Snider, Joe Bridges
 
    Website: http://ascensiongamedev.com
    Contact Email: admin@ascensiongamedev.com 

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program; if not, write to the Free Software Foundation, Inc.,
    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intersect_Server.Classes
{
    public class SpellInstance
    {
        public int SpellNum = -1;
        public long SpellCD = 0;

        public SpellInstance()
        {
        }

        public SpellInstance(int num)
        {
            SpellNum = num;
        }

        public SpellInstance Clone()
        {
            SpellInstance newSpell = new SpellInstance();
            newSpell.SpellNum = SpellNum;
            newSpell.SpellCD = SpellCD;
            return newSpell;
        }
        public void Load(ByteBuffer bf)
        {
            SpellNum = bf.ReadInteger();
            SpellCD = bf.ReadLong();
        }
        public byte[] Data()
        {
            var bf = new ByteBuffer();
            bf.WriteInteger(SpellNum);
            bf.WriteLong(SpellCD);
            return bf.ToArray();
        }
    }
}