using UnityEngine;


/// <summary>
/// REQUIRE COMPONENT
/// Agrega a el gameobject que contenga el script el componente escrito en la linea
/// </summary>
[RequireComponent(typeof(Rigidbody), typeof(GroundCheck))]
public class MovementController : MonoBehaviour
{
    public float walkSpeed;
    public float runSpeed;
    public float crouchSpeed;

    public float jumpForce;

    private Rigidbody rb;
    private GroundCheck groundCheck;

    Vector3 currentVelocity; // La velocidad actual de mi rigid body

    private void Metodo()
    { 
        //var rigidBody = GetComponent<Rigidbody>();

        //bool condicion = gameObject.active && gameObject.name == "Pedro";

        //if(condicion)
        //{
        //    // hago esto
        //}
        //else
        //{
        //    // hago esto otro
        //}

        //int numero = 5;

        //if(numero > 0 && numero < 1000)
        //{

        //}

        //switch (numero)
        //{
        //    case var num when numero > 0 && numero < 1000:
        //        break;

        //    case 1:
        //        break;

        //    case 2:
        //        break;

        //    case 3:
        //        break;
        //}

        //string cadena = (584.54456f * 783245.5465f + "Pepe" + true).ToString();

    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        groundCheck = GetComponent<GroundCheck>();
    }

    private void Update()
    {
        Jump();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    #region Movimiento

    private void Movement()
    {
        currentVelocity = rb.velocity; // Me consigue la velocidad actual de el rigidbody
        //Indica hacia donde y a que velocidad de me voy a mover
        Vector3 movement = transform.localRotation * new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical") * ActualMoveSpeed());
        // Corrige mi velocidad en y
        movement.y = currentVelocity.y;
        //Aplica el movimiento
        rb.velocity = movement;     
    }

    //Este metodo nos regresa un valor flotante que indica la velocidad a la que nos moveremos
    private float ActualMoveSpeed()
    {

        //if (RunInputPressed())
        //{
        //    return runSpeed;
        //}
        //else if (CrouchInputPressed())
        //{
        //    return crouchSpeed;
        //}
        //else
        //{
        //    return walkSpeed;
        //}

        return RunInputPressed()? runSpeed : CrouchInputPressed()? crouchSpeed : walkSpeed; 
    }

    private bool RunInputPressed()
    {
        return Input.GetKeyDown(KeyCode.LeftShift);
    }

    private bool CrouchInputPressed()
    {
        return Input.GetKeyDown(KeyCode.LeftControl);
    }

    #endregion

    private void Jump()
    {
        // El ground check se puso como 1ra condición, para que esta
        // se ejecute primero, de manera que nos haga el debug de el rayo en el metodo IsGrounded
        if (groundCheck.IsGrounded() && JumpInputPressed())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private bool JumpInputPressed()
    {
       return Input.GetKeyDown(KeyCode.Space);
    }

}
