using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.NiceVibrations;
using UnityEngine.UI;

public class VibrationButton : MonoBehaviour
{
    public Button button;
    public Text text;
    public HapticTypes type;

    private void Awake()
    {
        button.onClick.AddListener(OnClick);
    }

    public void Init(HapticTypes type)
    {
        this.type = type;
        text.text = type.ToString();
    }

    private void OnClick()
    {
        MMVibrationManager.Haptic(type);
    }
}
