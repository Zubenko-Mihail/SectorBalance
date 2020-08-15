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
        if (Input.GetKey(KeyCode.LeftBracket))
        {
            opora.transform.Rotate(Vector3.up*0.3f);
        }
        if (Input.GetKey(KeyCode.RightBracket))
        {
            opora.transform.Rotate(Vector3.down*0.3f);
        }
    }
}
