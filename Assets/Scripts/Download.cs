using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
public class Download : MonoBehaviour
{
    private GameObject _myPrefab;
    IEnumerator Start()
    {
        string url = "https://s3-us-west-2.amazonaws.com/aquabuckettest/personaje";
        using (var uwr = new UnityWebRequest(url, UnityWebRequest.kHttpVerbGET))
        {
            uwr.downloadHandler = new DownloadHandlerAssetBundle(url, 0);
            yield return uwr.Send();
            AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(uwr);
//            _myPrefab = bundle.LoadAsset("SombrerinTPose") as GameObject;
//            _myPrefab.transform.position = new Vector3(100, 100, 100);
//			Instantiate(_myPrefab);
        }
    }
}