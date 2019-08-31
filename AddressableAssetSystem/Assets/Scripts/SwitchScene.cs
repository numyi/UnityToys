using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

public class SwitchScene : MonoBehaviour
{
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
    
    public void Switch()
    {
        Addressables.LoadSceneAsync("SampleScene2", UnityEngine.SceneManagement.LoadSceneMode.Single).Completed += OnSceneLoaded;
    }

    void OnSceneLoaded(AsyncOperationHandle<SceneInstance> obj)
    {
        Debug.Log($"SwitchScene SampleScene2");
    }
}
