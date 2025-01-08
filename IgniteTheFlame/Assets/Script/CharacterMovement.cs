using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Animator animator;
    private bool isDie=false;


    public float speed;
    public float rotationSpeed;

    public GameObject asd;
    public GameObject kazandin;



    private bool dashing = false;
    private float dashingPower = 30f;
    private float dashingTime = 0.3f;
    private float dashingCooldown = 1.5f;

    [SerializeField] private TrailRenderer tr;
    




    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

        asd.SetActive(false);
        kazandin.SetActive(false);

        tr.emitting = false;
    }


    void Update()
    {
        if(!isDie)
        {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize();

        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space) && !dashing && (horizontalInput != 0 || verticalInput !=0))
        {
            StartCoroutine(Dash());
        }

        if(horizontalInput != 0 || verticalInput != 0)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        if(PlayerHealth.playerHealt == 0)
        {
            animator.SetBool("isDie", true);
                isDie = true;
            transform.Translate(0, 0, 0);
                asd.SetActive(true);
            //Scene de?i?tir
        }

        }


    }

    private IEnumerator Dash()
    {
        dashing = true;
        tr.emitting = true;

        speed = dashingPower;
        yield return new WaitForSeconds(dashingTime);
        speed = 10;
        tr.emitting = false;
        yield return new WaitForSeconds(dashingCooldown);
        dashing = false;

    }

}