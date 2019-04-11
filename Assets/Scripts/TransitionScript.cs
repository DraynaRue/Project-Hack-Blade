using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransitionScript : MonoBehaviour {
    static public Image transition;

    // Use this for initialization
    void Awake () {
        transition = GetComponentInChildren<Image>();
        DontDestroyOnLoad(this.gameObject);
    }
}
