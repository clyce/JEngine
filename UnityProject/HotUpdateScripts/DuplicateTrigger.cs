using JEngine.Core;
using UnityEngine;
namespace DuplicateTrigger
{
    public class TriggerParent : JBehaviour
    {
        public GameObject child;
        public override void Init() {
            child.SetActive(true);
        }
    }

    public class TriggerChild : JBehaviour
    {
        public override void Init() {
            Debug.Log("I should have been triggered only ONCE");
        }
    }
}