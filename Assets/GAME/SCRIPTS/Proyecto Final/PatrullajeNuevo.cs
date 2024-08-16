using UnityEngine;
public class PatrullajeNuevo : MonoBehaviour
{
    [Header("comportamiento")]
    [SerializeField] private int rutina;
    [SerializeField] private float cronometro;
    [SerializeField] private Quaternion angulo;
    [SerializeField] private float grado;
    [SerializeField] private float rango;

    [Header("Seguir Player")]
    [SerializeField] private GameObject target;
    private bool atacando;
    [SerializeField] private float velocidad;



    void Start()
    {
        target = GameObject.Find("Player");

    }


    void Update()
    {
        Comportamiento_Enemigo();
    }

    public void Comportamiento_Enemigo()
    {
        if (Vector3.Distance(transform.position, target.transform.position) > rango)// cuando el jugador este fuera de rango el enemigo hace su rutina
        {

            cronometro += 1 * Time.deltaTime;
            if (cronometro >= 4)
            {
                rutina = Random.Range(0, 2);
                cronometro = 0;
            }

            switch (rutina)
            {
                case 0:


                    break;

                case 1:
                    grado = Random.Range(0, 360);
                    angulo = Quaternion.Euler(0, grado, 0);
                    rutina++;
                    break;

                case 2:
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 0.5f);
                    transform.Translate(Vector3.forward * velocidad * Time.deltaTime);// el enemigo se mueve al angulo preestablecido
                    break;
            }
        }
        else
        {

            var lookPos = target.transform.position - transform.position;//para seguir al personaje
            lookPos.y = 0;
            var rotatio = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotatio, 3);
            transform.Translate(Vector3.forward * 3 * Time.deltaTime);
            Debug.Log("Te ando siguiendo");



        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, rango);
    }

}
