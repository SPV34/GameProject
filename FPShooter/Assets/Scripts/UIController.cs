using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//импорт инфраструктуры для работы с кодом UI

public class UIController : MonoBehaviour {

    public Text scoreLabel;//объект сцены Reference Text, предназначенный для задания свойства Text
    public SettingsPopul settingsPopul;

    void Start()
    {
        settingsPopul.Close();//Закрываем высплывающее окно в момент начала игры
    }

    void Update()
    {
        scoreLabel.text = Time.realtimeSinceStartup.ToString();
    }

    public void OnOpenSettings()
    {//метод, вызываемый кнопкой настроек
        settingsPopul.Open();//Заменяем отладочный текст методом всплывающего окна
    }

    public void OnPointerDown()
    { 
        Debug.Log("pointer down"); 
    }


}
