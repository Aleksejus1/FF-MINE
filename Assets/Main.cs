using UnityEngine;
using System.Collections;
using System;
using Control;

[Serializable]
public class Main : MonoBehaviour {
    public KeyControl control;
	void Start () {
        control.Initialize();
	}
}
