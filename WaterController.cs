using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterController : MonoBehaviour
{
    float count = 0; // 타이머

    public void Shoot(Vector3 dir) // 물 발사
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Fire") // 다른 불과 겹칠 시 삭제
        {
            Destroy(this.gameObject);
            other.gameObject.GetComponent<FireController>().Damaged();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime; // 타이머
        if (count >= 5) // 5초뒤 물 삭제
        {
            Destroy(this.gameObject);
        }
    }
}
