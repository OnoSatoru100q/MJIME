using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CPt : MonoBehaviour
{
	// 生成したいPrefab
	public GameObject Prefab;

	public List<GameObject> prefabs;


	// クリックした位置座標
	private Vector3 clickPosition;
	// Use this for initialization
	void Start()
	{

	}

	private GameObject GetRandom()
	{
		return prefabs[Random.Range(0, prefabs.Count)];

	}

	// Update is called once per frame
	void Update()
	{
		// マウス入力で左クリックをした瞬間
		if (Input.GetMouseButtonDown(0))
		{
			// ここでの注意点は座標の引数にVector2を渡すのではなく、Vector3を渡すことである。
			// Vector3でマウスがクリックした位置座標を取得する
			clickPosition = Input.mousePosition;
			// Z軸修正
			clickPosition.z = 10f;
			var randomPrefab = GetRandom();
			// オブジェクト生成 : オブジェクト(GameObject), 位置(Vector3), 角度(Quaternion)
			// ScreenToWorldPoint(位置(Vector3))：スクリーン座標をワールド座標に変換する
			Instantiate(randomPrefab, Camera.main.ScreenToWorldPoint(clickPosition), randomPrefab.transform.rotation);
		}
	}
}