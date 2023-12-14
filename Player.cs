using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //hp
    public int heatlh = 10;
    //����� 
    public int damage = 2;

    //���-�� �����
    public int coins;
    //������ ������� 
    public GameObject fireballPrefab;
    //����� ������� 
    public Transform attackPoint;

    //������ ����� 
    private void Update()
    {
        //��� ������� �� ���
        if (Input.GetMouseButtonDown(0))
        {
            //��������� ��� � ��� ������� �������
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }

    //����� ���������� hp
    public void TakeDamage(int damage)
    {
        heatlh -= damage;
        print("Heatlh:" + heatlh);
    }

    public void CollectCoins()
    {
        coins += 1;
        print("Coins" + coins);
    }

