using UnityEngine;
using System.Reflection;


#if UNITY_EDITOR
using UnityEditor;
#endif

[DisallowMultipleComponent] // 중복 스크립트 Add 불가
public class TestScript : MonoBehaviour
{
    void OnEnable()
    {
#if UNITY_EDITOR
        var tex = EditorGUIUtility.Load("logo.png") as Texture;
        Debug.Log(tex.name);
#endif
    }

    // [InitializeOnLoadMethod]
    // static void GetBultinAssetNames()
    // {
    //     var flags = BindingFlags.Static | BindingFlags.NonPublic;
    //     var info = typeof(EditorGUIUtility).GetMethod("GetEditorAssetBundle", flags);
    //     var bundle = info.Invoke(null, new object[0]) as AssetBundle;
    //     foreach (var n in bundle.GetAllAssetNames())
    //     {
    //         Debug.Log(n);
    //     }
    // }
}