﻿using UnityEngine;
using System.Collections;

public class BaseOgreRace : BaseCharacterRace {
 
    public BaseOgreRace()
    {
        new BaseCharacterRace();
        RaceName            = "Ogre";
        RaceDescription     = "";
        HasStrengthBonus    = true;
        HasSpiritBonus      = true;
        HasLuckBonus        = true;
    }
}