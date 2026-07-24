using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class CrearAsset : MonoBehaviour
{
    [SerializeField] AssetReferenceGameObject assetACrear;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            assetACrear.InstantiateAsync();
        }
    }
}
