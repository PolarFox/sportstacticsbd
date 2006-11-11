// Sports Tactics Board
//
// http://sportstacticsbd.sourceforge.net/
// http://sourceforge.net/projects/sportstacticsbd/
// 
// Sports Tactics Board is a utility that allows coaches, trainers and 
// officials to describe sports tactics, strategies and positioning using 
// a magnetic or chalk-board style approach.
// 
// Copyright (C) 2006 Robert Turner
// 
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License along
// with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
//
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace SportsTacticsBoard
{
  public class FieldObjectLayout
  {
    public class Entry 
    {
      public PointF pos;
      public string tag;
    }

    public List<Entry> entries;

    public FieldObjectLayout()
    {
      entries = new List<Entry>();
    }

    public Entry GetEntry(string tag)
    {
      return entries.Find(delegate(Entry entry) { return (entry.tag == tag); });
    }

    public void RemoveEntry(string tag)
    {
      entries.Remove(entries.Find(delegate(Entry entry) { return (entry.tag == tag); }));
    }
  }
}
