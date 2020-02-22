﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandPattern
{
    public virtual void executeAction()
    {
    }
}

public class MoveUnitCommand : CommandPattern
{
    public int x, y;
    public int undoX, undoY;
    public Unit unit = null;

    public MoveUnitCommand(Unit _unit, int _x, int _y)
    {
        x = _x;
        y = _y;

        unit = _unit;
    }

    public override void executeAction()
    {
        
        undoX = unit.posX;
        undoY = unit.posY;
        unit.MoveTo(x, y);
    }
}
