﻿using UnityEngine;
using System.Collections;

public class LevelUp {

    private int _maxPlayerLevel = 50;

    public void LevelUpCharacter()
    {
        //Check to see if current xp is greater then required
        if (GameInformation.CurrentXP > GameInformation.RequiredXP)
        {
            GameInformation.CurrentXP -= GameInformation.RequiredXP;
        }
        else
        {
            GameInformation.CurrentXP = 0;
        }

        if (GameInformation.PlayerLevel < _maxPlayerLevel)
        {
            GameInformation.PlayerLevel += 1;
        }
        else
        {
            GameInformation.PlayerLevel = _maxPlayerLevel;
        }
        //Give player stat points
        //randomly give items
        //give them a skill/move
        //give money
        //determine next amount of required xp
        DetermineRequiredXP();
    }

    private void DetermineRequiredXP()
    {
        int temp = (GameInformation.PlayerLevel * 1000) + 250;
        GameInformation.RequiredXP = temp;
    }

    private void DetermineMoneyToGive()
    {
        if (GameInformation.PlayerLevel <= 10)
        {
            //give a certain amount of money
        }
    }

}
