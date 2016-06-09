using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DisapearInGame : MonoBehaviour {
    // TODO: you can turn on debugeable mode ingame.
    // private List<Renderer> _myRenderers; // esto es como un vector, pero con super poderes :D
    
    // Use this for initialization
    void Start () {
        // _myRenderers = new List<Renderer>();

        for (int i=0; i<transform.childCount; i++) {
            transform.GetChild(i).gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
	
    // Update is called once per frame
    void Update () {
	
    }
}
