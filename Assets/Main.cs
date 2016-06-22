using UnityEngine;
using System.Collections;
using System;
using Control;

[Serializable]
public class Main : MonoBehaviour {
    public KeyControl control;
    public string test = "hi mom";
	void Start () {
        control.Initialize();
	}
}
