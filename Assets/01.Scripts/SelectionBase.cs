using UnityEngine;

// 이 스크립트가 들어있는 컴포넌트는, 이것의 부모 오브젝트를 클릭했을 때 바로 이 자식 오브젝트가 선택된다.
// Non - first object selection
// 근데 버그로 인해 유니티 구버전에서만 작동한다.
[SelectionBaseAttribute]
public class TestSectionBase : MonoBehaviour 
{
    private void Start()
    {
        Debug.Log("이 오브젝트가 베이스이다!");
    }
}