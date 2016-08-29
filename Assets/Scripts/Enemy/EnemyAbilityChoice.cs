﻿using UnityEngine;
using System.Collections;

public class EnemyAbilityChoice : MonoBehaviour {

    private int     _totalPlayerHealth;
    private int   _playerHealthPercentage;
    private BaseAbility _chosenAbility;


    public BaseAbility ChooseEnemyAbility()
    {
        _totalPlayerHealth = GameInformation.PlayerHealth;
        _playerHealthPercentage = (_totalPlayerHealth /100) * 100;

        if (_playerHealthPercentage >= 75)
        {
            return _chosenAbility = ChooseAbilityAtSeventyFivePercent();
        }
        else if (_playerHealthPercentage < 75 && _playerHealthPercentage >= 30)
        {
            return _chosenAbility = new SwordSlash();
        }
        else if (_playerHealthPercentage < 30 && _playerHealthPercentage >= 1)
        {
            return _chosenAbility = new SwordSlash();
        }
        return _chosenAbility = new AttackAbility();
    }

    private BaseAbility ChooseAbilityAtSeventyFivePercent()
    {
        //Can also check for stats or other things to decide on abilities
        return _chosenAbility = new SwordSlash();
    }
}