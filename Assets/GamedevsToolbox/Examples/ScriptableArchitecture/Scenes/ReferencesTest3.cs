﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GamedevsToolbox.ScriptableArchitecture.Values;

namespace GamedevsToolbox.Examples
{
    public class ReferencesTest3 : MonoBehaviour
    {
        [SerializeField]
        public ScriptableIntReference intVal;
        [SerializeField]
        public ScriptableFloatReference floatVal;

        private void Start()
        {
            Debug.Log(intVal.Value.ToString());
            Debug.Log(floatVal.Value.ToString());
        }
    }
}