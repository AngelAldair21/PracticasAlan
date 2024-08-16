using UnityEngine;
using UnityEngine.UIElements;

/// <summary>
/// REQUIRE COMPONENT
/// Agrega a el gameobject que contenga el script el componente escrito en la linea
/// </summary>
public class MovementController : MonoBehaviour
{
    [Header("Movimiento")]
    [SerializeField] private CharacterController controlador;
    [SerializeField] private float velocidadMovimiento = 0f;
    [SerializeField] private float gravedad = -10f;

    [Header("Ensuelo")]
    [SerializeField] private Transform enSuelo;
    [SerializeField] private float distancia;
    [SerializeField] private LayerMask queEsSuelo;
    [SerializeField] private Vector3 dimensionesCaja;
    bool estaEnSuelo;

    Vector3 velocidadAbajo;

    [Header("Salto")]

    [SerializeField] private float fuerzaSalto;

    [Header("Vida")]
    [SerializeField] private int golpesVida;


    private void Start()
    {
        controlador = GetComponent<CharacterController>();

    }



    void Update()
    {
        estaEnSuelo = Physics.CheckSphere(enSuelo.position, distancia, queEsSuelo);
        if (estaEnSuelo && velocidadAbajo.y < 0)
        {
            velocidadAbajo.y = -2f;

        }

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 mover = transform.right * horizontal + transform.forward * vertical;
        controlador.Move(mover * velocidadMovimiento * Time.deltaTime);
        velocidadAbajo.y += gravedad * Time.deltaTime;
        controlador.Move(velocidadAbajo * Time.deltaTime);


        if (Input.GetButtonDown("Jump") && estaEnSuelo == true)
        {

            velocidadAbajo.y = Mathf.Sqrt(fuerzaSalto * -2 * gravedad);

        }
        else if (estaEnSuelo == false)
        {
            estaEnSuelo = false;
        }

        velocidadAbajo.y += gravedad * Time.deltaTime;
        controlador.Move(velocidadAbajo * Time.deltaTime);

    
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(enSuelo.position, dimensionesCaja);

    }   

}
