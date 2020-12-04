using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace F42
{
    public class InstantiatorAddressable : Instantiator
    {
        [SerializeField] AssetReferenceGameObject _reference;

        GameObject _instance;

        protected override void Instantiate()
        {
            _reference.LoadAssetAsync<GameObject>().Completed += FinishByInstantiate;
        }

        void FinishByInstantiate(AsyncOperationHandle<GameObject> go)
        {
            _instance = GameObject.Instantiate(go.Result, transform);
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
