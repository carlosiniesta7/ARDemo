using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class DragMove : NetworkBehaviour {

    public float horozontalSpeed = 0.01f;
    public float verticalSpeed = 0.01f;

    void Update () {

        //#Debug.Log(isLocalPlayer);
        //#if (!isLocalPlayer) return;

        Debug.Log("Entra por aqui");
        #if UNITY_EDITOR
            /*if (Input.GetMouseButtonDown(0)) {
                float h = horozontalSpeed * Input.mousePosition.x;
                float v = verticalSpeed * Input.mousePosition.y;
                transform.Translate(h, 0, v);
            }*/
            float h1 = 0;
            //float v1 = 0;

            if(Input.GetKeyDown(KeyCode.A))
                h1 = 1;
            if (Input.GetKeyDown(KeyCode.S))
                h1 = -1;

            /*if (Input.GetKeyDown(KeyCode.W))
                v1 = -1;
            if (Input.GetKeyDown(KeyCode.Z))
                v1 = 1;*/

            transform.position += new Vector3(h1, 0, 0);

            return; 
        #endif
        if (Input.touchCount >= 1) {
            Touch touch = Input.GetTouch (0);
            if (touch.phase == TouchPhase.Moved) {
                float h = horozontalSpeed * touch.deltaPosition.x;
                float v = verticalSpeed * touch.deltaPosition.y;
                transform.Translate(h, 0, v);
            }
        }
        
    }
}