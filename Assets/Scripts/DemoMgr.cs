using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class DemoMgr : MonoBehaviour
{
    public AssetReference LocalNo;
    // Start is called before the first frame update
    void Start()
    {
        DisplayNo();
    }

    private void DisplayNo()
    {
        LocalNo.InstantiateAsync(Vector3.zero,Quaternion.identity);
    }
}
