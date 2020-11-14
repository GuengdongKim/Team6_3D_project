using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireController : MonoBehaviour
{
    public GameObject CampFire; // 기존 불
    public GameObject fire;

    float time = 10.0f; // 타이머
    float fireHp = 10.0f; // 불 체력

    Vector3 pos; // 기존 불의 위치 저장용

    float fire_x; // 새로운 불의 위치 이동량
    float fire_z;

    public void Damaged() // 불에 데미지
    {
        fireHp -= 1.0f; // 물 하나의 데미지
        Debug.Log("Fire Damaged"); // 데미지 입는 여부 확인용
        if (fireHp <= 0) // 불 꺼짐
        {
            Destroy(this.gameObject);
            Debug.Log("Fire Removed");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Fire") // 다른 불과 겹칠 시 삭제
        {
            Destroy(other.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0) // 불 번지는 시간
        {
            time -= Time.deltaTime; // 시간에 따른 감소
        }
        else
        {
            time = 10.0f; // 10초 마다 번짐
            pos = this.CampFire.transform.position; // 기존 불의 위치

            while (true)
            {
                fire_x = Random.Range(-1, 2); // 랜덤 위치 선정
                fire_z = Random.Range(-1, 2);
                if (fire_x == 0 && fire_z == 0) continue; // 현 위치와 같으면 다시
                else break; // 다르면 반복문 탈출
            }

            fire = Instantiate(CampFire); // 번짐 불 생성
            fire.transform.position = new Vector3(pos.x + fire_x, pos.y, pos.z + fire_z); // 새로 생성될 불의 위치로 불 이동
        }
    }
}
