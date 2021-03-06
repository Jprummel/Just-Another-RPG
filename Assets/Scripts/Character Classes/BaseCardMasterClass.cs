﻿using UnityEngine;
using System.Collections;
[System.Serializable]
public class BaseCardMasterClass : BaseCharacterClass {

	public BaseCardMasterClass()
    {
        CharactersClassName          = "Card Master";
        CharactersClassDescription   = "A trickster who uses a magical deck of cards to buff his allies and destroy his enemies";
        MainStat        = MainStatBonuses.INTELLECT;
        SecondMainStat  = SecondStatBonuses.STRENGTH;
        BonusStat       = BonusStatBonuses.MASTERY;
        CharactersClass  = CharactersClasses.CARDMASTER;
    }
}
