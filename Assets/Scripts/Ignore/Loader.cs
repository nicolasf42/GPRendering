using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace F42
{
    public class Loader : MonoBehaviour
    {
        [SerializeField] AssetReferenceGameObject _ref1;
        [SerializeField] AssetReferenceGameObject _ref2;

        private void Start()
        {
            LoadAndInstantiate(_ref1);
            LoadAndInstantiate(_ref2);
        }

        void LoadAndInstantiate(AssetReferenceGameObject reference)
        {
            reference.LoadAssetAsync<GameObject>().Completed += FinishByInstantiate;
        }

        void FinishByInstantiate(AsyncOperationHandle<GameObject> go)
        {
            GameObject.Instantiate(go.Result);
        }
    }
}