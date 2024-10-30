using UnityEngine;

[ExecuteInEditMode]
public class ExecuteEditMode : MonoBehaviour
{
    [Range(0, 10)]
    public int number;

    void Awake()
    {
        Debug.Log("ExecuteEditMode Awake");
    }
    void Start()
    {
        Debug.Log("ExecuteEditMode Start");
    }
    void Update()
    {
        Debug.Log("ExecuteEditMode Update");
    }
}