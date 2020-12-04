using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace F42
{
    public abstract class Instantiator : MonoBehaviour
    {
        [SerializeField]
        float _scale = 1.0f;

        //----

        //unlikely value to force at least one RescaleInstanceIfNeeded
        float _currentScale = -1000.0f;

        Vector3 _rescaleVector = new Vector3();

        //----

        private void Start()
        {
            Instantiate();
        }

        private void Update()
        {
            RescaleInstanceIfNeeded();
        }

        void RescaleInstanceIfNeeded()
        {
            if (_scale != _currentScale)
            {
                if (InstanceTransform() != null)
                {
                    _rescaleVector[0] = _scale;
                    _rescaleVector[1] = _scale;
                    _rescaleVector[2] = _scale;

                    InstanceTransform().localScale = _rescaleVector;
                    _currentScale = _scale;
                }
            }
        }

        protected abstract void Instantiate();
        protected abstract Transform InstanceTransform();
    }
}