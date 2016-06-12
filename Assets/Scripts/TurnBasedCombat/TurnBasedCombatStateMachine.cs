﻿using UnityEngine;
using System.Collections;

public class TurnBasedCombatStateMachine : MonoBehaviour {

    private bool _hasAddedXP;

    public enum BattleStates
    {
        START,
        PLAYERCHOICE,
        //PlayerAnimate
        ENEMYCHOICE,
        LOSE,
        WIN
    }

    private BattleStates currentState;

	void Start () {
        currentState = BattleStates.START;
        _hasAddedXP = false;
	}

	// Update is called once per frame
	void Update () {

        Debug.Log(currentState);

        switch (currentState)
        {
            case (BattleStates.START):
                 //Setup Battle Function
                 break;
            case (BattleStates.PLAYERCHOICE):
                
                break;
            case (BattleStates.ENEMYCHOICE):
                
                break;
            case (BattleStates.LOSE):
                
                break;
            case (BattleStates.WIN):
                if (!_hasAddedXP)
                {
                    IncreaseExperience.AddExperience();
                    _hasAddedXP = true;
                }
                break;
        }
	}

    void OnGUI()
    {
        if (GUILayout.Button("NEXT STATE"))
        {
            if (currentState == BattleStates.START)
            {
                currentState = BattleStates.PLAYERCHOICE;
            }else if (currentState == BattleStates.PLAYERCHOICE)
            {
                currentState = BattleStates.ENEMYCHOICE;
            }else if (currentState == BattleStates.ENEMYCHOICE)
            {
                currentState = BattleStates.LOSE;
            }else if (currentState == BattleStates.LOSE)
            {
                currentState = BattleStates.WIN;
            }else if (currentState == BattleStates.WIN)
            {
                currentState = BattleStates.START;
            }
        }
    }
}
