using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
public class Download : MonoBehaviour
{
    private GameObject _myPrefab;
    IEnumerator Start()
    {
        string url = "https://s3-us-west-2.amazonaws.com/aquabuckettest/auto.1";
        using (var uwr = new UnityWebRequest(url, UnityWebRequest.kHttpVerbGET))
        {
            uwr.downloadHandler = new DownloadHandlerAssetBundle(url, 0);
            yield return uwr.Send();
            AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(uwr);
            _myPrefab = bundle.LoadAsset("Car") as GameObject;
            _myPrefab.transform.position = new Vector3(10, 1, 10);
			Instantiate(_myPrefab);
        }
    }
}