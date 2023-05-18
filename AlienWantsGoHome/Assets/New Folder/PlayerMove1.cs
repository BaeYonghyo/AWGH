using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove1 : MonoBehaviour
{
    Rigidbody rigid;
    public float moveSpeed = 5f; // 이동 속도 지정
    public float rotationSpeed = 360f; // 회전 속도 지정
    CharacterController characterController;
    // Use this for initialization
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        // 좌우 방향키와 상하 방향키를 눌렀는지 판별
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (direction.sqrMagnitude > 0.01f)
        {
            Vector3 forward = Vector3.Slerp( // 메소드를 조합해 플레이어의 방향 변환
            transform.forward,
            direction,
            rotationSpeed * Time.deltaTime / Vector3.Angle(transform.forward, direction)
            );
            
            transform.LookAt(transform.position + forward);
        }
        Jump();

        // Move()를 이용해 이동, 충돌 처리, 속도 값 얻기 가능
        characterController.Move(direction * moveSpeed * Time.deltaTime);
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 8, ForceMode.Impulse);
        }

    }
}
