using UnityEditor;
using UnityEngine;

public class CustomEditorSettings
{
    [InitializeOnLoadMethod]
    static void LoadSettings()
    {
        // 에디터가 시작될 때 설정 파일을 불러옴
        string savedSetting = EditorPrefs.GetString("CustomSettingKey", "기본값");
        Debug.Log($"불러온 설정 값: {savedSetting}");
    }
}