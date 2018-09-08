using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSkyBox : MonoBehaviour {

    private float rotation;

	// Use this for initialization
	void Start () {
        rotation = 0;
    }
	
	// Update is called once per frame
	void Update () {
        rotation += 0.1f;
        rotation = rotation >= 360.0f ? rotation - 360.0f : rotation;
        RenderSettings.skybox.SetFloat( "_Rotation", rotation );
    }
}
