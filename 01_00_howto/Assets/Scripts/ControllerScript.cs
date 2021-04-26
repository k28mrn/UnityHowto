using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 position;
    // スクリーン座標をワールド座標に変換した位置座標
    private Vector3 screenToWorldPointPosition;

    private Vector3 usePosition = new Vector3();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3でマウス位置座標を取得する
        position = Input.mousePosition;
        // Z軸修正
        position.z = 10f;

        // マウス位置座標をスクリーン座標からワールド座標に変換する
        screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);

        // ワールド座標に変換されたマウス座標を代入
        Vector3 pos = (screenToWorldPointPosition - gameObject.transform.position) * 0.1f;
        gameObject.transform.position += pos;
        gameObject.transform.Rotate(new Vector3(1, 1, 1));

        // gameObject.transform.position = screenToWorldPointPosition;
    }
}
