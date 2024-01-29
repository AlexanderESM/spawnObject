using UnityEngine;

public class Bullet : MonoBehaviour
{
    //время жизни объекта
    // public float life=1;

    private void Awake()
    {
        // Destroy(gameObject, life);
        Debug.Log("Destroy Bullet =" + Distance.intDistance);
        Destroy(gameObject, Distance.intDistance);
       
    }


    //если объект столкнулся с объектом
    
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("если объект столкнулся с объектом Destroy Bullet =" + Distance.intDistance);
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
    

}
