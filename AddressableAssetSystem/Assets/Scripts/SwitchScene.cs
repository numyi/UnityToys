using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public void Switch()
    {
        Addressables.LoadSceneAsync("SampleScene2", LoadSceneMode.Single).Completed += OnSceneLoaded;
    }

    void OnSceneLoaded(AsyncOperationHandle<SceneInstance> obj)
    {
        Debug.Log($"SwitchScene SampleScene2");
    }
}
