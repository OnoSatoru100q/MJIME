using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ClickPositionCreatePrefabScript : MonoBehaviour
{
    // 生成したいPrefab
    public GameObject Prefab;

    public List<GameObject> prefabs;

    public Camera currentCamera;

    // クリックした位置座標
    private Vector3 clickPosition;
    // Use this for initialization
    void Start()
    {
        currentCamera = Camera.main;
    }

    private GameObject GetRandom()
    {
        return prefabs[Random.Range(0, prefabs.Count)];

    }

    // Update is called once per frame
    public void GenerateObject()
    {
        // ここでの注意点は座標の引数にVector2を渡すのではなく、Vector3を渡すことである。
        // Vector3でマウスがクリックした位置座標を取得する
        clickPosition = Input.mousePosition;
        // Z軸修正
        clickPosition.z = 13f;
        var randomPrefab = GetRandom();
        // オブジェクト生成 : オブジェクト(GameObject), 位置(Vector3), 角度(Quaternion)
        // ScreenToWorldPoint(位置(Vector3))：スクリーン座標をワールド座標に変換する
        Instantiate(randomPrefab, currentCamera.ScreenToWorldPoint(clickPosition), randomPrefab.transform.rotation);

    }
}

