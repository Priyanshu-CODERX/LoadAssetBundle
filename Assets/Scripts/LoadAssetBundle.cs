using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;

public class LoadAssetBundle : MonoBehaviour
{
   	public string bundleURL = "";
   	public string assetName = "";

   	IEnumerator Start()
   	{
        string url = bundleURL;
        var request
            = UnityEngine.Networking.UnityWebRequestAssetBundle.GetAssetBundle(url, 0);
        yield return request.SendWebRequest();
        AssetBundle bundle = UnityEngine.Networking.DownloadHandlerAssetBundle.GetContent(request);
        GameObject cube = bundle.LoadAsset<GameObject>(assetName);
        Instantiate(cube);
   	}
}
