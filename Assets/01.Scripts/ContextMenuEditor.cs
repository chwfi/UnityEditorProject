using UnityEngine;

public class ContextMenuEditor : MonoBehaviour
{
    [Range(0, 10)]
    public int number;

    [ContextMenu("RandomNumber")] // 스크립트 전체를 대상으로 Edit 가능하게 만들어주는 기능
    void RandomNumber()
    {
        number = Random.Range(0, 10);
    }

    [ContextMenu("ResetNumber")]
    void ResetNumber()
    {
        number = 0;
    }
}