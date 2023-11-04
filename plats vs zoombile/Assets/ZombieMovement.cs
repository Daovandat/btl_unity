using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    public float moveSpeed = 1.0f; // Tốc độ di chuyển
    public int maxHP = 100; // Máu tối đa
    private int currentHP; // Máu hiện tại

    void Start()
    {
        currentHP = maxHP; // Khởi tạo máu ban đầu
    }

    // Update is called once per frame
    void Update()
    {
        // Di chuyển Zombie về phía trái (hoặc phía phải tùy theo mục tiêu của bạn)
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
}
