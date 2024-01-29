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
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * SpeedField.in�Speed;
    }
    */

    void Start()
    {
        // ��������� ������� SpawnCube ����� ������ spawnInterval ������
        InvokeRepeating("SpawnCube", 0f, (float)TimeField.intTime);
        Debug.Log("#### InvokeRepeating");
    }

    void SpawnCube()
    {
        if (sec >= TimeField.intTime)
        {
            Debug.Log("#### SpawnCube");
            // ������������� ��� � ������� �������
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * SpeedField.in�Speed;
            sec = 0;
            Debug.Log("void sec=" + sec);
        }
    }

    private void Update()
    {
        
        
        if (TimeField.intTime >0 && SpeedField.in�Speed > 0 && Distance.intDistance >0) {
            // Debug.Log("Gun TimeField.intTime= "+ TimeField.intTime);
            //Debug.Log("Gun= SpeedField.in�Speed"+ SpeedField.in�Speed);
            // Debug.Log("Gun= Distance.intDistance"+ Distance.intDistance);
            sec++;
            Debug.Log("void sec=" + sec);
            // ��������� ������� SpawnCube ����� ������ spawnInterval ������
            InvokeRepeating("SpawnCube", 0f, (float)TimeField.intTime);



            /*
            if (Input.GetKeyDown(KeyCode.W))
            {
                GameObject projectile = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                // �������� ��������� Rigidbody �������
                Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();
                // ������� ������� �������� � ����������� ��� Y
                projectileRb.velocity = bulletSpawnPoint.forward * SpeedField.in�Speed;
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
