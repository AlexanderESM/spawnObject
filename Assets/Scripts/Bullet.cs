using UnityEngine;

public class Bullet : MonoBehaviour
{
    //����� ����� �������
    // public float life=1;

    private void Awake()
    {
        // Destroy(gameObject, life);
        Debug.Log("Destroy Bullet =" + Distance.intDistance);
        Destroy(gameObject, Distance.intDistance);
       
    }


    //���� ������ ���������� � ��������
    
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("���� ������ ���������� � �������� Destroy Bullet =" + Distance.intDistance);
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
    

}
