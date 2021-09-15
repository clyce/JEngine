using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDuplicate : MonoBehaviour
{
    public GameObject target;


    void Start()
    {
        // 触发条件：
        // void Awake 也能触发bug
        // 但是如果写在自定义函数里，而不是UnityComponent自己的生命周期，就不触发bug
        // 如果该GameObject初始状态并非Active，游戏逻辑中设置为Active，也不会触发
        // 即： 当且仅当热更场景里，该GameObject初始状态为Active时，若其Awake/Start里“跨域链式”SetActive，才会触发Bug
        target.SetActive(true);
    }

}
