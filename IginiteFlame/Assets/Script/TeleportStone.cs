using UnityEngine;

public class TeleportStone : MonoBehaviour
{
    [SerializeField] int max_x;
    [SerializeField] int max_y;
    [SerializeField] int min_x;
    [SerializeField] int min_y;
    private float sayac = 0.0f;

    void Start()
    {
        RandomizePosition();
    }

     void Update()
    {
       if (sayac < 2.8f)
        {
            sayac += Time.deltaTime;
        } 

       else
        {
            sayac = 0;
            RandomizePosition();
        }
    }
    private void RandomizePosition()
    {
        float x = Random.Range(min_x, max_x);
        float y = Random.Range(min_y, max_y);

        this.transform.position = new Vector3(x, 0.5f, y);
    }


}
