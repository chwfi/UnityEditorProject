using UnityEngine;

public class ChildSOScript : ScriptableObject
{
    [SerializeField]
    string str;
    
    void OnEnable()
    {
        name = "New ChildSOScript";
        Debug.Log(name);
    }
}
