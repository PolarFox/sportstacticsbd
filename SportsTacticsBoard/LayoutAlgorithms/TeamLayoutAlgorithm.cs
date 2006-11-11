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

namespace SportsTacticsBoard.LayoutAlgorithms
{
  abstract public class TeamLayoutAlgorithm : ILayoutAlgorithm
  {
    private IFieldType fieldType;

    public TeamLayoutAlgorithm(IFieldType _fieldType)
    {
      fieldType = _fieldType;
    }

    private List<FieldObjects.Player> GetTeam(List<FieldObject> fieldObjects, FieldObjects.Player.TeamId team)
    {
      List<FieldObjects.Player> players = new List<FieldObjects.Player>();
      foreach (FieldObject fo in fieldObjects)
      {
        if (fo.GetType() == typeof(FieldObjects.Player))
        {
          FieldObjects.Player p = (FieldObjects.Player)fo;
          if (p.Team == team)
          {
            players.Add(p);
          }
        }
      }
      return players;
    }

    public FieldObjectLayout GetLayout(IFieldType fieldType)
    {
      FieldObjectLayout layout = new FieldObjectLayout();
      AppendPlayerPositions(layout, fieldType.GetTeam(FieldObjects.Player.TeamId.Attacking), true);
      AppendPlayerPositions(layout, fieldType.GetTeam(FieldObjects.Player.TeamId.Defending), false);
      return layout;
    }

    public abstract List<string> SupportedFieldTypes { get; }

    protected abstract void AppendPlayerPositions(FieldObjectLayout layout, List<string> playersToPosition, bool putOnLeftSide);

    protected float FieldLength
    {
      get { return fieldType.FieldLength; }
    }

    protected float FieldWidth
    {
      get { return fieldType.FieldWidth; }
    }

    protected float FlipSide(float pos, bool putOnLeftSize)
    {
      if (putOnLeftSize) {
        return pos;
      } else {
        return FieldLength - pos;
      }
    }

    protected FieldObjects.Player GetPlayer(List<FieldObjects.Player> players, int number)
    {
      return players.Find(delegate(FieldObjects.Player p) { return (p.Number == number); });
    }
  }
}
