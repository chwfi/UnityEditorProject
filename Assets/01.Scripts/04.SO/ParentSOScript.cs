using System.IO;
using UnityEditor;
using UnityEngine;

public class ParentSOScript : ScriptableObject
{
    const string PATH = "Assets/01.Scripts/New ParentSOScript.asset";

    [SerializeField] ChildSOScript child1;

    [MenuItem("Example/Create ParentSOAsset")]
    static void CreateScriptableObject()
    {
        // 부모를 인스턴스화
        var parent = ScriptableObject.CreateInstance<ParentSOScript>();

        AssetDatabase.CreateAsset(parent, PATH);

        var childInst = ScriptableObject.CreateInstance<ChildSOScript>();
        parent.child1 = childInst;

        // 부모를 애샛으로 하여 저장
        AssetDatabase.AddObjectToAsset(childInst, PATH);

        // 변경사항 저장
        AssetDatabase.SaveAssets();
    }
}
