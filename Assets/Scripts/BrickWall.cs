using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickWall : MonoBehaviour {

    public const int width = 21;
    public const int length = 21;

    // Use this for initialization
    void Start () {
		for (int z = 0; z < width; z++) {
            for (int x = 0; x < length; x++) {
                if(z % 2 == 1 || x % 2 == 1) {
                    Instantiate(Resources.Load("Wall"), new Vector3(x, 0, z), Quaternion.identity);
                }
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
