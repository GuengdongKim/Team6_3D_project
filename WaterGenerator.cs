using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterGenerator : MonoBehaviour
{
    public GameObject waterPrefab;
    public Camera camera;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 마우스를 누르면
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // 마우스 위치로 물 발사
            Vector3 worlDir = ray.direction;
            GameObject water = Instantiate(waterPrefab) as GameObject;
            water.GetComponent<WaterController>().Shoot(worlDir.normalized * 2000);
        }
    }
}
