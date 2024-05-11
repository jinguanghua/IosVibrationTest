using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.NiceVibrations;
using UnityEngine.UI;

public class VibrationTest : MonoBehaviour
{
    public VibrationButton copyItem;
    public Transform parent;

    private void Awake()
    {
        MMVibrationManager.iOSInitializeHaptics();
    }

    private void OnDestroy()
    {
        MMVibrationManager.iOSReleaseHaptics();
    }

    private void Start()
    {
        var types = System.Enum.GetValues(typeof(HapticTypes));
        foreach(HapticTypes type in types) {
            var obj = GameObject.Instantiate(copyItem.gameObject, parent);
            var newButton = obj.GetComponent<VibrationButton>();
            newButton.gameObject.name = string.Format("button{0:D4}", (int)type);
            newButton.Init(type);
        }
    }
}
