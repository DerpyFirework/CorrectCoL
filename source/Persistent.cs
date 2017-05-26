﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

using KSP.UI.Screens;
using KSP.UI.Dialogs;
using KSPAchievements;
using System.Reflection;

//using System.Diagnostics;
using Upgradeables;

#if true
namespace CorrectCoL
{
    [KSPScenario(ScenarioCreationOptions.AddToAllGames, new GameScenes[] {
        GameScenes.SPACECENTER,
        GameScenes.EDITOR,
        GameScenes.FLIGHT,
        GameScenes.TRACKSTATION,
        GameScenes.SPACECENTER
     })]
    public class CorrectCoL_Persistent : ScenarioModule
    {
        static public CorrectCoL_Persistent Instance;        

        [KSPField(isPersistant = true)]
        public string lastSelectedPlanet = "";

        override public void OnAwake()
        {
            Instance = this;
        }

        void Start()
        {
            Debug.Log("CorrectCoL_Persistent.Start");
            if (HighLogic.CurrentGame.Parameters.CustomParams<CCOLParams>().useLastPlanet)
            if (lastSelectedPlanet != "")
                PlanetSelection.setSelectedBody(lastSelectedPlanet);
        }

    }
}

#endif