﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviceOperator : MonoBehaviour {

    public float radius = 1.5f;//расстояние, с которого можно активировать

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {//реакция на кнопку ввода, заданную в настройках ввода unity(правая кнопка мыши)
            Collider[] hitColliders =
                Physics.OverlapSphere(transform.position, radius);//метод OverlapSphere возвращает список ближайших объектов    
            foreach (Collider hitCollider in hitColliders)//прохождение по всем элементам массива (по всем найденным объектам)
            {
                hitCollider.SendMessage("Operate", SendMessageOptions.DontRequireReceiver);//метод SendMessage пытается вызвать функцию 
            }
        }
    }
}

