using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    // public int bulletSpeed = 10;
    private int sec = 0;


    /*
    private void Start()
    {
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * SpeedField.inеSpeed;
    }
    */

    void Start()
    {
        // Запускаем функцию SpawnCube через каждый spawnInterval секунд
        InvokeRepeating("SpawnCube", 0f, (float)TimeField.intTime);
        Debug.Log("#### InvokeRepeating");
    }

    void SpawnCube()
    {
        if (sec >= TimeField.intTime)
        {
            Debug.Log("#### SpawnCube");
            // Инстанциируем куб в текущей позиции
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * SpeedField.inеSpeed;
            sec = 0;
            Debug.Log("void sec=" + sec);
        }
    }

    private void Update()
    {
        
        
        if (TimeField.intTime >0 && SpeedField.inеSpeed > 0 && Distance.intDistance >0) {
            // Debug.Log("Gun TimeField.intTime= "+ TimeField.intTime);
            //Debug.Log("Gun= SpeedField.inеSpeed"+ SpeedField.inеSpeed);
            // Debug.Log("Gun= Distance.intDistance"+ Distance.intDistance);
            sec++;
            Debug.Log("void sec=" + sec);
            // Запускаем функцию SpawnCube через каждый spawnInterval секунд
            InvokeRepeating("SpawnCube", 0f, (float)TimeField.intTime);



            /*
            if (Input.GetKeyDown(KeyCode.W))
            {
                GameObject projectile = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                // Получаем компонент Rigidbody снаряда
                Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();
                // Придаем снаряду скорость в направлении оси Y
                projectileRb.velocity = bulletSpawnPoint.forward * SpeedField.inеSpeed;
            }
            */

        }
        
        
       /*
       
        if (Input.GetKeyDown(KeyCode.W)) {

          // Debug.Log("Gun speed =" + InputFieldController.speed);
            

            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
           // 1 bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * 10;
        }
        */
       
    }




}
