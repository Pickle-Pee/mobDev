using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour {
    
    public GameObject block;
    private GameObject blockInst;
    void Start() {
        blockInst = Instantiate (block, new Vector3 (Random.Range (9f, 19f), Random.Range (3f, 5f), 0f), Quaternion.identity) as GameObject;
    }
}

