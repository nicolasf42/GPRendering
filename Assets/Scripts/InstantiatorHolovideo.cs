using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace F42
{
    public class InstantiatorHolovideo : Instantiator
    {
        [SerializeField]
        protected HoloVideoObject _prefab;

        [SerializeField]
        string _url;

        HoloVideoObject _instance;

        //----

        protected override void Instantiate()
        {
            _instance = GameObject.Instantiate(_prefab, transform);
            _instance.Url = _url;
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