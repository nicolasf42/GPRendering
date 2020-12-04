﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace F42
{
    public class InstantiatorInsideProjectPrefab : Instantiator
    {
        [SerializeField]
        protected GameObject _prefab;

        GameObject _instance;

        //----

        protected override void Instantiate()
        {
            _instance = GameObject.Instantiate(_prefab, this.transform);
        }

        protected override Transform InstanceTransform()
        {
            if (_instance != null)
            {
                return _instance.transform;
            }

            return null;
        }
    }
}