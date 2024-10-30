using System;
using UnityEngine;

[RequireComponent(typeof(Animator))] // 이 컴포넌트가 반드시 포함된다.
public class BasicInspectorEditor : MonoBehaviour
{
    Animator _animator;
    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    /// <summary>
    /// Range
    /// </summary>
    [Range(1, 10)]
    public int num1;
    [Range(1, 10)]
    public float num2;
    [Range(1, 10)]
    public long num3;
    [Range(1, 10)]
    public double num4;

    /// <summary>
    /// 텍스트를 보기좋게 해준다. 엔터가능
    /// </summary>
    [Multiline]
    public string textStr;
    [TextArea] // 이게 더 낫다.
    public string textStr2;

    /// <summary>
    /// 인스펙터에 기능추가 하기
    /// </summary>
    [ContextMenuItem("Random", "RandomNumber")]
    [ContextMenuItem("Reset", "ResetNumber")]
    public int number;
    void RandomNumber()
    {
        number = UnityEngine.Random.Range(0, 100);
    }
    void ResetNumber()
    {
        number = 0;
    }

    /// <summary>
    /// Color값 상세하게 세팅해주는 기능
    /// </summary>
    public Color color1; // 일반 컬러 인스펙터

    [ColorUsage(false)]
    public Color color2; // 알파값 빼기

    [ColorUsageAttribute( true, true)] // Hdr 타입으로
    public Color color3;

    /// <summary>
    /// 헤더, Spacing 기능
    /// 외형을 정리정돈 해준다.
    /// </summary>
    [Header("Player Settings")]
    public Player player;
    [Serializable]
    public class Player  
    {
        public string name;
        [Range(1, 100)]
        public int hp;
    }
    [Header("Game Settings")]
    public Color background;
    [Space(16)]
    public string str1;
    [Space(48)]
    public string str2;

    [Tooltip("이것은 툴팁입니다")]
    public long tooltip;

    public string str3;
    [HideInInspector]
    public string str4;
}
