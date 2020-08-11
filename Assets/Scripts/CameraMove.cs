using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject opora, player;
    void Start()
    {
        player = GameObject.Find("Player");
        opora = GameObject.Find("Opora");
    }

    // Update is called once per frame
    void Update()
    {
        opora.transform.position = player.transform.position;
    }
}
