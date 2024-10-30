using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class FormerlySerializedAs : MonoBehaviour
{
    // 최초에는 playerHealth 변수명으로 지정하고 값을 세팅
    // [SerializeField]
    // int playerHealth; 기존값은 제거

    // 변수 이름을 바꿔도 값을 유지시키는 기법 !

    // 기존 변수 이름
    [FormerlySerializedAs("playerHealth")]
    public int health;

    // 새 변수 이름
    public string playerName;

    void Start()
    {
        Debug.Log($"Player Health: {health}, Player Name: {playerName}");
    }

    // 예를 들어 이미 어딘가에 저장된 데이터를 이름만 혹은 자료형만 바꾸고 싶을 때 사용하면 유용
}
