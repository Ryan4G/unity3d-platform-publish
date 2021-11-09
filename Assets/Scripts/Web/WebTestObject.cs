using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class WebTestObject : MonoBehaviour
{
    private string _message;

    [DllImport("__Internal")]
    private static extern void ShowAlert(string msg);

    private void Start()
    {
        _message = "No message yet";
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShowAlert("Hello out there!");
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 20), _message);
    }

    public void RespondToBrower(string message)
    {
        _message = message;
    }
}
