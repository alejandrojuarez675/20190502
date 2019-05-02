using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BundlesBuilder : Editor
{
    [MenuItem("Assets/Build AssetBundles")]
    static void BuildAssetBundle()
    {
        BuildPipeline.BuildAssetBundles(
            @"C:\Users\usuario\Desktop",
            BuildAssetBundleOptions.ChunkBasedCompression,
            BuildTarget.StandaloneWindows64);
    } 
}