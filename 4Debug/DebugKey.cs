using System.Collections.Generic;
using static System.Enum;
using UnityEngine;
using System;

public class DebugKey : MonoBehaviour {

    [Tooltip("Выберите активные функции отладки")]
    public DebugMode debugMode;

    public Boolean debugKeyDown;
    public Boolean debugKey;

    [Tooltip("{EQEQEKFSDKFSDKMFLSK}")]
    [Range(5, 10)]
    public float requestPeriod;

    private void Start() {

    }

    void Update() {
        if(debugKeyDown && Input.anyKeyDown) {
            Debug.Log($"Key {KeyDownHandler()} is down");
        }
        if(debugKey && Input.anyKey) {
            Debug.Log($"Key {KeyHandler()} is pressed");
        }
    }

    public void KeyJOPA() {
        //float t

        if(debugKey && Input.anyKey) {
            Debug.Log($"Key {KeyHandler()} is pressed");
        }

    }

    public KeyCode KeyDownHandler() {
        if(Input.anyKeyDown) {
            foreach(KeyCode keyCode in GetValues(typeof(KeyCode))) {
                if (Input.GetKeyDown(keyCode)) {
                    
                    return keyCode;
                }
            }
        }
        return KeyCode.None;
    }

    public KeyCode KeyHandler() {
        if(Input.anyKey) {
            foreach(KeyCode keyCode in GetValues(typeof(KeyCode))) {
                if (Input.GetKey(keyCode)) {
                    return keyCode;
                }
            }
        }
        return KeyCode.None;
    }
}
