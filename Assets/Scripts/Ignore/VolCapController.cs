using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace F42
{
    public class VolCapController : MonoBehaviour
    {
        [SerializeField]
        HoloVideoObject _holoVideoObjectPrefab;

        [SerializeField]
        string _urlBase;

        [SerializeField]
        string[] _fileNames;

        [SerializeField]
        int _current = -1;

        [SerializeField]
        int _previous = -1;

        void Start()
        {
        }

        void Update()
        {
            if ((_current >= 0) && (_current >= 0))
            {

            }
        }
    }
}