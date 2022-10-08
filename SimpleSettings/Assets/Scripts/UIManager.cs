using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Dropdown resDrop;
    [SerializeField] TMP_Text windowText;
    bool window = true;

    public void PrintLog()
    {    
        Debug.Log(EventSystem.current.currentSelectedGameObject.name + " Button Clicked");
    }

    private string GetWindow(bool val)
    {
        return val ? "Fullscreen" : "Windowed";
    }

    public void OnWindowChange()
    {
        window = !window;
        Debug.Log("Window Mode: " + GetWindow(window));
        windowText.text = GetWindow(window);
    }

    public void OnMusicChange(float val)
    {
        Debug.Log("Music Volume: " + val);
    }

    public void OnChangeMute(bool val)
    {
        Debug.Log("Mute: " + val);
    }

    public void OnChangeResolution(int val)
    {
        Debug.Log("Resolution: " + resDrop.options[val].text);
    }
}
