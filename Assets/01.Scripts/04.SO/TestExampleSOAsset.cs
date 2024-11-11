using UnityEditor;
using UnityEngine;

public class TestExampleSOAsset : ScriptableObject
{
    [SerializeField]
    string str;
    [SerializeField, Range(0, 10)]
    int number;

    [MenuItem("SO Examples/Create TestExampleSOAsset Instance")]
    static void CreateExampleAssetInstance()
    {
        var exampleAsset = CreateInstance<TestExampleSOAsset>();

        AssetDatabase.CreateAsset(exampleAsset, "Assets/ExampleAsset.asset");
        AssetDatabase.Refresh();
    }

    [MenuItem("SO Examples/Load TestExampleSOAsset")]
    static void LoadExampleAsset()
    {
        var exampleAsset = AssetDatabase.LoadAssetAtPath<TestExampleSOAsset>("Assets/ExampleAsset.asset");
        Debug.Log(exampleAsset);
    }
}
