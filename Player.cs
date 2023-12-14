using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //hp
    public int heatlh = 10;
    //дамаг 
    public int damage = 2;

    //кол-во монет
    public int coins;
    //объект снаряда 
    public GameObject fireballPrefab;
    //спавн снаряда 
    public Transform attackPoint;

    //каждый кадор 
    private void Update()
    {
        //При нажатии на лкм
        if (Input.GetMouseButtonDown(0))
        {
            //аргументы что и где создать поворот
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }

    //метод уменьшение hp
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

